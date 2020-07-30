using AuthenticateAPI.Application.DTOs;
using AuthenticateAPI.Domain.Class;
using AuthenticateAPI.Domain.Interfaces.UnitOfWork;
using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AuthenticateAPI.Application.Commands.Queries
{
    public class GetAllTCustomerQueryHandler : IRequestHandler<GetAllCustomerQuery, List<CustomerDTO>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public GetAllTCustomerQueryHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public async Task<List<CustomerDTO>> Handle(GetAllCustomerQuery request, CancellationToken cancellationToken)
        {
            var result = await _unitOfWork.CustomerRepository.GetAll();
            return _mapper.Map<List<CustomerDTO>>(result.ToList());
        }
    }
}
