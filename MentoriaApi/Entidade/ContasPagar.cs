using System.ComponentModel.DataAnnotations;

namespace MentoriaApi.Entidade
{
    public class ContasPagar()
    {
        [Key]
        public int ContasPagarId { get; set; }
        public string Descricao { get; set; }
        public double Valor { get; set; }
        public int Cartao { get; set; }
    }
}