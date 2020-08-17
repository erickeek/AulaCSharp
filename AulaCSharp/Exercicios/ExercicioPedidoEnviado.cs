using AulaCSharp.Models;
using System;
using System.Linq;

namespace AulaCSharp.Exercicios
{
    public class ExercicioPedidoEnviado
    {
        public static void Executar()
        {
            var pedidos = new PedidoEnviado[5];

            for (var i = 0; i < pedidos.Length; i++)
            {
                Console.Clear();
                var numeroDoPedido = RecuperarNumeroDoPedido(pedidos);

                Console.Write("Digite o nome do cliente: ");
                string nomeDoCliente = Console.ReadLine();

                Console.Write("Digite a quantidade: ");
                int quantidadeSolicitada = Convert.ToInt32(Console.ReadLine());

                pedidos[i] = new PedidoEnviado(numeroDoPedido, nomeDoCliente, quantidadeSolicitada);
            }

            foreach (var pedido in pedidos.OrderBy(q => q.NumeroDoPedido))
            {
                Console.WriteLine(pedido);
            }

            Console.WriteLine($"Total: {pedidos.Sum(q => q.ValorTotal):c2}");

            Console.ReadKey();
        }

        private static int RecuperarNumeroDoPedido(PedidoEnviado[] pedidos)
        {
            int numeroDoPedido = 0;
            bool indisponivel = true;
            do
            {
                try
                {
                    Console.Write("Digite o número do pedido: ");
                    numeroDoPedido = Convert.ToInt32(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Tente novamente esse não é um número válido!");
                    continue;
                }

                indisponivel = pedidos.Any(q => q?.NumeroDoPedido == numeroDoPedido);

                if (indisponivel)
                {
                    Console.WriteLine($"O número {numeroDoPedido} já existe no sistema!!");
                }

            } while (indisponivel);

            return numeroDoPedido;
        }

        private static int RecuperarNumeroDoPedido2(PedidoEnviado[] pedidos)
        {
            var disponivel = false;
            int numeroDoPedido;
            do
            {
                Console.Write("Digite o número do pedido: ");
                numeroDoPedido = Convert.ToInt32(Console.ReadLine());

                var all = true;
                foreach (var pedido in pedidos)
                {
                    if (pedido?.NumeroDoPedido == numeroDoPedido)
                    {
                        all = false;
                        break;
                    }
                }

                if (all) disponivel = true;

            } while (!disponivel);

            return numeroDoPedido;
        }
    }
}