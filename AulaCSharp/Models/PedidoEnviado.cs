namespace AulaCSharp.Models
{
    public class PedidoEnviado : Pedido
    {
        private const decimal TaxaDeEntrega = 4;

        public PedidoEnviado(int numeroDoPedido, string nomeDoCliente, int quantidadeSolicitada)
            : base(numeroDoPedido, nomeDoCliente, quantidadeSolicitada)
        {
        }

        public override int QuantidadeSolicitada
        {
            get => base.QuantidadeSolicitada;
            set
            {
                base.QuantidadeSolicitada = value;
                ValorTotal += TaxaDeEntrega;
            }
        }
    }
}