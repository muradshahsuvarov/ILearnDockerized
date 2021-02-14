using System;
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
using Microsoft.EntityFrameworkCore;
using ILearnCoreV19.Models;

namespace ILearnCoreV19.Controllers
{
    public class UserController : Controller
    {
        public readonly SignInManager<ApplicationUser> _signInManager; // Application's cookie is managed in Sign In Manager
        public readonly ILogger<LogoutModel> _logger; // Is needed for creating Logs in the Controller
        public readonly AuthDbContext _context;

        public readonly UserManager<ApplicationUser> _userManager; // Needed for SignalR

        public UserController(SignInManager<ApplicationUser> signInManager, ILogger<LogoutModel> logger, AuthDbContext context, UserManager<ApplicationUser> userManager)
        {
            _signInManager = signInManager;
            _logger = logger;
            _context = context;
            _userManager = userManager;
        }

        public IActionResult Index()
        {
            ViewBag.NumberOfNotifs = GetTotalNumOfNotifs();

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
            var events = _context.Events.Where(r => r.userId == id && r.status == "AVAILABLE" && r.start_date >= DateTime.Now).ToList();

            return View(events);
        }

        [HttpPost]
        [Authorize]
        public IActionResult Subscribe(string userName, int? eventId, string email, string returnUrl) // eventID - id of the event to which user with email wants to subscribe.  // Done by the student
        {
            System.Diagnostics.Debug.WriteLine("userName: " + userName);
            System.Diagnostics.Debug.WriteLine("EventId: " + eventId);
            System.Diagnostics.Debug.WriteLine("SubscriberEmail: " + email);
            System.Diagnostics.Debug.WriteLine("ReturnUrl: " + returnUrl);

            // For saving the changed event

            var targetEvent = (from e in _context.Events
                               where e.EventId == eventId
                               select e).Single();


            targetEvent.status = "PENDING";
            targetEvent.subscriberEmail = email;

            ApplicationNotif notif = new ApplicationNotif();
            notif.UserName = userName;
            notif.Header = "New subject request";
            notif.Body = email + " sent a request for " + targetEvent.text;
            notif.CreatedAt = DateTime.Now;
            notif.IsRead = false;

            _context.Notif.Add(notif);

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
                            where e.subscriberEmail == User.Identity.Name && e.status == "ACCEPTED" && e.start_date >= DateTime.Now
                            select e).ToList();

            return View(targetEvents);
        }

        [HttpGet]
        [Authorize]
        public IActionResult GetSearchedSubjects(string? name)
        {
            List<ApplicationEvent> targetEvents = new List<ApplicationEvent>();

            targetEvents = (from e in _context.Events
                            where (e.text.Contains(name) || e.description.Contains(name)) && e.status == "AVAILABLE" && e.start_date >= DateTime.Now
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

        // User who you chose to see a message history with.


        public int GetTotalNumOfNotifs()
        {
            var notifs = (from e in _context.Notif
                          where e.UserName == User.Identity.Name && e.IsRead != true
                          select e).ToList();

            return notifs.Count;
        }

        // Async to get messages asynchronously
        public async Task<IActionResult> OpenChat()
        {
            var currentUser = await _userManager.GetUserAsync(User); // Added by MS
            if (User.Identity.IsAuthenticated)
            {
                ViewBag.CurrentUserName = User.Identity.Name;
                ViewBag.NumberOfNotifs = GetTotalNumOfNotifs();
            }
            var messages = await _context.Messages.Where(r => r.UserName == User.Identity.Name || r.ReceiverName == User.Identity.Name).ToListAsync(); // Added by MS    
            return View(messages);
        }

        [HttpGet]
        public ActionResult ReloadOpenChat([FromQuery(Name = "selectedUser")] string selectedUser)
        {

            return Redirect("http://localhost:59000?selectedUser=" + selectedUser);
        }

        public IActionResult GetAllNotifs()
        {
            var notifs = (from e in _context.Notif
                          where e.UserName == User.Identity.Name
                          select e).ToList();

            foreach (var item in notifs)
            {
                item.IsRead = true;
            }

            _context.SaveChanges();

            return View(notifs);
        }
        // Is assigned once you clicked on him on the right panel. Get From query param

        public async Task<IActionResult> CreateMessage(ApplicationMessage message, String selectedUser)
        {
            if (ModelState.IsValid)
            {
                message.UserName = User.Identity.Name;
                message.ReceiverName = selectedUser;
                var sender = await _userManager.GetUserAsync(User);
                message.UserID = sender.Id;

                ApplicationNotif notif = new ApplicationNotif();
                notif.UserName = selectedUser;
                notif.Header = User.Identity.Name + " sent a message";
                notif.Body = message.Text;
                notif.CreatedAt = DateTime.Now;
                notif.IsRead = false;

                await _context.Notif.AddAsync(notif);
                await _context.Messages.AddAsync(message);
                await _context.SaveChangesAsync();
                Trace.WriteLine("Data is saved into the database");
                return Ok();
            }

            Trace.WriteLine("Data is not saved into the database");
            return Error();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
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
            ViewBag.NumberOfNotifs = GetTotalNumOfNotifs();
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