using System.Collections.Generic;

namespace AulaCSharp.Context.Models
{
    public class Genero
    {
        public int Id { get; set; }
        public string Nome { get; set; }

        public ICollection<Album> Albuns { get; set; } = new HashSet<Album>();

        public override string ToString()
        {
            return $"{Id,-10}{Nome,-20}";
        }
    }
}
