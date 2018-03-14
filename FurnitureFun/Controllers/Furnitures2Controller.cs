﻿using System;
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
    public class Furnitures2Controller : Controller
    {
        private Context db = new Context();

        // GET: Furnitures2
        public ActionResult Index()
        {
            return View(db.Furnitures.ToList());
        }

        // GET: Furnitures2/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Furniture furniture = db.Furnitures.Find(id);
            if (furniture == null)
            {
                return HttpNotFound();
            }
            return View(furniture);
        }

        // GET: Furnitures2/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Furnitures2/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Name,Description,Price,ImageFileName,IsInStock,DpeartmentId")] Furniture furniture)
        {
            if (ModelState.IsValid)
            {
                db.Furnitures.Add(furniture);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(furniture);
        }

        // GET: Furnitures2/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Furniture furniture = db.Furnitures.Find(id);
            if (furniture == null)
            {
                return HttpNotFound();
            }
            return View(furniture);
        }

        // POST: Furnitures2/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Name,Description,Price,ImageFileName,IsInStock,DpeartmentId")] Furniture furniture)
        {
            if (ModelState.IsValid)
            {
                db.Entry(furniture).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(furniture);
        }

        // GET: Furnitures2/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Furniture furniture = db.Furnitures.Find(id);
            if (furniture == null)
            {
                return HttpNotFound();
            }
            return View(furniture);
        }

        // POST: Furnitures2/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Furniture furniture = db.Furnitures.Find(id);
            db.Furnitures.Remove(furniture);
            db.SaveChanges();
            return RedirectToAction("Index");
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
