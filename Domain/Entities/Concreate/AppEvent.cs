using System.ComponentModel.DataAnnotations;

namespace Appointment_calendar.Domain.Entities.Concreate
{
    public class AppEvent
    {
        [Key]
        [Required]
        public string Id { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime Date { get; set; }

        [Required]
        public string Start { get; set; }

        [Required]
        public string End { get; set; }

        [Required]
        public User? User { get; set; }

        [Required]
        public string? Description { get; set; }


    }
}
