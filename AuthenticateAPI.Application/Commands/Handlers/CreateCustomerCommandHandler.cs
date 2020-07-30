using AuthenticateAPI.Application.Commands.Requests;
using AuthenticateAPI.Application.Commands.Responses;
using AuthenticateAPI.Domain.Class;
using AuthenticateAPI.Domain.Interfaces.UnitOfWork;
using AutoMapper;
using MediatR;
using System.Net;
using System.Threading;
using System.Threading.Tasks;

namespace AuthenticateAPI.Application.Commands.Handlers
{
    public class CreateCustomerCommandHandler : IRequestHandler<CreateCustomerCommand, Response>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public CreateCustomerCommandHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public async Task<Response> Handle(CreateCustomerCommand request, CancellationToken cancellationToken)
        {
            var mapper = _mapper.Map<Customer>(request);

            var result = await _unitOfWork.CustomerRepository.Add(mapper);

            return new Response("User created successfully");
        }

    }
}
