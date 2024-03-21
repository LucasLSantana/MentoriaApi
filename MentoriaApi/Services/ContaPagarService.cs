using MentoriaApi.Entidade;
using MentoriaApi.Interface;

namespace MentoriaApi.Services
{
    public class ContaPagarService(IContaPagarRepository repository) : IContaPagarService
    {
        public async Task<IEnumerable<ContaPagar>> GetContaPagar()
        {
            var conta = await repository.GetContaPagar();
            return conta;
        }

        public async Task<bool> IntegraContasPagar(ContaPagar entity)
        {
            return await repository.IntegraContasPagar(entity);
        }

        public void DeletaContaPagar(int id)
        {
            repository.DeletaContaPagar(id);
        }

        public IAsyncEnumerable<int> ContagemContasPagar()
        {
            return repository.ContagemContasPagar();
        }
    }
}