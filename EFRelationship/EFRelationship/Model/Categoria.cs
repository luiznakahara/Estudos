using System.Collections.Generic;

namespace EFRelationship.Model
{
    public class Categoria
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public virtual ICollection<Livro> Livros { get; set; }

        public Categoria()
        {
            Livros = new List<Livro>();
        }

    }
}