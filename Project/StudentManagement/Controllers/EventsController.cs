using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using StudentManagement.DBContexts;
using StudentManagement.Entities;
using StudentManagement.Models.Events;
using StudentManagement.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentManagement.Controllers
{
    public class EventsController : Controller
    {
        private static User user = new User();
        private readonly IUserService userService;
        private readonly IEventService eventService;
        private readonly IWebHostEnvironment webHostEnvironment;
        private readonly StudentManagementContext context;

        public EventsController(IUserService userService,
                                IEventService eventService,
                                IWebHostEnvironment webHostEnvironment,
                                StudentManagementContext context)
        {
            this.userService = userService;
            this.eventService = eventService;
            this.webHostEnvironment = webHostEnvironment;
            this.context = context;
        }
        [Route("/Events/Index/{userId}")]
        public IActionResult Index(string userId)
        {
            user = userService.Get(userId);
            ViewBag.User = user;
            return View(eventService.GetEventbyUserId(userId));
        }
        [HttpGet]
        public IActionResult Create()
        {
            ViewData["ListEventId"] = new SelectList(context.ListEvents, "ListEventId", "ListEventName");
            return View();
        }
        [HttpPost]
        public IActionResult Create(CreateEvent create)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    create.UserId = user.Id;
                    var events = new Event()
                    {
                        UserId = create.UserId,
                        Status = (Enums.EventStatus?)1,
                        Act = create.Act,
                        Activities = create.Activities,
                        PowerDev = create.PowerDev,
                        PowerExerted = create.PowerExerted,
                        SchoolYear = null,
                        Think = create.Think,
                        ListEventId = create.ListEventId
                    };
                    if (eventService.Create(events))
                    {
                        return RedirectToAction("Index", "Events", new { userId = user.Id });
                    }
                }
                ViewBag.User = user;
                return View(create);
            }
            catch (Exception ex)
            {

                throw;
            }
         
            
        }
    }
}
