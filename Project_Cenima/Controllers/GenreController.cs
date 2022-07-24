using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Project_Cenima.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project_Cenima.Controllers
{
    public class GenreController : Controller
    {
        private readonly CenimaDBContext db;
        public GenreController(CenimaDBContext _context)
        {
            db = _context;
        }
        public IActionResult Index()
        {
            var g = db.Genres.ToList();
            ViewBag.listG = g;
            return View();
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View("Create");
        }
        [HttpPost]
        public ActionResult Create(Genre m)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            db.Genres.Add(m);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult Edit(int id)
        {
            Genre m = db.Genres.FirstOrDefault(p => p.GenreId == id);
            if (m == null)
            {
                return View();
            }
            return View("Edit", m);
        }
        [HttpPost]
        public ActionResult Edit(Genre m)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            db.Entry<Genre>(m).State = EntityState.Modified;

            db.SaveChanges();
            return RedirectToAction("Index");
        }


        [HttpGet]
        public ActionResult Delete(int id)
        {
            var per = db.Genres.Where(m => m.GenreId == id).FirstOrDefault();
            if (per == null)
            {
                return View();
            }
            return View("Delete", per);
        }
        [HttpPost]
        public ActionResult Delete(Genre m)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            var gen = db.Genres.Where(m => m.GenreId == m.GenreId).FirstOrDefault();
            db.Genres.Remove(m);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
