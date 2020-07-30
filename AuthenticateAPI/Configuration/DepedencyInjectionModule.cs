using AuthenticateAPI.Application.AutoMapper;
using AuthenticateAPI.Application.Commands.Handlers;
using AuthenticateAPI.Application.Commands.Requests;
using AuthenticateAPI.Application.Commands.Responses;
using AuthenticateAPI.Domain.Interfaces.Repository;
using AuthenticateAPI.Domain.Interfaces.UnitOfWork;
using AuthenticateAPI.Infra.Repository;
using AuthenticateAPI.Infra.UnitOfWork;
using AutoMapper;
using FluentValidation;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

using Microsoft.OpenApi.Models;
using FluentValidation.AspNetCore;
using AuthenticateAPI.Filters;
using AuthenticateAPI.Application.Commands.Validations;

namespace AuthenticateAPI.Configuration
{
    public static class DepedencyInjectionModule
    {
        public static IServiceCollection ResolveDependencies(this IServiceCollection services)
        {
            ApplicationModule(services);
            UnitOfWorkModule(services);

            RepositoryModule(services);
            AutoMapperModule(services);


            return services;
        }

        private static IServiceCollection RepositoryModule(IServiceCollection services)
        {
            services.AddTransient<ICustomerRepository, CustomerRepository>();

            return services;
        }

        private static IServiceCollection ServicesModule(IServiceCollection services)
        {
            services.AddTransient<ICustomerRepository, CustomerRepository>();

            return services;
        }

        private static IServiceCollection UnitOfWorkModule(IServiceCollection services)
        {
            services.AddTransient<IUnitOfWork, UnitOfWork>();

            return services;
        }

        public static IServiceCollection ApplicationModule(this IServiceCollection services)
        {
            //services.AddMvc().AddFluentValidation(fv => {
            //    fv.RunDefaultMvcValidationAfterFluentValidationExecutes = false;
            //});

            services.AddMvc(options =>
            {
                options.EnableEndpointRouting = false;
                options.Filters.Add<ValidationFilter>();
            });
            services.AddMediatR(Assembly.GetExecutingAssembly());

            services.AddTransient<IValidator<CreateCustomerCommand>, CreateCustomerCommandValidator>();
            services.AddTransient<IRequestHandler<CreateCustomerCommand, Response>, CreateCustomerCommandHandler>();

            services.AddTransient(typeof(IPipelineBehavior<,>), typeof(ValidationBehavior<,>));

            services.AddValidatorsFromAssembly(Assembly.GetExecutingAssembly());
            return services;
        }

        public static IServiceCollection AutoMapperModule(this IServiceCollection services)
        {
            var mappingConfig = new MapperConfiguration(mc =>
            {
                mc.AddProfile(new MapProfiles());
            });

            services.AddSingleton(mappingConfig.CreateMapper());

            return services;
            //services.AddAutoMapper(typeof(Startup))
        }
    }
}
