using System.Web.Mvc;
using WK.Orion.Platform.Examples.Components.Framework.Integration.MVC.Controllers;
using WK.Orion.Platform.Examples.Components.Tasks.BusinessLogicLayer.Interfaces;

namespace WK.Orion.Applications.DPM.Controllers
{
    [Authorize]
    public class HomeController : OrionController
    {
        private readonly ITaskService _taskService;

        public HomeController(ITaskService taskService)
        {
            _taskService = taskService;
        }


        public ActionResult Index()
        {
            _taskService.GetOne(5);

            return View();
        }
    }
}
