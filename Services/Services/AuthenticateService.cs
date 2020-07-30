using AuthenticateAPI.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AuthenticateAPI.Services.Services
{
    public class AuthenticateService : IAuthenticateService
    {
        public Task<bool> CheckCredentials(string email, string password)
        {

            throw new NotImplementedException();
        }
    }
}
