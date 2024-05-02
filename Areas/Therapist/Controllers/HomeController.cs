using Appointment_calendar.Domain.DatabaseAccess;
using Appointment_calendar.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Appointment_calendar.Areas.Therapist.Controllers
{
	[Area("Therapist")]
	public class HomeController : Controller
	{
		private readonly ServiceManager serviceManager;

		public HomeController(ServiceManager serviceManager)
		{
			this.serviceManager = serviceManager;
		}

		public IActionResult Index()
		{
			return View();
		}

		

        
    }
}
