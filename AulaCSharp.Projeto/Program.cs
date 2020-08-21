using AulaCSharp.Projeto.Servicos;

namespace AulaCSharp.Projeto
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var menu = new Menu("Escolha uma entidade para manipular");

            menu.Adicionar("Genero", () => new MenuGeneroCrud().Executar());
            menu.Adicionar("Artista", () => new MenuArtistaCrud().Executar());
            menu.Adicionar("Album", () => new MenuAlbumCrud().Executar());

            menu.Executar();
        }
    }
}
