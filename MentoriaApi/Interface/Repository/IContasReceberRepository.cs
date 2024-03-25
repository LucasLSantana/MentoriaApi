using MentoriaApi.Entidade;

namespace MentoriaApi.Interface.Repository;

public interface IContasReceberRepository
{
    Task<IEnumerable<ContasReceber>> GetContasReceberAsync();
    Task<bool> IntegraContasReceberAsync(ContasReceber entity);
    Task IntegraListaContasReceberAsync(IEnumerable<ContasReceber> listContaPagar);
    Task DeletaContasReceberAsync(int id);
    Task<int> ContagemContasReceberAsync();
    Task<double> ValorContasReceberAsync();
}