using MentoriaApi.Data;
using MentoriaApi.Entidade;
using MentoriaApi.Interface;
using Microsoft.EntityFrameworkCore;

namespace MentoriaApi.Repository
{
    public class ContaPagarRepository(MentoriaContext context) : IContaPagarRepository
    {
        public async Task<IEnumerable<ContaPagar>> GetContaPagar()
        {
            return await context.ContaPagar.ToListAsync();
        }

        public async Task<bool> IntegraContasPagar(ContaPagar entity)
        {
            await context.ContaPagar.AddAsync(entity);
            await context.SaveChangesAsync();
            return true;
        }

        public void DeletaContaPagar(int id)
        {
            var conta = context.ContaPagar.FirstOrDefault(s => s.ContaPagarId == id);
            if (conta is not null)
            {
                context.Remove(conta);
            }
        }

        public async IAsyncEnumerable<int> ContagemContasPagar()
        {
            var lstContasPagar = await context.ContaPagar.ToListAsync();
            yield return lstContasPagar.Count;
        }
    }
}