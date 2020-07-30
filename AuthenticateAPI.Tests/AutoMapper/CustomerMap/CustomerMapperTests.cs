using AuthenticateAPI.Application.Commands.Requests;
using AuthenticateAPI.Domain.Class;
using AuthenticateAPI.Tests.AutoData;
using AuthenticateAPI.Tests.Fixtures;
using AutoMapper;
using FluentAssertions;
using Moq;
using Xunit;

namespace AuthenticateAPI.Tests.AutoMapper.CustomerMap
{
    public class CustomerMapperTests : IClassFixture<AutoMapperFixture>
    {
        private readonly AutoMapperFixture _autoMapperFixture;

        public CustomerMapperTests(AutoMapperFixture autoMapperFixture)
        {
            _autoMapperFixture = autoMapperFixture;
        }

        [Theory, AutoNSubstituteData]
        public void CreateCustomerCommand_Should_Be_Of_Type_Customer_After_Mapper(CreateCustomerCommand customerCommand)
        {
            var customer = _autoMapperFixture._mapper.Map<Customer>(customerCommand);

            customer.Should().BeOfType<Customer>();
            customer.Name.Should().Be(customerCommand.Name);
            customer.Password.Should().Be(customerCommand.Password);
            customer.Email.Should().Be(customerCommand.Email);
            customer.Document.Should().Be(customerCommand.Document);

        }
    }
}
