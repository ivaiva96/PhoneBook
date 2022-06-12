using System.Collections.Generic;

namespace PhoneBook.Entities
{
    public class Favourites
    {
       public Guid ID { get; set; }
        public string GroupName { get; set; }
        public Guid UID { get; set; }
       // public List ContactID { get; set; }
    }
}
