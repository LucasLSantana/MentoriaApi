using MentoriaApi.Interface;
using MentoriaApi.Repository;
using MentoriaApi.Services;

namespace MentoriaApi.StartupHelper
{
    public static class ServiceExtensions
    {
        public static void AddCustomServices(this IServiceCollection services)
        {
            services.AddScoped<IContaPagarService, ContaPagarService>();
            services.AddScoped<IContaPagarRepository, ContaPagarRepository>();
        }
    }
}
