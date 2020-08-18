using AulaCSharp.Context;
using System;
using System.Linq;

namespace AulaCSharp
{
    class Program
    {
        // função principal, chamada automaticamente
        public static void Main()
        {
            var context = new AulaContext();

            foreach (var genero in context.Generos.OrderBy(q => q.Nome))
            {
                Console.WriteLine($"{genero.Id}, {genero.Nome}");
            }

            Console.ReadKey();
        }
    }
}
