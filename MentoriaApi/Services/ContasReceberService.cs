using MentoriaApi.Entidade;
using MentoriaApi.Interface.Repository;
using MentoriaApi.Interface.Service;

namespace MentoriaApi.Services
{
    public class ContasReceberService(IContasReceberRepository repository) : IContasReceberService
    {
        public async Task<IEnumerable<ContasReceber>> GetContasReceberAsync()
        {
            var conta = await repository.GetContasReceberAsync();
            return conta;
        }

        public async Task<bool> IntegraContasReceberAsync(ContasReceber entity)
        {
            return await repository.IntegraContasReceberAsync(entity);
        }

        public async Task IntegraListaContasReceberAsync(IEnumerable<ContasReceber> listContaPagar)
        {
            await repository.IntegraListaContasReceberAsync(listContaPagar);
        }

        public async Task DeletaContaReceberAsync(int id)
        {
            await repository.DeletaContasReceberAsync(id);
        }

        public async Task<int> ContagemContasReceberAsync()
        {
            return await repository.ContagemContasReceberAsync();
        }
    }
}