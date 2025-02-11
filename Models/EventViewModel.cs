using Appointment_calendar.Domain.Entities.Concreate;

namespace Appointment_calendar.Models
{
    public class EventViewModel
    {
        public EventViewModel(IEnumerable<Patient> patient, AppEvent appEvent)
        {
            PatientsInEventViewModel = patient;
            AppEventInEventViewModel = appEvent;
        }

        public IEnumerable<Patient> PatientsInEventViewModel { get; set; }

        public AppEvent AppEventInEventViewModel { get; set; }

        public Patient PatientInAppEvent { get; set; }
    }
}
