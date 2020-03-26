using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MVCCastleWindsorDemo;

namespace MVCCastleWindsorDemo.Controllers
{
    public class ProductsController : Controller
    {
        private ProductDbContext ProductDatabase;
        public ProductsController(ProductDbContext ProductDatabaseService)
        {
            ProductDatabase = ProductDatabaseService;
        }

        // GET: Products
        public ActionResult Index()
        {
            return View(ProductDatabase.Products.ToList());
        }

        // GET: Products/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Product product = ProductDatabase.Products.Find(id);
            if (product == null)
            {
                return HttpNotFound();
            }
            return View(product);
        }

        // GET: Products/Create
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create([Bind(Include = "Id,Name,category,price")] Product product)
        {
            if (ModelState.IsValid)
            {
                ProductDatabase.Products.Add(product);
                ProductDatabase.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(product);
        }

        // GET: Products/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Product product = ProductDatabase.Products.Find(id);
            if (product == null)
            {
                return HttpNotFound();
            }
            return View(product);
        }

        
        [HttpPost]
       // [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Name,category,price")] Product product)
        {
            if (ModelState.IsValid)
            {
                var result = ProductDatabase.Products.SingleOrDefault(x => x.Id == product.Id);
                if (result != null)
                {
                    result.Name = product.Name;
                    result.category = product.category;
                    result.price = product.price;
                    ProductDatabase.SaveChanges();
                  
                }
                return View(product);
            }
                return RedirectToAction("Index");

        }

        // GET: Products/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Product product = ProductDatabase.Products.Find(id);
            if (product == null)
            {
                return HttpNotFound();
            }
            return View(product);
        }

        // POST: Products/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Product product = ProductDatabase.Products.Find(id);
            ProductDatabase.Products.Remove(product);
            ProductDatabase.SaveChanges();
            return RedirectToAction("Index");
        }

        //protected override void Dispose(bool disposing)
        //{
        //    if (disposing)
        //    {
        //        ProductDatabase.Dispose();
        //    }
        //    base.Dispose(disposing);
        //}
    }
}
