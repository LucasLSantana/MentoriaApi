using MentoriaApi.Entidade;
using System.Collections.Generic;

namespace MentoriaApi.Interface
{
    public interface IContaPagarService
    {
        Task<IEnumerable<ContaPagar>> GetContaPagar();
    }
}