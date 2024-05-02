using Appointment_calendar.Domain.DatabaseAccess;
using Appointment_calendar.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Appointment_calendar.Areas.Therapist.Controllers
{

    [Area("Therapist")]
    public class ClientDataApplicationController : Controller
    {
        private readonly ServiceManager serviceManager;

        public ClientDataApplicationController(ServiceManager serviceManager)
        {
            this.serviceManager = serviceManager;
        }

        public IActionResult Index()
        {
            return View(serviceManager.ClientDataFields.GetClientDataFields());
        }


        [HttpPost]
        public IActionResult Delete(Guid id)
        {
            serviceManager.ClientDataFields.DeleteClientDataField(id);
            return RedirectToAction(nameof(HomeController.Index), nameof(HomeController).CutController());
        }



    }
}
