using Microsoft.AspNetCore.Mvc;
using PhoneBook.Interfaces;
using PhoneBook.Models;

namespace PhoneBook.Controllers
{
    public class ContactController : Controller
    {
        private readonly IContactService _contactService;

        public ContactController(IContactService categoryService)
        {
            _contactService = categoryService;
        }
        public IActionResult GetAllContacts()
        {
            IEnumerable<ContactModel> contacts =_contactService.GetAllContacts();
            return View(contacts);
        }

    }
}
