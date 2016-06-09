using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using WK.Orion.Platform.Examples.Components.Framework.Integration.MVC.Controllers;

namespace WK.Orion.Applications.ADM.Controllers
{
    [Authorize]
    public class HomeController : OrionController
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}
