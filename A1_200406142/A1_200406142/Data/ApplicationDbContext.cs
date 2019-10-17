using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using A1_200406142.Models;

namespace A1_200406142.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<A1_200406142.Models.Food> Food { get; set; }
        public int AnimalId { get; private set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Animal>().HasData(
            new Animal(1, "Cats", "Cats - incredibly cute creatures that successfully live both in houses and in the wild (instilling fear in any forest animals). And those cats who live in houses have their own slaves - people."),
            new Animal(2, "Dogs", "Dogs (doge) - animals devoted to man, ready to give their lives in order to protect the owner. But be sure, if you leave the dog at house alone, it will gobble up your Sweet Roll.")
            );

            modelBuilder.Entity<Food>().HasData(
                new Models.Food() { Id = 1, Name = "Real Hunter's Dinner", Price = 12, Description = "Gives your cat the power of Tiger!", NutritionalInformation = "Protein: 15. Fat: 5. Tiger Meat: 101%.", Weight = 400, Brand = "TigerFood", TypeOfAnimal = "Cat", AnimalId = 1 },
                new Models.Food() { Id = 2, Name = "Wolf Mittagessen", Price = 30, Description = "The food, the secret of the recipe of which is kept in Germany, contains all the necessary elements for a healthy dog nutrition.", NutritionalInformation = "Protein: 20, Fat: 10, Secret Ingridient B418/2918, Secret Ingridient 'Wolfenstein'", Weight = 1300, Brand = "Wolfenstein", TypeOfAnimal = "Dog", AnimalId = 2 }
                
              );


        }

        public DbSet<A1_200406142.Models.Animal> Animal { get; set; }
        





    }
}
