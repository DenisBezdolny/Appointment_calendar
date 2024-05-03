using System.Web;
using Appointment_calendar.Domain.Entities.Concreate;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Calendar.v3;
using Google.Apis.Calendar.v3.Data;
using Google.Apis.Services;
using Google.Apis.Util.Store;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;




namespace Appointment_calendar.Areas.Therapist.Controllers
{
    [Area("Therapist")]
    public class EventController : Controller
    {

        public List<AppEvent> GoogleEvents = new List<AppEvent>();
        static string[] Scopes = { CalendarService.Scope.CalendarReadonly };
        static string ApplicationName = "app";
        

        //private const string CalendarId = "SOME-GOOGLE-CALENDAR-ID";
        //// GET: EventController
        public ActionResult Index()
        {
            CalendarEvents();
            ViewBag.EventList = GoogleEvents;
            return View();
        }


        public void CalendarEvents()
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

            // Create the service.
            var service = new CalendarService(new BaseClientService.Initializer()
            {
                HttpClientInitializer = credential,
                ApplicationName = ApplicationName,
            });

            EventsResource.ListRequest request = service.Events.List(calendarId);
            request.TimeMinDateTimeOffset = DateTime.Now;
            request.ShowDeleted = false;
            request.SingleEvents = true;
            request.MaxResults = 10;
            request.OrderBy = EventsResource.ListRequest.OrderByEnum.StartTime;



           
        }



      
    }
}
