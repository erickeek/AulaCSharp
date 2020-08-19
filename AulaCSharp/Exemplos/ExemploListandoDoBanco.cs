using AulaCSharp.Context;
using System;

namespace AulaCSharp.Exemplos
{
    public class ExemploListandoDoBanco
    {
        public static void Executar()
        {
            var context = new AulaContext();

            //metodo EAGER tenho q explicitamente apontar as classes que vou utilizar
            //var albuns = context.Albuns
            //    .Include(q => q.Artista)
            //    .Include(q => q.Genero);

            // LAZY
            var albuns = context.Albuns;

            foreach (var album in albuns)
            {
                Console.WriteLine($"{album.Nome}, {album.Genero.Nome}, {album.Artista.Nome}");
            }
        }
    }
}