using AulaCSharp.Context.Models;
using AulaCSharp.Projeto.Helpers;
using System;

namespace AulaCSharp.Projeto.Servicos
{
    public class MenuAlbumCrud : MenuCrud
    {
        protected override void Apresentar()
        {
            Console.WriteLine("CRUD de Album");
            base.Apresentar();
        }

        protected override void Adicionar()
        {
            Console.Write("Digite o nome para o album: ");
            var nome = Console.ReadLine();
            var artista = Context.RecuperarArtista("Digite um código de artista: ");
            var genero = Context.RecuperarGenero("Digite um código do gênero: ");
            var valor = ConsoleHelper.SolicitarDecimal("Digite o valor do album: ");

            Context.Albuns.Add(new Album
            {
                Nome = nome,
                IdArtista = artista.Id,
                IdGenero = genero.Id,
                Valor = valor
            });
            Context.SaveChanges();
        }

        protected override void Listar()
        {
            foreach (var album in Context.Albuns)
            {
                Console.WriteLine(album);
            }

            ConsoleHelper.DigiteQualquerTeclaParaContinuar();
        }

        protected override void Excluir()
        {
            var album = Context.RecuperarAlbum("Digite um código para excluir: ");

            Context.Albuns.Remove(album);
            Context.SaveChanges();
        }

        protected override void Atualizar()
        {
            var album = Context.RecuperarAlbum("Digite um código para atualizar: ");

            Console.WriteLine($"Código = {album.Id}");
            var nome = ConsoleHelper.SolicitarTexto($"Digite um novo nome para album ({album.Nome}): ");
            var artista = Context.RecuperarArtista("Digite um código de artista: ");
            var genero = Context.RecuperarGenero("Digite um código do gênero: ");
            var valor = ConsoleHelper.SolicitarDecimal("Digite o valor do album: ");

            album.Nome = nome;
            album.IdArtista = artista.Id;
            album.IdGenero = genero.Id;
            album.Valor = valor;

            Context.SaveChanges();
        }
    }
}