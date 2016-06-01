using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NgcookingBackend.Models
{
    public abstract class BaseEntity
    {
        public Int64 ID { get; set; }
        public DateTime AddedDate { get; set; }
        public DateTime ModifiesDate { get; set; }
     
    }
}
