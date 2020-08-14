using System;

namespace AulaCSharp.Exercicios
{
    class ExercicioApresentandoNumerosParesDe2A100
    {
        // formata o codigo => CTRL + K, CTRL + D 
        // para duplicar uma linha CTRL + D 

        public static void Executar()
        {
            int i;

            for (i = 2; i <= 100; i++)
            {
                if (i % 2 == 0)
                    Console.WriteLine(i);
            }

            for (i = 2; i <= 100; i += 2)
            {
                Console.WriteLine(i);
            }
        }
    }
}
