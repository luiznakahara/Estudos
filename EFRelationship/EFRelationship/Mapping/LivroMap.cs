using EFRelationship.Model;
using System.Data.Entity.ModelConfiguration;

namespace EFRelationship.Mapping
{
    public class LivroMap : EntityTypeConfiguration<Livro>
    {
        public LivroMap()
        {
            ToTable("Livro");

            HasKey(l => l.Id);

            Property(l => l.Titulo)
                .HasMaxLength(80)
                .IsRequired();

            HasMany(l => l.Autores);

            HasRequired(l => l.Categoria)
                .WithMany(c => c.Livros)
                .Map(x => x.ToTable("LivroCategoria"));
        }
    }
}