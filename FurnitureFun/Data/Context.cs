﻿using FurnitureFun.Models;
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
        public virtual DbSet<Furniture> Furnitures { get; set; }
        public virtual DbSet<Department> Departments { get; set; }


        public Context()

        {
            Database.SetInitializer(new DatabaseInitializer());
        }
    }
}

    

    