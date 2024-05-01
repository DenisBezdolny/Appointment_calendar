using Appointment_calendar.Domain.DatabaseAccess;
using Appointment_calendar.Domain.Entities.Concreate;
using Appointment_calendar.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Appointment_calendar.Areas.Admin.Controllers
{
	[Area("Admin")]
	public class TextFieldsController : Controller
	{
		private readonly ServiceManager serviceManager;
		public TextFieldsController(ServiceManager serviceManager)
		{
			this.serviceManager = serviceManager;
		}

		public IActionResult Edit(string codeWord)
		{
			var entity = serviceManager.TextFields.GetTextFieldByCodeWord(codeWord);
			return View(entity);
		}

		[HttpPost]
		public IActionResult Edit(TextField model)
		{
			if (ModelState.IsValid)
			{
				serviceManager.TextFields.SaveTextField(model);
				return RedirectToAction(nameof(HomeController.Index), nameof(HomeController).CutController());
			}
			return View(model);
		}
	}

}
