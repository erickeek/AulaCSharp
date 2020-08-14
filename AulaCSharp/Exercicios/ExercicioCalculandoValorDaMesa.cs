using System;

namespace AulaCSharp.Exercicios
{
    public class ExercicioCalculandoValorDaMesa
    {
        public static void Executar()
        {
            var quantidadeDeGavetas = ReceberQuantidadeDeGavetas();
            var tipoDeMadeira = ReceberTipoDeMadeira();

            Detalhes(quantidadeDeGavetas, tipoDeMadeira);
        }

        private static int ReceberQuantidadeDeGavetas()
        {
            Console.Write("Digite o número de gavetas: ");
            return Convert.ToInt32(Console.ReadLine());
        }

        private static char ReceberTipoDeMadeira()
        {
            Console.WriteLine("Digite o tipo de madeira");
            Console.WriteLine("[ m ] - Mogno");
            Console.WriteLine("[ c ] - Carvalho");
            Console.WriteLine("[ p ] - Pinheiro");

            return Convert.ToChar(Console.ReadLine().ToLower());
        }

        private static decimal CalcularCusto(int quantidadeDeGavetas, char tipoDeMadeira)
        {
            var valorDaMadeira = CalcularCustoDaMadeira(tipoDeMadeira);
            var valorDasGavetas = CalcularCustoDasGavetas(quantidadeDeGavetas);
            return valorDasGavetas + valorDaMadeira;
        }

        private static int CalcularCustoDasGavetas(int quantidadeDeGavetas) => quantidadeDeGavetas * 30;

        private static int CalcularCustoDaMadeira(char tipoDeMadeira)
        {
            var valorDaMadeira = 0;
            switch (tipoDeMadeira)
            {
                case 'm':
                    valorDaMadeira = 180;
                    break;
                case 'c':
                    valorDaMadeira = 140;
                    break;
                case 'p':
                    valorDaMadeira = 100;
                    break;
            }

            return valorDaMadeira;
        }

        private static void Detalhes(int quantidadeDeGavetas, char tipoDeMadeira)
        {
            Console.WriteLine($"Mesa de {TipoDaMadeira(tipoDeMadeira)} = {CalcularCustoDaMadeira(tipoDeMadeira):C}");

            if (quantidadeDeGavetas > 0)
                Console.WriteLine($"{quantidadeDeGavetas} {(quantidadeDeGavetas == 1 ? "gaveta" : "gavetas")} = {CalcularCustoDasGavetas(quantidadeDeGavetas):C}");

            Console.WriteLine($"Custo total = {CalcularCusto(quantidadeDeGavetas, tipoDeMadeira):C}");
        }

        private static string TipoDaMadeira(char tipoDeMadeira)
        {
            switch (tipoDeMadeira)
            {
                case 'm': return "Mogno";
                case 'c': return "Carvalho";
                case 'p': return "Pinheiro";
            }

            return "Outras madeiras";
        }
    }
}