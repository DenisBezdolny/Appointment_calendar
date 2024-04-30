using Appointment_calendar.Domain.ServicesRepository.Abstract;



namespace Appointment_calendar.Domain.DatabaseAccess
{
    public class ServiceManager
    {
        public ITextFieldsService TextFields { get; set; }


        public ServiceManager(ITextFieldsService textFieldsRepository)
        {
            TextFields = textFieldsRepository;


        }
    }
}
