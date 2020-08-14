using System;
using System.Linq;

namespace AulaCSharp.Exercicios
{
    public class ExercicioUtilizandoParametroOut
    {
        public static void Executar()
        {
            int[] conjunto = new int[8];

            PreencherPosicoes(conjunto);
            CalcularSomaEMedia(conjunto, out var soma, out var media);

            Console.WriteLine($"Soma: {soma}");
            Console.WriteLine($"Média: {media}");
        }

        private static void PreencherPosicoes(int[] conjunto)
        {
            for (var i = 0; i < conjunto.Length; i++)
            {
                Console.Write($"Digite um número para a posição {(i + 1)}: ");
                conjunto[i] = Convert.ToInt32(Console.ReadLine());
            }
        }

        private static void CalcularSomaEMedia(int[] conjunto, out int soma, out double media)
        {
            soma = conjunto.Sum();
            media = conjunto.Average();
        }
    }
}