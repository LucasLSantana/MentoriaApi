using MentoriaApi.Entidade;
using Microsoft.EntityFrameworkCore;

namespace MentoriaApi.Data
{
    public class MentoriaContext(DbContextOptions<MentoriaContext> options) : DbContext(options)
    {
        public DbSet<ContasPagar> ContasPagar { get; set; } = default!;
        public DbSet<ContasReceber> ContasReceber { get; set; } = default!;
    }   
}