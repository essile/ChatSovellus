using ChatSovellus.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Web;
using System.Web.Mvc;
using System.Text;

namespace ChatSovellus.Controllers
{
    public class HomeController : Controller
    {
        ChatDBModel db = new ChatDBModel();

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

        public ActionResult LuoUusi()
        {

            return View();
        }

        [HttpPost]
        public ActionResult LuoUusi([Bind(Include ="nickname, hometown, description, password")] Person person )
        {
            person.RegistrationDate = DateTime.Now;
            int? hash = GetHashCode(person.Password);
            person.PasswordHash = hash;
            person.Password = "";

            if(ModelState.IsValid)
            {
                db.Person.Add(person);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View();
        }

        public int? GetHashCode(string password)
        {
            MD5 md5 = MD5.Create();
            byte[] inputBytes = Encoding.ASCII.GetBytes(password);
            byte[] hash = md5.ComputeHash(inputBytes);

            int? hashCode = Math.Abs(BitConverter.ToInt32(hash, 0));

            return hashCode;
        }
    }
}