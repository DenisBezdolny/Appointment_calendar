using Appointment_calendar.Domain.DatabaseAccess;
using Appointment_calendar.Domain.Entities.Concreate;
using Appointment_calendar.Domain.ServicesRepository.Abstract;
using Microsoft.EntityFrameworkCore;

namespace Appointment_calendar.Domain.ServicesRepository.Entity_Framework
{
	public class EFClientDataFieldsService : IClientDataFieldsService
	{
		private readonly AppDbContext context;
		public EFClientDataFieldsService(AppDbContext context)
		{
			this.context = context;
		}

		public IQueryable<ClientDataField> GetClientDataFields()
		{
			return context.ClientDataFields;
		}

		public ClientDataField GetClientDataFieldById(Guid id)
		{
			return context.ClientDataFields.FirstOrDefault(x => x.Id == id);
		}

		public void SaveClientDataField(ClientDataField entity)
		{
			if (entity.Id == default)
				context.Entry(entity).State = EntityState.Added;
			else
				context.Entry(entity).State = EntityState.Modified;
			context.SaveChanges();
		}

		public void DeleteClientDataField(Guid id)
		{
			context.ClientDataFields.Remove(new ClientDataField() { Id = id });
			context.SaveChanges();
		}


	}
}
}
