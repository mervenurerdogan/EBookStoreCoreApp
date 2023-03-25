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
    public class OrderMap : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.HasKey(o => o.ID);
            builder.Property(o => o.ID).ValueGeneratedOnAdd();
            builder.Property(o => o.Payment).IsRequired();
            builder.Property(o => o.Price).IsRequired();
            builder.Property(o => o.Stok).IsRequired();
            builder.Property(o => o.IsDeleted).IsRequired();
            builder.Property(o => o.IsActive).IsRequired();
            builder.ToTable("Orders");

            //foreign key one to many 
            builder.HasOne<User>(u => u.User).WithMany(o=>o.Orders).HasForeignKey(o=>o.UserID);




        }
    }
}
