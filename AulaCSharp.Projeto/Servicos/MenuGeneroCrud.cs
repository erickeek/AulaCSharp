using System;
using System.Linq;
using AulaCSharp.Context.Models;
using AulaCSharp.Projeto.Helpers;

namespace AulaCSharp.Projeto.Servicos
{
    public class MenuGeneroCrud : MenuCrud
    {
        protected override void Apresentar()
        {
            Console.WriteLine("CRUD de Gênero");
            base.Apresentar();
        }

        protected override void Adicionar()
        {
            var nome = ConsoleHelper.SolicitarTexto("Digite o nome para gênero: ");
            Context.Generos.Add(new Genero
            {
                Nome = nome
            });
            Context.SaveChanges();
        }

        protected override void Listar()
        {
            foreach (var genero in Context.Generos)
            {
                Console.WriteLine(genero);
            }

            Console.WriteLine("Digite qualquer tecla para continuar...");
            Console.ReadKey();
        }

        protected override void Excluir()
        {
            var genero = RecuperarGenero("Digite um código para excluir: ");
            if (genero == null) return;

            Context.Generos.Remove(genero);
            Context.SaveChanges();
        }

        protected override void Atualizar()
        {
            var genero = RecuperarGenero("Digite um código para atualizar: ");
            if (genero == null) return;

            Console.WriteLine($"Código = {genero.Id}");
            genero.Nome = ConsoleHelper.SolicitarTexto($"Digite um novo nome para gênero ({genero.Nome}): ");
            Context.SaveChanges();
        }

        private Genero RecuperarGenero(string enunciado)
        {
            Listar();

            var id = ConsoleHelper.SolicitarNumero(enunciado);
            return Context.Generos.FirstOrDefault(q => q.Id == id);
        }
    }
}