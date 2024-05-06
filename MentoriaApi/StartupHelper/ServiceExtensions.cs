using MentoriaApi.Interface.Repository;
using MentoriaApi.Interface.Service;
using MentoriaApi.Repository;
using MentoriaApi.Services;

namespace MentoriaApi.StartupHelper
{
    public static class ServiceExtensions
    {
        public static void AddCustomServices(this IServiceCollection services)
        {
            #region Service

            services.AddScoped<IContasPagarService, ContasPagarService>();
            services.AddScoped<IContasReceberService, ContasReceberService>();
            services.AddScoped<INotasService, NotasService>();

            #endregion

            #region Repository

            services.AddScoped<IContasPagarRepository, ContasPagarRepository>();
            services.AddScoped<IContasReceberRepository, ContasReceberRepository>();
            services.AddScoped<INotasRepository, NotasRepository>();

            #endregion
        }
    }
}
