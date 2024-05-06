using System.ComponentModel.DataAnnotations;

namespace MentoriaApi.Entidade
{
    public class Notas
    {
        [Key]
        public int NotaId { get; set; }
        public required string Titulo { get; set; }
        public required string Descricao { get; set; }
    }
}