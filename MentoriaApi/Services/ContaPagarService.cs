using MentoriaApi.Entidade;
using MentoriaApi.Interface;

namespace MentoriaApi.Services
{
    public class ContaPagarService : IContaPagarService
    {
        private readonly IContaPagarRepository _repository;

        public ContaPagarService(IContaPagarRepository repository)
        {
            _repository = repository;
        }

        public async Task<IEnumerable<ContaPagar>> GetContaPagar()
        {
            var conta = await _repository.GetContaPagar();
            return conta;
        }
    }
}