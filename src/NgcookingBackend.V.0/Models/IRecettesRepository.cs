using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NgcookingBackend.Models
{
    public interface IRecetteRepository : IGenericRepository<Recette>
    {
        IEnumerable<Recette> GetRecettes();
        long GetNumberOfRecettes(string query);
        bool RecetteExists(int id);
        Recette GetRecetteById(int id);
        long Insert(Recette recette);
        void Update(int id, Recette recette);
        void Delete(int id);
        void ResetDataBase10Recettes();
        void ResetDataBase1000Recettes();

    }
}
