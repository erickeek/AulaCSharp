using System;

namespace AulaCSharp.Exercicios
{
    public class ExercicioDePedraPapelTesoura
    {
        public enum Jokenpo
        {
            Pedra = 1,
            Papel = 2,
            Tesoura = 3
        }

        public static void Executar()
        {
            Random random = new Random();

            Console.WriteLine("Digite uma opção");
            Console.WriteLine("1 - Pedra\n2 - Papel\n3 - Tesoura");
            var opcaoDoJogador = (Jokenpo)Convert.ToInt32(Console.ReadLine());
            var opcaoDaMaquina = (Jokenpo)random.Next(1, 4);

            Console.WriteLine($"Jogador: {opcaoDoJogador} VS Máquina: {opcaoDaMaquina}");

            if (opcaoDoJogador == opcaoDaMaquina)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Deu empate!");
            }
            else if (JogadorGanhou(opcaoDoJogador, opcaoDaMaquina))
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Você ganhou, parabéns!");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("A casa sempre ganha!!!");
            }

            Console.ReadKey();
        }

        public static bool JogadorGanhou(Jokenpo jogador, Jokenpo maquina)
        {
            return (jogador == Jokenpo.Papel && maquina == Jokenpo.Pedra)
                   || (jogador == Jokenpo.Pedra && maquina == Jokenpo.Tesoura)
                   || (jogador == Jokenpo.Tesoura && maquina == Jokenpo.Papel);
        }
    }
}