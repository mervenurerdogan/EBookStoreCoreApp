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
    public class UserMap : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(u => u.ID);
            builder.Property(u=>u.ID).ValueGeneratedOnAdd();
            builder.Property(u=>u.Name).IsRequired();
            builder.Property(u=>u.Name).HasMaxLength(50);
            builder.Property(u=>u.Surname).IsRequired();
            builder.Property(u=>u.Surname).HasMaxLength(50);
            builder.Property(u=>u.UserName).IsRequired();
            builder.Property(u=>u.UserName).HasMaxLength(50);
            builder.Property(u => u.Password).IsRequired();
            builder.Property(u => u.Password).HasMaxLength(10);
            builder.Property(u => u.EMail).IsRequired();
            builder.Property(u => u.PhoneNumber).IsRequired();
            builder.Property(u => u.Address).IsRequired();
            builder.Property(u => u.BirthDate).IsRequired();
            builder.Property(u => u.UserImage).IsRequired();
            builder.Property(u => u.UserImage).HasMaxLength(300);
            builder.Property(u => u.IsDeleted).IsRequired();
            builder.Property(u => u.IsActive).IsRequired();

            builder.ToTable("Users");

            //foreign key one to many

            builder.HasOne<Role>(r=>r.Role).WithMany(u=>u.Users).HasForeignKey(u=>u.RoleID);

            builder.HasData(new User
            {
                ID = 1,
                Name="Merve",
                Surname="Erdoğannnnnn",
                RoleID=1,
                UserName="merveeeeenureeee",
                Password="avavav",
                EMail="merveee@gmail.com",
                PhoneNumber="222222222",
                IsActive=true,
                IsDeleted=false,
                BirthDate=DateTime.Now,
                Address="Merkezz dskfjf",
                UserImage= "https://encrypted-tbn0.gstatic.com/images?q=tbn%3AANd9GcSX4wVGjMQ37PaO4PdUVEAliSLi8-c2gJ1zvQ&usqp=CAU ",
                CreatedDate=DateTime.Now,


            });

        




        }
    }
}
