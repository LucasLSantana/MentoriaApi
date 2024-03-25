using MentoriaApi.Entidade;
using System.Collections.Generic;

namespace MentoriaApi.Interface.Service
{
    public interface IContasPagarService
    {
        Task<IEnumerable<ContasPagar>> GetContasPagarAsync();
        Task<bool> IntegraContasPagarAsync(ContasPagar entity);
        Task IntegraListaContasPagarAsync(IEnumerable<ContasPagar> listContaPagar);
        Task DeletaContaPagarAsync(int id);
        Task<int> ContagemContasPagarAsync();
        Task AtualizaValorContasPagarAsync(List<int> listId, double valorAtualizar);
        Task<double> ValorContasPagarAsync();
    }
}