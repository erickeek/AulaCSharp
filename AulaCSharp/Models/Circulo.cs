using System;

namespace AulaCSharp.Models
{
    public class Circulo
    {
        private decimal _raio;

        public Circulo(int raio = 1)
        {
            Raio = raio;
        }

        public decimal Raio
        {
            get => _raio;
            set
            {
                _raio = value;
                Diametro = 2 * _raio;
                Area = (decimal)(Math.PI * Math.Pow((double)_raio, 2));
                Perimetro = (decimal)(2 * Math.PI * (double)_raio);
            }
        }

        public decimal Area { get; private set; }
        public decimal Diametro { get; private set; }
        public decimal Perimetro { get; private set; }
    }
}