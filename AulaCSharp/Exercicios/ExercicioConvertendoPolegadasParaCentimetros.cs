using System;
using System.Globalization;

namespace AulaCSharp.Exercicios
{
    public class ExercicioConvertendoPolegadasParaCentimetros
    {
        private static readonly CultureInfo CulturaPadrao = new CultureInfo("pt-BR");

        public static void Executar()
        {
            Console.Write("Digite um valor em polegadas: ");
            var polegadas = Convert.ToDecimal(Console.ReadLine(), CulturaPadrao);

            var centimetros = ConverterPolegadasEmCentimetros(polegadas);
            Console.WriteLine($"O seu valor em centimetros é: {centimetros}");
        }

        public static decimal ConverterPolegadasEmCentimetros(decimal valor)
        {
            return valor * 2.54m;
        }
    }
}