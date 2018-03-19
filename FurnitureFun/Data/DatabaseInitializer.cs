
using FurnitureFun.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FurnitureFun.Data
{
    internal class DatabaseInitializer:DropCreateDatabaseIfModelChanges<Context>
    {
        protected override void Seed(Context context)
        {

            IList<Furniture> defaultFurniture = new List<Furniture>();

            defaultFurniture.Add(new Furniture()
            {
                Name = "Modern Chair Set",
                Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit.Lorem ipsum dolor sit amet, consectetur adipiscing elit.Lorem ipsum dolor sit amet, consectetur adipiscing elit.Lorem ipsum dolor sit amet, consectetur adipiscing elit.Lorem ipsum dolor sit amet, consectetur adipiscing elit.Lorem ipsum dolor sit amet, consectetur adipiscing elit.Lorem ipsum dolor sit amet, consectetur adipiscing elit.Lorem ipsum dolor sit amet, consectetur adipiscing elit.",
                Price = 299.98,
                ImageFileName = "smChairSet300x200.jpeg",
                FurnitureId = 1,
                IsInStock = true,
                Department = "Bedroom"
            });
            defaultFurniture.Add(new Furniture()
            {
                Name = "Sleep Master 3000",
                Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit.Lorem ipsum dolor sit amet, consectetur adipiscing elit.Lorem ipsum dolor sit amet, consectetur adipiscing elit.Lorem ipsum dolor sit amet, consectetur adipiscing elit.Lorem ipsum dolor sit amet, consectetur adipiscing elit.Lorem ipsum dolor sit amet, consectetur adipiscing elit.Lorem ipsum dolor sit amet, consectetur adipiscing elit.",
                Price = 1299.98,
                ImageFileName = "smBed300x200.jpeg",
                FurnitureId = 2,
                IsInStock = true,
                Department = "Bedroom"
            });
            defaultFurniture.Add(new Furniture()
            {
                Name = "Limited Edition Chair",
                Description = "Lorem ipsum dolor sit amet.Lorem ipsum dolor sit amet, consectetur adipiscing elit.Lorem ipsum dolor sit amet, consectetur adipiscing elit.Lorem ipsum dolor sit amet, consectetur adipiscing elit.Lorem ipsum dolor sit amet, consectetur adipiscing elit.Lorem ipsum dolor sit amet, consectetur adipiscing elit.Lorem ipsum dolor sit amet, consectetur adipiscing elit.Lorem ipsum dolor sit amet, consectetur adipiscing elit.Lorem ipsum dolor sit amet, consectetur adipiscing elit.",
                Price = 29.98,
                ImageFileName = "smChair300x200.jpeg",
                FurnitureId = 3,
                IsInStock = true,
                Department = "Bedroom"
            });
            defaultFurniture.Add(new Furniture()
            {
                Name = "Cheese and Citrus Grater",
                Description = "Lorem ipsum dolor sit amet.Lorem ipsum dolor sit amet.Lorem ipsum dolor sit amet.Lorem ipsum dolor sit amet.Lorem ipsum dolor sit amet.Lorem ipsum dolor sit amet.Lorem ipsum dolor sit amet.Lorem ipsum dolor sit amet.Lorem ipsum dolor sit amet.Lorem ipsum dolor sit amet.Lorem ipsum dolor sit amet.Lorem ipsum dolor sit amet.Lorem ipsum dolor sit amet.Lorem ipsum dolor sit amet.Lorem ipsum dolor sit amet.Lorem ipsum dolor sit amet.Lorem ipsum dolor sit amet.Lorem ipsum dolor sit amet.Lorem ipsum dolor sit amet.Lorem ipsum dolor sit amet.Lorem ipsum dolor sit amet.Lorem ipsum dolor sit amet.Lorem ipsum dolor sit amet.",
                Price = 9.98,
                ImageFileName = "smGrater300x200.jpeg",
                FurnitureId = 4,
                IsInStock = true,
                Department = "Kitchen"
            });
            defaultFurniture.Add(new Furniture()
            {
                Name = "Coffee Mug",
                Description = "Lorem ipsum dolor sit amet.Lorem ipsum dolor sit amet.Lorem ipsum dolor sit amet.Lorem ipsum dolor sit amet.Lorem ipsum dolor sit amet.Lorem ipsum dolor sit amet.",
                Price = 9.98,
                ImageFileName = "smMug300x200.jpeg",
                FurnitureId=5,
                IsInStock = true,
                Department = "Kitchen"
            });
            defaultFurniture.Add(new Furniture()
            {
                Name = "Silver Spoon",
                Description = "Lorem ipsum dolor sit amet.Lorem ipsum dolor sit amet.Lorem ipsum dolor sit amet.Lorem ipsum dolor sit amet.Lorem ipsum dolor sit amet.Lorem ipsum dolor sit amet.Lorem ipsum dolor sit amet.Lorem ipsum dolor sit amet.Lorem ipsum dolor sit amet.Lorem ipsum dolor sit amet.Lorem ipsum dolor sit amet.Lorem ipsum dolor sit amet.Lorem ipsum dolor sit amet.Lorem ipsum dolor sit amet.Lorem ipsum dolor sit amet.",
                Price = 2.98,
                ImageFileName = "smSpoon300x200.jpeg",
                FurnitureId=6,
                IsInStock = true,
                Department = "Kitchen"
            });

            context.Furnitures.AddRange(defaultFurniture);
            base.Seed(context);

        }


    }
}



