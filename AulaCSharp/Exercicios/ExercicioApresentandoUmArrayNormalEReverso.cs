using System;

namespace AulaCSharp.Exercicios
{
    public class ExercicioApresentandoUmArrayNormalEReverso
    {
        public static void Executar()
        {
            var numeros = new int[5];

            for (int i = 0; i < numeros.Length; i++)
            {
                Console.Write("Digite um número: ");
                var numero = Convert.ToInt32(Console.ReadLine());
                numeros[i] = numero;
            }

            Console.WriteLine("* Lista normal");
            for (int i = 0; i < numeros.Length; i++)
            {
                Console.WriteLine(numeros[i]);
            }

            Console.WriteLine("* Lista reversa");
            for (int i = numeros.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(numeros[i]);
            }
        }
    }
}