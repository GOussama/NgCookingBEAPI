using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Microsoft.Data.Entity;


namespace NgcookingBackend.Modelss 
{
    public class GenericRepository<T> : IGenericRepository<T>
        where T : BaseEntity
    {
        protected DbContext _entities;
        protected readonly DbSet<T> _dbset;

        public GenericRepository(DbContext context)
        {
            _entities = context;
            _dbset = context.Set<T>();

        }
        public virtual T Add(T entity)
        {
            this._entities.Add(entity);
            this._entities.SaveChanges();
            return entity;
        }

        public virtual T Delete(T entity)
        {
            this._entities.Remove(entity);
            this._entities.SaveChanges();
            return entity;
        }

        public virtual void Edit(T entity)
        {
            this._entities.Update(entity);
            this._entities.SaveChanges();
        }

        public virtual IEnumerable<T> FindBy(System.Linq.Expressions.Expression<Func<T, bool>> predicate)
        {
            IEnumerable<T> query = _dbset.Where(predicate).AsEnumerable();
            return query;
        }

        public virtual IEnumerable<T> GetAll()
        {
            return _dbset.AsEnumerable<T>();
        }

        public virtual void Save()
        {
             _entities.SaveChanges();
        }
    }
}
