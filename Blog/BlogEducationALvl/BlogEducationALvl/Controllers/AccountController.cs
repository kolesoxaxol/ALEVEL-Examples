using BlogEducationALvl.App_Start;
using BlogEducationALvl.Models;
using Microsoft.AspNet.Identity;
using Microsoft.Owin.Security;
using Microsoft.Owin;
using System.Linq;
using System.Web.Mvc;
using System.Web;
using Microsoft.AspNet.Identity.Owin;

namespace BlogEducationALvl.Controllers
{
    public class AccountController : Controller
    {
        IAuthenticationManager AuthManger => HttpContext.GetOwinContext().Authentication;
        ApplicationUserManager UserManger => HttpContext.GetOwinContext().Get<ApplicationUserManager>(); //HttpContext.GetUserManager<ApplicationUserManager>();
        // GET: Account

        public ActionResult Index()
        {
            return View("Register");
        }

        [HttpPost]
        public ActionResult Index(RegisterModel model)
        {
            //return View("Register", model);
            // Default UserStore constructor uses the default connection string named: DefaultConnection
            var user = new ApplicationUser() { UserName = model.UserName, Email = model.UserName };
            IdentityResult result = UserManger.Create(user, model.Password);
            // Default UserStore constructor uses the default connection string named: DefaultConnection



            if (result.Succeeded)
            {
                ViewBag.StatusMessage = string.Format("User {0} was created successfully!", user.UserName);

                var userIdentity = UserManger.CreateIdentity(user, DefaultAuthenticationTypes.ApplicationCookie);
                //AuthManger.SignIn(new AuthenticationProperties() { }, userIdentity);
                UserManger.SendEmailAsync(userIdentity.GetUserId(), "Confirmation", "");
                UserManger.SendSmsAsync(userIdentity.GetUserId(), "Confirmation");
                return View("");
            }
            else
            {
                ViewBag.StatusMessage = result.Errors.FirstOrDefault();
            }

            return View();
        }


    }
}