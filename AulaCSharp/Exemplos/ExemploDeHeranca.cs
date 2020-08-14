using System;

namespace AulaCSharp.Exemplos
{
    public abstract class Pessoa
    {
        public string Nome { get; set; }
    }
    public class PessoaFisica : Pessoa
    {
        public string Cpf { get; set; }
    }
    public class PessoaJuridica : Pessoa
    {
        public string Cnpj { get; set; }
    }

    public class Funcionario
    {
        public int Numero { get; set; }
        public string Nome { get; set; }
        public double Salario { get; set; }

        public string Saudacao()
        {
            return $"Oi, sou funcionário #{Numero}";
        }
    }

    public class ComissaoFuncionario : Funcionario
    {
        public double TaxaDeComissao { get; set; }
    }

    public class InstrumentoMusical
    {
        public virtual void Tocar()
        {
            Console.WriteLine("Tocando um instrumento");
        }
    }

    public class Guitarra : InstrumentoMusical
    {
        public override void Tocar()
        {
            Console.WriteLine("Aprendendo o nome das cordas");
        }
    }

    public class Bateria : InstrumentoMusical
    {
        public override void Tocar()
        {
            Console.WriteLine("Aprendendo coordenção motora");
        }
    }

    public abstract class ExportarRelatorioDeAmigos
    {
        protected string NomeDoArquivo { get; private set; }

        protected ExportarRelatorioDeAmigos(string nomeDoArquivo)
        {
            NomeDoArquivo = nomeDoArquivo;
        }

        public abstract void Exportar();
    }

    public class ExportarRelatorioDeAmigosEmPdf : ExportarRelatorioDeAmigos
    {
        public ExportarRelatorioDeAmigosEmPdf(string nomeDoArquivo) : base(nomeDoArquivo)
        {
        }

        public override void Exportar()
        {
            Console.WriteLine("Vou criar um pdf");
        }
    }

    public class ExportarRelatorioDeAmigosEmExcel : ExportarRelatorioDeAmigos
    {
        public ExportarRelatorioDeAmigosEmExcel(string nomeDoArquivo) : base(nomeDoArquivo)
        {
        }

        public override void Exportar()
        {
            Console.WriteLine("Vou criar um excel");
        }
    }
}