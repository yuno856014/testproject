using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StudentManagement.Entities;
using StudentManagement.Models;
using StudentManagement.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentManagement.Controllers
{
    public class StudentController : Controller
    {
        private readonly IUserService userService;
        private readonly UserManager<User> userManager;

        public StudentController(IUserService userService,
                                 UserManager<User> userManager)
        {
            this.userService = userService;
            this.userManager = userManager;
        }
        public IActionResult Index()
        {
            var appUsers = userService.Gets();
            var users = new List<Student>();
            foreach (var u in appUsers)
            {
                var user = new Student()
                {
                    UserId = u.Id,
                    Events = u.Events,
                    UserSchoolYears = u.UserSchoolYears,
                    Skills = null,
                    Username = u.UserName,
                    Roles = string.Join(',', Task.Run(async () => await userManager.GetRolesAsync(u)).Result.ToArray())
                };
                users.Add(user);
            }
            return View(users);
        }
    }
}
