using EBookStoreModel.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EBookStoreDataAccess.Concrete.Mapping
{
    public class CityMap : IEntityTypeConfiguration<City>
    {
        public void Configure(EntityTypeBuilder<City> builder)
        {
            builder.HasKey(c => c.ID);
            builder.Property(c=>c.ID).ValueGeneratedOnAdd();
            builder.Property(c=>c.Name).IsRequired();
            builder.Property(c=>c.IsDeleted).IsRequired();
            builder.Property(c=>c.IsActive).IsRequired();
            builder.ToTable("Cities");

            builder.HasData(new City
            {
                ID = 1,
                Name="Aksaray"
            });
        }
    }
}
