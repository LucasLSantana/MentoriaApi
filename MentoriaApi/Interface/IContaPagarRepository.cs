using MentoriaApi.Entidade;

namespace MentoriaApi.Interface
{
    public interface IContaPagarRepository
    {
        Task<IEnumerable<ContaPagar>> GetContaPagarAsync();
        Task<bool> IntegraContasPagarAsync(ContaPagar entity);
        Task IntegraListaContasPagarAsync(IEnumerable<ContaPagar> listContaPagar);
        Task DeletaContaPagarAsync(int id);
        Task<int> ContagemContasPagarAsync();
        Task<double> ValorContasPagarAsync();
    }
}