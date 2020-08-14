using System;

namespace AulaCSharp.Exercicios
{
    public class ExercicioSomandoNumerosDe1A50
    {
        public static void Executar()
        {
            var soma = 0;
            for (var i = 1; i <= 50; i++)
            {
                soma += i;
            }

            Console.WriteLine(soma);
        }
    }
}