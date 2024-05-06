using MentoriaApi.Entidade;
using MentoriaApi.Helpers.Factory;
using MentoriaApi.Interface.Repository;
using MentoriaApi.Interface.Service;
using MentoriaApi.Resource;

namespace MentoriaApi.Services
{
    public class ContasPagarService(IContasPagarRepository repository) : IContasPagarService
    {
        public async Task<IEnumerable<ContasPagar>> GetContasPagarAsync()
        {
            var conta = await repository.GetContasPagarAsync();
            return conta;
        }

        public async Task IntegraContasPagarAsync(ContasPagar entity)
        {
            ValidaLimite(entity);
            await repository.IntegraContasPagarAsync(entity);
            await repository.SalvarAlteracoes();
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

        public void ValidaLimite(ContasPagar contasPagar)
        {
            var cartao = CartaoFactory.GetCartao(contasPagar.Cartao);
            var limite = cartao.LimiteCartao();
            if (limite - contasPagar.Valor < 0) throw new Exception(message: Messages.SemLimiteParaOperacao);
        }


        public IEnumerable<double> CalcularValorTotalPagar(ContasPagar conta, double desconto = 0)
        {
            yield return conta.Valor - desconto;
        }

        public async Task<double> RecuperDescontoContasPagar(double desconto)
        {
            var listContasPagar = await repository.GetContasPagarAsync();
            var valor = 0.0;
            foreach (var item in listContasPagar)
            {
                valor += CalcularValorTotalPagar(item, desconto).FirstOrDefault();
            }
            return valor;
        }
    }
}