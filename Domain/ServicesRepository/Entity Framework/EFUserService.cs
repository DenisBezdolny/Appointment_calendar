using Appointment_calendar.Domain.Entities.Concreate;
using Appointment_calendar.Domain.ServicesRepository.Abstract;
using Microsoft.AspNetCore.Identity;

namespace Appointment_calendar.Domain.ServicesRepository.Entity_Framework
{
	public class EFUserService : IUserService
	{
		private readonly UserManager<User> userManager;

		public EFUserService(UserManager<User> userManager)
		{
			_userManager = userManager;
		}

		public void CreateUser(User user)
		{
			userManager.CreateAsync(user).Wait();
		}

		public List<User> GetUsers()
		{
			return userManager.Users.ToList();
		}
		public User GetUserById(string id)
		{
			return userManager.FindByIdAsync(id).Result;
		}


		public bool UpdateUser(User user)
		{
			try
			{
				userManager.UpdateAsync(user).Wait();
				return true;
			}
			catch
			{
				return false;
			}
		}

		public bool DeleteUser(string userId)
		{
			var user = userManager.FindByIdAsync(userId).Result;
			if (user != null)
			{
				try
				{
					userManager.DeleteAsync(user).Wait();
					return true;
				}
				catch
				{
					return false;
				}
			}
			else
			{
				return false;
			}
		}


	}

}

