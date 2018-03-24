using EFRelationship.Model;
using System.Data.Entity.ModelConfiguration;

namespace EFRelationship.Mapping
{
    public class AutorMap : EntityTypeConfiguration<Autor>
    {
        public AutorMap()
        {
            ToTable("Autor");

            HasKey(a => a.Id);

            Property(a => a.Nome).HasMaxLength(80).IsRequired();

            HasMany(a => a.Livros)
                .WithMany(a => a.Autores)
                .Map(a => a.ToTable("LivroAutor"));
        }
    }
}