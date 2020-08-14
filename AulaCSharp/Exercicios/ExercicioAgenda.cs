using AulaCSharp.Models;
using System;
using System.Linq;

namespace AulaCSharp.Exercicios
{
    public class ExercicioAgenda
    {
        public static void Executar()
        {
            var amigos = new[]
            {
                new Amigo{Nome = "Érick", Telefone = "(44) 0000-0000", Ano = 1987, Mes = 11, Dia = 12},
                new Amigo{Nome = "José", Telefone = "(44) 1111-1111", Ano = 1990, Mes = 11, Dia = 11},
                new Amigo{Nome = "Maria", Telefone = "(44) 2222-2222", Ano = 2000, Mes = 1, Dia = 5},
                new Amigo{Nome = "José Maria", Telefone = "(44) 3333-3333", Ano = 1985, Mes = 6, Dia = 20},
                new Amigo{Nome = "Maria José", Telefone = "(44) 4444-4444", Ano = 1989, Mes = 8, Dia = 21},
                new Amigo{Nome = "Joselito", Telefone = "(44) 55555-5555", Ano = 1999, Mes = 5, Dia = 25},
                new Amigo{Nome = "Noel", Telefone = "(44) 6666-6666", Ano = 2000, Mes = 12, Dia = 25},
                new Amigo{Nome = "Natalino", Telefone = "(44) 7777-7777", Ano = 2001, Mes = 12, Dia = 24},
            };

            do
            {
                Console.Clear();
                Console.WriteLine("Digite uma das opções da agenda");
                Console.WriteLine("1 - Listar amigos");
                Console.WriteLine("2 - Consultar amigos");
                Console.WriteLine("3 - Listar aniversariantes");
                Console.WriteLine("4 - Sair");
                var opcao = Convert.ToInt32(Console.ReadLine());
                if (opcao == 4) break;

                switch (opcao)
                {
                    case 1:
                        Listar(amigos);
                        break;
                    case 2:
                        Console.Write("Digite um termo de consulta: ");
                        var termo = Console.ReadLine();
                        Consultar(termo, amigos);
                        break;
                    case 3:
                        Console.Write("Digite um mês para listar: ");
                        var mes = Convert.ToInt32(Console.ReadLine());
                        ListarPeloMesDeAniversario(mes, amigos);
                        break;
                }

                Console.WriteLine("Preesione qualquer tecla para continuar...");
                Console.ReadKey();

            } while (true);
        }

        private static void Listar(params Amigo[] amigos)
        {
            foreach (var amigo in amigos.OrderBy(q => q.Nome))
            {
                Console.WriteLine($"{amigo.Nome.PadRight(20)}{amigo.Telefone}");
            }
        }

        private static void Consultar(string termo, params Amigo[] amigos)
        {
            var amigosAchados = amigos.Where(q => q.Nome.ToLower().Contains(termo.ToLower())).OrderBy(q => q.Nome);
            if (!amigosAchados.Any())
            {
                Console.WriteLine($"Não foram encontrados amigos com o termo '{termo}'");
                return;
            }

            foreach (var amigo in amigosAchados)
            {
                Console.WriteLine($"{amigo.Nome.PadRight(20)}\t{amigo.Telefone}\t{amigo.DataDeNascimento}");
            }
        }

        private static void ListarPeloMesDeAniversario(int mes, params Amigo[] amigos)
        {
            foreach (var amigo in amigos.Where(q => q.Mes == mes).OrderBy(q => q.Dia))
            {
                Console.WriteLine($"{amigo.Dia} {amigo.Nome.PadRight(20)}{amigo.Telefone}");
            }
        }
    }
}