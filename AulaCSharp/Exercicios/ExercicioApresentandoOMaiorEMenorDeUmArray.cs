using System;
using System.Linq;

namespace AulaCSharp.Exercicios
{
    public class ExercicioApresentandoOMaiorEMenorDeUmArray
    {
        public static void Executar()
        {
            var numeros = new[] { 6, 12, 7, 5, 1 };
            var maiorNumero = int.MinValue;
            var menorNumero = int.MaxValue;
            var quantidadeDeNumerosPares = 0;
            var quantidadeDeNumerosImpares = 0;

            /*foreach (var numero in numeros)
            {
                if (numero > maiorNumero)
                    maiorNumero = numero;

                if (numero < menorNumero)
                    menorNumero = numero;

                if (numero % 2 == 0)
                    quantidadeDeNumerosPares++;
                else
                    quantidadeDeNumerosImpares++;
            }*/

            maiorNumero = numeros.Max();
            menorNumero = numeros.Min();
            quantidadeDeNumerosPares = numeros.Count(q => q % 2 == 0);
            quantidadeDeNumerosImpares = numeros.Count(q => q % 2 != 0);

            Console.WriteLine($"O maior: {maiorNumero}");
            Console.WriteLine($"O menor: {menorNumero}");
            Console.WriteLine($"Pares: {quantidadeDeNumerosPares}");
            Console.WriteLine($"Impares: {quantidadeDeNumerosImpares}");
        }
    }
}