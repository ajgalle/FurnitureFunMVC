using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FurnitureFun.Models
{
    public class Furniture
    {

     
        public int Id { get; set; }

        [Required(ErrorMessage = "Please enter a name for this item.")]
        [MaxLength(100,ErrorMessage ="Please do not exceed 100 characters.")]
        public string Name { get; set; }

        [MaxLength(10000, ErrorMessage = "Please do not exceed 10,000 characters.")]
        public string Description { get; set; }

        [Required (ErrorMessage = "Please enter a price.")]
        [Range(1,10000000, ErrorMessage = "In order to be entered automatically in this system, the price must be less than $10,000,000.")]
        public double Price { get; set; }

        public string ImageFileName { get; set; }

        public string[] AvailableColors { get; set; }

        public bool IsInStock { get; set; }

        public int DpeartmentId { get; set; }
        public virtual Department Department { get; set; }
    }
}