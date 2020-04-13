using NHibernate;
using NhibernateDemo.Mappings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NhibernateDemo.Controllers
{
    public class FriendController : Controller
    {
        // GET: Friend
        public ActionResult Index()
        {
            ViewBag.Message = "Your application description page.";
            IList<Friend> friends;

            using (ISession session = NHibernateSession.OpenSession())  // Open a session to conect to the database
            {
                friends = session.Query<Friend>().ToList(); //  Querying to get all the friends
            }

            return View(friends);
        }

        // GET: Friend/Details/5
        public ActionResult Details(int id)
        {
            Friend friend = new Friend();
            using (ISession session = NHibernateSession.OpenSession())
            {
                friend = session.Query<Friend>().Where(b => b.FriendId == id).FirstOrDefault();
            }

            return View(friend);
        }

        // GET: Friend/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Friend/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                Friend friend = new Friend();     //  Creating a new instance of the Friend
                friend.FriendName = collection["FriendName"].ToString();
                friend.Place = collection["Place"].ToString();

                // TODO: Add insert logic here
                using (ISession session = NHibernateSession.OpenSession())
                {
                    using (ITransaction transaction = session.BeginTransaction())   //  Begin a transaction
                    {
                        session.Save(friend); //  Save the friend in session
                        transaction.Commit();   //  Commit the changes to the database
                    }
                }
                return RedirectToAction("Index");
            }
            catch (Exception e)
            {
                return View();
            }
        }

        // GET: Friend/Edit/5
        public ActionResult Edit(int id)
        {
            Friend friend = new Friend();
            using (ISession session = NHibernateSession.OpenSession())
            {
                friend = session.Query<Friend>().Where(b => b.FriendId == id).FirstOrDefault();
            }

            ViewBag.SubmitAction = "Save";
            return View(friend);
        }

        // POST: Friend/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                Friend friend = new Friend();
                friend.FriendId = id;
                friend.FriendName = collection["FriendName"].ToString();
                friend.Place = collection["Place"].ToString();


                // TODO: Add insert logic here
                using (ISession session = NHibernateSession.OpenSession())
                {
                    using (ITransaction transaction = session.BeginTransaction())
                    {
                        session.SaveOrUpdate(friend);
                        transaction.Commit();
                    }
                }
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Friend/Delete/5
        public ActionResult Delete(int id)
        {
            // Delete the friend
            Friend friend = new Friend();
            using (ISession session = NHibernateSession.OpenSession())
            {
                friend = session.Query<Friend>().Where(b => b.FriendId == id).FirstOrDefault();
            }
            ViewBag.SubmitAction = "Confirm delete";
            return View("Edit", friend);
        }

        // POST: Friend/Delete/5
        [HttpPost]
        public ActionResult Delete(long id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here
                using (ISession session = NHibernateSession.OpenSession())
                {
                    Friend friend = session.Get<Friend>(id);

                    using (ITransaction trans = session.BeginTransaction())
                    {
                        session.Delete(friend);
                        trans.Commit();
                    }
                }
                return RedirectToAction("Index");
            }
            catch (Exception e)
            {
                return View();
            }
        }
    }
}
