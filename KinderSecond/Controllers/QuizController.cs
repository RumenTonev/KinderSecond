using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KinderSecond.Controllers
{
    public class QuizController : Controller
    {
        // GET: Quiz
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult GetQuizForm()
        {
            return PartialView("_QuizForm");
        }

    }
}