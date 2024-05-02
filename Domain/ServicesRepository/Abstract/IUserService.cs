using Appointment_calendar.Domain.Entities.Concreate;

namespace Appointment_calendar.Domain.ServicesRepository.Abstract
{
	public interface IUserService
	{
		public void CreateUser(User user);
		public IQueryable<User> GetUsers();
        public User GetUserById(string id);
		public bool UpdateUser(User user);
		public void DeleteUser(string id);




    }
}
