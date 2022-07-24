using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Project_Cenima.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Project_Cenima.Controllers
{
    public class HomeController : Controller
    {
        private readonly CenimaDBContext db;
        public HomeController(CenimaDBContext _context)
        {
            db = _context;
        }
        //[BindProperty]
        //public Person Person { get; set; }
       
        
        public IActionResult Index(string search)
        {

            var listMovie = db.Movies.ToList();
            if(search != null)
            {
                listMovie = db.Movies.Where(p => p.Title.Contains(search)).ToList();
            }
            var listGenres = db.Genres.ToList();
            var listRate = db.Rates.ToList();
            foreach (var item in listMovie)
            {
                item.Genre = db.Genres.Where(x => x.GenreId == item.GenreId).FirstOrDefault();
            }
            //var type = "1";
            //HttpContext.Session.SetString("type",type);
            //ViewBag.IsAdmin = HttpContext.Session.GetString("type");
            //int b = ViewBag.a;
            //Person m = db.Persons.Where(n => n.PersonId == b).FirstOrDefault();
            //ViewBag.name=m;
            ViewBag.Id = HttpContext.Session.GetInt32("Id");
            ViewBag.Movie = listMovie;
            ViewBag.Genre = listGenres;
            ViewBag.Rate = listRate;
            return View();
        }

        public ActionResult Detail(int id)
        {
            int count = 0;
            float sum = 0;

            var IMovie = db.Movies.Include(p => p.Genre).Where(n => n.MovieId == id).FirstOrDefault();
            var ARate = db.Rates.Include(p => p.Person).Where(n => n.MovieId == id).ToList();
            var IRate = db.Rates.ToList();
            var IPerson = db.Persons.ToList();
            var IGenre = db.Genres.ToList();
            var Log = db.Persons.Select(p => p.Type).FirstOrDefault();
            //var t = IPerson.GroupBy(n => n.Type).ToList();
            //List<Person>LPerson= db.Persons.ToList();
            //count = db.Rates.Where(n => n.MovieId == 1).Count();
            //var m = db.Rates.Where(n => n.MovieId == 1).ToList();
            foreach (var item in IGenre)
            {
                if (IMovie.GenreId == item.GenreId)
                {
                    IMovie.Genre = item;
                }
            }
            foreach (var item in IRate)
            {
                if (item.MovieId == id)
                {
                    sum += (float)item.NumericRating;
                    count++;
                }
            }
            ViewBag.Id = HttpContext.Session.GetInt32("Id");
            double m = sum / count;
            double a = Math.Round(m, 2);
            ViewBag.numberRate = a;
            ViewBag.Movie = IMovie;
            ViewBag.Rate = IRate;
            ViewBag.Person = IPerson;
            ViewBag.ARate = ARate;
            ViewBag.ILog = Log;
            return View();

        }
        [HttpPost]
        public ActionResult Comment(Rate rate)
        {
            if (!ModelState.IsValid)
            {

                return View();
            }
            db.Rates.Add(rate);
            db.SaveChanges();
            return View("Detail");
        }
        public ActionResult Genre(int id)
        {
            var ListMovie = db.Movies.Where(p=>p.GenreId==id).ToList();
            var listGenres = db.Genres.ToList();
            var listRate = db.Rates.ToList();
            foreach (var item in ListMovie)
            {
                item.Genre = db.Genres.Where(x => x.GenreId == item.GenreId).FirstOrDefault();
            }
            ViewBag.Id = HttpContext.Session.GetInt32("Id");
            ViewBag.Movie = ListMovie;
            ViewBag.Genre = listGenres;
            ViewBag.Rate = listRate;
            return View();
        }


        

        [HttpGet]
        public ActionResult Register()
        {
            return View("Register");
        }
        [HttpPost]
        public ActionResult Register(Person person)
        {
            if (ModelState.IsValid)
            {
            var check = db.Persons.FirstOrDefault(e => e.Email == person.Email);
            if (check == null)
            {
                    db.Persons.Add(person);
                    db.SaveChanges();
                    if (HttpContext.Session.GetInt32("Id") == null)
                    {
                        HttpContext.Session.SetInt32("Id", person.PersonId);
                    }
                    return RedirectToAction("Index");
            }
            else
            {
                ViewBag.error = "Email exists";
                return View();
            }
          
            }
             return View();
        }
        public ActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Login()
        {
            return View("Login");
        }

        [HttpPost]
        public ActionResult Login(Person person)
        {
          
                
          
            var per = db.Persons.Where(p => p.Email == person.Email && p.Password == person.Password ).FirstOrDefault();
           


            if (per == null)
            {
                ViewBag.mess = "on";
                return View();
            }

            if (per.IsActive == false)
            {
                ViewBag.block = "on";
                return RedirectToAction("Login");
            }
            
            //Person p = db.Persons.Where(n => n.PersonId == HttpContext.Session.GetInt32("Id")).FirstOrDefault();
            //HttpContext.Session.SetString("FullName", person.Fullname);
            //if (HttpContext.Session.GetString("FullName") == null)
            //{
            //    HttpContext.Session.SetString("FullName", person.Fullname); 
            //}

            //ViewBag.name = HttpContext.Session.GetString("FullName");


            if (HttpContext.Session.GetInt32("Id") == null)
            {
                HttpContext.Session.SetInt32("Id", person.PersonId);
            }
            //int a= Convert.ToInt32(HttpContext.Session.GetInt32("Id"));
            //ViewBag.id = a;
            if (per.Type == 1)
            {
                ViewBag.login = "on";
                return Redirect("/Movie/Index");
            }

            return RedirectToAction("Index");
           
        }

        
    }

}
