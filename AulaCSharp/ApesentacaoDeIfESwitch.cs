using System;

namespace AulaCSharp
{
    public class ApesentacaoDeIfESwitch
    {
        public void Menu()
        {
            var opcao = Console.ReadLine();

            if (opcao == "1")
            {
                Console.WriteLine("Cadastrar algo");
            }
            else if (opcao == "2")
            {
                Console.WriteLine("Listar algo");
            }
            else
            {
                Console.WriteLine("Não entendi sua opção");
            }

            switch (opcao)
            {
                case "1":
                    Console.WriteLine("Cadastrar algo");
                    break;
                case "2":
                    Console.WriteLine("Listar algo");
                    break;

                default:
                    Console.WriteLine("Não entendi sua opção");
                    break;
            }

            Console.ReadKey();
        }
    }
}