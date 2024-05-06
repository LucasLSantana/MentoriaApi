using MentoriaApi.Data;
using MentoriaApi.Entidade;
using MentoriaApi.Interface.Repository;
using Microsoft.EntityFrameworkCore;

namespace MentoriaApi.Repository
{
    public class NotasRepository(MentoriaContext context) : INotasRepository
    {
        public async Task<int> ContagemNotasAsync()
        {
            var listNotas = await GetNotasAsync();
            return listNotas.Count();
        }

        public async Task DeletaNotasAsync(int id)
        {
            var nota = context.Notas.FirstOrDefault(s => s.NotaId == id);
            if (nota is not null)
            {
                context.Remove(nota);
            }
            await Task.CompletedTask;
        }

        public void Dispose()
        {
            context.Dispose();
            GC.SuppressFinalize(this);
        }

        public async Task<IEnumerable<Notas>> GetNotasAsync()
        {
            return await context.Notas.ToListAsync();
        }

        public async Task IntegraNotasAsync(Notas entity)
        {
            await context.Notas.AddAsync(entity);
            await context.SaveChangesAsync();
            await Task.CompletedTask;
        }

        public async Task SalvarAlteracoes()
        {
            var transation = await context.Database.BeginTransactionAsync();
            await context.SaveChangesAsync();
            await transation.CommitAsync();
        }
    }
}