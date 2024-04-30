using Microsoft.AspNetCore.Identity;

namespace Appointment_calendar.Domain.Entities.Concreate
{
	public class User : IdentityUser
	{
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public DateTime? DateOfBirth { get; set; }

	}
}
