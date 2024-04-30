using Appointment_calendar.Domain.Entities.Abstract;
using System.ComponentModel.DataAnnotations;

namespace Anppointment_calendar.Domain.Entities.Concreate
{
    public class TextField : PageEntityBase
	{
        [Required]
        public string CodeWord { get; set; }

        [Display(Name = "Название страницы (заголовок)")]
        public override string Title { get; set; } = "Информационная страница";

        [Display(Name = "Cодержание страницы")]
        public override string Text { get; set; } = "Содержание заполняется администратором";
    }
}
