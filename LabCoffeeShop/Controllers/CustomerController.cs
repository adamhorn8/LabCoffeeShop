using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace LabCoffeeShop.Controllers
{
    public class CustomerController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }
		public IActionResult Register()
        {
            return View();
        }
		public IActionResult RegisterSuccess(string firstName, string lastName, string email, string number, string password)
        {
            ViewBag.firstName = firstName;
            ViewBag.lastName = lastName;
            ViewBag.email = email;
			ViewBag.number = number;
			ViewBag.password = password;
            return View();
        }
		public IActionResult Login()
        {
            return View();
        }
    }
}
