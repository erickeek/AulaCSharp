using System;

namespace AulaCSharp.Models
{
    public class Pizza
    {
        public static double TaxaDeEntrega = 5;

        private string _nome;
        private int _diametro;
        private double _preco;

        public string Nome
        {
            get => _nome;
            set => _nome = value.Trim();
        }

        public int Diametro
        {
            get => _diametro;
            set => _diametro = value;
        }

        public double Preco
        {
            get => _preco;
            set => _preco = Math.Abs(value);
        }

        //public string Nome { get; set; }
        //public int Diametro { get; set; }
        //public double Preco { get; set; }

        public double ValorTotal()
        {
            return Preco + TaxaDeEntrega;
        }
    }
}
