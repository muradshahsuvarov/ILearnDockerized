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
using Stripe;
using System.Net.Mail;
using System.Net;
using System.Security.Cryptography.X509Certificates;
using System.Net.Security;
using static ILearnCoreV19.Areas.Identity.Pages.Account.LoginModel;
using System.Security.Claims;

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
            var myProfile = _context.Users.Where(u => u.Email == User.Identity.Name).Single();
            if (myProfile.Role == null)
            {
                return RedirectToAction("ModifyProfile","User");
            }
            return View();
        }

        [Authorize]
        [HttpGet]
        public IActionResult ModifyProfile()
        {
            var myProfileUser = _context.Users.Where(u => u.Email == User.Identity.Name).Single();
            return View(myProfileUser);
        }

        [AllowAnonymous]
        [HttpPost]
        public IActionResult ExternalLogin(string provider, string returnUrl)
        {
            var redirectUrl = Url.Action("ExternalLoginCallback", "User", new { ReturnUrl = returnUrl });

            var properties = _signInManager.ConfigureExternalAuthenticationProperties(provider, redirectUrl);

            return new ChallengeResult(provider, properties);
        }

         // Complete after documentation
        [AllowAnonymous]
        public async Task<IActionResult> ExternalLoginCallback(string returnUrl = null, string remoteError = null)
        {
            returnUrl = returnUrl ?? Url.Content("~/");

            InputModel inputModel = new InputModel
            {
                ReturnUrl = returnUrl,
                ExternalLogins = (await _signInManager.GetExternalAuthenticationSchemesAsync()).ToList()
            };

            if (remoteError != null)
            {
                ModelState.AddModelError(string.Empty, $"Error from external provider: {remoteError}");

                return View("Login", inputModel);
            }

            var info = await _signInManager.GetExternalLoginInfoAsync();
            if (info == null)
            {
                ModelState.AddModelError(string.Empty, "Error loading external login information.");

                return View("Login", inputModel);
            }

            var signInResult = await _signInManager.ExternalLoginSignInAsync(info.LoginProvider,
                info.ProviderKey, isPersistent: false, bypassTwoFactor: true);

            if (signInResult.Succeeded)
            {
                return LocalRedirect(returnUrl);
            }
            else
            {
                var email = info.Principal.FindFirstValue(ClaimTypes.Email);

                if (email != null)
                {
                    var user = await _userManager.FindByEmailAsync(email);

                    if (user == null)
                    {
                        user = new ApplicationUser
                        {
                            UserName = info.Principal.FindFirstValue(ClaimTypes.Email),
                            Email = info.Principal.FindFirstValue(ClaimTypes.Email),
                            FirstName = info.Principal.FindFirstValue(ClaimTypes.GivenName),
                            LastName = info.Principal.FindFirstValue(ClaimTypes.Surname)
                        };

                        await _userManager.CreateAsync(user);
                    }

                    await _userManager.AddLoginAsync(user, info);
                    await _signInManager.SignInAsync(user, isPersistent: false);

                    return LocalRedirect(returnUrl);
                }

                ViewBag.ErrorTitle = $"Email claim not received from: {info.LoginProvider}";
                ViewBag.ErrorMessage = $"Please contact support on jamessmith19098@gmail.com";

                return View("Error");
            }

            return View("Login", inputModel);
        } 

        [Authorize]
        public IActionResult SubscriptionPage()
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
        public IActionResult SUsers()
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


        [HttpGet]
        [Authorize]
        public IActionResult AddPaypal()
        {
            var myUser = _context.Users.Where(e => e.Email == User.Identity.Name).Single();
            return View(myUser);
        }

        [HttpPost]
        [Authorize]
        public IActionResult AddPaypalAccount(string paypal_email) // Email has to be business paypall mail
        {
            var myUser = (from e in _context.Users
                          where e.Email == User.Identity.Name
                          select e).Single();
            myUser.Paypal = paypal_email;
            _context.SaveChanges();
            Trace.WriteLine($"Paypal: {myUser.Paypal} added");
            return Redirect("/User/AddPaypal");
        }

        [HttpPost]
        [Authorize]
        public IActionResult ModifyAccount(string user_role) // Email has to be business paypall mail
        {
            var myUser = (from e in _context.Users
                          where e.Email == User.Identity.Name
                          select e).Single();
            myUser.Role = user_role;
            _context.SaveChanges();
            Trace.WriteLine($"Role: {myUser.Role} added");
            return RedirectToAction("Index","Home");
        }


        public void SendEmail(string to, string from, string password, string subject, string body)
        {

            MailMessage mailMessage = new MailMessage();
            mailMessage.To.Add(to);
            mailMessage.Subject = subject;
            mailMessage.Body = body;
            mailMessage.From = new MailAddress(from);
            mailMessage.IsBodyHtml = true;
            SmtpClient smtp = new SmtpClient("smtp.gmail.com");
            smtp.Port = 587;
            smtp.UseDefaultCredentials = true;
            smtp.EnableSsl = true;
            smtp.Credentials = new NetworkCredential(from, password);
            ServicePointManager.ServerCertificateValidationCallback =
                delegate (
                    object s,
                    X509Certificate certificate,
                    X509Chain chain,
                    SslPolicyErrors sslPolicyErrors
                ) {
                    return true;
                };
            smtp.Send(mailMessage);
            Trace.WriteLine($"Message has been sent from {from} to {to}");
        }


        [HttpPost]
        [Authorize]
        public IActionResult ActivateSubscription(string userName, int subscriptionID, int days)
        {
            var subscription = (from s in _context.Subscriptions
                                 where s.UserName == userName && s.Id == subscriptionID
                                 select s).Single();

            subscription.IsActivated = true;
            subscription.StartDate = DateTime.Now;
            subscription.EndDate = DateTime.Now.AddDays(days);

            _context.SaveChanges();
            _context.Dispose();

            return Redirect("/User/GetTotalNumOfSubscriptions");
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
                var subscriber = _context.Users.Where(u => u.Email == email).Single();
                targetEvent.subscriberFirstName = subscriber.FirstName;
                targetEvent.subscriberLastName = subscriber.LastName;

                ApplicationNotif notif = new ApplicationNotif();
                notif.UserName = userName;
                notif.Header = "New subject request";
                notif.Body = targetEvent.subscriberFirstName + " " + targetEvent.subscriberLastName + " sent a request for " + targetEvent.text + ". Start time: " + targetEvent.start_date + " , End time: " + targetEvent.end_date + " .\nContact details: " + email + ".\nPayment method: " + targetEvent.payment;
                notif.CreatedAt = DateTime.Now;
                notif.IsRead = false;

                _context.Notif.Add(notif);

                _context.SaveChanges();
               

                ViewBag.NumberOfNotifs = GetTotalNumOfNotifs();
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

            if (targetEvent.payment == "Paypal")
            {
                targetEvent.status = "ACCEPTED";

                var myUser = _context.Users.Where(e => e.Email == targetEvent.subscriberEmail).Single();
                var sent_event = _context.Events.Where(e => e.EventId == eventId).Single();
                var subjectName = sent_event.text;
                subjectName = subjectName.Replace(" ", "_");
                var creatorName = _context.Users.Where(t => t.UserName == sent_event.userId).Single();
                var sentUser = (from e in _context.Users
                                where e.Email == sent_event.userId
                                select e).Single();
                var paymentLink = "https://www.sandbox.paypal.com/cgi-bin/webscr?cmd=_xclick&amount=" + sent_event.Price + "&business=" + sentUser.Paypal + "&item_name=" + subjectName + "&return=" + this.Request.Scheme + ":" + this.Request.Host + "/User/PayForSubject?token=" + sent_event.Token + "&eventid=" + targetEvent.EventId;
                SendEmail(targetEvent.subscriberEmail, "ilearnchannel6@gmail.com", "Muradikov_21", "Subject Request Accepted",
                               $"Dear { myUser.FirstName },\nRequest for \"{targetEvent.text}\" has been accepted by {creatorName.FirstName} {creatorName.LastName}." +
                               $"\n\n<a href=\"{paymentLink}\">Pay here</a>" +
                               $"\n\n<div style=\"color: red; font - weight: bold;\">Please at the end of payment press <h2>Return to Merchant<h2> button, so that tutor gets notified about your transaction." +
                               $"\n\n In case you did not press the button, please contact: " + targetEvent.userId + "</div>");

                ApplicationNotif notif = new ApplicationNotif();
                notif.UserName = myUser.Email;
                notif.Header = "Request was accepted";
                var FirstName = myUser.FirstName;
                var LastName = myUser.LastName;
                var SubjectName = targetEvent.text;
                var creatorFName = creatorName.FirstName;
                var creatorLName = creatorName.LastName;
                var bodyText = $"Dear { myUser.FirstName },\nRequest for \"{targetEvent.text}\" at " + targetEvent.start_date + " - " + targetEvent.end_date + $" has been accepted by {creatorName.FirstName} {creatorName.LastName}." +
                               $"\n\n<a href=\"{paymentLink}\">Pay here</a>" +
                               $"\n\n<div style=\"color: red; font - weight: bold;\"> Please at the end of payment press \"Return to Merchant\" button, so that tutor gets notified about your transaction." +
                               $"\n\nIn case you did not press the button, please contact: " + targetEvent.userId + "</div>";
                notif.Body = bodyText;
                notif.CreatedAt = DateTime.Now;
                notif.IsRead = false;

                _context.Notif.Add(notif);

                ViewBag.NumberOfNotifs = GetTotalNumOfNotifs();
                _context.SaveChanges();
                return Redirect(returnUrl);
            }
            else if(targetEvent.payment == "Cash")
            {
                targetEvent.status = "ACCEPTED";

                var myUser = _context.Users.Where(e => e.Email == targetEvent.subscriberEmail).Single();
                var sent_event = _context.Events.Where(e => e.EventId == eventId).Single();
                var creatorName = _context.Users.Where(t => t.UserName == sent_event.userId).Single();
                SendEmail(targetEvent.subscriberEmail, "ilearnchannel6@gmail.com", "Muradikov_21", "Subject Request Accepted",
                               $"Dear { myUser.FirstName },\nRequest for \"{targetEvent.text}\" at " + targetEvent.start_date + " - " + targetEvent.end_date + $" has been accepted by {creatorName.FirstName} {creatorName.LastName}." +
                               $"\n\n<div style=\"color: red; font - weight: bold;\">Please pay with cash.</div>");

                ApplicationNotif notif = new ApplicationNotif();
                notif.UserName = myUser.Email;
                notif.Header = "Request was accepted";
                var FirstName = myUser.FirstName;
                var LastName = myUser.LastName;
                var SubjectName = targetEvent.text;
                var creatorFName = creatorName.FirstName;
                var creatorLName = creatorName.LastName;
                var bodyText = $"Dear { myUser.FirstName },\nRequest for \"{targetEvent.text}\" at " + targetEvent.start_date + " - " + targetEvent.end_date + $" has been accepted by {creatorName.FirstName} {creatorName.LastName}." +
                               $"\n\n<div style=\"color: red; font - weight: bold;\">Please pay with cash.</div>";
                notif.Body = bodyText;
                notif.CreatedAt = DateTime.Now;
                notif.IsRead = false;

                _context.Notif.Add(notif);

                ViewBag.NumberOfNotifs = GetTotalNumOfNotifs();
                _context.SaveChanges();
                return Redirect(returnUrl);
            }

            return Redirect("/User/PaymentError");
        }

        [HttpGet]
        [Authorize]
        public IActionResult ManageSubscription()
        {
            return View(_context);
        }
        
        [HttpPost]
        [Authorize]
        public IActionResult CheckCoursePayment([FromQuery(Name = "eventId")] int? eventId)
        {
            Trace.WriteLine("EVENT ID GO: " + eventId);
            var targetEvent = _context.Events.Where(e => e.EventId == eventId).Single();
            if (!targetEvent.IsPaid) { targetEvent.IsPaid = true; } else { targetEvent.IsPaid = false; }
            _context.SaveChanges();
            return Redirect("~/User/ManageSubscription");
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

            

            Trace.WriteLine("GAGASHH: " + targetEvent.subscriberEmail);
            var myUser = _context.Users.Where(e => e.Email == targetEvent.subscriberEmail).Single();
            var sent_event = _context.Events.Where(e => e.EventId == eventId).Single();
            var creatorName = _context.Users.Where(t => t.UserName == sent_event.userId).Single();

            SendEmail(targetEvent.subscriberEmail, "ilearnchannel6@gmail.com", "Muradikov_21", "Subject Request Rejected",
                           $"Dear {myUser.FirstName},\nRequest for {targetEvent.text} has been rejected by {creatorName.FirstName} {creatorName.LastName}");

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

            var user = (from e in _context.Users
                        where e.Email == User.Identity.Name
                        select e).Single();

            var targetEvents = (from e in _context.Events
                            where e.userId == user.Email && e.start_date >= DateTime.Now
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


        public IActionResult GetTotalNumOfNotifsAction()
        {
            var notifs = (from e in _context.Notif
                          where e.UserName == User.Identity.Name && e.IsRead != true
                          select e).ToList();

            Trace.WriteLine("GIDJDILLAG");

            return Ok(new { notifsCount = notifs.Count });
        }

        public IActionResult GetTotalNumOfSubscriptions()
        {
            var subscriptions = (from e in _context.Subscriptions
                          where e.UserName == User.Identity.Name
                          select e).ToList();

            return View(subscriptions);
        }



        // Async to get messages asynchronously
        public async Task<IActionResult> OpenChat()
        {
            var myUserRole = (from u in _context.Users
                              where u.UserName == User.Identity.Name
                              select u).Single();
            if (myUserRole.Role == "Student")
            {
                    var currentUserNew = await _userManager.GetUserAsync(User); // Added by MS
                    if (User.Identity.IsAuthenticated)
                    {
                        ViewBag.CurrentUserName = User.Identity.Name;
                        ViewBag.NumberOfNotifs = GetTotalNumOfNotifs();
                    }
                    var messagesNew = await _context.Messages.Where(r => r.UserName == User.Identity.Name || r.ReceiverName == User.Identity.Name).ToListAsync(); // Added by MS    
                    return View(messagesNew);
            }
            
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

            return Redirect("~/?selectedUser=" + selectedUser);
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
            Trace.WriteLine($"Message {message.Text} created for {selectedUser}");
            if (ModelState.IsValid)
            {
                message.UserName = User.Identity.Name;
                message.UserFirstName = _context.Users.Where(m => m.Email == message.UserName).Single().FirstName.ToString();
                message.UserLastName = _context.Users.Where(m => m.Email == message.UserName).Single().LastName.ToString();
                message.ReceiverName = selectedUser;
                message.ReceiverFirstName = _context.Users.Where(m => m.Email == message.ReceiverName).Single().FirstName.ToString();
                message.ReceiverLastName = _context.Users.Where(m => m.Email == message.ReceiverName).Single().LastName.ToString();

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
                ViewBag.NumberOfNotifs = GetTotalNumOfNotifs();

                Trace.WriteLine("Data is saved into the database");
                Trace.WriteLine($"Sender is {message.UserName}, Receiver is {message.ReceiverName}");
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
            var myUser = (from e in _context.Users
                        where e.Email == User.Identity.Name
                        select e).Single();
            Trace.WriteLine($"TUTOR PAYPAL: {myUser.Paypal}");
            if (myUser.Paypal == null)
            {
                return Redirect("/User/AddPaypal");
            }
            else
            {
                return View(myUser);
            }
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

        // For API Documentation
        [HttpGet]
        public JsonResult GetAllCoursesJSON()
        {
            var events = _context.Events.Where(u => u.status == "AVAILABLE").Select(u => new { u.text, u.description, u.start_date, u.end_date, u.ownerFirstName, u.ownerLastName, u.userId, u.status }).ToList();

            return new JsonResult(events);
        }

        [HttpGet]
        public JsonResult GetTutorCoursesJSON([FromQuery(Name = "email")] string email)
        {
            var courses = _context.Events.Where(u => u.status == "AVAILABLE" && u.userId == email).Select(u => new { u.text, u.description, u.start_date, u.end_date, u.ownerFirstName, u.ownerLastName, u.userId, u.status }).ToList();

            return new JsonResult(courses);
        }

        [HttpGet]
        public JsonResult GetAllUsersJSON()
        {
            var courses = _context.Users.Select(u => new { u.FirstName, u.LastName, u.Email, u.Role }).ToList();

            return new JsonResult(courses);
        }
        // For API Documentation


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

        [HttpGet]
        [Authorize]
        public IActionResult StudentSubjects()
        {
            var events = _context.Events.Where(r => r.subscriberEmail == User.Identity.Name  && r.start_date >= DateTime.Now && (r.status == "PENDING" || r.status == "ACCEPTED") && r.IsPaid == false).ToList();
            return View(events);
        }

        [HttpPost]
        [Authorize]
        public IActionResult StudentRejectSubscription(int? eventId, string returnUrl) //  // Done by the student
        {
            System.Diagnostics.Debug.WriteLine("EventId: " + eventId);
            System.Diagnostics.Debug.WriteLine("ReturnUrl: " + returnUrl);


            var targetEvent = (from e in _context.Events
                               where e.EventId == eventId
                               select e).Single();

            var sent_event = _context.Events.Where(e => e.EventId == eventId).Single();

            targetEvent.status = "AVAILABLE";
            targetEvent.subscriberEmail = String.Empty;
            _context.SaveChanges();

            return Redirect(returnUrl);
        }

        public IActionResult PayForSubject([FromQuery(Name = "token")] string token)
        {
            var targetEvent = (from e in _context.Events
                               where e.Token == token
                               select e).Single();
            targetEvent.IsPaid = true;

            targetEvent.status = "ACCEPTED";

            var subjectOwner = _context.Users.Where(e => e.Email == targetEvent.userId).Single();
            var subjectSubscriber = _context.Users.Where(e => e.Email == targetEvent.subscriberEmail).Single();

            ApplicationNotif notif = new ApplicationNotif();
            notif.UserName = subjectOwner.Email;
            notif.Header = "Payment Notification";
            var SubjectName = targetEvent.text;
            var bodyText = $"Dear {subjectOwner.FirstName} {subjectOwner.LastName}, \n {targetEvent.Price}€ was paid for \"{targetEvent.text}\" by {subjectSubscriber.FirstName} {subjectSubscriber.LastName}." +
                $"\n<div style=\"color: green; font - weight: bold;\">Please contact with {subjectSubscriber.FirstName} {subjectSubscriber.LastName} to start the lesson. Email: {subjectSubscriber.Email}</div>" +
                $"\nThank you for using ILearn!";
            notif.Body = bodyText;
            notif.CreatedAt = DateTime.Now;
            notif.IsRead = false;

            _context.Notif.Add(notif);

            _context.SaveChanges();
            return Redirect("/Home/Index");
        }
        
        [HttpGet]
        [Authorize]
        public IActionResult GetAllContacts([FromQuery(Name = "name")] string name)
        {
            if (String.IsNullOrWhiteSpace(name))
            {
                var allUsers = (from u in _context.Users
                                select u).ToList();

                return View(allUsers);
            }
            else
            {
                var allUsers = (from u in _context.Users
                                where u.FirstName == name || u.LastName == name
                                || (u.FirstName + " " + u.LastName) == name || u.Email == name
                                select u).ToList();

                return View(allUsers);
            }
        }

        // SaveEvent
        [HttpPost]
        [Authorize]
        public JsonResult SaveEvent(ApplicationEvent e)
        {

            Debug.WriteLine($"EventId: {e.EventId}");
            Debug.WriteLine($"Text: {e.text}");
            Debug.WriteLine($"Start: {e.start_date}");
            Debug.WriteLine($"End: {e.end_date}");
            Debug.WriteLine($"ThemeColor: {e.ThemeColor}");
            Debug.WriteLine($"Description: {e.description}");
            Debug.WriteLine($"IsFullDay: {e.isFullDay}");
            Debug.WriteLine($"Price: {e.Price}");

            if (e.EventId > 0)
            {
                //Update the event
                var v = _context.Events.Where(a => a.EventId == e.EventId).Single();
                Debug.WriteLine("EV ID: " + v.EventId);

                if (v != null)
                {
                    v.text = e.text;
                    v.start_date = e.start_date;
                    v.end_date = e.end_date;
                    v.description = e.description;
                    v.ThemeColor = e.ThemeColor;
                    v.isFullDay = e.isFullDay;
                    v.Price = e.Price;
                    v.Token = e.Token;
                    v.IsPaid = e.IsPaid;
                    v.payment = e.payment;

                    _context.SaveChanges();

                    Debug.WriteLine("Payment: " + v.payment);
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

                e.ownerFirstName = getAuthenticatedUser().FirstName;
                e.ownerFirstName = getAuthenticatedUser().LastName;

                e.status = "AVAILABLE";

                _context.Events.Add(e);
            }

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