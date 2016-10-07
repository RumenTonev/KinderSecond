using KinderSecond.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KinderSecond.Controllers
{
    public class BaseController : Controller
    {
 
            public BaseController(IUowData data)
            {
                Data = data;
            }

            protected IUowData Data { get; set; }
        
    }
}