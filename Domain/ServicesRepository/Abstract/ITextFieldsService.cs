using System;
using System.Linq;
using Appointment_calendar.Domain.Entities.Concreate;

namespace Appointment_calendar.Domain.ServicesRepository.Abstract
{
    public interface ITextFieldsService
    {
        IQueryable<TextField> GetTextFields();
        TextField GetTextFieldById(Guid id);
        TextField GetTextFieldByCodeWord(string codeWord);
        void SaveTextField(TextField entity);
        void DeleteTextField(Guid id);
    }
}
