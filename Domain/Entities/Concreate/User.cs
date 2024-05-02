using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace Appointment_calendar.Domain.Entities.Concreate
{
	public class User : IdentityUser
	{

        [Display(Name = "Имя")]
        public string? FirstName { get; set; }
        [Display(Name = "Фамилия")]
        public string? LastName { get; set; }
        [Display(Name = "Дата рождения")]
        public DateTime? DateOfBirth { get; set; }
        [Display(Name = "Место жительства")]
        public string? Place { get; set; }
        [Display(Name = "Описание")]
        public string? Description { get; set; }
    }
}
