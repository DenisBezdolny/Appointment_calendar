using Appointment_calendar.Domain.DatabaseAccess;
using Appointment_calendar.Domain.Entities.Concreate;
using Appointment_calendar.Models;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Calendar.v3;
using Google.Apis.Calendar.v3.Data;
using Google.Apis.Services;
using Google.Apis.Util.Store;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Identity.Client;
using System.Collections.Generic;





namespace Appointment_calendar.Areas.Therapist.Controllers
{
    [Area("Therapist")]
    public class EventController : Controller
    {
        private readonly ServiceManager serviceManager;

        public EventController(ServiceManager serviceManager)
        {
            this.serviceManager = serviceManager;
        }


        public List<AppEvent> GoogleEvents = new List<AppEvent>();
        static string[] Scopes = { CalendarService.Scope.Calendar };
        static string ApplicationName = "app";


        //private const string CalendarId = "SOME-GOOGLE-CALENDAR-ID";
        //// GET: EventController
        public ActionResult Index()
        {
            return View(serviceManager.AppEvents.GetEvents());
        }
        public ActionResult CreateEvent()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateEvent(AppEvent appEvent)
        {
            if (ModelState.IsValid)
            {
                serviceManager.AppEvents.SaveEvent(appEvent);
                AddAppEventInGoogleCalendar(appEvent);
                return RedirectToAction("Index");
            }

            return View(appEvent);
        }

        public void AddAppEventInGoogleCalendar(AppEvent appEvent)
        {
            UserCredential credential;
            var calendarId = "c8aaea13ba64a77219c97155c6d7c53c8aefc7c878122555f57d42a16fdf1578@group.calendar.google.com";
            string path = "Credentials.json";
            using (var stream = new FileStream(path, FileMode.Open,
            FileAccess.Read))
            {
                string credPath = "token.json";
                credential = GoogleWebAuthorizationBroker.AuthorizeAsync(
               GoogleClientSecrets.FromStream(stream).Secrets, Scopes, "user",
               CancellationToken.None, new FileDataStore(credPath, true)).Result;
            }

            DateTime dateForGoogleStart = DateTime.Parse(appEvent.Date.ToString("yyyy-MM-dd") 
                + " " + appEvent.Start.ToString("HH:mm:ss"));
            DateTime dateForGoogleEnd = DateTime.Parse(appEvent.Date.ToString("yyyy-MM-dd") 
                + " " + appEvent.End.ToString("HH:mm:ss"));
            // Create the service.
            var service = new CalendarService(new BaseClientService.Initializer()
            {
                HttpClientInitializer = credential,
                ApplicationName = ApplicationName,
            });

            if (appEvent.Patient != null && appEvent.Patient.Email != null)
            {
                Event newEvent = new Event()
                {
                    Description = appEvent.Description,
                    Start = new EventDateTime()
                    {
                        DateTime = dateForGoogleStart,
                        TimeZone = "Europe/Minsk",
                    },
                    End = new EventDateTime()
                    {
                        DateTime = dateForGoogleEnd,
                        TimeZone = "Europe/Minsk",
                    },
                    Recurrence = new String[] { "RRULE:FREQ=DAILY;COUNT=1" },
                    Attendees = new EventAttendee[] {
                        new EventAttendee() { Email = appEvent.Patient.Email },
                    },
                    Reminders = new Event.RemindersData()
                    {
                        UseDefault = false,
                        Overrides = new EventReminder[] {
                            new EventReminder() { Method = "email", Minutes = 24 * 60 },
                        }

                    }


                };
                EventsResource.InsertRequest request = service.Events.Insert(newEvent, calendarId);
                Event createdEvent = request.Execute();
            }
            else {
                Event newEvent = new Event()
                {
                    Description = appEvent.Description,
                    Start = new EventDateTime()
                    {
                        DateTime = dateForGoogleStart,
                        TimeZone = "Europe/Minsk",
                    },
                    End = new EventDateTime()
                    {
                        DateTime = dateForGoogleEnd,
                        TimeZone = "Europe/Minsk",
                    },
                    Recurrence = new String[] { "RRULE:FREQ=DAILY;COUNT=1" },

                };
                EventsResource.InsertRequest request = service.Events.Insert(newEvent, calendarId);
                Event createdEvent = request.Execute();
            }

        }

        //public void RemoveAppEventInGoogleCalendar(AppEvent appEvent)
        //{
        //    UserCredential credential;
        //    var calendarId = "c8aaea13ba64a77219c97155c6d7c53c8aefc7c878122555f57d42a16fdf1578@group.calendar.google.com";
        //    string path = "Credentials.json";
        //    using (var stream = new FileStream(path, FileMode.Open,
        //    FileAccess.Read))
        //    {
        //        string credPath = "token.json";
        //        credential = GoogleWebAuthorizationBroker.AuthorizeAsync(
        //       GoogleClientSecrets.FromStream(stream).Secrets, Scopes, "user",
        //       CancellationToken.None, new FileDataStore(credPath, true)).Result;
        //    }

        //    // Create the service.
        //    var service = new CalendarService(new BaseClientService.Initializer()
        //    {
        //        HttpClientInitializer = credential,
        //        ApplicationName = ApplicationName,
        //    });



        //        EventsResource.InsertRequest request = service.Events.Insert(newEvent, calendarId);
        //        Event createdEvent = request.Execute();
            
        //}


            [HttpPost]
        public ActionResult DeleteIvent(string id)
        {
            if (ModelState.IsValid)
            {
                serviceManager.AppEvents.DeleteEvent(id);

                
                return RedirectToAction("Index");
            }
            return View("Index");   
        }

    }
    
}
