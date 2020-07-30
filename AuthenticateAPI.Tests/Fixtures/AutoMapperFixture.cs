using AuthenticateAPI.Application.AutoMapper;
using AutoMapper;

namespace AuthenticateAPI.Tests.Fixtures
{
    public class AutoMapperFixture
    {
        public IMapper _mapper;
        public MapperConfiguration MapperConfiguration { get; set; }
        public AutoMapperFixture()
        {
            MapperConfiguration = new MapperConfiguration(x =>
            {
                x.AddProfile(typeof(MapProfiles));
            });
            _mapper = MapperConfiguration.CreateMapper();
        }
    }
}
