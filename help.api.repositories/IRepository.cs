
using System.Collections.Generic;

namespace help.api.repositories
{
    public interface IRepository<T> where T : class
    {
        void Add(T item);

        void Delete(T entity);

        T GetById(int Id);

        IEnumerable<T> Get();

        void Update(int Id, T item);
    }
}
