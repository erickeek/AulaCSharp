namespace AulaCSharp.Models
{
    public class Amigo
    {
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public int Dia { get; set; }
        public int Mes { get; set; }
        public int Ano { get; set; }

        public string DataDeNascimento => $"{Dia}/{Mes}/{Ano}";
    }
}