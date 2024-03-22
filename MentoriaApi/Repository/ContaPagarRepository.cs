using MentoriaApi.Data;
using MentoriaApi.Entidade;
using MentoriaApi.Interface;
using Microsoft.EntityFrameworkCore;

namespace MentoriaApi.Repository
{
    public class ContaPagarRepository(MentoriaContext context) : IContaPagarRepository
    {
        public async Task<IEnumerable<ContaPagar>> GetContaPagarAsync()
        {
            return await context.ContaPagar.ToListAsync();
        }

        public async Task<bool> IntegraContasPagarAsync(ContaPagar entity)
        {
            await context.ContaPagar.AddAsync(entity);
            await context.SaveChangesAsync();
            return true;
        }
        
        public async Task IntegraListaContasPagarAsync(IEnumerable<ContaPagar> listContaPagar)
        {
            await using var transaction = await context.Database.BeginTransactionAsync();
            await context.AddRangeAsync(listContaPagar);
            await context.SaveChangesAsync();
            await transaction.CommitAsync();
        }

        public async Task DeletaContaPagarAsync(int id)
        {
            var conta = context.ContaPagar.FirstOrDefault(s => s.ContaPagarId == id);
            if (conta is not null)
            {
                context.Remove(conta);
            }
            await Task.CompletedTask;
        }

        public async Task<int> ContagemContasPagarAsync()
        {
            var lstContasPagar = await context.ContaPagar.ToListAsync();
            return lstContasPagar.Count;
        }

        public async Task<double> ValorContasPagarAsync()
        {
            var lstContasPagar = await context.ContaPagar.ToListAsync();
            return lstContasPagar.Sum(s => s.Valor);
        }
    }
}