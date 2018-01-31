using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace help.api.repositories
{
    public abstract class BaseRepository<T> : IRepository<T> , IDisposable
        where T : class
    {
       private readonly DbContext dbContext;
        protected BaseRepository(DbContext dbContext )
        {
            this.dbContext = dbContext;
        }
        public virtual void Add(T entity)
        {
            dbContext.Set<T>().Add(entity);
            dbContext.SaveChanges();
        }

        public virtual void Delete(T entity)
        {
            dbContext.Set<T>().Remove(entity);
            dbContext.SaveChanges();
        }
               

        public virtual IEnumerable<T> Get()
        {
            return dbContext.Set<T>().ToList();
        }

        public virtual T GetById(int Id)
        {
           return  dbContext.Set<T>().Find(Id);
        }

        public virtual void Update(int Id, T item)
        {
            var entity = dbContext.Set<T>().Find(Id);
            dbContext.Set<T>().Remove(entity);
        }



        #region IDisposible Memeber 

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    dbContext.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        #endregion
    }
}
