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
                Text= "Lorem Ipsum pasajlarının birçok çeşitlemesi vardır. Ancak bunların büyük bir çoğunluğu mizah katılarak veya rastgele sözcükler eklenerek değiştirilmişlerdir. Eğer bir Lorem Ipsum pasajı kullanacaksanız, metin aralarına utandırıcı sözcükler gizlenmediğinden emin olmanız gerekir. İnternet'teki tüm Lorem Ipsum üreteçleri önceden belirlenmiş metin bloklarını yineler. Bu da, bu üreteci İnternet üzerindeki gerçek Lorem Ipsum üreteci yapar. Bu üreteç, 200'den fazla Latince sözcük ve onlara ait cümle yapılarını içeren bir sözlük kullanır. Bu nedenle, üretilen Lorem Ipsum metinleri yinelemelerden, mizahtan ve karakteristik olmayan sözcüklerden uzaktır.",
                CreatedDate=DateTime.Now,
                CommentAddDate=DateTime.Now,

            });


        }
    }
}
