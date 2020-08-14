using System;

namespace AulaCSharp
{
    public class ExemploCalculoDeDependentes
    {
        public void Calcular()
        {
            Console.WriteLine("Digite a quantidade de dependentes: ");
            var quantidade = Convert.ToInt32(Console.ReadLine());

            var valorDoPlano = 0m;

            if (quantidade == 1)
            {
                valorDoPlano = 50;
            }
            else if (quantidade >= 2 && quantidade <= 4)
            {
                valorDoPlano = 100;
            }
            else
            {
                valorDoPlano = 200;
            }

            Console.Write($"Valor do plano: {valorDoPlano}");
        }
    }
}