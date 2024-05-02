using Appointment_calendar.Domain.DatabaseAccess;
using Appointment_calendar.Domain.Entities.Concreate;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Appointment_calendar.Areas.Therapist.Controllers
{

    [Area("Therapist")]
    public class UserController : Controller
    {
        private readonly ServiceManager serviceManager;

        public UserController(ServiceManager serviceManager)
        {
            this.serviceManager = serviceManager;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View(serviceManager.UserServices.GetUsers());
        }

        public IActionResult Create()
        {
            return View();
        }



        [HttpPost]
        public IActionResult Create(User user)
        {
            if (ModelState.IsValid)
            {
                serviceManager.UserServices.CreateUser(user);
                return RedirectToAction("Index");
            }

            return View(user);
        }


        [HttpPost]
        public IActionResult Update(User user)
        {
            if (ModelState.IsValid)
            {
                serviceManager.UserServices.UpdateUser(user);
            }
            return View("Index");
        }

        [HttpPost]
        public IActionResult Delete(string id)
        {
            if (ModelState.IsValid)
            {
                serviceManager.UserServices.DeleteUser(id);
                return RedirectToAction("Index");
            }

            return View("Index");
        }







    }
}
