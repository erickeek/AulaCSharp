using System;

namespace AulaCSharp.Exercicios
{
    class ExercicioFormatandoDocumentos
    {
        public static void Executar()
        {
            // solicitar um documento
            Console.Write("Digite um documento: ");
            var documento = Console.ReadLine();
            var quantidadeDeCaracteres = documento.Length;

            // se tiver 11 caracteres é cpf
            if (quantidadeDeCaracteres == 11)
            {
                documento = documento.Insert(9, "-").Insert(6, ".").Insert(3, ".");

                Console.WriteLine($"Seu documento formatado é: {documento}");
            }
            // se tiver 14 caracteres é cnpj
            else if (quantidadeDeCaracteres == 14)
            {
                documento = documento.Insert(12, "-")
                    .Insert(8, "/")
                    .Insert(5, ".")
                    .Insert(2, ".");

                Console.WriteLine($"Seu documento formatado é: {documento}");
            }
            // caso contrário apresento um erro
            else
            {
                Console.WriteLine("Esse não é um documento válido!");
            }
        }
    }
}
