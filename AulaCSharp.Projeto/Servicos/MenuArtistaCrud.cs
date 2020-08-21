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

            Console.WriteLine("Digite qualquer tecla para continuar...");
            Console.ReadKey();
        }

        protected override void Excluir()
        {
            var artista = RecuperarArtista("Digite um código para excluir: ");
            if (artista == null) return;

            Context.Artistas.Remove(artista);
            Context.SaveChanges();
        }

        protected override void Atualizar()
        {
            var artista = RecuperarArtista("Digite um código para atualizar: ");
            if (artista == null) return;

            Console.WriteLine($"Código = {artista.Id}");
            artista.Nome = ConsoleHelper.SolicitarTexto($"Digite um novo nome para artista ({artista.Nome}): ");
            Context.SaveChanges();
        }

        private Artista RecuperarArtista(string enunciado)
        {
            Listar();

            var id = ConsoleHelper.SolicitarNumero(enunciado);
            return Context.Artistas.FirstOrDefault(q => q.Id == id);
        }
    }
}