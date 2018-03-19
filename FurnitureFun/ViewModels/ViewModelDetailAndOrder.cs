using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using FurnitureFun.Models;

namespace FurnitureFun.ViewModels
{
    public class ViewModelDetailAndOrder
    {
         
            public Furniture Furniture { get; set; }
            public Order Order { get; set; }
        
    }
  
}