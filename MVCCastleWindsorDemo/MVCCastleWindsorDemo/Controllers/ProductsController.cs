using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MVCCastleWindsorDemo;
using MVCCastleWindsorDemo.Models;

namespace MVCCastleWindsorDemo.Controllers
{
    public class ProductsController : Controller
    {
        private IProductRepository repository;
        public ProductsController(IProductRepository repository1)
        {
            repository = repository1;
        }

        // GET: Products
        public ActionResult Index()
        {
            return View(repository.GetAll());
        }

        // GET: Products/Details/5
        public ActionResult Details(int id)
        {
            Product product = repository.Get(id);
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
                repository.Add(product);
                return View(product);
              
            }

            return RedirectToAction("Index");
        }

        // GET: Products/Edit/5
        public ActionResult Edit(int id)
        {
            Product product = repository.Get(id);
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
                if (repository.Update(product))
                {
                    return View(product);
                }
                return HttpNotFound();
            }
                return RedirectToAction("Index");

        }

        // GET: Products/Delete/5
        public ActionResult Delete(int id)
        {
            Product product = repository.Get(id);
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
            repository.Remove(id);
            return RedirectToAction("Index");
        }

       
    }
}
