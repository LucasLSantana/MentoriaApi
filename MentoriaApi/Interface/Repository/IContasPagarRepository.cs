using MentoriaApi.Entidade;

namespace MentoriaApi.Interface.Repository
{
    public interface IContasPagarRepository
    {
        Task<IEnumerable<ContasPagar>> GetContasPagarAsync();
        Task<bool> IntegraContasPagarAsync(ContasPagar entity);
        Task IntegraListaContasPagarAsync(IEnumerable<ContasPagar> listContaPagar);
        Task DeletaContaPagarAsync(int id);
        Task<int> ContagemContasPagarAsync();
        Task<double> ValorContasPagarAsync();
        Task<IEnumerable<ContasPagar>> BuscaPorListaId(List<int> listId);
        Task SalvarAlteracoes();
    }
}