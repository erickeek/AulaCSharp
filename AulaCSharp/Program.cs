using AulaCSharp.Exemplos;
using System;

namespace AulaCSharp
{
    class Program
    {
        // função principal, chamada automaticamente
        public static void Main()
        {
            InstrumentoMusical instrumentoMusical = new InstrumentoMusical();
            InstrumentoMusical guitarra = new Guitarra();
            InstrumentoMusical bateria = new Bateria();

            var instrumentos = new[] { instrumentoMusical, guitarra, bateria };
            foreach (var instrumento in instrumentos)
            {
                instrumento.Tocar();
            }

            bool exportarEmPdf = false;
            string nomeDoArquivo;
            ExportarRelatorioDeAmigos exportador;
            if (exportarEmPdf)
            {
                nomeDoArquivo = "arquivo.pdf";
                exportador = new ExportarRelatorioDeAmigosEmPdf(nomeDoArquivo);
            }
            else
            {
                nomeDoArquivo = "arquivo.xls";
                exportador = new ExportarRelatorioDeAmigosEmExcel(nomeDoArquivo);
            }

            exportador.Exportar();

            Console.ReadKey();
        }
    }
}
