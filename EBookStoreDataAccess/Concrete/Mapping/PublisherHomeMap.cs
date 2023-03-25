using EBookStoreModel.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EBookStoreDataAccess.Concrete.Mapping
{
    public class PublisherHomeMap : IEntityTypeConfiguration<PublisherHome>
    {
        public void Configure(EntityTypeBuilder<PublisherHome> builder)
        {
            builder.HasKey(p => p.ID);
            builder.Property(p=>p.ID).ValueGeneratedOnAdd();
            builder.Property(p => p.Name).IsRequired();
            builder.Property(p => p.Name).HasMaxLength(200);
            builder.Property(p => p.Address).HasMaxLength(300);
            builder.Property(p => p.Address).IsRequired();
            builder.Property(p => p.PhoneNumber).IsRequired();
            builder.Property(p => p.PhoneNumber).HasMaxLength(11);
            builder.Property(p => p.IsDeleted).IsRequired();
            builder.Property(p => p.IsActive).IsRequired();
            builder.ToTable("PublisherHomes");

            //foreign key one to many
            builder.HasOne<City>(c => c.City).WithMany(p => p.PublisherHomes).HasForeignKey(p => p.CityID);

            builder.HasData(new PublisherHome
            {
                ID = 1,
                Name = "A YayınEvi",
                Address = "Blla balaaa",
                CityID = 1,
                PhoneNumber = "22258884",
                IsActive = true,
                IsDeleted = false,
                CreatedDate=DateTime.Now,


            });
            
        }
    }
}
