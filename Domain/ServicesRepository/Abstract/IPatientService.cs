using Appointment_calendar.Domain.Entities.Concreate;

namespace Appointment_calendar.Domain.ServicesRepository.Abstract
{
	public interface IPatientService
	{
		public void CreatePatient(Patient patient);
		public IQueryable<Patient> GetPatients();
        public Patient GetPatientById(string id);
		public bool UpdatePatient(Patient patient);
		public void DeletePatient(string id);




    }
}
