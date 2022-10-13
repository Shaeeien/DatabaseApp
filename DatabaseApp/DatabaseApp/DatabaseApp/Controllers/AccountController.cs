using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Configuration;
using System.Linq;
using Microsoft.AspNetCore.Http;
using DatabaseApp.Entities;

namespace DatabaseApp.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Login(string login, string password)
        {
            using(var DbCtx = new AppointmentContext())
            {
                bool user = DbCtx.AppUsers.Where(x => x.Login == login && x.Password == password).Any();
                if(!user)
                {
                    return View("LoginError");
                }
                else
                {
                    HttpContext.Session.SetString("Login", login);
                    return View();
                }

            }
        }

        public IActionResult LoggedIn()
        {
            if(HttpContext.Session.GetString("Login") == null)
            {
                return View("Index");
            }
            return View();
        }

        //DODAĆ TRY CATCH WSZĘDZIE
        public IActionResult Register(string login, string password, string repeatedPassword)
        {
            if(login != null && password != null)
            {
                if (password != repeatedPassword)
                {
                    return View("SamePassword");
                }
                else
                {
                    using(var DbCtx = new AppointmentContext())
                    {
                        bool exists = (from appuser in DbCtx.AppUsers where appuser.Login == login select appuser).Any();
                        if (!exists)
                        {
                            AppUser u = new AppUser()
                            {
                                Login = login,
                                Password = password,
                                AccountType = 0
                            };
                            DbCtx.Add(u);
                            DbCtx.SaveChanges();
                            return View("RegistrationSuccess");
                        }                            
                    }
                    return View("RegistrationError");
                }
            }
            else
            {
                return View("RegistrationError");
            }
        }

        public IActionResult RegisterPage()
        {
            return View("Register");
        }
    }
}
