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
    public class BookAuthorMap : IEntityTypeConfiguration<BookAuthor>
    {
        public void Configure(EntityTypeBuilder<BookAuthor> builder)
        {
            builder.HasKey(ba => ba.ID);
            builder.Property(ba => ba.ID).ValueGeneratedOnAdd();
            builder.Property(ba => ba.IsDeleted).IsRequired();
            builder.Property(ba => ba.IsActive).IsRequired();
            builder.ToTable("BookAuthors");
          

            // many to many bir yazarın birden fazla kitabı olabilir bir kitabın birden fazla yazarı olanilir
            builder.HasOne(ba=>ba.Book).WithMany(b=>b.BookAuthors).HasForeignKey(ba=>ba.BookID);
            builder.HasOne(ba => ba.Author).WithMany(a => a.BookAuthors).HasForeignKey(ba => ba.AuthorID);

            builder.HasData(new BookAuthor 
            { ID = 1,
            BookID=1,
            AuthorID=1,
            CreatedDate=DateTime.Now,
            IsActive=true,
            IsDeleted=false,
            
            
            });

        }
    }
}
