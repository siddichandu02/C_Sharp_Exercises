using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using friends.Models;
using Microsoft.AspNetCore.Http;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace friends.Controllers
{
    [Route("friend")]
    public class FriendController : Controller
    {
        private readonly FriendDataContext _db;

        public FriendController(FriendDataContext db)
        {
            _db = db;
        }
        // GET: /<controller>/
        [Route("")]
        public IActionResult Index()
        {
            var friends = _db.Friends.ToArray();
            return View(friends);
        }
        [HttpGet, Route("update")]
        public IActionResult Update()
        {
            return View();
        }
        [HttpPost, Route("update")]
        public IActionResult Update(Friend friend)
        {

            var result = _db.Friends.SingleOrDefault(x => x.FriendId == friend.FriendId);
            if (result != null)
            {
                result.FriendName = friend.FriendName;
                result.Place = friend.Place;
                _db.SaveChanges();
            }

            return View();
        }
        //[HttpPost, Route("update")]
        //public IActionResult Update(IFormCollection form)
        //{
        //    var id = int.Parse(Request.Form["FriendId"]);
        //    var result = _db.Friends.SingleOrDefault(x => x.FriendId == id);
        //    if (result != null)
        //    {
        //        result.FriendName = Request.Form["FriendName"];
        //        result.Place = Request.Form["Place"];
        //        _db.SaveChanges();
        //    }

        //    return View();
        //}
        [HttpGet, Route("delete")]
        public IActionResult Delete()
        {
            return View();
        }
        [HttpPost, Route("delete")]
        public IActionResult Delete(Friend friend)
        {

            var result = _db.Friends.SingleOrDefault(x => x.FriendName == friend.FriendName);
            if (result != null)
            {
                _db.Remove(result);
                _db.SaveChanges();
            }

            return View();
        }
      
        [HttpGet, Route("create")]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost, Route("create")]
        public IActionResult Create(Friend friend)
        {
            if (!ModelState.IsValid)
                return View();
            _db.Friends.Add(friend);
            _db.SaveChanges();
            return View();
        }
    }
}