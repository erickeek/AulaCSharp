using System.Collections.Generic;

namespace AulaCSharp.Context.Models
{
    public class Album
    {
        public int Id { get; set; }
        public int IdGenero { get; set; }
        public int IdArtista { get; set; }
        public string Nome { get; set; }
        public decimal Valor { get; set; }

        public virtual Artista Artista { get; set; }
        public virtual Genero Genero { get; set; }

        public virtual ICollection<Musica> Musicas { get; set; } = new HashSet<Musica>();
    }
}
