using FurnitureFun.Data;
using FurnitureFunDAL.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace FurnitureFun.Controllers
{
    public class HomeController : Controller
    {
        
        public HomeController()
        {
            
   

        }

        public ActionResult Index()
        {
            var allFurniture = FurnitureRepository.GetAllFurniture();

            return View(allFurniture);
        }

        public ActionResult Detail(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }
            // Recall, when useing nullable types(e.g., int?) must use .Value to get at the value.
            var furniture = FurnitureRepository.GetFurniture(id.Value);
            return View(furniture);
        }
        
    }
}