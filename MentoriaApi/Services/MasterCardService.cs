using MentoriaApi.Interface.Factory;

namespace MentoriaApi.Services
{
    class MasterCardService : Cartao
    {
        public async Task<double> LimiteCartao()
        {
            return 2500;
        }

        public async Task<string> TipoCartao()
        {
            return "Master Card";
        }
    }
}