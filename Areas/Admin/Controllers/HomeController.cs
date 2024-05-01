using Appointment_calendar.Domain.DatabaseAccess;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Appointment_calendar.Areas.Admin.Controllers
{
	[Area("Admin")]
	public class HomeController : Controller
	{
		private readonly ServiceManager serviceManager;

		public HomeController(ServiceManager serviceManager)
		{
			this.serviceManager = serviceManager;
		}

        public IActionResult Index()
        {
            return View(serviceManager.ServiceItems.GetServiceItems());
        }
    }

}
