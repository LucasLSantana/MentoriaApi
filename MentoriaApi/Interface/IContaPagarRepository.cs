using MentoriaApi.Entidade;

namespace MentoriaApi.Interface
{
    public interface IContaPagarRepository
    {
        Task<IEnumerable<ContaPagar>> GetContaPagar();
        Task<bool> IntegraContasPagar(ContaPagar entity);
        void DeletaContaPagar(int id);
        IAsyncEnumerable<int> ContagemContasPagar();
    }
}