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
            Console.WriteLine("Batendo nas cordas");
        }
    }

    public class Bateria : InstrumentoMusical
    {
        public override void Tocar()
        {
            Console.WriteLine("Batentendo nas peças");
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

        public virtual string CaminhoDoArquivo()
        {
            return "c:/";
        }
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

        public override string CaminhoDoArquivo()
        {
            var caminhoDoArquivo = base.CaminhoDoArquivo();
            return $"{caminhoDoArquivo}pdf/"; // c:/pdf/
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