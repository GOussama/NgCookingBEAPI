using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NgcookingBackend.Models
{
    public class ModelRepository : IModelRepository
    {
        public ModelContext Context { get; set; }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public bool ElementExists(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Recette> GetAll()
        {
            throw new NotImplementedException();
        }

        public Recette GetElementById(int id)
        {
            throw new NotImplementedException();
        }

        public long GetNumberOfElements(string query)
        {
            throw new NotImplementedException();
        }

        public long Insert(Recette recette)
        {
            throw new NotImplementedException();
        }

        public void Update(int id, Recette recette)
        {
            throw new NotImplementedException();
        }
    }
}
