using System.Collections.Generic;

namespace WebApiBookStore.Domain.Contracts
{
    public interface IBookRepository : IRepository<Book>
    {
        IList<Book> GetWithAuthors(int skip = 0, int take = 25);

        Book GetWithAutors(int id);
    }
}