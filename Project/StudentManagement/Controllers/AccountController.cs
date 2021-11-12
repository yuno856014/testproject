using Microsoft.AspNetCore.Mvc;
using StudentManagement.Models.Accounts;
using StudentManagement.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentManagement.Controllers
{
    public class AccountController : Controller
    {
        private readonly IUserService userService;

        public AccountController(IUserService userService)
        {
            this.userService = userService;
        }
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Login(Login login)
        {
            if (ModelState.IsValid)
            {
                var result = await userService.Login(login);
                if (result.Success && result.Roles.Length > 0)
                {
                    if (result.Roles.Contains("Student"))
                    {
                        return RedirectToAction("Index", "Student");
                    }
                    else
                    {
                        return RedirectToAction("Privacy", "Home");
                    }
                }
                ViewBag.Error = result.Message;
                return View();
            }
            return View();
        }
        public IActionResult Signout()
        {
            userService.Sighout();
            return RedirectToAction("Login", "Account");
        }
    }
}
