using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace AuthenticateAPI.Application.Commands.Requests
{
    public class CreateCustomerCommandValidator : AbstractValidator<CreateCustomerCommand>
    {
        public CreateCustomerCommandValidator()
        {
            RuleFor(t => t.Name).NotNull().NotEmpty();
            RuleFor(t => t.Password).NotEmpty();
            RuleFor(t => t.Document).NotNull();
            RuleFor(t => t.Email).NotNull();
        }
    }
}
