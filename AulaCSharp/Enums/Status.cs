namespace AulaCSharp.Enums
{
    public enum Status
    {
        Aprovado = 1,
        Reprovado = 2,
        EmAnalise = 3
    }

    public class Proposta
    {
        public int Id { get; set; }
        public decimal Valor { get; set; }
        public Status Status { get; set; }

        public bool EstaEmAnalise()
        {
            return Status == Status.EmAnalise;
        }
    }

    public class TestaProposta
    {
        public static void Executar()
        {
            var proposta = new Proposta();
            if (proposta.EstaEmAnalise())
            {

            }

            if (proposta.Status == Status.EmAnalise)
            {

            }
        }
    }
}