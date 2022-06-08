using Microsoft.AspNetCore.Mvc;
using SmartMeter.Data;
using SmartMeter.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartMeter.Controllers
{
    public class LoginController : Controller
    {

        private readonly ApplicationDbContext _db;


        public LoginController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            IEnumerable<Login> objList = _db.Login;
            return View(objList);
        }
        //Get -signup
        public IActionResult Signup()
        {
            return View();
        }
        //POST -signup
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Signup(Signup obj)
        {
            _db.Signup.Add(obj);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

        //Get -forgotpassword
        public IActionResult FgPassword()
        {
            return View();
        }
    }
}
