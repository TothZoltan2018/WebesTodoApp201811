using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ToDoApp.Models;

namespace ToDoApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult TodoList()
        {
            //------- Ez volt az megoldas #1 Mukodott, de eleg proszto --------
            //var lista = new List<string>();
            //lista.Add("Só");
            //lista.Add("Cukor");
            //lista.Add("Spagetti");
            //lista.Add("Marhahús");
            //lista.Add("Paradicsom");

            //A ViewBag-be tett adatokat a nezeten ki tudjuk olvasni
            //figyelem:az erosen tipusos vedelmet itt elveszitjuk
            //ViewBag.Lista = lista;
            //return View();

            //------- Ez a megoldas #2 ---------------------
            //A TodoList.cshtml elejere: @model List<string>
            //return View(lista);
            //---------------------------------------------------

            var lista = new List<TodoItem>();
            lista.Add(new TodoItem() { Name = "Só", Done = true});
            lista.Add(new TodoItem() { Name = "Cukor", Done = true });
            lista.Add(new TodoItem() { Name = "Spagetti", Done = true });
            lista.Add(new TodoItem() { Name = "Marhahús", Done = false });
            lista.Add(new TodoItem() { Name = "Paradicsom", Done = false });

            return View(lista);
        }
    }
}