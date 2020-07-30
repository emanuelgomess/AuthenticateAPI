using AuthenticateAPI.Application.AutoMapper;
using AuthenticateAPI.Tests.Fixtures;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace AuthenticateAPI.Tests.AutoMapper
{
    public class AutoMapperConfigurationTests : IClassFixture<AutoMapperFixture>
    {
        public AutoMapperFixture _autoMapperFixture;

        public AutoMapperConfigurationTests(AutoMapperFixture autoMapperFixture)
        {
            _autoMapperFixture = autoMapperFixture;
        }

        [Fact]
        public void MapperConfiguration_ShouldReturnValid()
        {
            _autoMapperFixture.MapperConfiguration.AssertConfigurationIsValid();
        }
    }
}
