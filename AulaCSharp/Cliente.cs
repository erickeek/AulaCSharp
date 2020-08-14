using System;

namespace AulaCSharp
{
    public class Pessoa
    {
        public int id;
        public string nome;

        protected void ApresentarNome()
        {
            Console.WriteLine(nome);
        }
    }

    public class Cliente : Pessoa
    {
        public string documento;

        internal void Nomes()
        {
            ApresentarNome();
        }
    }
}
