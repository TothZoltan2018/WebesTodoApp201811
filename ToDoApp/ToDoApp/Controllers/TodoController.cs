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
        public ActionResult Create()  //lekerjuk az urlapot
        {
            return View();
        }

        [HttpPost]//annotacio. A routing innentol csak a POST keresek eseten iranyit ide
        public ActionResult Create(string name, bool isDone)
        {
            if (!string.IsNullOrEmpty(name))
            {//Ha van adat a parameterben
                //adatok mentese es vissza az indexre
                //Ez nem jo, mert ha torlok a listabol, akkor onnantol ez duplazni fogja az Id-kat
                //var maxId = MyDb.Lista.Count;

                var maxId = MyDb.Lista.Max(x => x.Id);
                MyDb.Lista.Add(new TodoItem() { Id = maxId+1, Name = name, Done = isDone });

                return RedirectToAction("Index");
            }

            //todo: mivel a adat nem valid, itt kene a hibauzenettel valamit kezdeni
            //(kiadni az ugyfel fele)
            return View();
        }

        /// <summary>
        /// Az action feladata az adott elem megjelenitese modositasra.
        /// Azomositas ID alapjan.
        /// </summary>
        /// <param name="id">a modositando tetel azonositoja</param>
        /// <returns></returns>
        [HttpGet] //lekerjuk az urlapot
        public ActionResult Edit(int id)
        {
            //elo kell keresni az adott elemet
            //MyDb.Lista.Where(x=>x.Id == id); //Olyan lista lesz, amin csak az id-nak megfelelo elemek vannak, azaz 1 db.
            
            //csak, ha garantalni tudom, hogy egyetlen elem van ilyen, amugy exception!
            var item = MyDb.Lista.Single(x =>x.Id == id);

            //Ha nem garantalhato, akkor: (ha nincs ilyen elem, akkor null-lal ter vissza. Kivetelt ez is dob, ha tobb talalat van)
            //var item = MyDb.Lista.SingleOrDefault(x => x.Id == id);

            //Ezt az elemet kell modositanunk, atadjuk az Edit.cshtml-nek
            return View(item);
        }
        
        [HttpPost]
        public ActionResult Edit(int id, string name, bool done) 
        //public ActionResult Edit(TodoItem item) // nem jon vissza adat a view-bol
        {
            //a modositott elem kikeresese
            var item = MyDb.Lista.Single(x => x.Id == id);
            //A modositasok vegrehajtasa
            item.Name = name;
            item.Done = done;
            return RedirectToAction("Index");            
        }

        [HttpGet]
        public ActionResult Delete(int id)
        {
            var item = MyDb.Lista.Single(x => x.Id == id);
            return View(item);
        }

        [HttpPost]
        public ActionResult DeleteConfirmed(int id)
        {
            var item = MyDb.Lista.Single(x => x.Id == id); 
            MyDb.Lista.Remove(item);
            return RedirectToAction("Index");             
        } 
    }
} 