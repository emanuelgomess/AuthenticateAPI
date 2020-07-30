using System.Linq;
using System.Threading.Tasks;
using AuthenticateAPI.Application.Commands.Requests;
using AuthenticateAPI.Application.Commands.Responses;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;

namespace AuthenticateAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ApiController
    {
        [HttpPost]
        [AllowAnonymous]
        [Route("Add")]
        public async Task<ActionResult<ResponseCreateCustomer>> Add(CreateCustomerCommand command)
        {
            var response = await Mediator.Send(command).ConfigureAwait(false);

            if (response.Errors.Any())
            {
                return BadRequest(response.Errors);
            }

            return Ok(response.Result);

        }
    }
}
