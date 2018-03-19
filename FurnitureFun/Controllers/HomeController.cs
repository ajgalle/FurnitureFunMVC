using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using FurnitureFun.Data;
using FurnitureFun.Models;

namespace FurnitureFun.Controllers
{
    public class HomeController : Controller
    {
        private Context db = new Context();

        // GET: Furnitures
        public ActionResult Index()
        {
        
            return View(db.Furnitures.ToList());
        }

        // GET: Furniture/Detail/5
        public ActionResult Detail(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Furniture furniture = db.Furnitures.Find(id);
            Order order = new Order();
            order.Furniture = furniture;

            if (furniture == null)
            {
                return HttpNotFound();
            }
            return View(order);
        }

        
        // POST: Orders/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        //[ValidateAntiForgeryToken]
        public ActionResult Detail([Bind(Include = "Id,FirstName,LastName,Email,Phone,HasAgreed")] int id, Order order)
        {
            Furniture furniture = db.Furnitures.Find(id);

            if (ModelState.IsValid)
            {
                order.Furniture = furniture;
                db.Orders.Add(order);
                db.SaveChanges();
                TempData["message"] = "Your order has been placed.  We will email you when your credit card is charged.";
                return RedirectToAction("Index");
            }
            
            
            order.Furniture = furniture;

            return View(order);
        }

 

         protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
