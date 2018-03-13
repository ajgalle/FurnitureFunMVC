using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FurnitureFun.Models
{
    public class Furniture
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public string ImageFileName { get; set; }
        public string[] AvailableColors { get; set; }
        public bool IsInStock { get; set; }
        public string Department { get; set; }
    }
}