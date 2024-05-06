using MentoriaApi.Entidade;
using MentoriaApi.Interface.Repository;
using MentoriaApi.Interface.Service;

namespace MentoriaApi.Services
{
    public class NotasService(INotasRepository repository) : INotasService
    {
        public async Task<int> ContagemNotasAsync()
        {
            return await repository.ContagemNotasAsync();
        }

        public async Task DeletaNotasAsync(int id)
        {
            await repository.DeletaNotasAsync(id);
            await Task.CompletedTask;
        }

        public async Task<IEnumerable<Notas>> GetNotasAsync()
        {
            return await repository.GetNotasAsync();
        }

        public async Task IntegraNotasAsync(Notas entity)
        {
            await repository.IntegraNotasAsync(entity);
        }
    }
}