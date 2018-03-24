using EFRelationship.Model;
using System.Data.Entity.ModelConfiguration;

namespace EFRelationship.Mapping
{
    public class CategoriaMap : EntityTypeConfiguration<Categoria>
    {
        public CategoriaMap()
        {
            ToTable("Categoria");

            HasKey(c => c.Id);

            Property(c => c.Titulo)
                .HasMaxLength(80)
                .IsRequired();

            HasMany(c => c.Livros);
        }
    }
}