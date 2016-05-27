using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NgcookingBackend.Models
{
    interface IModelRepository
    {
        IEnumerable<Recette> GetAll();
        long GetNumberOfElements(string query);
        bool ElementExists(int id);
        Recette GetElementById(int id);
        long Insert(Recette recette);
        void Update(int id, Recette recette);
        void Delete(int id);
        
    }
}
