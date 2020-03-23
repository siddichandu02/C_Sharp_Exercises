using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Friends_linq.Controllers
{
    public class CrudController : Controller
    {
        // GET: Crud
        DataClasses1DataContext dc = new DataClasses1DataContext();
        public ActionResult Index()
        {
            var frienddetails = from x in dc.Friends2s select x;
            return View(frienddetails);
        }

        // GET: Crud/Details/5
        public ActionResult Details(int id)
        {
            var getFriendDetails = dc.Friends2s.Single(x => x.FriendId == id);
            return View(getFriendDetails);
        }

        // GET: Crud/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Crud/Create
        [HttpPost]
        public ActionResult Create(Friends2 collection)
        {
            try
            {
                // TODO: Add insert logic here
                dc.Friends2s.InsertOnSubmit(collection);
                dc.SubmitChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Crud/Edit/5
        public ActionResult Edit(int id)
        {
            var getFriendDetails = dc.Friends2s.Single(x => x.FriendId == id);
            return View(getFriendDetails);
        }

        // POST: Crud/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Friends2 collection)
        {
            try
            {
                // TODO: Add update logic here
                Friends2 friendsupdate = dc.Friends2s.Single(x => x.FriendId == id);
                friendsupdate.FriendName = collection.FriendName;
                friendsupdate.Place = collection.Place;
                dc.SubmitChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Crud/Delete/5
        public ActionResult Delete(int id)
        {
            var getFriendDetails = dc.Friends2s.Single(x => x.FriendId == id);
            return View(getFriendDetails);
        }

        // POST: Crud/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, Friends2 collection)
        {
            try
            {
                // TODO: Add delete logic here
                var friendDelete = dc.Friends2s.Single(x => x.FriendId == id);
                dc.Friends2s.DeleteOnSubmit(friendDelete);
                dc.SubmitChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
