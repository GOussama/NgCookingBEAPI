using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace NgcookingBackend.Models
{
    public class CommunautesRepository : ICommunautesRepository
    {

        public ModelContext Context { get; set; }

        public CommunautesRepository(ModelContext context)
        {
            Context = context;
        }

        public bool CommunuateExists(string email)
        {
            return Context.Communautes.Select(x => x.Email == email).ToList().Count >= 1;
        }

        public void Delete(int id)
        {
            Context.Communautes.Remove(Context.Communautes.Single(x=>x.Id == id));
            Context.SaveChanges();
        }

        public IList<Communaute> GetAllCommunautes(string query,int page,int pageSize)
        {
            var filteredContacts = string.IsNullOrWhiteSpace(query) ? Context.Communautes.ToList() : Context.Communautes
                .Where(x => x.Firstname.Contains(query) || x.Surname.Contains(query)).ToList();

            return filteredContacts.Skip(page * pageSize).Take(pageSize).ToList();
        }

        public Communaute GetCommunauteByEmail(string email)
        {
            return Context.Communautes.Single(x=>x.Email == email);
        }

        public Communaute GetCommunauteById(int id)
        {
            return Context.Communautes.Single(x=>x.Id == id);
        }

        public long GetNumberOfCommunautes(string query)
        {
            return Context.Communautes.ToList().Count;
        }

        public int Insert(Communaute communaute)
        {
            Context.Communautes.Add(communaute);
            Context.SaveChanges();

            return communaute.Id;
        }

        public void ResetDataBase1000Communautes()
        {
            throw new NotImplementedException();
        }

        public void ResetDataBase10Communautes()
        {

            var recettes = new List<Recette>()
            {
                new Recette("Myrecette01",200,"MyPicture01"),
                new Recette("Myrecette02",200,"MyPicture02"),
                new Recette("Myrecette03",200,"MyPicture03")
            };

            var communautes = new List<Communaute>()
            {
                new Communaute("firstname1","surname1","email1","password",01,"picture","city",new DateTime(1985, 10, 15),"bio",recettes),
                new Communaute("firstname2","surname2","email2","password",01,"picture","city",new DateTime(1985, 10, 15),"bio",recettes),
                new Communaute("firstname3","surname3","email3","password",01,"picture","city",new DateTime(1985, 10, 15),"bio",recettes)
            };

            Context.Communautes.RemoveRange(Context.Communautes);
            Context.Communautes.AddRange(communautes);
            Context.SaveChanges();

        }

        public void Update(int id, Communaute communaute)
        {

            var updateContact = Context.Communautes.Single(x => x.Id == id);

            updateContact.Firstname = communaute.Firstname;
            updateContact.Surname = communaute.Surname;
            updateContact.Email = communaute.Email;
            updateContact.Birth = communaute.Birth;
            updateContact.City = communaute.City;
            updateContact.Bio = communaute.Bio;
            updateContact.Level = communaute.Level;
            updateContact.Password = communaute.Password;
            updateContact.Picture = communaute.Picture;

            Context.SaveChanges(); 
             
              
        }

        public IEnumerable<Communaute> GetCommunautes()
        {
            return Context.Communautes.AsEnumerable();
        }

        public Communaute getSingle(int communauteId)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Communaute> GetAll()
        {
            throw new NotImplementedException();
        }

        public IQueryable<Communaute> FindBy(Expression<Func<Communaute, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public void Add(Communaute entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Communaute entity)
        {
            throw new NotImplementedException();
        }

        public void Edit(Communaute entity)
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            throw new NotImplementedException();
        }

        long ICommunautesRepository.Insert(Communaute communaute)
        {
            throw new NotImplementedException();
        }

        
    }
}
