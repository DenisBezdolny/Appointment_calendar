using Appointment_calendar.Domain.DatabaseAccess;
using Appointment_calendar.Domain.Entities.Concreate;
using Appointment_calendar.Domain.ServicesRepository.Abstract;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics.Metrics;
using System.Linq;

namespace Appointment_calendar.Domain.ServicesRepository.Entity_Framework
{
	public class EFUserService : IUserService
	{
        private readonly AppDbContext context;

        public EFUserService(AppDbContext context)
        {
            this.context = context;
        }

        public void CreateUser(User user)
        {
            if (user.Id != default)
                context.Entry(user).State = EntityState.Added;
            else
                context.Entry(user).State = EntityState.Modified;
            context.SaveChanges();
        }

        public void DeleteUser(string id)
        {
            var user = context.Users.FirstOrDefault(x => x.Id == id);
            context.Users.Remove(user);
            context.SaveChanges();
        }

        public User GetUserById(string id)
        {
            throw new NotImplementedException();
        }

        //public void CreateUser(User user)
        //{
        //	userManager.CreateAsync(user).Wait();
        //}

        public IQueryable<User> GetUsers()
        {
            return context.Users;
        }

        public bool UpdateUser(User user)
        {
            throw new NotImplementedException();
        }
        //      public User GetUserById(string id)
        //{
        //	return userManager.FindByIdAsync(id).Result;
        //}


        //public bool UpdateUser(User user)
        //{
        //	try
        //	{
        //		userManager.UpdateAsync(user).Wait();
        //		return true;
        //	}
        //	catch
        //	{
        //		return false;
        //	}
        //}

        //public bool DeleteUser(string userId)
        //{
        //	var user = userManager.FindByIdAsync(userId).Result;
        //	if (user != null)
        //	{
        //		try
        //		{
        //			userManager.DeleteAsync(user).Wait();
        //			return true;
        //		}
        //		catch
        //		{
        //			return false;
        //		}
        //	}
        //	else
        //	{
        //		return false;
        //	}
        //}


    }

}

