using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace FilmsDbAzureApp.Models
{
    public class FilmContext : DbContext
    {
        public DbSet<Basket> Baskets { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Film> Products { get; set; }
    }
}