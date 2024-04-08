using MentoriaApi.Interface.Factory;

namespace MentoriaApi.Services
{
    class VisaService : Cartao
    {
        public async Task<double> LimiteCartao()
        {
            return 1500;
        }

        public async Task<string> TipoCartao()
        {
            return "Visa";
        }
    }
}