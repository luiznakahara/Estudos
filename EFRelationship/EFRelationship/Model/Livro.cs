using System.Collections.Generic;

namespace EFRelationship.Model
{
    public class Livro
    {
        public int Id;
        public string Titulo { get; set; }
        public int CategoriaId { get; set; }
        public virtual Categoria Categoria { get; set; }
        public virtual ICollection<Autor> Autores { get; set; }

        public Livro()
        {
            Autores = new List<Autor>();
        }
    }
}