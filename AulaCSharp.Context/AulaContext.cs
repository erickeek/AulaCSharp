using AulaCSharp.Context.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Reflection;

namespace AulaCSharp.Context
{
    public class AulaContext : DbContext
    {
        public AulaContext() : base("DefaultConnection")
        {
        }

        public DbSet<Album> Albuns { get; set; }
        public DbSet<Artista> Artistas { get; set; }
        public DbSet<Genero> Generos { get; set; }
        public DbSet<Musica> Musicas { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();

            modelBuilder.Configurations.AddFromAssembly(Assembly.GetExecutingAssembly());

            base.OnModelCreating(modelBuilder);
        }
    }
}
