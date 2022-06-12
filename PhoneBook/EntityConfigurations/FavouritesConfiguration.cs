using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PhoneBook.Entities;

namespace PhoneBook.EntityConfigurations
{
    public class FavouritesConfiguration : IEntityTypeConfiguration<Favourites>
    {
        public void Configure(EntityTypeBuilder<Favourites> builder)
        {
            builder.HasKey(x => x.ID);
        }
    }
}
