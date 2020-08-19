using AulaCSharp.Context.Models;
using System.Data.Entity.ModelConfiguration;

namespace AulaCSharp.Context.Types
{
    public class MusicaTypeConfiguration : EntityTypeConfiguration<Musica>
    {
        public MusicaTypeConfiguration()
        {
            //marcar no EF que essa propriedade é uma chave primaria
            HasKey(q => q.Id);

            // property me da acesso a alguns metodos para modificar a propriedade
            // por exemplo: IsRequired => vai deixar o campo NOT NULL no banco e
            // HasMaxLength => vai colocar um VARCHAR(100)
            Property(q => q.Nome).IsRequired().HasMaxLength(100);
            Property(q => q.Cantor).IsRequired().HasMaxLength(100);

            HasMany(q => q.Albuns)
                .WithMany(q => q.Musicas)
                .Map(c =>
                {
                    c.MapLeftKey("IdMusica");
                    c.MapRightKey("IdAlbum");
                    c.ToTable("AlbumMusica");
                });

            // AlbumMusica
            // IdMusica -> Musica(Id)
            // IdAlbum -> Album(Id)
        }
    }
}