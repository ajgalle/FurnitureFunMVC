
using FurnitureFunDAL.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FurnitureFunDAL.Data
{
    internal class DatabaseInitializer:DropCreateDatabaseIfModelChanges<Context>
    {
        protected override void Seed(Context context)
        {
            var seedDepartmentBedroom = new Department()
            {
                DepartmentName = "Bedroom"
            };

            var seedDepartmentKitchen = new Department()
            {
                DepartmentName = "Kitchen"
            };

            var seedFurnitureChair = new Furniture()
            {
                Name = "Modern Chair Set",
                Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit.Lorem ipsum dolor sit amet, consectetur adipiscing elit.Lorem ipsum dolor sit amet, consectetur adipiscing elit.Lorem ipsum dolor sit amet, consectetur adipiscing elit.Lorem ipsum dolor sit amet, consectetur adipiscing elit.Lorem ipsum dolor sit amet, consectetur adipiscing elit.Lorem ipsum dolor sit amet, consectetur adipiscing elit.Lorem ipsum dolor sit amet, consectetur adipiscing elit.",
                Price = 299.98,
                ImageFileName = "smChairSet300x200.jpeg",
                Id = 1,
                AvailableColors = new string[] { "white", "black" },
                IsInStock = true,
                Department = seedDepartmentBedroom
            };
            var seedFurnitureBed = new Furniture()
            {
                Name = "Sleep Master 3000",
                Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit.Lorem ipsum dolor sit amet, consectetur adipiscing elit.Lorem ipsum dolor sit amet, consectetur adipiscing elit.Lorem ipsum dolor sit amet, consectetur adipiscing elit.Lorem ipsum dolor sit amet, consectetur adipiscing elit.Lorem ipsum dolor sit amet, consectetur adipiscing elit.Lorem ipsum dolor sit amet, consectetur adipiscing elit.",
                Price = 1299.98,
                ImageFileName = "smBed300x200.jpeg",
                Id = 2,
                AvailableColors = new string[] { "white", "oyster" },
                IsInStock = true,
                Department = seedDepartmentBedroom
            };
            var seedFurnitureLimitedChair = new Furniture()
            {
                Name = "Limited Edition Chair",
                Description = "Lorem ipsum dolor sit amet.Lorem ipsum dolor sit amet, consectetur adipiscing elit.Lorem ipsum dolor sit amet, consectetur adipiscing elit.Lorem ipsum dolor sit amet, consectetur adipiscing elit.Lorem ipsum dolor sit amet, consectetur adipiscing elit.Lorem ipsum dolor sit amet, consectetur adipiscing elit.Lorem ipsum dolor sit amet, consectetur adipiscing elit.Lorem ipsum dolor sit amet, consectetur adipiscing elit.Lorem ipsum dolor sit amet, consectetur adipiscing elit.",
                Price = 29.98,
                ImageFileName = "smChair300x200.jpeg",
                Id = 3,
                AvailableColors = new string[] { "white", "blue", "green" },
                IsInStock = true,
                Department = seedDepartmentBedroom
            };
            var seedFurnitureGrater = new Furniture()
            {
                Name = "Cheese and Citrus Grater",
                Description = "Lorem ipsum dolor sit amet.Lorem ipsum dolor sit amet.Lorem ipsum dolor sit amet.Lorem ipsum dolor sit amet.Lorem ipsum dolor sit amet.Lorem ipsum dolor sit amet.Lorem ipsum dolor sit amet.Lorem ipsum dolor sit amet.Lorem ipsum dolor sit amet.Lorem ipsum dolor sit amet.Lorem ipsum dolor sit amet.Lorem ipsum dolor sit amet.Lorem ipsum dolor sit amet.Lorem ipsum dolor sit amet.Lorem ipsum dolor sit amet.Lorem ipsum dolor sit amet.Lorem ipsum dolor sit amet.Lorem ipsum dolor sit amet.Lorem ipsum dolor sit amet.Lorem ipsum dolor sit amet.Lorem ipsum dolor sit amet.Lorem ipsum dolor sit amet.Lorem ipsum dolor sit amet.",
                Price = 9.98,
                ImageFileName = "smGrater300x200.jpeg",
                Id = 4,
                AvailableColors = null,
                IsInStock = true,
                Department = seedDepartmentBedroom
            };
            var seedFurnitureMug = new Furniture()
            {
                Name = "Coffee Mug",
                Description = "Lorem ipsum dolor sit amet.Lorem ipsum dolor sit amet.Lorem ipsum dolor sit amet.Lorem ipsum dolor sit amet.Lorem ipsum dolor sit amet.Lorem ipsum dolor sit amet.",
                Price = 9.98,
                ImageFileName = "smMug300x200.jpeg",
                Id = 4,
                AvailableColors = new string[] { "white", "blue", "black" },
                IsInStock = true,
                Department = seedDepartmentBedroom
            };
            var seedFurnitureSpoon = new Furniture()
            {
                Name = "Silver Spoon",
                Description = "Lorem ipsum dolor sit amet.Lorem ipsum dolor sit amet.Lorem ipsum dolor sit amet.Lorem ipsum dolor sit amet.Lorem ipsum dolor sit amet.Lorem ipsum dolor sit amet.Lorem ipsum dolor sit amet.Lorem ipsum dolor sit amet.Lorem ipsum dolor sit amet.Lorem ipsum dolor sit amet.Lorem ipsum dolor sit amet.Lorem ipsum dolor sit amet.Lorem ipsum dolor sit amet.Lorem ipsum dolor sit amet.Lorem ipsum dolor sit amet.",
                Price = 2.98,
                ImageFileName = "smSpoon300x200.jpeg",
                Id = 5,
                AvailableColors = null,
                IsInStock = true,
                Department = seedDepartmentBedroom
            };
            context.Furnitures.Add(seedFurnitureBed);
            context.Furnitures.Add(seedFurnitureChair);
            context.Furnitures.Add(seedFurnitureGrater);
            context.Furnitures.Add(seedFurnitureLimitedChair);
            context.Furnitures.Add(seedFurnitureMug);
            context.Furnitures.Add(seedFurnitureSpoon);
            context.SaveChanges();

        }


    }
}




