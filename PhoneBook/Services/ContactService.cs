using PhoneBook.Interfaces;
using PhoneBook.Mapper;
using PhoneBook.Models;

namespace PhoneBook.Services
{
    public class ContactService : IContactService
    {
        private readonly PhonebookContext _context;

        private readonly IMapper<Entities.Contact, ContactModel> _contactMapper;

        public ContactService(PhonebookContext context)
        {
            _contactMapper = new ContactMapper();
            _context = context;
        }
        public IEnumerable<ContactModel> GetAllContacts()
        {
            var contacts = new List<ContactModel>();
            foreach (var item in _context.Contacts)
            {
                contacts.Add(_contactMapper.MapFromEntityToModel(item));
            }
            return contacts;
        }
    }
}
