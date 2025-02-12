using Application.UserFeatures.Commands.Add;
using FluentValidation;
using FluentValidation.AspNetCore;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace Application;

public static class DependencyInjection
{
    public static IServiceCollection AddApplicationLayer(this IServiceCollection services)
    {
        services.AddMediatR(config =>
        {
            config.RegisterServicesFromAssemblies(Assembly.GetExecutingAssembly());
        });
        services.AddValidatorsFromAssemblyContaining<CreateUserCommandValidator>();
        services.AddFluentValidationAutoValidation();
        return services;
    }
}
