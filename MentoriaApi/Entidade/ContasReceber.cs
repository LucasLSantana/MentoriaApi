using System.ComponentModel.DataAnnotations;

namespace MentoriaApi.Entidade;

public class ContasReceber
{
    [Key]
    public int ContasReceberId { get; set; }
    public required string Descricao { get; set;}
    public double Valor { get; set; }
    public int Cartao { get; set; }
}