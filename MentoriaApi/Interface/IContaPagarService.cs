using MentoriaApi.Entidade;
using System.Collections.Generic;

namespace MentoriaApi.Interface
{
    public interface IContaPagarService
    {
        Task<IEnumerable<ContaPagar>> GetContaPagarAsync();
        Task<bool> IntegraContasPagarAsync(ContaPagar entity);
        Task IntegraListaContasPagarAsync(IEnumerable<ContaPagar> listContaPagar);
        Task DeletaContaPagarAsync(int id);
        Task<int> ContagemContasPagarAsync();
    }
}