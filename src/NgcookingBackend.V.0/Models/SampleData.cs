using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Extensions.DependencyInjection;
using System.Threading.Tasks;

namespace NgcookingBackend.Models
{
    public class SampleData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            var context = serviceProvider.GetService<ModelContext>();

            var recettes = new List<Recette>()
            {
                new Recette("Myrecette01",200,"MyPicture01"),
                new Recette("Myrecette02",200,"MyPicture02"),
                new Recette("Myrecette03",200,"MyPicture03")
            };

            if (!context.Communautes.Any())
            {

                context.Communautes.AddRange(new List<Communaute>()
                {
                     new Communaute("firstname01","surname01","email01","password01",001,"picture01","city01",new DateTime(1985, 10, 15),"bio01",recettes),
                     new Communaute("firstname02","surname02","email02","password02",002,"picture02","city02",new DateTime(1985, 10, 15),"bio02",recettes),
                     new Communaute("firstname03","surname03","email03","password03",003,"picture03","city03",new DateTime(1985, 10, 15),"bio03",recettes)
                });

                context.Recettes.AddRange( new List<Recette>()
                {
                    new Recette("MaRecette",200,"/picture"),
                    new Recette("MaRecette", 200, "/picture")
                });
                context.SaveChanges();
            }

        }


    }
}
