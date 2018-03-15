using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FurnitureFun.Models
{
    // This is for a new use case to associate images with new furniture uploads.  
    // They will be stored as binary data in the database. 
    public enum FileType
    {
      FurnitureImage = 1, Photo
    } 
}