using System;
using System.Reflection;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using ProductApp.Application.Mapping;

namespace ProductApp.Application
{
    public static class ServiceRegistration
    {
        public static void AddApplicationRegistration(this IServiceCollection services)
        {
            var assembly = Assembly.GetExecutingAssembly();
            services.AddAutoMapper(assembly);
            services.AddMediatR(assembly);
         }
    }
}

