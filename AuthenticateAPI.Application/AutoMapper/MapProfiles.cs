using AuthenticateAPI.Application.Commands.Requests;
using AuthenticateAPI.Application.DTOs;
using AuthenticateAPI.Application.Extensions;
using AuthenticateAPI.Domain.Class;
using AutoMapper;

namespace AuthenticateAPI.Application.AutoMapper
{
    public class MapProfiles : Profile
    {
        public MapProfiles()
        {
            CreateMap<CreateCustomerCommand, Customer>()
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name))
                .ForMember(dest => dest.Password, opt => opt.MapFrom(src => src.Password))
                .ForMember(dest => dest.Email, opt => opt.MapFrom(src => src.Email))
                .ForMember(dest => dest.Document, opt => opt.MapFrom(src => src.Document));

            CreateMap<Customer, CreateCustomerCommand>();

            CreateMap<Customer, CustomerDTO>();
        }
    }
}
