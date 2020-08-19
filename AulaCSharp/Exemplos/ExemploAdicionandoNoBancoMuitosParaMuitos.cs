using AulaCSharp.Context;
using AulaCSharp.Context.Models;
using System;
using System.Data.Entity;
using System.Linq;

namespace AulaCSharp.Exemplos
{
    public class ExemploAdicionandoNoBancoMuitosParaMuitos
    {
        public static void Executar()
        {
            var context = new AulaContext();
            var musica = new Musica
            {
                Nome = "Stratovarius",
                Cantor = "XXX",
                Duracao = 250
            };

            var album = new Album
            {
                Nome = "Stratovarius",
                IdGenero = 3,
                IdArtista = 4,
                Valor = 30
            };
            album.Musicas.Add(musica);

            context.Albuns.Add(album);

            context.SaveChanges();
        }

        public static void Listar()
        {
            var context = new AulaContext();

            foreach (var album in context.Albuns.Where(q => q.Musicas.Any()))
            {
                Console.WriteLine(album.Nome + " " + album.Genero.Nome);

                var i = 0;
                foreach (var musica in album.Musicas)
                {
                    Console.WriteLine($"{++i} - {musica.Nome}");
                }
            }
        }
    }
}