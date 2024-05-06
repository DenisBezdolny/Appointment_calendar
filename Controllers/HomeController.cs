using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Appointment_calendar.Models;
using Appointment_calendar.Domain.DatabaseAccess;

namespace Appointment_calendar.Controllers;

public class HomeController : Controller
{
    private readonly ServiceManager serviceManager;

    public HomeController(ServiceManager serviceManager)
    {
        this.serviceManager = serviceManager;
    }

    public IActionResult Index()
    {
        return View(serviceManager.TextFields.GetTextFieldByCodeWord("PageIndex"));
    }

    public IActionResult Contacts()
    {
        return View(serviceManager.TextFields.GetTextFieldByCodeWord("PageContacts"));
    }

    public IActionResult AboutUs()
    {
        return View(serviceManager.TextFields.GetTextFieldByCodeWord("PageAboutUs"));
    }
    public IActionResult Services(Guid id)
    {
        if (id != default)
        {
            return View("ShowService", serviceManager.ServiceItems.GetServiceItemById(id));
        }

        ViewBag.TextField = serviceManager.TextFields.GetTextFieldByCodeWord("PageServices");
        return View(serviceManager.ServiceItems.GetServiceItems());
    }
}
