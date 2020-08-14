using System;
using System.Linq;
using AulaCSharp.Models;

namespace AulaCSharp.Exercicios
{
    public class ExercicioEscola
    {
        public static void Executar()
        {
            // Escola[] escolas = new Escola[5];
            var escolas = new Escola[5];

            for (int i = 0; i < escolas.Length; i++)
            {
                // instanciando uma nova escola
                var escola = new Escola();

                // recuperando o nome da escola do usuário
                Console.Write($"Digite o nome da escola {i + 1}: ");
                escola.Nome = Console.ReadLine();

                // recuperando a quantidade de estudantes e convetendo para inteiro
                Console.Write($"Digite a quantidade de estudantes da escola {escola.Nome}: ");
                escola.QuantidadeDeEstudantes = Convert.ToInt32(Console.ReadLine());

                // colocando o objeto/instância criada dentro do array numa posição especifica
                escolas[i] = escola;

                //-----------

                //escolas[i] = new Escola();
                //Console.Write($"Digite o nome da escola {i + 1}: ");
                //escolas[i].Nome = Console.ReadLine();
                //
                //Console.Write($"Digite a quantidade de estudantes da escola {escola.Nome}: ");
                //escolas[i].QuantidadeDeEstudantes = Convert.ToInt32(Console.ReadLine());
            }

            foreach (var escola in escolas.OrderByDescending(q => q.QuantidadeDeEstudantes))
            {
                Console.WriteLine($"{escola.Nome}\t{escola.QuantidadeDeEstudantes}");
            }
        }
    }
}