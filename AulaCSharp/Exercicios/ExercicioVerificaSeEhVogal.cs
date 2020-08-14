using System;

namespace AulaCSharp.Exercicios
{
    public class ExercicioVerificaSeEhVogal
    {
        public static void Executar()
        {
            // CTRL + K, CTRL + C
            /* CTRL + SHIFT + Q */
            // Para passar para MAISCULO Ctrl+Shift+U
            // Alt + Shift + ↑ ou ↓

            const string vogais = "aeiou";
            do
            {
                var vogal = Console.ReadLine();

                if (vogal == "!")
                    break;

                if (!string.IsNullOrWhiteSpace(vogal))
                    continue;

                if (vogais.Contains(vogal.ToLower()))
                {
                    Console.WriteLine("OK");
                }
                else
                {
                    Console.WriteLine("Não é uma vogal");
                }
            } while (true);
        }
    }
}