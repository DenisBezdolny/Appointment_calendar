using Appointment_calendar.Domain.Entities.Concreate;

namespace Appointment_calendar.Domain.ServicesRepository.Abstract
{
    public interface IAppEventService
    {
        IQueryable<AppEvent> GetEvents();
        AppEvent GetEventById(string id);
        void SaveEvent(AppEvent entity);
        void DeleteEvent(string id);
    }
}
