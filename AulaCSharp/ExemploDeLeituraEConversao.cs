using System;

namespace AulaCSharp
{
    class ExemploDeLeituraEConversao
    {
        static void Main2()
        {
            const double taxaDeImposto = 0.06;
            string precoDoItemString;
            double precoDoItem;
            double total;

            Console.Write("Digite o preço do item: ");
            precoDoItemString = Console.ReadLine();
            precoDoItem = Convert.ToDouble(precoDoItemString);
            total = precoDoItem * taxaDeImposto + precoDoItem;

            Console.WriteLine($"Com uma taxa de {taxaDeImposto}, o item {precoDoItem:C} custa {total:C}");

            Console.WriteLine("Com uma taxa de {0}, o item {1:C} custa {2:C}", taxaDeImposto, precoDoItem, total);

            Console.ReadKey();
        }
    }
}
