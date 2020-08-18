using AulaCSharp.Context.Models;
using System.Data.Entity.ModelConfiguration;

namespace AulaCSharp.Context.Types
{
    public class AlbumTypeConfiguration : EntityTypeConfiguration<Album>
    {
        public AlbumTypeConfiguration()
        {
            HasKey(q => q.Id);

            Property(q => q.Nome).IsRequired().HasMaxLength(100);

            HasRequired(q => q.Genero).WithMany().HasForeignKey(q => q.IdGenero);

            HasRequired(q => q.Artista).WithMany().HasForeignKey(q => q.IdArtista);
        }
    }
}