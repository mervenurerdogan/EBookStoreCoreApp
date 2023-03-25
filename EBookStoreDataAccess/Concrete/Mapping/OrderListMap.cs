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
    public class OrderListMap : IEntityTypeConfiguration<OrderList>
    {
        public void Configure(EntityTypeBuilder<OrderList> builder)
        {
            builder.HasKey(ol => ol.ID);
            builder.Property(ol => ol.ID).ValueGeneratedOnAdd();
            builder.Property(ol => ol.Quantity).IsRequired();
            builder.Property(ol => ol.TotalOrder).IsRequired();
            builder.Property(ol => ol.IsActive).IsRequired();
            builder.Property(ol => ol.IsDeleted).IsRequired();
            builder.ToTable("OrderList");

            //foreign key  many to many

            builder.HasOne(ol => ol.Book).WithMany(b => b.OrderLists).HasForeignKey(ol => ol.BookID);
            builder.HasOne(ol=>ol.Order).WithMany(o=>o.OrderLists).HasForeignKey(ol => ol.OrderID);



        }
    }
}
