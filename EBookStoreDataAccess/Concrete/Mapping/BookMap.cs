using EBookStoreModel.Concrete;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EBookStoreDataAccess.Concrete.Mapping
{
    public class BookMap : IEntityTypeConfiguration<Book>
    {
        public void Configure(EntityTypeBuilder<Book> builder)
        {
            builder.HasKey(b => b.ID);
            builder.Property(b => b.ID).ValueGeneratedOnAdd();
            builder.Property(b => b.Name).IsRequired(true);
            builder.Property(b => b.Name).HasMaxLength(250);
            builder.Property(b => b.Description).IsRequired(true);
            builder.Property(b => b.Description).HasColumnType("NVARCHAR(MAX)");
            builder.Property(b => b.NumberOfPages).IsRequired();
            builder.Property(b => b.PublishYear).IsRequired();
            builder.Property(b => b.Condition).IsRequired();
            builder.Property(b => b.Status).IsRequired();
            builder.Property(b => b.Stock).IsRequired();
            builder.Property(b => b.Price).IsRequired();
            builder.Property(b => b.Language).IsRequired();
            builder.Property(b => b.Language).HasMaxLength(100);
            builder.Property(b => b.BookImage).IsRequired();
            builder.Property(b => b.BookImage).HasMaxLength(300);
            builder.Property(b => b.IsDeleted).IsRequired();
            builder.Property(b => b.IsActive).IsRequired();
            builder.ToTable("Books");
            //foreignkeyler
            //bire çok one to many 
            builder.HasOne<Category>(b => b.Category).WithMany(c => c.Books).HasForeignKey(b => b.CategoryID);

            builder.HasOne<PublisherHome>(b => b.PublisherHome).WithMany(p => p.Books).HasForeignKey(b => b.PublisherHomeID);

            builder.HasData(new Book
            {
                ID = 1,
                CategoryID = 1,
                Name = "Lorem Ipsum Nedir?",
                Description = "Lorem Ipsum, dizgi ve baskı endüstrisinde kullanılan mıgır metinlerdir. Lorem Ipsum, adı bilinmeyen bir matbaacının bir hurufat numune kitabı oluşturmak üzere bir yazı galerisini alarak karıştırdığı 1500'lerden beri endüstri standardı sahte metinler olarak kullanılmıştır. Beşyüz yıl boyunca varlığını sürdürmekle kalmamış, aynı zamanda pek değişmeden elektronik dizgiye de sıçramıştır. 1960'larda Lorem Ipsum pasajları da içeren Letraset yapraklarının yayınlanması ile ve yakın zamanda Aldus PageMaker gibi Lorem Ipsum sürümleri içeren masaüstü yayıncılık yazılımları ile popüler olmuştur.",
                PublishYear = 2018,
                PublisherHomeID = 1,
                Language = "Türkçe",
                NumberOfPages = 256,
                Stock = 2,
                Status = EBookStoreCore.Utilities.ClassEnum.Status.New,
                Condition = EBookStoreCore.Utilities.ClassEnum.Condition.Normal,
                IsActive = true,
                IsDeleted = false,
                Price = 5,
                CreatedDate=DateTime.Now,
                BookImage = "https://encrypted-tbn0.gstatic.com/images?q=tbn%3AANd9GcSX4wVGjMQ37PaO4PdUVEAliSLi8-c2gJ1zvQ&usqp=CAU ",
            });



        }
    }
}
