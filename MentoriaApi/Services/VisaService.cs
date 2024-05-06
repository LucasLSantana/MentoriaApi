using MentoriaApi.Helpers.Const;
using MentoriaApi.Interface.Factory;

namespace MentoriaApi.Services
{
    class VisaService : Cartao
    {
        public double LimiteCartao()
        {
            return 1500;
        }

        public string TipoCartao()
        {
            return StringConst.Visa;
        }
    }
}