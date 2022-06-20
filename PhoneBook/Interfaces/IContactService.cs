using PhoneBook.Models;

namespace PhoneBook.Interfaces
{
    public interface IContactService
    {
       IEnumerable<ContactModel> GetAllContacts();
    }
}
