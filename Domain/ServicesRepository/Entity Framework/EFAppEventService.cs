using Appointment_calendar.Domain.DatabaseAccess;
using Appointment_calendar.Domain.Entities.Concreate;
using Appointment_calendar.Domain.ServicesRepository.Abstract;
using Microsoft.EntityFrameworkCore;

namespace Appointment_calendar.Domain.ServicesRepository.Entity_Framework
{
    public class EFAppEventService : IAppEventService
    {
        private readonly AppDbContext context;
        public EFAppEventService(AppDbContext context)
        {
            this.context = context;
        }

        public IQueryable<AppEvent> GetEvents()
        {
            return context.AppEvents;
        }

        public AppEvent GetEventById(string id)
        {
            return context.AppEvents.FirstOrDefault(x => x.Id == id);
        }

        public void SaveEvent(AppEvent entity)
        {
            if (entity.Id != default)
                context.Entry(entity).State = EntityState.Added;
            else
                context.Entry(entity).State = EntityState.Modified;
            context.SaveChanges();
        }

        public void DeleteEvent(string id)
        {
            context.AppEvents.Remove(new AppEvent() { Id = id });
            context.SaveChanges();
        }
    }
}
