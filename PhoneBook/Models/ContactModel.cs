using PhoneBook.Enums;
using System.ComponentModel.DataAnnotations;

namespace PhoneBook.Models
{
    public class ContactModel
    {
        public Guid ID { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public Genders Gender { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string PhoneNumber { get; set; }
        public Cities City { get; set; }
        public string Adress { get; set; }
        public string AdditionalInfo { get; set; }
        public bool IsFavourite { get; set; }
    }
}
