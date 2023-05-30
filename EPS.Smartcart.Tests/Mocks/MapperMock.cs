using AutoMapper;
using EPS.Smartcart.Application.Mappers;

namespace EPS.Smartcart.Tests.Mocks;

public class MapperMock
{
    public static IMapper GetMapper()
    {
        var config = new MapperConfiguration(cfg =>
        {
            cfg.AddProfile(new Mappings());
        });

        return config.CreateMapper();
    }
}