using Microsoft.EntityFrameworkCore;
using PhoneBook.Entities;
using PhoneBook.EntityConfigurations;

namespace PhoneBook
{
    public class PhonebookContext: DbContext
    {
        public DbSet<Contact> Contacts { get; set; }  
        public DbSet<User> Users { get; set; }
        public DbSet<Favourites> Favorites { get; set; }


        public PhonebookContext()
        {

        }

        public PhonebookContext(DbContextOptions options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ContactConfiguration());
            modelBuilder.ApplyConfiguration(new UserConfiguration());
            modelBuilder.ApplyConfiguration(new FavouritesConfiguration());
        }
    }

  
}
