using System;

namespace AulaCSharp.Exercicios
{
    public class ExercicioCalculandoComissao
    {
        public static void Executar()
        {
            var valorDasVendas = RecuperarDadosDaVenda();
            Console.WriteLine($"A comissão do vendedor é de: {CalularComissao(valorDasVendas)}");
        }

        public static decimal RecuperarDadosDaVenda()
        {
            Console.Write("Digite o valor das vendas: ");
            return Convert.ToDecimal(Console.ReadLine());
        }

        public static decimal CalularComissao(decimal valorDasVendas)
        {
            decimal comissao;

            if (valorDasVendas <= 999)
                comissao = 0.03m;
            else if (valorDasVendas >= 1000 && valorDasVendas <= 2999)
                comissao = 0.04m;
            else
                comissao = 0.05m;

            return valorDasVendas * comissao;
        }
    }
}