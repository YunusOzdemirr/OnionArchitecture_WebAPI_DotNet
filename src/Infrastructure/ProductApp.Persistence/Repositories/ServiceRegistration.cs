using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using ProductApp.Application.Interfaces.Repository;
using ProductApp.Persistence.Context;

namespace ProductApp.Persistence.Repositories;

public static class ServiceRegistration
{
    public static void AddServices(this IServiceCollection services)
    {
        services.AddDbContext<ApplicationDbContext>(a => a.UseInMemoryDatabase("memoryDb"));
        services.AddScoped<IProductRepository, ProductRepository>();
    }
}