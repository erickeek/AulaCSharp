using System;

namespace AulaCSharp.Exercicios
{
    public class ExercicioValidandoOTipoDeExtensao
    {
        public static void Executar()
        {
            // solicitar um nome de arquivo
            Console.Write("Digite um nome de arquivo: ");
            var nomeDoArquivo = Console.ReadLine();

            // validar se tem extensão
            if (!nomeDoArquivo.Contains(".")) // nomeDoArquivo.IndexOf('.') == -1
            {
                Console.WriteLine("Esse não é um arquivo");
                return;
            }

            // caso seja .txt ou .csv apresentar OK
            if (nomeDoArquivo.EndsWith(".txt") || nomeDoArquivo.EndsWith(".csv"))
            {
                Console.WriteLine("OK");
            }
            // caso contrário apresentar Tipo de arquivo inválido
            else
            {
                Console.WriteLine("Tipo de arquivo inválido");
            }
        }
    }
}