using FurnitureFun.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FurnitureFun.Data
{
    
    public class FurnitureRepository
    {
        // For now, I'll hard code in the data for furniture here. Later, I'll spin up a database for it. 
        private static Furniture[] _allFurniture = new Furniture[]
        {
            new Furniture
            {
                Name = "Modern Chair Set",
                Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit.",
                Price = 299.98,
                ImageFileName = "smChairSet300x200.jpeg",
                Id = 1,
                AvailableColors = new string[] {"white","black" },
                IsInStock = true,
                Department="kitchen"
            },
            new Furniture
            {
                Name = "Sleep Master 3000",
                Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit.Lorem ipsum dolor sit amet, consectetur adipiscing elit.",
                Price = 1299.98,
                ImageFileName = "smBed300x200.jpeg",
                Id = 2,
                AvailableColors = new string[] {"white", "oyster" },
                IsInStock = true,
                Department="bedroom"
            },
            new Furniture
            {
                Name = "Limited Edition Chair",
                Description = "Lorem ipsum dolor sit amet.",
                Price = 29.98,
                ImageFileName = "smChair300x200.jpeg",
                Id = 3,
                AvailableColors = new string[] {"white", "blue", "green" },
                IsInStock = true,
                Department="bedroom"
            },
            new Furniture
            {
                Name = "Cheese and Citrus Grater",
                Description = "Lorem ipsum dolor sit amet.",
                Price = 9.98,
                ImageFileName = "smGrater300x200.jpeg",
                Id = 4,
                AvailableColors =  null,
                IsInStock = true,
                Department="kitchen"
            },
            new Furniture
            {
                Name = "Coffee Mug",
                Description = "Lorem ipsum dolor sit amet.",
                Price = 9.98,
                ImageFileName = "smMug300x200.jpeg",
                Id = 4,
                AvailableColors =  new string[] {"white", "blue", "black" },
                IsInStock = true,
                Department="kitchen"
            },
            new Furniture
            {
                Name = "Silver Spoon",
                Description = "Lorem ipsum dolor sit amet.",
                Price = 2.98,
                ImageFileName = "smSpoon300x200.jpeg",
                Id = 5,
                AvailableColors =  null,
                IsInStock = true,
                Department="kitchen"
            },

        };


        public Furniture[] GetAllFurniture()
        {
            return _allFurniture;
        }

        // To grab a specific furniture item from the private _allFurniture array field

        public Furniture GetFurniture(int Id)
        {
            
            Furniture furniture = null;
            foreach (var item in _allFurniture)
                {
                if (item.Id == Id)
                    {
                    furniture = item;
                    break;
                    }
                }

            return furniture;
        }
        
        }
    }
