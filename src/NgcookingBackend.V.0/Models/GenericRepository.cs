using Microsoft.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Linq.Expressions;

namespace NgcookingBackend.Models
{
    public class GenericRepository<TType, TContext> : IRepository<TType>
        where TContext : DbContext, new()
        where TType : BaseEntity
    {

        private readonly TContext _entity = new TContext();

        protected TContext Context
        {
            get { return this._entity; }
        }

        /*
        protected string GetEntitySetName(string entityTypeName)
        {
            return this._entity.
        }
        */
        public TType Add(TType entity)
        {

            this._entity.Add(entity); 
            this._entity.SaveChanges();

            return entity;
        }

        public bool Delete(TType entity)
        {
            throw new NotImplementedException();
        }

        public TType Get(Expression<Func<TType, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public ICollection<TType> GetAll()
        {
            throw new NotImplementedException();
        }

        public bool Update(TType entity)
        {
            throw new NotImplementedException();
        }
    }
}
