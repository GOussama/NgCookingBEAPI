using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NgcookingBackend.Models
{
    public class Recette //: BaseEntity
    {
        public Recette()
        {
        }

        public Recette(string name,int calories,string picture)
        {
            Name = name;
            Calories = calories;
            Picture = picture;
        }

        public string Name { get; set; }
        public int Id { get; set; }
        public int Calories { get; set; }
        public string Picture { get; set; }
    }
}
