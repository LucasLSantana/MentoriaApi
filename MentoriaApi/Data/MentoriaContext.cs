using MentoriaApi.Entidade;
using Microsoft.EntityFrameworkCore;

namespace MentoriaApi.Data
{
    public class MentoriaContext(DbContextOptions<MentoriaContext> options) : DbContext(options)
    {
        public DbSet<ContaPagar> ContaPagar { get; set; } = default!;
    }   
}