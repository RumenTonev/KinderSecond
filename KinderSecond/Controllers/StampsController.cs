using KinderSecond.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using KinderSecond.Data;
using System.Data.Entity;

namespace KinderSecond.Controllers
{
    [Authorize]
    public class StampsController : BaseController
    {
        public StampsController(IUowData data)
            : base(data)
        {
        }

        public ActionResult Index()
        {

            ApplicationUser user = HttpContext.GetOwinContext().GetUserManager<ApplicationUserManager>().FindById(User.Identity.GetUserId());
            var model = Data.Users.All().FirstOrDefault(x => x.Id == User.Identity.GetUserId()).TakenQuizes.Select(y => y.PicturePath);
            return View(model);
        }

        public ActionResult AddStamp (int quizId)
        {
            ApplicationUser user = HttpContext.GetOwinContext().GetUserManager<ApplicationUserManager>().FindById(User.Identity.GetUserId());
            user.TakenQuizes.Add(Data.Quizes.GetById(quizId));
            Data.Users.Update(user);
            Data.SaveChanges();
            return new HttpStatusCodeResult(200);
        }
    }
}