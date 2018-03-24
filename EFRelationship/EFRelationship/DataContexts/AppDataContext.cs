using EFRelationship.Model;
using System.Data.Entity;

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
    }

    public class AppDataContextInitializer : DropCreateDatabaseAlways<AppDataContext> { }
}