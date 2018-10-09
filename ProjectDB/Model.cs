using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace Model
{
    public class BagContext: DbContext
    {
        public DbSet<User> Users {get;set;}
        public DbSet<Item> Items {get;set;} 

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder){
      optionsBuilder.UseNpgsql("User ID=postgres;Password=;Host=localhost;Port=5432;Database=ProjectDB;Pooling=true;");}
    }
    public class User
    {
        public int Id {get; set;}
    }

    public class Item
    {
        public int Id {get;set;}

    }
}