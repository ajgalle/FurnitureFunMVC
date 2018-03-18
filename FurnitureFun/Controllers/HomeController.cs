using FurnitureFun.Data;
using FurnitureFun.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FurnitureFun.ViewModels;

namespace FurnitureFun.Controllers
{
   
    public class HomeController : Controller
    {
        private Context _db = new Context();

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

            // Recall, when using nullable types(e.g., int?) must use .Value to get at the value.
            var furniture = FurnitureRepository.GetFurniture(id.Value);
            var order = new Order();
            ViewModelDetailAndOrder viewModel = new ViewModelDetailAndOrder();
            viewModel.Furniture = furniture;
            return View(viewModel);
        }

        //If the form on the detail page for an item is submitted, this will trigger.
        [HttpPost]
        public ActionResult Detail(int id, ViewModelDetailAndOrder viewModel)
        {
            if (ModelState.IsValid)
            {
                //TODO: Update database to include the FK Id for the furniture being bought, then display this on the customers recent orders page. 
                viewModel.Order.orderedId = id;

                _db.Orders.Add(viewModel.Order);

                
               _db.SaveChanges();

                TempData["message"] = "Your order was placed successfully. Check the Order tab for more information";   // TODO Add this message to the index page
                


                return RedirectToAction("Index");
            }
            var furniture = FurnitureRepository.GetFurniture(id);
             
            viewModel.Furniture = furniture;
            return View(viewModel);

        }
    }
   }