using MentoriaApi.Entidade;
using MentoriaApi.Interface;

namespace MentoriaApi.Services
{
    public class ContaPagarService(IContaPagarRepository repository) : IContaPagarService
    {
        public async Task<IEnumerable<ContaPagar>> GetContaPagarAsync()
        {
            var conta = await repository.GetContaPagarAsync();
            return conta;
        }

        public async Task<bool> IntegraContasPagarAsync(ContaPagar entity)
        {
            return await repository.IntegraContasPagarAsync(entity);
        }

        public async Task IntegraListaContasPagarAsync(IEnumerable<ContaPagar> listContaPagar)
        {
            await repository.IntegraListaContasPagarAsync(listContaPagar);
        }

        public async Task DeletaContaPagarAsync(int id)
        {
            await repository.DeletaContaPagarAsync(id);
        }

        public async Task<int> ContagemContasPagarAsync()
        {
            return await repository.ContagemContasPagarAsync();
        }
        
        public async Task MediaContasPagarAsync()
        {
            var contagem = ContagemContasPagarAsync();
            var somatorio = SomaValorContasPagarAsync();

            await Task.WhenAll(contagem, somatorio);
        }
        
        private async Task<double> SomaValorContasPagarAsync()
        {
            return await repository.ValorContasPagarAsync();
        }
    }
}