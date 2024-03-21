using MentoriaApi.Entidade;
using System.Collections.Generic;

namespace MentoriaApi.Interface
{
    public interface IContaPagarService
    {
        Task<IEnumerable<ContaPagar>> GetContaPagar();
        Task<bool> IntegraContasPagar(ContaPagar entity);
        void DeletaContaPagar(int id);
        IAsyncEnumerable<int> ContagemContasPagar();
    }
}