using MentoriaApi.Helpers.Const;
using MentoriaApi.Interface.Factory;

namespace MentoriaApi.Services
{
    class MasterCardService : Cartao
    {
        public double LimiteCartao()
        {
            return 2500;
        }

        public string TipoCartao()
        {
            return StringConst.MasterCard;
        }
    }
}