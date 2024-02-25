using MentoriaApi.Data;
using MentoriaApi.Entidade;
using MentoriaApi.Interface;
using Microsoft.EntityFrameworkCore;

namespace MentoriaApi.Repository
{
    public class ContaPagarRepository : IContaPagarRepository
    {
        private readonly MentoriaContext _context;

        public ContaPagarRepository(MentoriaContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<ContaPagar>> GetContaPagar()
        {
            return await _context.ContaPagar.ToListAsync();
        }
    }
}