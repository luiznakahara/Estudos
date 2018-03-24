using EFRelationship.Model;
using System.Data.Entity;
using EFRelationship.Mapping;

namespace EFRelationship.DataContexts
{
    public class AppDataContext : DbContext
    {
        public DbSet<Autor> Autores { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Livro> Livros { get; set; }

        public AppDataContext()
            : base("MinhaConnectionString")
        {
            Database.SetInitializer<AppDataContext>(new AppDataContextInitializer());
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new AutorMap());
            modelBuilder.Configurations.Add(new LivroMap());
            modelBuilder.Configurations.Add(new CategoriaMap());

            base.OnModelCreating(modelBuilder);
        }
    }

    public class AppDataContextInitializer : DropCreateDatabaseAlways<AppDataContext> { }
}