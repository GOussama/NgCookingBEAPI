using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NgcookingBackend.Models
{
    public class Communaute //: BaseEntity
    {

        public Communaute()
        {
        }

        public Communaute(string firstname, string surname, string email,string password, int level, string picture, string city, DateTime birth, string bio, ICollection<Recette> recettes)
        {
            Firstname = firstname;
            Surname = surname;
            Email = email;
            Password = password;
            Level = level;
            Picture = picture;
            City = city;
            Birth = birth;
            Bio = bio;
            Recettes = recettes;
        }

        public string Firstname { get; set; }
        public string Surname { get; set; }
        public int Id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public int Level { get; set; }
        public string Picture { get; set; }
        public string City { get; set; }
        public DateTime Birth { get; set; }
        public string Bio { get; set; }
        public ICollection<Recette> Recettes { get; set; }

    }
}
