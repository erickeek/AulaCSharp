using System;

namespace AulaCSharp.Exemplos
{
    public class ExemploDeEstruturasDeRepeticao
    {
        public static void Executar()
        {
            int i;

            // uso quando sei exatamente a quantidade de vezes que vou repetir
            for (i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine(i);

            i = 0;
            // uso quando não sei exatamente a quantidade de vezes que vou repetir
            while (i < 10)
            {
                Console.WriteLine(i);
                i++;
            }
            Console.WriteLine(i);

            i = 0;
            // uso quando não sei exatamente a quantidade de vezes que vou repetir, porém é executado pelo menos uma vez
            // independente da condição
            do
            {
                Console.WriteLine(i);
                i++;
            } while (i < 10);

            Console.WriteLine(i);

            var nomes = new[] { "Karina", "Lucas", "Rodrigo", "Pellizon" };
            for (i = 0; i < nomes.Length; i++)
            {
                var nome = nomes[i];
                Console.WriteLine(nome);
            }

            Console.WriteLine("".PadRight(50, '-'));

            foreach (var nome in nomes)
            {
                Console.WriteLine(nome);
            }
        }
    }
}