using AulaCSharp.Services;
using System;

namespace AulaCSharp
{
    class Program
    {
        // função principal, chamada automaticamente
        public static void Main()
        {
            Console.Write("Digite um cep: ");
            var cep = Console.ReadLine();

            var endereco = CepService.Consultar(cep);

            Console.WriteLine($"Logradouro: {endereco.Logradouro}");
            Console.WriteLine($"Bairro: {endereco.Bairro}");
            Console.WriteLine($"Cidade: {endereco.Cidade}");
            Console.WriteLine($"Uf: {endereco.Uf}");

            Console.ReadKey();
        }
    }
}
