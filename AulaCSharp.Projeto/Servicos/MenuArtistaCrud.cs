using System;
using System.Linq;
using AulaCSharp.Context.Models;
using AulaCSharp.Projeto.Helpers;

namespace AulaCSharp.Projeto.Servicos
{
    public class MenuArtistaCrud : MenuCrud
    {
        protected override void Apresentar()
        {
            Console.WriteLine("CRUD de Artista");
            base.Apresentar();
        }

        protected override void Adicionar()
        {
            var nome = ConsoleHelper.SolicitarTexto("Digite o nome para o artista: ");
            Context.Artistas.Add(new Artista
            {
                Nome = nome
            });
            Context.SaveChanges();
        }

        protected override void Listar()
        {
            foreach (var artista in Context.Artistas)
            {
                Console.WriteLine(artista);
            }

            ConsoleHelper.DigiteQualquerTeclaParaContinuar();
        }

        protected override void Excluir()
        {
            var artista = Context.RecuperarArtista("Digite um código para excluir: ");

            Context.Artistas.Remove(artista);
            Context.SaveChanges();
        }

        protected override void Atualizar()
        {
            var artista = Context.RecuperarArtista("Digite um código para atualizar: ");

            Console.WriteLine($"Código = {artista.Id}");
            artista.Nome = ConsoleHelper.SolicitarTexto($"Digite um novo nome para artista ({artista.Nome}): ");
            Context.SaveChanges();
        }
    }
}