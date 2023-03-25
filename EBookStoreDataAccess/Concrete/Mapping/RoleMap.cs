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
    public class RoleMap : IEntityTypeConfiguration<Role>
    {
        public void Configure(EntityTypeBuilder<Role> builder)
        {
            builder.HasKey(r => r.ID);
            builder.Property(r=>r.ID).ValueGeneratedOnAdd();
            builder.Property(r => r.Roles).IsRequired();
            builder.Property(r => r.Description).IsRequired();
            builder.Property(r => r.Description).HasColumnType("VARCHAR(MAX)");
            builder.Property(r => r.IsDeleted).IsRequired();
            builder.Property(r => r.IsActive).IsRequired();
            builder.ToTable("Roles");

            builder.HasData(new Role
            {
                ID = 1,
                Roles = EBookStoreCore.Utilities.ClassEnum.Roles.Admin,
                Description = "Admininn yapacağı işlevlerin gerekli açıklamaları",
                IsActive = true,
                IsDeleted = false,
                CreatedDate = DateTime.Now,

            });



        }
    }
}
