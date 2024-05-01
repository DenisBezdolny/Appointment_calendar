using Appointment_calendar.Domain.Entities.Concreate;

namespace Appointment_calendar.Domain.ServicesRepository.Abstract
{
	public interface IUserService
	{
		public void CreateUser(User user);
		public List<User> GetUsers();
		public User GetUserById(string id);
		public bool UpdateUser(User user);
		public bool DeleteUser(string userId);



	}
}
