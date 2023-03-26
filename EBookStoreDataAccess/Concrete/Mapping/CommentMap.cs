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
    public class CommentMap : IEntityTypeConfiguration<Comment>
    {
        public void Configure(EntityTypeBuilder<Comment> builder)
        {
            builder.HasKey(c => c.ID);
            builder.Property(c => c.ID).ValueGeneratedOnAdd();
            builder.Property(c => c.Text).IsRequired();
            builder.Property(c => c.Text).HasMaxLength(300);
            builder.Property(c => c.IsDeleted).IsRequired();
            builder.Property(c => c.IsActive).IsRequired();
            builder.Property(c => c.CommentAddDate).IsRequired();
            builder.ToTable("Comments");


            //foreign key one to many
            builder.HasOne<Book>(b=>b.Book).WithMany(c => c.Comments).HasForeignKey(c=>c.BookID);

            builder.HasOne<User>(u => u.User).WithMany(c => c.Comments).HasForeignKey(c => c.UserID);

            builder.HasData(new Comment
            {
                ID=1,
                IsActive=true,
                IsDeleted=false,
                UserID=1,
                BookID=1,
                Text= "Lorem Ipsum pasajlarınLorem Ipsum ",
                CreatedDate=DateTime.Now,
                CommentAddDate=DateTime.Now,

            });


        }
    }
}
