using Microsoft.Extensions.DependencyInjection;
using Services.Interfaces;
using Services.Services;

namespace IoC
{
    public static class NativeInjector
    {
        public static void RegisterServices(IServiceCollection services)
        {

            services.AddScoped<ICDBService, CDBService>();
        }
    }
}