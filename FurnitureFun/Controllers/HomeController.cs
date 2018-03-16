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

                TempData["message"] = "Your order was placed successfully.";

                return RedirectToAction("Index");
            }
            var furniture = FurnitureRepository.GetFurniture(id);
            //var order = new Order();
            //ViewModelDetailAndOrder viewModel = new ViewModelDetailAndOrder();
            viewModel.Furniture = furniture;
            return View(viewModel);

        }
    }
   }