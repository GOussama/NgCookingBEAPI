using NgcookingBackend.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Linq.Expressions;

namespace NgcookingBackend.Models
{
    public class RecetteRepository : IRecetteRepository
    {
        public ModelContext Context { get; set; } 

        public RecetteRepository(ModelContext context)
        {
            Context = context;
        }

        public bool RecetteExists(int id)
        {   
            return Context.Recettes.Select(x => x.Id == id).ToList().Count <= 1;
        }

        public void Delete(int id)
        {
            Context.Recettes.Remove(Context.Recettes.Single(x => x.Id == id));
            Context.SaveChanges();
        }

        public Recette GetRecetteById(int id)
        {
            return Context.Recettes.Single(x => x.Id == id);
        }

        public long GetNumberOfRecettes(string query)
        {
            return Context.Recettes.ToList().Count;
        }

        public IEnumerable<Recette> GetRecettes()
        {
            return Context.Recettes.AsEnumerable();
        }

        public int Insert(Recette recette)
        {

            Context.Recettes.Add(recette);
            Context.SaveChanges();

            return recette.Id;

        }

        public void ResetDataBase1000Recettes()
        {
            throw new NotImplementedException();
        }

        public void ResetDataBase10Recettes()
        {
            throw new NotImplementedException();
        }

        public void Update(int id, Recette recette)
        {
            var updateRecette = Context.Recettes.Single((x => x.Id == id));

            updateRecette.Name = recette.Name;
            updateRecette.Picture = recette.Picture;
            updateRecette.Calories = recette.Calories;

        }

        public IQueryable<Recette> GetAll()
        {
            throw new NotImplementedException();
        }

        public IQueryable<Recette> FindBy(Expression<Func<Recette, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public void Add(Recette entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Recette entity)
        {
            throw new NotImplementedException();
        }

        public void Edit(Recette entity)
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            throw new NotImplementedException();
        }
      
        long IRecetteRepository.Insert(Recette recette)
        {
            throw new NotImplementedException();
        }


    }
}
