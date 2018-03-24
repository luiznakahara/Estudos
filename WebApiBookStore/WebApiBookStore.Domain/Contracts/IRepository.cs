using System;
using System.Collections.Generic;

namespace WebApiBookStore.Domain.Contracts
{
    public interface IRepository<T> : IDisposable
    {
        IList<T> Get(int skip = 0, int take = 50);
        T Get(Guid id);
        void Create(T entity);
        void Update();
        void Delete(Guid id);
    }
}