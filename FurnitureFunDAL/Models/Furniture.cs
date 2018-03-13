using FurnitureFunDAL.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FurnitureFunDAL.Models
{
    public class Furniture
    {

     
        public int Id { get; set; }

        [Required (ErrorMessage="Please enter the name of the item.")]
        public string Name { get; set; }

        [Required (ErrorMessage="Please add a description")]
        [MaxLength (1000, ErrorMessage ="Please keep the description to less than 1,000 characters")]
        public string Description { get; set; }

        [Required(ErrorMessage ="Please include a price.")   ]
        [Range(1, 1000000, ErrorMessage = "The price must be between $1 and $1,000,000")]
        public double Price { get; set; }

        public string ImageFileName { get; set; }

        public string[] AvailableColors { get; set; }

        public bool IsInStock { get; set; }

        
        // Navigation property
        public virtual Department Department { get; set; }
    }
}