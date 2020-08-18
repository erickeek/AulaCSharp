using AulaCSharp.Context.Models;
using System.Data.Entity.ModelConfiguration;

namespace AulaCSharp.Context.Types
{
    public class GeneroTypeConfiguration : EntityTypeConfiguration<Genero>
    {
        public GeneroTypeConfiguration()
        {
            HasKey(q => q.Id);

            Property(q => q.Nome).IsRequired().HasMaxLength(100);

            HasMany(q => q.Albuns).WithRequired().HasForeignKey(q => q.IdGenero);
        }
    }
}