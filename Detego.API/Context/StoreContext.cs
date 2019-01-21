using System;
using Detego.API.Entity;
using Microsoft.EntityFrameworkCore;

namespace Detego.API.Context
{
    public class StoreContext : DbContext    
    {

        public StoreContext(DbContextOptions options) : base(options)
        {
            
        }

        public DbSet<Store> Stores { get; set; }
        public DbSet<Manager> Managers { get; set; }
        public DbSet<Characteristic> Characteristics { get; set; }
    }
}