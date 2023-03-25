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
    public class CategoryMap : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasKey(c => c.ID);
            builder.Property(c => c.ID).ValueGeneratedOnAdd();
            builder.Property(c => c.Name).IsRequired();
            builder.Property(c => c.Name).HasMaxLength(80);
            builder.Property(c => c.Description).HasMaxLength(500);
            builder.Property(c => c.IsDeleted).IsRequired();
            builder.Property(c => c.IsActive).IsRequired();
            builder.ToTable("Categories");



            builder.HasData(new Category
            {
                ID = 1,
                Name = "Roman",
                Description = "Roman türüne ait kitaplar bu kategoride bulunmaktadır",
                IsActive = true,
                IsDeleted = false,
                CreatedDate = DateTime.Now,
            },
            new Category
            {
                ID = 2,
                Name = "Hikaye",
                Description = "Hikaye türüne ait kitaplar bu kategoride bulunmaktadır",
                IsActive = true,
                IsDeleted = false,
                CreatedDate = DateTime.Now,

            }
            );

        }
    }
}
