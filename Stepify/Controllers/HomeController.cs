using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Stepify.Models;

namespace Stepify.Controllers
{
    public class HomeController : Controller
    {
        // I added this.
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Login()
        {
            return View();
        }

        public IActionResult Register()
        {
            return View();
        }

        public IActionResult UserDashboard()
        {
            return View();
        }

        public IActionResult AdminDashboard()
        {
            return View();
        }

        public IActionResult CourseDetail()
        {
            return View();
        }

        public IActionResult CourseSteps()
        {
            return View();
        }

        public IActionResult CreateCourse()
        {
            return View();
        }

        public IActionResult PaymentDetail()
        {
            return View();
        }

        public IActionResult UserProfileForm()
        {
            return View();
        }

        public IActionResult SearchResults()
        {
            return View();
        }
    }
}
