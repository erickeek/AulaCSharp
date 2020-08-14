using System;

namespace AulaCSharp.Exercicios
{
    public class ExercicioSomaESubtrai
    {
        public static void Executar()
        {
            Console.Write("Digite um número: ");
            var a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite outro número: ");
            var b = Convert.ToInt32(Console.ReadLine());

            int soma = Somar(a, b);
            int subtracao = Subtrair(a, b);

            Console.WriteLine($"A soma dos números é: {soma}");
            Console.WriteLine($"A subtração dos números é: {subtracao}");
        }

        public static int Somar(int numero1, int numero2)
        {
            return numero1 + numero2;
        }

        public static int Subtrair(int numero1, int numero2)
        {
            return numero1 - numero2;
        }
    }
}