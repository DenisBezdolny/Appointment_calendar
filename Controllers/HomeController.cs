using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Appointment_calendar.Models;
using Appointment_calendar.Domain.DatabaseAccess;

namespace Appointment_calendar.Controllers;

public class HomeController : Controller
{
    private readonly ServiceManager serviceManager;

    public HomeController(ServiceManager dataManager)
    {
        this.serviceManager = dataManager;
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
}
