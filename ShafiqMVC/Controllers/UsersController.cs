using ShafiqMVC.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ShafiqMVC.Controllers
{
    public class UsersController : Controller
    {
        // GET: Users
        public ActionResult Index()
        {
            return View();
        }


        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(UserVM user)
        {
            if (user.Age > 20)
            {
                if (user.image.ContentLength > 0)
                {
                    string folderName = "~/AppData/Images";
                    if (!System.IO.Directory.Exists(folderName))
                    {
                        System.IO.Directory.CreateDirectory(folderName);
                    }
                    user.image.SaveAs(Server.MapPath(Path.Combine(folderName, user.image.FileName)));
                }

                //UserContext db = new UserContext();

                //User dbUser = db.Users.Find(1);
                //ViewBag.ImageName= $"~/AppData/Images/{dbUser.ImageName}";


                return RedirectToAction("Index", "Home");
            }
            return View();
        }



    }
}