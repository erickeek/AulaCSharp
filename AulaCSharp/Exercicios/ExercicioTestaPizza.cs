using System;
using AulaCSharp.Models;

namespace AulaCSharp.Exercicios
{
    public class ExercicioTestaPizza
    {
        public static void Executar()
        {
            var p1 = new Pizza();
            p1.Nome = "Peperoni";
            p1.Diametro = 6;
            p1.Preco = 25;

            Console.WriteLine(p1.ValorTotal());

            Pizza.TaxaDeEntrega = 10;

            var p2 = new Pizza
            {
                Nome = "4 queijos",
                Diametro = 7,
                Preco = 50
            };

            Console.WriteLine(p1.ValorTotal());
            Console.WriteLine(p2.ValorTotal());

            ApresentarPizza(p1);
            ApresentarPizza(p2);
        }

        private static void ApresentarPizza(Pizza pizza)
        {
            Console.WriteLine($"Nome: {pizza.Nome}");
            Console.WriteLine($"Diametro: {pizza.Diametro}");
            Console.WriteLine($"Preco: {pizza.Preco:c}");
            Console.WriteLine("--------");
        }
    }
}