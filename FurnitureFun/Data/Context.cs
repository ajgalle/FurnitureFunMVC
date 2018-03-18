using FurnitureFun.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace FurnitureFun.Data
{
    public class Context : DbContext
    {
        public DbSet<Furniture> Furnitures { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Order> Orders { get; set; } 


        public Context()

        {
            Database.SetInitializer(new DatabaseInitializer());
        }
    }
}

    

    