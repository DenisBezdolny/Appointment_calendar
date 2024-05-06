using System.ComponentModel.DataAnnotations;

namespace Appointment_calendar.Domain.Entities.Concreate
{
    public class Patient:User
    {
        [Display(Name = "Дата рождения")]
        public DateTime? DateOfBirth { get; set; }

        [Display(Name = "Место жительства")]
        public string? Place { get; set; }

        [Display(Name = "Контакт в телеграме")]
        public string? TelgramContact { get; set; }

        [Display(Name = "Описание")]
        public string? Description { get; set; }

        [Display(Name = "Ссылка Google Meet")]
        public string? MeetLink { get; set; }

        public IEnumerable <AppEvent> AppEvents { get; set; } = new List <AppEvent>();


    }
}
