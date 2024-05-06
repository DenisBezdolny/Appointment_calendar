using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Appointment_calendar.Domain.Entities.Concreate
{
    public class AppEvent
    {

        [Key]
        public string Id { get; set; } = Guid.NewGuid().ToString();

        [Required]
        [DataType(DataType.Date)]
        public DateTime Date { get; set; }

        [Required]
        [DataType(DataType.Time)]
        public DateTime Start { get; set; }

        [Required]
        [DataType(DataType.Time)]
        public DateTime End { get; set; }

        public Patient? Patient { get; set; }

        [Required]
        public string? Description { get; set; }
    }
}
