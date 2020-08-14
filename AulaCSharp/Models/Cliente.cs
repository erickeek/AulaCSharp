using System;

namespace AulaCSharp.Models
{
    public class Cliente
    {
        public static double taxaDeSaque = 2;

        public int Codigo { get; set; }
        public string Nome { get; set; }
        public double Saldo { get; private set; }

        public void Depositar(double valor)
        {
            Saldo += valor;
        }

        public bool Sacar(double valor)
        {
            if ((Saldo + taxaDeSaque) >= valor)
            {
                Saldo -= (valor + taxaDeSaque);
                return true;
            }

            return false;
        }

        public void PreencherDadosDoCliente(int codigo, string nome, double saldo)
        {
            Codigo = codigo;
            Nome = nome;
            Saldo = saldo;
        }

        public void Apresentar()
        {
            Console.WriteLine("{0} {1} {2}", Codigo, Nome, Saldo);
        }

        public static void ApresentarSaldo(Cliente cliente)
        {
            Console.WriteLine("{0} {1}", cliente.Nome, cliente.Saldo);
        }
    }
}