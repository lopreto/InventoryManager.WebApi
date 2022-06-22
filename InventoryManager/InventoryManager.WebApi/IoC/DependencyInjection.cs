using InventoryManager.Application.Services;
using InventoryManager.Domain.IRepositories;
using InventoryManager.Infrastructure.Repository;

namespace InventoryManager.WebApi.IoC
{
    public static class DependencyInjection
    {
        public static void RegisterServices(this IServiceCollection services)
        {
            services.AddScoped<IInventoryRepository, InventoryRepository>();
            services.AddScoped<IInventoryService, InventoryService>();
        }
    }
}
