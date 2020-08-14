using System;

namespace AulaCSharp.Exercicios
{
    public class ExercicioFuncionamentoDoParamsERef
    {
        public static void Executar()
        {
            int a = 1;
            int b = 2;
            int c = 3;

            ApresentarVariaveis(a, b, c);
            TrocarValores(ref a, ref b, ref c);
            ApresentarVariaveis(a, b, c);
        }

        private static void ApresentarVariaveis(params int[] conjunto)
        {
            foreach (var n in conjunto)
            {
                Console.WriteLine(n);
            }
        }

        private static void TrocarValores(ref int a, ref int b, ref int c)
        {
            int aux = a;
            a = b;
            b = c;
            c = aux;
        }
    }
}