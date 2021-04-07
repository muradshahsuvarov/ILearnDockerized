using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ILearnCoreV19.Models;
using Microsoft.AspNetCore.Authorization;
using ILearnCoreV19.Data;
using System.Linq;
using ILearnCoreV19.Areas.Identity.Data;
using System.Collections.Generic;

namespace ILearnCoreV19.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private AuthDbContext _context;

        /*
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        } */

        public HomeController(AuthDbContext _context)
        {
            this._context = _context;
        }

        // Getting user from the database
        public ApplicationUser GetUser(string email)
        {
            var user = (from e in _context.Users
                        where e.Email == email
                        select e).Single();
            return user;
        }

        public IActionResult Index()
        {
            if (User.Identity.IsAuthenticated)
            {
                return RedirectToAction("MyProfile", "User");
            }

            if (User.Identity.IsAuthenticated)
            {
                return View();
            }
            else
            {
                return View();
            }

        }


        public IActionResult GetLoginForm()
        {
            string url = "~/Identity/Account/Login";

            return Redirect(url);
        }

        public IActionResult GetRegisterForm()
        {
            string url = "~/Identity/Account/Register";

            return Redirect(url);
        }

        public IActionResult GetUsers()
        {
            List<ApplicationUser> users = (from e in _context.Users
                                           select e).ToList();
            return View(users);
        }
        public IActionResult Privacy()
        {

            var user = (from e in _context.Users
                        where e.Email == User.Identity.Name
            select e).Single();


            return View(user);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        [HttpGet]
        public IActionResult About()
        {
            ApplicationUser user = (from e in _context.Users
                                    where e.Email == User.Identity.Name
                                    select e).Single();

            return View(user);
        }

        [HttpGet]
        [Authorize]
        public IActionResult Services()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Contact()
        {
            return View();
        }

        [HttpGet]
        [Authorize]
        public IActionResult myApplications()
        {
            return View();
        }
    }
}
