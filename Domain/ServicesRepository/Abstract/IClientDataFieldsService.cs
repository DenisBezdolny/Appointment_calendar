using Appointment_calendar.Domain.Entities.Concreate;

namespace Appointment_calendar.Domain.ServicesRepository.Abstract
{
	public interface IClientDataFieldsService
	{
		IQueryable<ClientDataField> GetClientDataFields();
		ClientDataField GetClientDataFieldById(Guid id);
		void SaveClientDataField(ClientDataField entity);
		void DeleteClientDataField(Guid id);
	}
}
