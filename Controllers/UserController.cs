﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ILearnCoreV19.Areas.Identity.Data;
using ILearnCoreV19.Areas.Identity.Pages.Account;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ILearnCoreV19.Data;
using Microsoft.AspNetCore.Http;
using System.Diagnostics;

namespace ILearnCoreV19.Controllers
{
    public class UserController : Controller
    {
        private readonly SignInManager<ApplicationUser> _signInManager; // Application's cookie is managed in Sign In Manager
        private readonly ILogger<LogoutModel> _logger; // Is needed for creating Logs in the Controller
        private AuthDbContext _context;

        public UserController(SignInManager<ApplicationUser> signInManager, ILogger<LogoutModel> logger, AuthDbContext context)
        {
            _signInManager = signInManager;
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        // For logging out the user
        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();

            _logger.LogInformation("User logged out.");
            return RedirectToAction("Index", "Home");


        }

        [HttpGet]
        [Authorize]
        public IActionResult ListOfUsers()
        {
            var users = from e in _context.Users
                        orderby e.Email
                        select e;
            return View(users);
        }


        [HttpGet]
        [Authorize]
        public IActionResult ListOfEvents(string id)
        {
            var events = _context.Events.Where(r => r.userId == id && r.status == "AVAILABLE").ToList();

            return View(events);
        }

        [HttpPost]
        [Authorize]
        public IActionResult Subscribe(int? eventId, string email, string returnUrl) // eventID - id of the event to which user with email wants to subscribe.  // Done by the student
        {
            System.Diagnostics.Debug.WriteLine("EventId: " + eventId);
            System.Diagnostics.Debug.WriteLine("SubscriberEmail: " + email);
            System.Diagnostics.Debug.WriteLine("ReturnUrl: " + returnUrl);

            // For saving the changed event

            var targetEvent = (from e in _context.Events
                               where e.EventId == eventId
                               select e).Single();

            targetEvent.status = "PENDING";
            targetEvent.subscriberEmail = email;

            _context.SaveChanges();
            _context.Dispose();

            return Redirect(returnUrl);
        }

        [HttpPost]
        [Authorize]
        public IActionResult AcceptSubscription(int? eventId, string returnUrl) // Done by the tutor
        {
            System.Diagnostics.Debug.WriteLine("EventId: " + eventId);
            System.Diagnostics.Debug.WriteLine("ReturnUrl: " + returnUrl);

            var targetEvent = (from e in _context.Events
                               where e.EventId == eventId && e.status == "PENDING"
                               select e).Single();

            targetEvent.status = "ACCEPTED";
            _context.SaveChanges();

            return Redirect(returnUrl);
        }

        [HttpPost]
        [Authorize]
        public IActionResult RejectSubscription(int? eventId, string returnUrl) //  // Done by the student
        {
            System.Diagnostics.Debug.WriteLine("EventId: " + eventId);
            System.Diagnostics.Debug.WriteLine("ReturnUrl: " + returnUrl);


            var targetEvent = (from e in _context.Events
                               where e.EventId == eventId && e.status == "PENDING"
                               select e).Single();

            targetEvent.status = "AVAILABLE";
            targetEvent.subscriberEmail = String.Empty;
            _context.SaveChanges();

            return Redirect(returnUrl);
        }

        [HttpGet]
        [Authorize]
        public IActionResult GetApplications()
        {
            List<ApplicationEvent> targetEvents = new List<ApplicationEvent>();

            targetEvents = (from e in _context.Events
                            where e.subscriberEmail == User.Identity.Name && e.status == "ACCEPTED"
                            select e).ToList();

            return View(targetEvents);
        }

        [HttpGet]
        [Authorize]
        public IActionResult GetTutorClasses()
        {

            List<ApplicationEvent> targetEvents = new List<ApplicationEvent>();

            var user = (from e in _context.Users
                        where e.Email == User.Identity.Name
                        select e).Single();

            targetEvents = (from e in _context.Events
                            where e.userId == user.Id && e.start_date >= DateTime.Now && e.status == "ACCEPTED"
                            select e).ToList();

            return View(targetEvents);
        }

        [HttpGet]
        [Authorize]
        public IActionResult GetTutorDashboard()
        {
            var tutor = (from t in _context.Users
                         where t.Email == User.Identity.Name && t.Role == "Tutor"
                         select t).Single();

            // TODO
            // Instantiate dashboard for the tutor
            // Return it in View

            return View();
        }

        [HttpGet]
        [Authorize]
        public IActionResult ListOfTutorEvents()
        {
            // Getting events which belong to the user with userId == userID
            var events = _context.Events.Where(r => r.userId == User.Identity.Name && r.status == "PENDING").ToList();

            return View(events);
        }


        [HttpGet]
        [Authorize]
        public IActionResult Teachers()
        {

            List<ApplicationUser> teachers = (from e in _context.Users
                           where e.Role == "Tutor"
                           select e).ToList();
            return View(teachers);
        }


        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(ApplicationUser usr)
        {
            try
            {
                _context.Users.Add(usr);
                _context.SaveChanges();
                return RedirectToAction("ListOfUsers");
            }
            catch (Exception)
            {

                return View();
            }
        }


        // GET: User/Edit/5
        [HttpGet]
        public IActionResult Edit()
        {
            string emailID = User.Identity.Name;


            var user = (from e in _context.Users
                        where e.Email == emailID
                        select e).Single();

            return View(user);
        }

        //Registration Action
        [HttpGet]
        public ActionResult Registration()
        {
            return View();
        }

        //Login 
        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }

        [HttpGet]
        [Authorize]
        public IActionResult MyProfile()
        {
            /*
            string emailID = User.Identity.Name;


            var user = (from e in _context.Users
                        where e.Email == emailID
                        select e).Single(); */

            // To parse the authenticated user's with his ID
            /* var userWithId = (from e in db.Users
                              where e.UserID == user.UserID
                              select e).Single(); */

            return View(_context);
        }

        [HttpGet]
        [Authorize]
        public IActionResult GetTutorSchedule()
        {
            var user = (from e in _context.Users
                        where e.Email == User.Identity.Name
                        select e).Single();

            return View(user);
        }

        [HttpGet]
        [Authorize]
        public IActionResult GetStudentSchedule()
        {

            return View(_context);
        }



        // Get authenticated user
        public ApplicationUser getAuthenticatedUser()
        {
            string emailID = User.Identity.Name;

            ApplicationUser authenticatedUser = (from e in _context.Users
                                                 where e.Email == emailID
                                                 select e).Single();

            return authenticatedUser;
        }


        // --------------IMPLEMENT CALENDAR METHODS AGAIN--------------------------------
        // GetEvents
        public JsonResult GetEvents()
        {
                List<ApplicationEvent> events = (from e in _context.Events
                              where e.userId == getAuthenticatedUser().UserName
                              select e).ToList();

                // To see the subjects assigned to the teacher
                foreach (var item in events)
                {
                    Debug.WriteLine("LOG: " + item.text);
                }

                return new JsonResult(events);
        }

        // SaveEvent
        [HttpPost]
        public JsonResult SaveEvent(ApplicationEvent e)
        {

                if (e.EventId > 0)
                {
                    //Update the event
                    var v = _context.Events.Where(a => a.EventId == e.EventId).FirstOrDefault();

                if (v != null)
                    {
                        v.text = e.text;
                        v.start_date = e.start_date;
                        v.end_date = e.end_date;
                        v.description = e.description;
                        v.ThemeColor = e.ThemeColor;
                        v.isFullDay = e.isFullDay;


                        Debug.WriteLine("here 1");
                    }
                }
                else
                {
                    Debug.WriteLine("here 2");

                    e.userId = getAuthenticatedUser().UserName;
                    if (e.isFullDay == true)
                    {
                        e.end_date = null;
                    }
                    e.status = "AVAILABLE";

                    _context.Events.Add(e);
                }

                Debug.WriteLine($"EventId: {e.EventId}");
                Debug.WriteLine($"Text: {e.text}");
                Debug.WriteLine($"Status: {e.status}");
                Debug.WriteLine($"Start: {e.start_date}");
                Debug.WriteLine($"End: {e.end_date}");
                Debug.WriteLine($"ThemeColor: {e.ThemeColor}");
                Debug.WriteLine($"Description: {e.description}");
                Debug.WriteLine($"IsFullDay: {e.isFullDay}");

            _context.SaveChanges();

            return new JsonResult("\"STATUS\": INSERTED");
        }
        // DeleteEvent
        [HttpPost]
        public JsonResult DeleteEvent(int eventID)
        {
            var status = false;

            Debug.WriteLine($"eventID: {eventID}");

                var v = _context.Events.Where(a => a.EventId == eventID).FirstOrDefault();
                if (v != null)
                {
                    _context.Events.Remove(v);
                    _context.SaveChanges();
                    status = true;
                }

            Debug.WriteLine($"status: {status}");

            return new JsonResult(status);
        }
        // --------------IMPLEMENT CALENDAR METHODS AGAIN--------------------------------



        [HttpGet]
        [Authorize]
        public IActionResult GetDetails(string id)
        {


            var user = (from e in _context.Users
                        where e.Id == id
                        select e).Single();

            return View(user);
        }


    }
}