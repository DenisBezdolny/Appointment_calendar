using System;
using System.Linq;
using Appointment_calendar.Domain.Entities.Concreate;

namespace Appointment_calendar.Domain.ServicesRepository.Abstract
{
    public interface IServiceItemService
	{
		IQueryable<ServiceItem> GetServiceItems();
		ServiceItem GetServiceItemById(Guid id);
		void SaveServiceItem(ServiceItem entity);
		void DeleteServiceItem(Guid id);
	}
}
