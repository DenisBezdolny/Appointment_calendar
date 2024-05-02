using Appointment_calendar.Domain.Entities.Concreate;
using Appointment_calendar.Domain.ServicesRepository.Abstract;



namespace Appointment_calendar.Domain.DatabaseAccess
{
    public class ServiceManager
    {
        public ITextFieldsService TextFields { get; set; }
        public IServiceItemService ServiceItems { get; set; }   
        public IClientDataFieldsService ClientDataFields { get; set; }
        public IUserService UserServices { get; set; }

        public ServiceManager(ITextFieldsService textFieldsRepository, 
            IServiceItemService serviceItemService, IClientDataFieldsService clientDataFieldsService,
            IUserService userService)
        {
            TextFields = textFieldsRepository;
            ServiceItems = serviceItemService;
            ClientDataFields = clientDataFieldsService;
            UserServices = userService;

        }
    }
}
