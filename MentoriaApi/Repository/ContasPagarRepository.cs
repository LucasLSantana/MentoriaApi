using MentoriaApi.Data;
using MentoriaApi.Entidade;
using MentoriaApi.Interface;
using MentoriaApi.Interface.Repository;
using Microsoft.EntityFrameworkCore;

namespace MentoriaApi.Repository
{
    public class ContasPagarRepository(MentoriaContext context) : IContasPagarRepository
    {
        private IContasPagarRepository _contasPagarRepositoryImplementation;

        public async Task<IEnumerable<ContasPagar>> GetContasPagarAsync()
        {
            return await context.ContasPagar.ToListAsync();
        }

        public async Task<bool> IntegraContasPagarAsync(ContasPagar entity)
        {
            await context.ContasPagar.AddAsync(entity);
            await context.SaveChangesAsync();
            return true;
        }
        
        public async Task IntegraListaContasPagarAsync(IEnumerable<ContasPagar> listContaPagar)
        {
            await context.AddRangeAsync(listContaPagar);
            await context.SaveChangesAsync();
        }

        public async Task DeletaContaPagarAsync(int id)
        {
            var conta = context.ContasPagar.FirstOrDefault(s => s.ContasPagarId == id);
            if (conta is not null)
            {
                context.Remove(conta);
            }
            await Task.CompletedTask;
        }

        public async Task<int> ContagemContasPagarAsync()
        {
            var lstContasPagar = await context.ContasPagar.ToListAsync();
            return lstContasPagar.Count;
        }

        public async Task<double> ValorContasPagarAsync()
        {
            var lstContasPagar = await context.ContasPagar.ToListAsync();
            return lstContasPagar.Sum(s => s.Valor);
        }

        public async Task<IEnumerable<ContasPagar>> BuscaPorListaId(List<int> listId)
        {
            var listContasPagar = new List<ContasPagar>();

            foreach (var id in listId)
            {
                var conta = await context.ContasPagar.FirstAsync(f => f.ContasPagarId == id);
                listContasPagar.Add(conta);
            }
            return listContasPagar;
        }

        public async Task SalvarAlteracoes()
        {
            var transation = await context.Database.BeginTransactionAsync();
            await context.SaveChangesAsync();
            await transation.CommitAsync();
        }
    }
}