using MentoriaApi.Entidade;

namespace MentoriaApi.Interface.Service
{
    public interface INotasService
    {
        Task<IEnumerable<Notas>> GetNotasAsync();
        Task IntegraNotasAsync(Notas entity);
        Task DeletaNotasAsync(int id);
        Task<int> ContagemNotasAsync();
    }
}