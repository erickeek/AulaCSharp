namespace AulaCSharp.Exemplos
{
    public interface IExcluivel
    {
        int Id { get; set; }
        bool Excluido { get; set; }
    }

    public class Cliente : IExcluivel
    {
        public int Id { get; set; }
        public bool Excluido { get; set; }
    }

    public interface ITrabalhavel
    {
        string Trabalhar();
    }

    public abstract class Animal : ITrabalhavel
    {
        public string Nome { get; private set; }

        public Animal(string nome)
        {
            Nome = nome;
        }

        public abstract string Falar();
        public abstract string Trabalhar();

        public override string ToString()
        {
            return Nome;
        }
    }

    public class Cachorro : Animal
    {
        public Cachorro(string nome) : base(nome)
        {
        }

        public override string Falar()
        {
            return "Au";
        }

        public override string Trabalhar()
        {
            return "Eu vigio a casa";
        }
    }

    public class Gato : Animal
    {
        public Gato(string nome) : base(nome)
        {
        }

        public override string Falar()
        {
            return "Miau";
        }

        public override string Trabalhar()
        {
            return "Eu caço ratos";
        }
    }
}