using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplicationMvc.Models;

namespace WebApplicationMvc.Controllers
{
    public class RegisterController : Controller
    {
       
        public List<string> test = new List<string>();
        // GET: Register
        public ActionResult AddUser()

        {
            
            User user = new User();
            return View(user);
        }
        [HttpPost]
        public ActionResult AddUser(User user)
        {
            DbModel context = new DbModel();
            context.Users.Add(user);
            context.SaveChanges();
            ModelState.Clear();
            ViewBag.Message = "Successfully registered";
            return View();
        }
       
        public ActionResult AllUsers() 
        {
            return View();
        }
    }
}