using System;

namespace AulaCSharp.Projeto.Helpers
{
    public static class ConsoleHelper
    {
        public static string SolicitarTexto(string enunciado = "")
        {
            Console.Write(enunciado);
            return Console.ReadLine();
        }

        public static int SolicitarNumero(string enunciado = "")
        {
            int numero;

            do
            {
                Console.Write(enunciado);
            } while (!int.TryParse(Console.ReadLine(), out numero));

            return numero;
        }

        public static decimal SolicitarDecimal(string enunciado = "")
        {
            decimal numero;

            do
            {
                Console.Write(enunciado);
            } while (!decimal.TryParse(Console.ReadLine(), out numero));

            return numero;
        }

        public static void DigiteQualquerTeclaParaContinuar()
        {
            Console.WriteLine("Digite qualquer tecla para continuar...");
            Console.ReadKey();
        }
    }
}