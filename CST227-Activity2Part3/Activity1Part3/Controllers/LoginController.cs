using Activity1Part3.Models;
using Activity1Part3.Services.Business;
using Activity1Part3.Services.Utility;
using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Activity1Part3.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            return View("Login");
        }

        [HttpPost]

        public ActionResult Login(UserModel model)
        {
            MyLogger.GetInstance().Info("Entering the login controller using login ActionResult.");
            try
            {
                SecurityService security = new SecurityService();

                model = new UserModel();

                // Validate the Form POST               
                if (!ModelState.IsValid) 
                    return View("Login");

                bool check = security.Authenticate(model);

                if (check == true)
                {
                    MyLogger.GetInstance().Info("Exit login controller. Login successful.");
                    return View("LoginPassed");
                }
                else
                {
                    MyLogger.GetInstance().Info("Exit login controller. Login failure.");
                    return View("LoginFailed");
                }
            }
            catch (Exception e)
            {
                MyLogger.GetInstance().Error("Exception! " + e.Message);

                return Content("Exception in login" + e.Message);
            }
        }
    }
}