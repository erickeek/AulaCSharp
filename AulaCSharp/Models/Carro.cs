using System;
using System.Linq;

namespace AulaCSharp.Models
{
    public class Carro
    {
        public string Placa { get; set; } // ALA1L34
        public string Fabricante { get; set; }
        public string Modelo { get; set; }
        public string Cor { get; set; }
        public decimal Valor { get; set; }

        public static void MostraFrota(params Carro[] carros)
        {
            /*var soma = 0m;
            for (int i = 0; i < carros.Length; i++)
            {
                var carro = carros[i];

                Console.WriteLine(carros[i].Placa);
                Console.WriteLine(carros[i].Fabricante);
                Console.WriteLine(carros[i].Modelo);
                Console.WriteLine(carros[i].Cor);
                Console.WriteLine($"{carros[i].Valor:c}");
                Console.WriteLine("---");

                soma += carros[i].Valor;
            }

            Console.WriteLine($"Total em estoque: {soma:c}");*/

            foreach (var carro in carros.OrderBy(q => q.Valor))
            {
                Console.WriteLine($"{carro.Placa}\t{carro.Fabricante}\t{carro.Modelo}\t{carro.Cor}\t{carro.Valor:c}");
            }

            //var soma = 0m;
            //foreach (var carro in carros)
            //{
            //    soma += carro.Valor;
            //}

            var soma = carros.Sum(carro => carro.Valor);
            Console.WriteLine($"Total em estoque: {soma:c}");
        }
    }
}
