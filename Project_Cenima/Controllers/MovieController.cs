using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Project_Cenima.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project_Cenima.Controllers
{
    public class MovieController : Controller
    {

        private readonly CenimaDBContext db;
        public MovieController(CenimaDBContext _context)
        {
            db = _context;
        }
        public IActionResult Index()
        {
            List<Movie> listM = db.Movies.Include(m=> m.Genre).ToList();
            var listG = db.Genres.Select(p => p.Description).ToList();
            ViewBag.listM = listM;
            ViewBag.listG = listG;
            return View();
        }
        [HttpGet]
        public ActionResult Edit(int id)
        {
            Movie m = db.Movies.FirstOrDefault(p => p.MovieId == id);
            if (m == null)
            {
                return View();
            }
            return View("Edit",m);
        }
        [HttpPost]
        public ActionResult Edit(Movie m)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            db.Entry<Movie>(m).State = EntityState.Modified;

            db.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View("Create");
        }
        [HttpPost]
        public ActionResult Create(Movie m)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            
            db.Movies.Add(m);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult Delete(int id)
        {
            var movie = db.Movies.Where(m => m.MovieId == id).FirstOrDefault();
            if (movie == null)
            {
                return View();
            }
            return View("Delete",movie);
        }
        [HttpPost]
        public ActionResult Delete(Movie m)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            var movie = db.Movies.Where(m => m.MovieId == m.GenreId).FirstOrDefault();
            db.Movies.Remove(m);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
