using Appointment_calendar.Domain.DatabaseAccess;
using Appointment_calendar.Domain.Entities.Concreate;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Appointment_calendar.Areas.Therapist.Controllers
{

    [Area("Therapist")]
    public class PatientController : Controller
    {
        private readonly ServiceManager serviceManager;

        public PatientController(ServiceManager serviceManager)
        {
            this.serviceManager = serviceManager;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View(serviceManager.Patients.GetPatients());
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Patient patient)
        {
            if (ModelState.IsValid)
            {
                serviceManager.Patients.CreatePatient(patient);
                return RedirectToAction("Index");
            }
            return View(patient);
        }

        [HttpPost]
        public IActionResult GetPatientById(string id)
        {
            if (ModelState.IsValid)
            {
                return View(serviceManager.Patients.GetPatientById(id));
            }
            return View("Index");
        }


        [HttpPost]
        public IActionResult Update(Patient patient)
        {
            if (ModelState.IsValid)
            {
                serviceManager.Patients.UpdatePatient(patient);
            }
            return View("Index");
        }

        [HttpPost]
        public IActionResult Delete(string id)
        {
            if (ModelState.IsValid)
            {
                serviceManager.Patients.DeletePatient(id);
                return RedirectToAction("Index");
            }

            return View("Index");
        }







    }
}
