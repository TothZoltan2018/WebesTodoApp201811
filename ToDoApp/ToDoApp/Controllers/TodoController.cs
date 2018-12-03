using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ToDoApp.Models;

namespace ToDoApp.Controllers
{
    public class TodoController : Controller
    { 
        public ActionResult Index()
        {
            return View(MyDb.Lista);
        }

        //[HttpGet, HttpPost]
        [HttpGet] //annotacio. A routing innentol csak a GET keresek eseten iranyit ide
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]//annotacio. A routing innentol csak a POST keresek eseten iranyit ide
        public ActionResult Create(string name, bool isDone)
        {
            if (!string.IsNullOrEmpty(name))
            {//Ha van adat a parameterben
                //adatok mentese es vissza az indexre
                MyDb.Lista.Add(new TodoItem() { Name = name, Done = isDone });

                return RedirectToAction("Index");
            }

            //todo: mivel a adat nem valid, itt kene a hibauzenettel valamit kezdeni
            //(kiadni az ugyfel fele)
            return View();
        }

    }
} 