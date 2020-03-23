using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using Ado_friends.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Ado_friends.Controllers
{
    [Route("crud")]
    public class CrudController : Controller
    {
        // GET: /<controller>/
        [Route("")]
        public IActionResult Index()
        {
            Crud model = new Crud();
            DataTable dt = model.GetAllStudents();
            return View("Index", dt);
        }
        [HttpGet, Route("create")]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost, Route("create")]
        public ActionResult Create(IFormCollection frm, string action)
        {
            if (action == "Submit")
            {
                Crud model = new Crud();
                string name = frm["friendname"];
                int id = Convert.ToInt32(frm["friendid"]);
                string place = frm["place"];
                int status = model.InsertStudent(id,name,place);
                return RedirectToAction("Index");
            }
            else
            {
                return RedirectToAction("Index");
            }
        }
        [HttpGet, Route("update")]
        public IActionResult Update()
        {
            return View();
        }
        [HttpPost, Route("update")]
        public ActionResult Update(IFormCollection frm, string action)
        {
            if (action == "Submit")
            {
                Crud model = new Crud();
                string name = frm["friendname"];
                int id = Convert.ToInt32(frm["friendid"]);
                string place = frm["place"];
                int status = model.UpdateStudent(id, name, place);
                return RedirectToAction("Create");
            }
            else
            {
                return RedirectToAction("Create");
            }
        }
        [HttpGet, Route("delete")]
        public IActionResult Delete()
        {
            return View();
        }
        [HttpPost, Route("delete")]
        public ActionResult Delete(IFormCollection frm, string action)
        {
            if (action == "Submit")
            {
                Crud model = new Crud();
                model.DeleteStudent(Convert.ToInt32(frm["friendid"]));
                return RedirectToAction("Index");
            }
            else
            {
                return RedirectToAction("Index");
            }
        }

    }
}
