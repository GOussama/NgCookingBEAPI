using Microsoft.Data.Entity;
using NgcookingBackend.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Linq.Expressions;

namespace NgcookingBackend.Models
{
    public class GenericRepository<C, T> : IGenericRepository<T>, IDisposable
        where T : class
        where C : DbContext, new()

    {

        private C _entities = new C();

        public C Context
        {
            get { return _entities; }
            set { _entities = value; }
        }
        public void Add(T entity)
        {
            _entities.Set<T>().Add(entity);
        }

        public void Delete(T entity)
        {
            _entities.Set<T>().Remove(entity);
        }

        public void Dispose()
        {
            Context.Dispose();
        }

        public void Edit(T entity)
        {
           // _entities.Entry(entity).State = System.Data.
        }

        public IQueryable<T> FindBy(Expression<Func<T, bool>> predicate)
        {
            IQueryable<T> query = _entities.Set<T>().Where(predicate);
            return query;
        }

        public IQueryable<T> GetAll()
        {
            IQueryable<T> query = _entities.Set<T>();
            return query;
        }

        public void Save()
        {
            throw new NotImplementedException();
        }
    }

   
}
