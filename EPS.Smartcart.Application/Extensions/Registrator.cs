using System.Reflection;
using EPS.Smartcart.Application.Validation;
using FluentValidation;
using MediatR;
using Microsoft.Extensions.DependencyInjection;

namespace EPS.Smartcart.Application.Extensions;

public static class Registrator
{
    public static IServiceCollection RegisterApplication(this IServiceCollection service)
    {
        service.AddMediatR(Assembly.GetExecutingAssembly());
        service.AddAutoMapper(Assembly.GetExecutingAssembly());
        service.AddValidatorsFromAssembly(Assembly.GetExecutingAssembly());
        service.AddTransient(typeof(IPipelineBehavior<,>), typeof(ValidationHandler<,>));

        return service;
    }
}