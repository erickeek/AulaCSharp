using System.Collections.Generic;

namespace AulaCSharp.Context.Models
{
    public class Musica
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Cantor { get; set; }
        public int Duracao { get; set; }

        public ICollection<Album> Albuns { get; set; } = new HashSet<Album>();
    }
}