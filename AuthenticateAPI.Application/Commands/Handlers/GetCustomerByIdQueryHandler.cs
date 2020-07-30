using AuthenticateAPI.Application.Commands.Queries;
using AuthenticateAPI.Application.DTOs;
using AuthenticateAPI.Domain.Interfaces.UnitOfWork;
using AutoMapper;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace AuthenticateAPI.Application.Commands.Handlers
{
    public class GetCustomerByIdQueryHandler : IRequestHandler<GetCustomerByIdQuery, CustomerDTO>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public GetCustomerByIdQueryHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public async Task<CustomerDTO> Handle(GetCustomerByIdQuery request, CancellationToken cancellationToken)
        {
            var result = await _unitOfWork.CustomerRepository.Get(request.Id);
            return _mapper.Map<CustomerDTO>(result);
        }
    }
}
