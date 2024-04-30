using Appointment_calendar.Domain.Entities.Abstract;
using System.ComponentModel.DataAnnotations;

namespace Appointment_calendar.Domain.Entities.Concreate
{
	public class ServiceItem : PageEntityBase
	{
		[Required(ErrorMessage = "Заполните название услуги")]
		[Display(Name = "Название услуги")]
		public override string Title { get; set; }

		[Display(Name = "Краткое описание услуги")]
		public override string Subtitle { get; set; }

		[Display(Name = "Полное описание услуги")]
		public override string Text { get; set; }


	}
}
