using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ToDoApp.Models;

namespace ToDoApp.Controllers
{
    public class AircraftController : Controller
    {
        DbAircraft dbAircaft = new DbAircraft();
        
        // GET: Aircraft
        public ActionResult Index()
        { 
            return View(dbAircaft.AirCrafts.ToList());
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(string type, Roles role, int crew, int range, int speed, int load, bool stealth)
        {
            if (!string.IsNullOrEmpty(type))
            {
                dbAircaft.AirCrafts.Add(new Aircraft { Type = type, Role = role, Crew = crew, Range = range, Speed = speed, Load = load, Stealth = stealth });

                dbAircaft.SaveChanges();
                return RedirectToAction("Index");
            }
                return View();            
        }

        public ActionResult Details(int id)
        {
            var item = dbAircaft.AirCrafts.Single(x => x.Id == id);
            return View(item);
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            var item = dbAircaft.AirCrafts.Single(x => x.Id == id);
            return View(item);
        }

        [HttpPost]
        public ActionResult Edit(int id, string type, Roles role, int crew, int range, int speed, int load, bool stealth)
        {
            var item = dbAircaft.AirCrafts.Single(x => x.Id == id);
            item.Type = type;
            item.Role = role;
            item.Crew = crew;
            item.Range = range;
            item.Speed = speed;
            item.Load = load;
            item.Stealth = stealth;

            dbAircaft.SaveChanges();
            return RedirectToAction("Index");            
        }

        [HttpGet]
        public ActionResult Delete(int id)
        {
            var item = dbAircaft.AirCrafts.Single(x => x.Id == id);
            return View(item);
        }

        public ActionResult DeleteConfirmed(int id)
        {
            var item = dbAircaft.AirCrafts.Single(x => x.Id == id);
            dbAircaft.AirCrafts.Remove(item);
            dbAircaft.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}