using AulaCSharp.Exemplos;
using System;

namespace AulaCSharp
{
    class Program
    {
        // função principal, chamada automaticamente
        public static void Main()
        {
            var livro = new Livro { Isbn = 2 };

            var a = new Livro { Isbn = 1 };
            var b = a;
            a.Isbn = 2;

            Console.WriteLine(livro.Isbn);
        }

        public static void TestarLivro(Livro livro)
        {
            livro.Isbn = 1;
        }
    }
}
