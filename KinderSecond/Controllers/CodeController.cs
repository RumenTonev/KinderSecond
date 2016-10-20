using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;
using KinderSecond.Data;
using KinderSecond.Models;

namespace KinderSecond.Controllers
{
    [Authorize]
    public class CodeController : BaseController
    {
        public CodeController(IUowData data)
            : base(data)
        {
        }
        // GET: Code
        public ActionResult Index()
        {
            return View();
        }
        public bool AddCode(string code)
        {

            var userId = User.Identity.GetUserId();
            var codeEntry = Data.Codes.All().FirstOrDefault(x => x.UserId.ToString() == userId && code == x.Value);
            if (codeEntry == null)
            {
                var newEntry = new PromoCode()
                {
                    Value = code,
                    UserId = userId
                };
                Data.Codes.Add(newEntry);
                Data.SaveChanges();
                return true;
            }

            return true;
        }
    }
}