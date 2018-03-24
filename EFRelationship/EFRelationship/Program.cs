using System;
using System.Linq;
using EFRelationship.DataContexts;
using EFRelationship.Model;

namespace EFRelationship
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            #region Objetos
            var informatica = new Categoria { Id = 1, Titulo = "Informatica" };
            var artesMarciais = new Categoria { Id = 2, Titulo = "Artes Marciais" };
            var ciencias = new Categoria { Id = 1, Titulo = "Ciencias" };

            var andre = new Autor { Id = 1, Nome = "André Baltieri" };
            var luiz = new Autor { Id = 1, Nome = "Luiz Nakahara" };
            var pedro = new Autor { Id = 1, Nome = "Pedro Baltieri" };
            var giordana = new Autor { Id = 1, Nome = "Giordana Nakahara" };

            var devApi = new Livro { Id = 1, Titulo = "Desenvolvimento APIs com WebApi", CategoriaId = 1 };
            var ninjitsu = new Livro { Id = 2, Titulo = "Os segredos do Ninjitsu", CategoriaId = 2 };
            var aranhas = new Livro { Id = 3, Titulo = "O segredo das aranhas", CategoriaId = 3 };
            var robotica = new Livro { Id = 4, Titulo = "Robótica avançada", CategoriaId = 3 };
            #endregion

            #region Context
            using (AppDataContext db = new AppDataContext())
            {
                db.Categorias.AddRange(new[] { informatica, artesMarciais, ciencias });

                db.Autores.AddRange(new[] { andre, luiz, pedro, giordana });

                db.Livros.AddRange(new[] { devApi, ninjitsu, aranhas, robotica });

                devApi.Autores.Add(andre);
                devApi.Autores.Add(giordana);
                devApi.Autores.Add(luiz);

                ninjitsu.Autores.Add(luiz);

                devApi.Autores.Add(pedro);

                robotica.Autores.Add(andre);
                robotica.Autores.Add(giordana);

                db.SaveChanges();
            }
            #endregion

            #region CategoriaShow

            using (AppDataContext db = new AppDataContext())
            {
                Console.WriteLine("Categorias");

                foreach (var categoria in db.Categorias)
                {
                    Console.WriteLine("{0} - {1}", categoria.Id, categoria.Titulo);
                }
            }
            #endregion

            #region TodoShow
            using (AppDataContext db = new AppDataContext())
            {
                Console.WriteLine("Tudo");

                foreach (var categoria in db.Categorias.Include("Livros")
                    .Include("Livros.Autores")
                    .ToList())
                {
                    Console.WriteLine("Categoria - {1}", categoria.Titulo);

                    foreach (var livro in categoria.Livros)
                    {
                        Console.WriteLine("\tLivro: {1}", livro.Titulo);
                        foreach (var autor in livro.Autores)
                        {
                            Console.WriteLine("\t\tAutor: {0}", autor.Nome);
                        }
                    }
                }
            }
            #endregion

            Console.ReadKey();
        }
    }
}