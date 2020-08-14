using System;
using AulaCSharp.Models;

namespace AulaCSharp.Exercicios
{
    public static class ExercicioFrotaDeCarrros
    {
        public static void Executar()
        {
            var c1 = new Carro { Placa = "ALA1L34", Fabricante = "Peugeot", Modelo = "206", Cor = "Preto", Valor = 6_000 };
            var c2 = new Carro { Placa = "AYA1L35", Fabricante = "Ford", Modelo = "KA", Cor = "Vemelho", Valor = 16_000 };
            var c3 = new Carro { Placa = "AAA1L36", Fabricante = "Fiat", Modelo = "UNO 147", Cor = "Verde", Valor = 4_000 };
            var c4 = new Carro { Placa = "ADA1L37", Fabricante = "Chev", Modelo = "Celta", Cor = "Azul", Valor = 7_000 };
            var c5 = new Carro { Placa = "AEA1L38", Fabricante = "BMW", Modelo = "X1", Cor = "Prata", Valor = 200_000 };

            Carro.MostraFrota(c1, c2, c3);
            Console.ReadKey();
            Console.Clear();
            Carro.MostraFrota(c1, c2, c3, c4);
            Console.ReadKey();
            Console.Clear();
            Carro.MostraFrota(c1, c2, c3, c4, c5);
            Console.ReadKey();
            Console.Clear();
        }
    }
}