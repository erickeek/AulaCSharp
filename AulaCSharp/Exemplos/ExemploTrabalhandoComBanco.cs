using AulaCSharp.Context;
using System;
using System.Linq;

namespace AulaCSharp.Exemplos
{
    public class ExemploTrabalhandoComBanco
    {
        public static void Salvando()
        {
            var context = new AulaContext();

            var generos = context.Generos;
            foreach (var g in generos)
            {
                Console.WriteLine($"{g.Id}, {g.Nome}");
            }

            Console.Write("Escolha um item pelo código para alterar: ");
            var id = Convert.ToInt32(Console.ReadLine());
            var genero = generos.FirstOrDefault(q => q.Id == id);

            Console.Write($"Digite um novo nome para o gênero '{genero.Nome}': ");
            genero.Nome = Console.ReadLine();
            context.SaveChanges();

            foreach (var g in generos)
            {
                Console.WriteLine($"{g.Id}, {g.Nome}");
            }
        }

        public static void Excluindo()
        {
            var context = new AulaContext();

            Console.Write("Digite o código do gênero que deseja excluir: ");
            var id = Convert.ToInt32(Console.ReadLine());

            var genero = context.Generos.FirstOrDefault(q => q.Id == id);
            if (genero != null)
                context.Generos.Remove(genero);

            context.SaveChanges();
        }

        public static void Atualizando()
        {
            var context = new AulaContext();

            var id = 0;
            do
            {
                try
                {
                    Console.Write("Digite o código do gênero que deseja alterar: ");
                    id = Convert.ToInt32(Console.ReadLine());

                    if (id > 0)
                        break;
                }
                catch
                {
                    Console.WriteLine("O codigo digitado não é válido!!");
                }

            } while (true);

            var genero = context.Generos.FirstOrDefault(q => q.Id == id);
            if (genero != null)
            {
                Console.Write($"O nome do gênero é {genero.Nome} digite o novo nome:");
                var nome = Console.ReadLine();
                genero.Nome = nome;
            }
        }
    }
}