namespace MentoriaApi.Interface.Factory
{
    public interface Cartao
    {
        Task<string> TipoCartao();
        Task<double> LimiteCartao();
    }
}