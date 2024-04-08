namespace MentoriaApi.Entidade
{
    public class ContasPagar
    {
        public int ContasPagarId { get; set; }
        public string? Descricao { get; set;}
        public double Valor { get; set; }
        public string Cartao { get; set; }
    }
}