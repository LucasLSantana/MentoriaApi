using MentoriaApi.Entidade;

namespace MentoriaApi.Interface.Service;

public interface IContasReceberService
{
    Task<IEnumerable<ContasReceber>> GetContasReceberAsync();
    Task<bool> IntegraContasReceberAsync(ContasReceber entity);
    Task IntegraListaContasReceberAsync(IEnumerable<ContasReceber> listContaReceber);
    Task DeletaContaReceberAsync(int id);
    Task<int> ContagemContasReceberAsync();
}