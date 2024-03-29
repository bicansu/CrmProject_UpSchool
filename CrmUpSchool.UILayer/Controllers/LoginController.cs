﻿using CrmUpSchool.EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using MailKit.Net.Smtp;
using MimeKit;
using CrmUpSchool.UILayer.Areas.Employee.Models;
using CrmUpSchool.UILayer.Models;

namespace CrmUpSchool.UILayer.Controllers
{
    [AllowAnonymous]
    public class LoginController : Controller
    {
        private readonly SignInManager<AppUser> _signInManager;

        public LoginController(SignInManager<AppUser> signInManager)
        {
            _signInManager = signInManager;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public async Task <IActionResult> Index(AppUser appUser)
        {
            
            //
            var result = await _signInManager.PasswordSignInAsync(appUser.UserName, appUser.PasswordHash, true, true);
            ViewBag.sonuc = "Gelen Confirm: " + appUser.EmailConfirmed;
            if (result.Succeeded && appUser.EmailConfirmed == true)
            {
                return RedirectToAction("Index", "User");
            }
            else
            {
                return RedirectToAction("Index", "Register");
            }
        }
    }
}
