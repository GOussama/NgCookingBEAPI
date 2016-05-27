using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NgcookingBackend.Models
{
    public interface ICommunautesRepository : IGenericRepository<Communaute>
    {
        Communaute getSingle(int communauteId);
        IList<Communaute> GetAllCommunautes(string query, int page, int pageSize);
        IEnumerable<Communaute> GetCommunautes(); 
        long GetNumberOfCommunautes(string query);
        bool CommunuateExists(string email);
        Communaute GetCommunauteById(int id);
        Communaute GetCommunauteByEmail(string email);
        long Insert(Communaute communaute);
        void Update(int id, Communaute communaute);
        void Delete(int id);
        void ResetDataBase10Communautes();
        void ResetDataBase1000Communautes();

    }
}
