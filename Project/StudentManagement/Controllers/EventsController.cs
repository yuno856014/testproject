using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using StudentManagement.DBContexts;
using StudentManagement.Entities;
using StudentManagement.Models.Events;
using StudentManagement.Models.Students;
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
        public async Task<IActionResult> Index(string userId, int? SchoolYearId, int? ListEvent, bool checkbox1, bool checkbox2, bool checkbox3, int status1 = 1, int status2 = 2, int status3 = 3)
        {
            var events = from m in context.Events select m; 

            if (!(SchoolYearId==null))
            {
                events = events.Where(s => s.SchoolYearId == SchoolYearId);
            }
            if (!(ListEvent == null))
            {
                events = events.Where(s => s.ListEvent.ListEventId == ListEvent);
            }
            if (checkbox1 && checkbox2 && !checkbox3)
            {
                events = events.Where(s => s.Status == (Enums.EventStatus?)status1 || s.Status == (Enums.EventStatus?)status2);
            }
            else if (checkbox1 && !checkbox2 && !checkbox3)
            {
                events = events.Where(s => s.Status == (Enums.EventStatus?)status1);
            }
            else if (!checkbox1 && checkbox2 && !checkbox3)
            {
                events = events.Where(s => s.Status == (Enums.EventStatus?)status2);
            }
            else if (checkbox1 && checkbox3 && !checkbox2)
            {
                events = events.Where(s => s.Status == (Enums.EventStatus?)status1 || s.Status == (Enums.EventStatus?)status3);
            }
            else if (checkbox1 && !checkbox3 && !checkbox2)
            {
                events = events.Where(s => s.Status == (Enums.EventStatus?)status1);
            }
            else if (!checkbox1 && checkbox3 && !checkbox2)
            {
                events = events.Where(s => s.Status == (Enums.EventStatus?)status3);
            }
            else if (checkbox2 && checkbox3 && !checkbox1)
            {
                events = events.Where(s => s.Status == (Enums.EventStatus?)status2 || s.Status == (Enums.EventStatus?)status3);
            }
            else if (checkbox2 && !checkbox3 && !checkbox1)
            {
                events = events.Where(s => s.Status == (Enums.EventStatus?)status2);
            }
            else if (!checkbox2 && checkbox3 && !checkbox1)
            {
                events = events.Where(s => s.Status == (Enums.EventStatus?)status3);
            }
            user = userService.Get(userId);
            var eventSearch = new SearchEvent
            {
                events = await events.Where(p => p.UserId == userId).OrderByDescending(c => c.SchoolYearId).OrderByDescending(c => c.EventId).ToListAsync()
            };
            var schoolYear = context.UserSchoolYears.Include(u => u.SchoolYear).Include(u => u.User).OrderByDescending(u => u.SchoolYearId).FirstOrDefault(m => m.UserId == userId).SchoolYear.SchoolYearName;
            ViewBag.ListSchoolYearId = await context.SchoolYears.ToListAsync(); 
            ViewData["ListEventId"] = new SelectList(context.ListEvents, "ListEventId", "ListEventName");
            ViewData["SchoolYearId"] = new SelectList(context.SchoolYears, "SchoolYearId", "SchoolYearName");
            ViewBag.User = user;
            ViewBag.SchoolYear = schoolYear;
            return View(eventSearch);
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
                    var schoolYear = context.UserSchoolYears.Include(u => u.SchoolYear).Include(u => u.User).OrderByDescending(u => u.SchoolYearId).FirstOrDefault(m => m.UserId == user.Id).SchoolYear.SchoolYearId;
                    var events = new Event()
                    {
                        UserId = create.UserId,
                        Status = (Enums.EventStatus?)1,
                        Act = create.Act,
                        Activities = create.Activities,
                        PowerDev = create.PowerDev,
                        PowerExerted = create.PowerExerted,
                        SchoolYearId = schoolYear,
                        Think = create.Think,
                        ListEventId = create.ListEventId
                    };
                    if (eventService.Create(events))
                    {
                        return RedirectToAction("Index", "Events", new { userId = user.Id });
                    }
                }
                ViewBag.User = user;
                ViewData["ListEventId"] = new SelectList(context.ListEvents, "ListEventId", "ListEventName");
                return View(create);
            }
            catch (Exception ex)
            {

                throw;
            }
        }
        [HttpGet]
        [Route("/Events/Detail/{eventId}")]
        public IActionResult Detail(int eventId)
        {
            var events = eventService.Get(eventId);
            var edituser = new EditEvents()
            {
                EventId = events.EventId,
                Act = events.Act,
                Activities = events.Activities,
                ListEvent = events.ListEvent,
                PowerDev = events.PowerDev,
                PowerExerted = events.PowerExerted,
                Status = events.Status,
                Think = events.Think,
                UserId = events.UserId,
                ListEventId = events.ListEventId
            };
            ViewData["ListEventId"] = new SelectList(context.ListEvents, "ListEventId", "ListEventName");
            ViewBag.User = user;
            return View(edituser);
        }
        [HttpGet]
        [Route("/Events/Edit/{eventId}")]
        public IActionResult Edit(int eventId)
        {
            var events = eventService.Get(eventId);
            var edituser = new EditEvents()
            {
                EventId = events.EventId,
                Act = events.Act,
                Activities = events.Activities,
                ListEvent = events.ListEvent,
                PowerDev = events.PowerDev,
                PowerExerted = events.PowerExerted,
                Status = events.Status,
                Think = events.Think,
                UserId = events.UserId,
                ListEventId = events.ListEventId
            };
            ViewData["ListEventId"] = new SelectList(context.ListEvents, "ListEventId", "ListEventName");
            ViewBag.User = user;
            return View(edituser);
        }
        [HttpPost]
        public IActionResult Edit(EditEvents model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var events = eventService.Get(model.EventId);
                    events.UserId = model.UserId;
                    events.PowerDev = model.PowerDev;
                    events.PowerExerted = model.PowerExerted;
                    events.Think = model.Think;
                    events.ListEvent = model.ListEvent;
                    events.Act = model.Act;
                    events.ListEventId = model.ListEventId;
                    events.Activities = model.Activities;
                    if (eventService.Edit(events))
                    {
                        return RedirectToAction("Index", "Events", new { userId = model.UserId });
                    }
                }
                ViewBag.User = user;
                ViewData["ListEventId"] = new SelectList(context.ListEvents, "ListEventId", "ListEventName");
                return View(model);
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(int eventId)
        {
            var events = await context.Events.FindAsync(eventId);
            if (events != null) context.Events.Remove(events);
            await context.SaveChangesAsync();
            return RedirectToAction("Index", "Events", new { userId = user.Id });
        }
    }
}
