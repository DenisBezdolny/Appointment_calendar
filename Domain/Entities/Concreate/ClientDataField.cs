using Appointment_calendar.Domain.Entities.Abstract;
using System.ComponentModel.DataAnnotations;

namespace Appointment_calendar.Domain.Entities.Concreate
{
	public class ClientDataField : PageEntityBase
	{
		[Required]
		[Display(Name = "Ваше имя*")]
		public string Name { get; set; }

        [Required]
        [Display(Name = "Ваша фамилия*")]
		public string LustName { get; set; }

        [Required]
        [Display(Name = "Ваш номер телефона*")]
		[DataType(DataType.PhoneNumber)]
		public string Phone { get; set; }

		[Display(Name = "Ваш Email")]
		[DataType(DataType.EmailAddress)]
		public string Email { get; set; }

		[Display(Name = "Ваш контакт в телеграме")]
		public string TelgramContact { get; set; }

		[Display(Name = "Услуга")]
		public string Service { get; set; }

        [Required]
        [Display(Name = "Описание проблемы*")]
        public string DescriptionOfProblem { get; set; }

    }
}
