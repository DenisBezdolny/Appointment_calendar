using Appointment_calendar.Domain.DatabaseAccess;
using Appointment_calendar.Domain.Entities.Concreate;
using Appointment_calendar.Domain.ServicesRepository.Abstract;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics.Metrics;
using System.Linq;

namespace Appointment_calendar.Domain.ServicesRepository.Entity_Framework
{
	public class EFPatientService : IPatientService
	{
        private readonly AppDbContext context;

        public EFPatientService(AppDbContext context)
        {
            this.context = context;
        }

        public void CreatePatient(Patient patient)
        {
            if (patient.Id != default)
            {
                new IdentityUserRole<string>() { RoleId = "ee560ba8-3277-4414-9a66-300fb2ffae38", UserId = patient.Id };

                context.Entry(patient).State = EntityState.Added;
            }    
                
            else
                context.Entry(patient).State = EntityState.Modified;
            context.SaveChanges();
        }

        public void DeletePatient(string id)
        {
            var patient = context.Patients.FirstOrDefault(x => x.Id == id);
            context.Patients.Remove(patient);
            context.SaveChanges();
        }

        public Patient GetPatientById(string id)
        {
            return context.Patients.FirstOrDefault(x => x.Id == id);
        }

        public IQueryable<Patient> GetPatients()
        {
            return context.Patients;
        }

        public bool UpdatePatient(Patient patient)
        {
            throw new NotImplementedException();
        }

    }

}

