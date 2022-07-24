using Microsoft.AspNetCore.Mvc;
using Project_Cenima.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project_Cenima.Controllers
{
    public class AdminController : Controller
    {

        private readonly CenimaDBContext db;
        public AdminController(CenimaDBContext _context)
        {
            db = _context;
        }
        public IActionResult Index()
        {
            var ra = db.Rates.ToList();
            ViewBag.Rat = ra;
            return View();
        }
    }
}
