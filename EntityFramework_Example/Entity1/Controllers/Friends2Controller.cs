using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Entity1;

namespace Entity1.Controllers
{
    public class Friends2Controller : Controller
    {
        private FriendsAdoEntities db = new FriendsAdoEntities();

        // GET: Friends2
        public ActionResult Index()
        {
            return View(db.Friends2.ToList());
        }

        // GET: Friends2/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Friends2 friends2 = db.Friends2.Find(id);
            if (friends2 == null)
            {
                return HttpNotFound();
            }
            return View(friends2);
        }

        // GET: Friends2/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Friends2/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "FriendId,FriendName,Place")] Friends2 friends2)
        {
            if (ModelState.IsValid)
            {
                db.Friends2.Add(friends2);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(friends2);
        }

        // GET: Friends2/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Friends2 friends2 = db.Friends2.Find(id);
            if (friends2 == null)
            {
                return HttpNotFound();
            }
            return View(friends2);
        }

        // POST: Friends2/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "FriendId,FriendName,Place")] Friends2 friends2)
        {
            if (ModelState.IsValid)
            {
                db.Entry(friends2).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(friends2);
        }

        // GET: Friends2/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Friends2 friends2 = db.Friends2.Find(id);
            if (friends2 == null)
            {
                return HttpNotFound();
            }
            return View(friends2);
        }

        // POST: Friends2/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Friends2 friends2 = db.Friends2.Find(id);
            db.Friends2.Remove(friends2);
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
