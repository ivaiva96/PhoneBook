using PhoneBook.Entities;
using PhoneBook.Interfaces;
using PhoneBook.Models;

namespace PhoneBook.Mapper
{
    public class ContactMapper : IMapper<Entities.Contact, ContactModel>
    {
        public ContactModel MapFromEntityToModel(Contact source)
        {
            return new ContactModel()
            {
                ID = source.ID,
                Name = source.Name,
                LastName = source.LastName,
                PhoneNumber = source.PhoneNumber,
                DateOfBirth = source.DateOfBirth,
                Gender = source.Gender,
                City = source.City,
                Adress = source.Adress,
                AdditionalInfo = source.AdditionalInfo,
                IsFavourite = source.IsFavourite,
            };
        }

        public Contact MapFromModelToEntity(ContactModel source)
        {
            var entity = new Entities.Contact();

            MapFromModelToEntity(source, entity);

            return entity;
        }

        public void MapFromModelToEntity(ContactModel source, Contact target)
        {
            target.ID = source.ID;
            target.Name = source.Name;
            target.LastName = source.LastName;
            target.PhoneNumber = source.PhoneNumber;
            target.DateOfBirth = source.DateOfBirth;
            target.Gender = source.Gender;
            target.City = source.City;
            target.Adress = source.Adress;
            target.AdditionalInfo = source.AdditionalInfo;
            target.IsFavourite = source.IsFavourite;
        }
    }
}
