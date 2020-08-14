using System;

namespace AulaCSharp.Exercicios
{
    public class ExercicioCalculandoQuadradoECuboDeUmNumero
    {
        public static void Executar()
        {
            Console.Write("Digite um número: ");
            var numero = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Quadrado: {Quadrado(numero)}\n");
            Console.WriteLine($"Cubo: {Cubo(numero)}");
        }

        public static int Quadrado(int numero)
        {
            return numero * numero;
        }

        public static int Cubo(int numero)
        {
            return Quadrado(numero) * numero;
        }
    }
}