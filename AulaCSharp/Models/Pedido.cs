namespace AulaCSharp.Models
{
    public class Pedido
    {
        private const decimal ValorDoItem = 19.50m;

        private int _numeroDoPedido;
        private string _nomeDoCliente;
        private int _quantidadeSolicitada;
        private decimal _valorTotal;

        public Pedido(int numeroDoPedido, string nomeDoCliente, int quantidadeSolicitada)
        {
            NumeroDoPedido = numeroDoPedido;
            NomeDoCliente = nomeDoCliente;
            QuantidadeSolicitada = quantidadeSolicitada;
        }

        public int NumeroDoPedido
        {
            get => _numeroDoPedido;
            set => _numeroDoPedido = value;
        }

        public string NomeDoCliente
        {
            get => _nomeDoCliente;
            set => _nomeDoCliente = value;
        }

        public virtual int QuantidadeSolicitada
        {
            get => _quantidadeSolicitada;
            set
            {
                _quantidadeSolicitada = value;
                _valorTotal = value * ValorDoItem;
            }
        }

        public decimal ValorTotal
        {
            get => _valorTotal;
            protected set => _valorTotal = value;
        }

        public override bool Equals(object obj)
        {
            return NumeroDoPedido == ((Pedido)obj).NumeroDoPedido;
        }

        public override int GetHashCode() => NumeroDoPedido;

        public override string ToString()
        {
            return $"{NumeroDoPedido,-5}{NomeDoCliente,-20}{QuantidadeSolicitada,-5}{ValorTotal:c2}";
        }
    }
}