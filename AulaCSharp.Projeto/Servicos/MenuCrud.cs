using AulaCSharp.Context;

namespace AulaCSharp.Projeto.Servicos
{
    public abstract class MenuCrud : Menu
    {
        protected readonly AulaContext Context = new AulaContext();

        protected MenuCrud() : base("Digite uma opção")
        {
            Adicionar("Adicionar", Adicionar);
            Adicionar("Listar", Listar);
            Adicionar("Excluir", Excluir);
            Adicionar("Atualizar", Atualizar);
        }

        protected abstract void Adicionar();
        protected abstract void Listar();
        protected abstract void Excluir();
        protected abstract void Atualizar();
    }
}