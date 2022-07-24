using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Project_Cenima.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project_Cenima.Controllers
{
    public class PersonsController : Controller
    {
        private readonly CenimaDBContext db;
        public PersonsController(CenimaDBContext _context)
        {
            db = _context;
        }
       
        public IActionResult Index()
        {
            List<Person> listP = db.Persons.ToList();
            //var listG = db.Genres.Select(p => p.Description).ToList();
            
            ViewBag.listP = listP;
            return View();
        }
        [HttpGet]
        public ActionResult Edit(int id)
        {
            Person m = db.Persons.FirstOrDefault(p => p.PersonId == id);
            if (m == null)
            {
                return View();
            }
            return View("Edit", m);
           
        }
        [HttpPost]
        public ActionResult Edit(Person p)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            //db.Entry<Person>(p).State = EntityState.Modified;
            db.Persons.Update(p);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View("Create");
        }
        [HttpPost]
        public ActionResult Create(Person m)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            db.Persons.Add(m);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Delete(int id)
        {
            var p = db.Persons.Where(m => m.PersonId == id).FirstOrDefault();
            if (p == null)
            {
                return View();
            }
            return View("Delete", p);
        }
        [HttpPost]
        public ActionResult Delete(Person pt)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            
            db.Persons.Remove(pt);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
