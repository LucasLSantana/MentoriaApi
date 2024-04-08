using MentoriaApi.Interface.Factory;
using MentoriaApi.Services;

namespace MentoriaApi.Helpers.Factory
{
    public class CartaoFactory
    {
        public static Cartao GetCartao(string cartao)
        {
            Cartao? factory = cartao
            
            switch
            {
                "Visa" => new VisaService(),
                "MasterCard" => new MasterCardService(),
                _ => throw new NotImplementedException(),
            };
            return factory;
        }
    }
}