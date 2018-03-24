using System.Collections.Generic;

namespace EFRelationship.Model
{
    public class Autor
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public virtual ICollection<Livro> Livros { get; set; }

        public Autor()
        {
            Livros = new List<Livro>();
        }
    }
}