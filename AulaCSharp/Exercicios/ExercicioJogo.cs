using System;

namespace AulaCSharp.Exercicios
{
    public class ExercicioJogo
    {
        public static void Executar()
        {
            var bancoImobiliario = new Jogo
            {
                Nome = "Banco imobiliário",
                NumeroMaximoDeJogadores = 4
            };

            var hockey = new JogoComTempoLimite
            {
                Nome = "Hockey",
                NumeroMaximoDeJogadores = 12,
                LimiteEmMinutos = 60
            };

            Console.WriteLine("----");
            Console.WriteLine(bancoImobiliario);

            Console.WriteLine("----");
            Console.WriteLine(hockey);
        }
    }

    public class Jogo
    {
        public string Nome { get; set; }
        public int NumeroMaximoDeJogadores { get; set; }

        public override string ToString()
        {
            return $"O nome da classe: {GetType().Name}\nO nome do jogo: {Nome}\nNúmero máximo de jogadores: {NumeroMaximoDeJogadores}";
        }
    }

    public class JogoComTempoLimite : Jogo
    {
        public int LimiteEmMinutos { get; set; }

        public override string ToString()
        {
            return $"{base.ToString()}\nLimite em minutos: {LimiteEmMinutos}";
        }
    }
}