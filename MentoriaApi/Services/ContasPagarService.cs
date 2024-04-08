using MentoriaApi.Entidade;
using MentoriaApi.Helpers.Factory;
using MentoriaApi.Interface.Repository;
using MentoriaApi.Interface.Service;

namespace MentoriaApi.Services
{
    public class ContasPagarService(IContasPagarRepository repository) : IContasPagarService
    {
        public async Task<IEnumerable<ContasPagar>> GetContasPagarAsync()
        {
            var conta = await repository.GetContasPagarAsync();
            return conta;
        }

        public async Task<bool> IntegraContasPagarAsync(ContasPagar entity)
        {
            if (!string.IsNullOrWhiteSpace(entity.Cartao)) await ValidaLimite(entity);
            await repository.IntegraContasPagarAsync(entity);
            await repository.SalvarAlteracoes();
            return true;
        }

        public async Task IntegraListaContasPagarAsync(IEnumerable<ContasPagar> listContaPagar)
        {
            await repository.IntegraListaContasPagarAsync(listContaPagar);
            await repository.SalvarAlteracoes();
        }

        public async Task DeletaContaPagarAsync(int id)
        {
            await repository.DeletaContaPagarAsync(id);
        }

        public async Task<int> ContagemContasPagarAsync()
        {
            return await repository.ContagemContasPagarAsync();
        }

        public async Task AtualizaValorContasPagarAsync(List<int> listId, double valorAtualizar)
        {
            var listContasPagar = await repository.BuscaPorListaId(listId);
            foreach (var conta in listContasPagar)
            {
                conta.Valor = valorAtualizar;
            }
            await repository.SalvarAlteracoes();
        }

        public async Task<double> ValorContasPagarAsync()
        {
            return await repository.ValorContasPagarAsync();
        }

        public async Task ValidaLimite(ContasPagar contasPagar)
        {
            var cartao = CartaoFactory.GetCartao(contasPagar.Cartao);
            var limite = await cartao.LimiteCartao();
            if (limite - contasPagar.Valor < 0) throw new Exception(message: "Sem limite");
        }
    }
}