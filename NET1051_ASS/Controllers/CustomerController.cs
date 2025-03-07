﻿using Castle.Core.Resource;
using Microsoft.AspNetCore.Mvc;
using NET1051_ASS.Models;
using NET1051_ASS.Services;

namespace NET1051_ASS.Controllers
{
    public class CustomerController : Controller
    {
        private readonly IAccountService _accountService;

        public CustomerController(IAccountService accountService)
        {
            _accountService = accountService;
        }

        public IActionResult Profile()
        {
            var username = HttpContext.Session.GetString("Username");
            var userRole = HttpContext.Session.GetString("UserRole");

            if (userRole != "customer")
            {
                TempData["ErrorMessage"] = "Please login with customer account to access this page.";
                return RedirectToAction("Login", "Account");
            }

            try
            {
                var user = _accountService.GetByUsername(username);

                if (user == null)
                {
                    ViewData["ErrorMessage"] = "User not found.";
                    return View("Error");
                }

                return View(user);
            }
            catch (Exception ex)
            {
                ViewData["ErrorMessage"] = ex.Message;
                return View("Error", "Shared");
            }
        }

        [HttpPost]
        public IActionResult Profile([FromForm] User updateUser)
        {
            try
            {
                var user = _accountService.GetByUsername(updateUser.Username);

                if (user == null)
                {
                    ViewData["ErrorMessage"] = "User not found.";
                    return View("Error");
                }

                user.Password = updateUser.Password;
                user.Email = updateUser.Email;
                user.Phone = updateUser.Phone;
                user.DateOfBirth = updateUser.DateOfBirth;

                _accountService.Update(user);

                TempData["SuccessMessage"] = "Profile updated successfully.";
                return RedirectToAction("Profile");
            }
            catch (Exception ex)
            {
                ViewData["ErrorMessage"] = ex.Message;
                return View("Error", "Shared");
            }
        }
    }
}
