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


        
    }
}
