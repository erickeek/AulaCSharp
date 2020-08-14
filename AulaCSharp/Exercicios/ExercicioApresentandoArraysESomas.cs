using System;
using System.Linq;

namespace AulaCSharp.Exercicios
{
    public class ExercicioApresentandoArraysESomas
    {
        public static void Executar()
        {
            var conjunto1 = new[] { 1, 2, 3 };
            var conjunto2 = new[] { 4, 5, 6, 7 };
            var conjunto3 = new[] { 7, 8, 9, 10, 11 };

            ApresentarESomar(conjunto1);
            ApresentarESomar(conjunto2);
            ApresentarESomar(conjunto3);
        }

        public static void ApresentarESomar(int[] array)
        {
            Console.WriteLine($"Listando...\n{string.Join("\n", array)}");
            Console.WriteLine($"Soma: {array.Sum()}");

            //Console.WriteLine("** Apresentando de outra forma ** ");
            //
            //var soma = 0;
            //for (int i = 0; i < array.Length; i++)
            //{
            //    soma += array[i];
            //    Console.WriteLine(array[i]);
            //}
            //Console.WriteLine($"Outra soma: {soma}");
        }
    }
}