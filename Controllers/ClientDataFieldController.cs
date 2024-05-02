using Appointment_calendar.Domain.DatabaseAccess;
using Appointment_calendar.Domain.Entities.Concreate;
using Microsoft.AspNetCore.Mvc;

namespace Language_School.Controllers
{
    public class ClientDataFieldController : Controller
    {
		private readonly ServiceManager serviceManager;

		public ClientDataFieldController(ServiceManager serviceManager)
        {
            this.serviceManager = serviceManager;
        }


        public IActionResult Index(Guid id)
        {
			var entity = serviceManager.TextFields.GetTextFieldByCodeWord("PageClientDataField");
            return View();
        }


        [HttpPost]
        public IActionResult Send(ClientDataField model)
        {
            if (ModelState.IsValid)
            {
				serviceManager.ClientDataFields.SaveClientDataField(model);
                return RedirectToAction("Complete");
            }
            return View();
        }
        public IActionResult Complete()
        {
            ViewBag.Message = "Ваша заявка принята";
            return View();
        }
    }
}