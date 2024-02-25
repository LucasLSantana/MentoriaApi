using MentoriaApi.Entidade;

namespace MentoriaApi.Interface
{
    public interface IContaPagarRepository
    {
        Task<IEnumerable<ContaPagar>> GetContaPagar();
    }
}