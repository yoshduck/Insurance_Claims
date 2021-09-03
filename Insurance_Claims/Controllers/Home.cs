using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;

namespace Insurance_Claims.Controllers
{
    public class HomeController : Controller
    {

        public ActionResult Login()
        {
            Session["LoginCounter"] = 0;
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(User objUser)
        {
            if (ModelState.IsValid)
            {
                using (InterviewEntities db = new InterviewEntities())
                {
                    var obj = db.Users.Where(a => a.UserName.Equals(objUser.UserName) && a.Password.Equals(objUser.Password)).FirstOrDefault();
                    if (obj != null)
                    {
                        if (obj.Active == true)
                        {
                            Session["UserID"] = obj.UserId.ToString();
                            Session["UserName"] = obj.UserName.ToString();
                            Session["DisplayName"] = obj.DisplayName.ToString();

                            return RedirectToAction("Index", "LossTypes");
                        }
                        else
                            ModelState.AddModelError("", "Your account is inactive");

                    }
                    else
                    {
                        ModelState.AddModelError("", "Incorrect User Id or Password!");
                    }
                    
                }
            }
            return View(objUser);
        }

        public ActionResult UserDashBoard()
        {
            if (Session["UserID"] != null)
            {
                return View();
            }
            else
            {
                return RedirectToAction("Login");
            }
        }
    }
}