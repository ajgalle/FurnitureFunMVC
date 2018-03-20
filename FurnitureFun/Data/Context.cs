using FurnitureFun.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace FurnitureFun.Data
{
    public class Context : DbContext
    {   
        public DbSet<Furniture> Furnitures { get; set; }
        public DbSet<Order> Orders { get; set; } 


        public Context() : base ("Data Source=den1.mssql6.gear.host;Initial Catalog=furniturefun;Integrated Security=False;User ID=furniturefun;Password=Ou0Efw-bi0!T;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False") 
        {
            Database.SetInitializer(new DatabaseInitializer());
        }
    }
}

    

    