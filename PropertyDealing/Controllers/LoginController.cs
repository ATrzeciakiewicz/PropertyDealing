﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin.Security;
using PropertyDealing.Models;
using System.Threading.Tasks;
using PropertyDealing.DataAccess.Models;
using PropertyDealing.DataAccess;

namespace PropertyDealing.Controllers
{
    public class LoginController : Controller
    {
        

        // GET: Login
        public ActionResult Index()
        {
            ViewData["registered"] = false;
            return View();
        }

        public ActionResult Register()
        {
            ViewData["registered"] = true;
            return View("Index");
        }

        [HttpPost]
        public ActionResult LoginUser(LoginViewModel model)
        {

            return View("Index");
        }

        [HttpPost]
        public ActionResult RegisterUser(RegisterViewModel model)
        {
            return View("Index");
        }

        public async Task<string> AddUser()
        {
            User user;
            ApplicationUserStore store = new ApplicationUserStore(new PropertyDealingDbContext());
            ApplicationUserManager userManager = new ApplicationUserManager(store);

            user = new User
            {
                Login = ""
            };

            var result = await userManager.CreateAsync(user);
            if(!result.Succeeded)
            {
                return result.Errors.First();
            }
            return "User Added";
        }
    }
}