using FurnitureFun.Data;
using FurnitureFunDAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FurnitureFun.Controllers
{
    public class EmployeeController : Controller
    {
        public ActionResult Index()
        {
            var allFurniture = FurnitureRepository.GetAllFurniture();

            return View(allFurniture);
                        
        }
        public ActionResult Edit(int? id)
        {

            if (id == null)
            {
                return HttpNotFound();
            }
            // Recall, when useing nullable types(e.g., int?) must use .Value to get at the value.
            var furniture = FurnitureRepository.GetFurniture(id.Value);
            return View(furniture);
        }
        public ActionResult Delete(int? id)
        {

            if (id == null)
            {
                return HttpNotFound();
            }
            // Recall, when useing nullable types(e.g., int?) must use .Value to get at the value.
            var furniture = FurnitureRepository.GetFurniture(id.Value);
            return View(furniture);
        }
        public ActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Add(Furniture furniture)
        { 
            if (ModelState.IsValid)
                {
                FurnitureRepository.AddFurniture(furniture);

                return RedirectToAction("Index");
                }

                return View(furniture);
        }
    }
}

        

