namespace AulaCSharp.Context.Models
{
    public class Album
    {
        public int Id { get; set; }
        public int IdGenero { get; set; }
        public int IdArtista { get; set; }
        public string Nome { get; set; }
        public decimal Valor { get; set; }

        public Artista Artista { get; set; }
        public Genero Genero { get; set; }
    }
}
