using System;

namespace AulaCSharp.Exercicios
{
    public class ExercicioParaSomarValoresDeUmArray
    {
        public static void Executar()
        {
            int[] numeros = { 10, 10, 10, 10, 10 };

            Console.WriteLine(string.Join(",", numeros));

            Console.WriteLine(ApresentarSoma(numeros));
        }

        private static int ApresentarSoma(int[] numeros)
        {
            var soma = 0;
            for (int i = 0; i < numeros.Length; i++)
            {
                soma += numeros[i];
            }
            Console.WriteLine(soma);

            foreach (var n in numeros)
            {
                soma += n;
            }

            return soma;
        }
    }
}