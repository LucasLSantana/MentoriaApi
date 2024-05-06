using MentoriaApi.Interface.Factory;
using MentoriaApi.Resource;
using MentoriaApi.Services;

namespace MentoriaApi.Helpers.Factory
{
    public class CartaoFactory
    {
        public static Cartao GetCartao(int cartao)
        {
            Cartao? factory = cartao
            
            switch
            {
                1 => new VisaService(),
                2 => new MasterCardService(),
                _ => throw new NotImplementedException(message: Messages.OperacaoNaoImplementada),
            };
            return factory;
        }
    }
}