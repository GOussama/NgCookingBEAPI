using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Data.Entity;

namespace NgcookingBackend.Models
{
    public class ModelContext : DbContext
    {
        public DbSet<Communaute> Communautes { get; set; }
        public DbSet<Recette> Recettes { get; set; }
        //This method create tables in the database
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            foreach (var entity in modelBuilder.Model.GetEntityTypes())
            {
                modelBuilder.Entity(entity.Name).ToTable(entity.Name + "s");
            }
        }
    }
}
