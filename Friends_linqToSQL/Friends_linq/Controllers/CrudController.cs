using Friends_linq.Models;
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
        FriendDataClassesDataContext dc = new FriendDataClassesDataContext();
        public ActionResult Index()
        {
            var frienddetails = from x in dc.Friends select x;
            return View(frienddetails);
        }

        // GET: Crud/Details/5
        public ActionResult Details(int id)
        {
            var getFriendDetails = dc.Friends.Single(x => x.FriendId == id);
            return View(getFriendDetails);
        }

        // GET: Crud/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Crud/Create
        [HttpPost]
        public ActionResult Create(Friend collection)
        {
            try
            {
                // TODO: Add insert logic here
                dc.Friends.InsertOnSubmit(collection);
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
            var getFriendDetails = dc.Friends.Single(x => x.FriendId == id);
            return View(getFriendDetails);
        }

        // POST: Crud/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Friend collection)
        {
            try
            {
                // TODO: Add update logic here
                Friend friendsupdate = dc.Friends.Single(x => x.FriendId == id);
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
            var getFriendDetails = dc.Friends.Single(x => x.FriendId == id);
            return View(getFriendDetails);
        }

        // POST: Crud/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, Friend collection)
        {
            try
            {
                // TODO: Add delete logic here
                var friendDelete = dc.Friends.Single(x => x.FriendId == id);
                dc.Friends.DeleteOnSubmit(friendDelete);
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
