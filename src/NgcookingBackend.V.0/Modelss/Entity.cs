using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NgcookingBackend.Modelss
{
    public abstract class Entity<T> : BaseEntity, IEntity<T>
    {
        public virtual T Id { get; set; }
    }
}
