using MentoriaApi.Entidade;

namespace MentoriaApi.Interface.Repository
{
    public interface INotasRepository : IDisposable
    {
        Task<IEnumerable<Notas>> GetNotasAsync();
        Task IntegraNotasAsync(Notas entity);
        Task DeletaNotasAsync(int id);
        Task<int> ContagemNotasAsync();
    }
}