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
    public class AuthorMap : IEntityTypeConfiguration<Author>
    {
        public void Configure(EntityTypeBuilder<Author> builder)
        {
            builder.HasKey(a => a.ID);
            builder.Property(a => a.ID).ValueGeneratedOnAdd();
            builder.Property(a => a.FirstName).IsRequired(true);
            builder.Property(a => a.FirstName).HasMaxLength(50);
            builder.Property(a => a.SurName).IsRequired(true);
            builder.Property(a => a.SurName).HasMaxLength(50);
            builder.Property(a => a.EMail).IsRequired(true);
            builder.Property(a => a.IsDeleted).IsRequired(true);
            builder.Property(a => a.IsActive).IsRequired(true);
            builder.ToTable("Authors");



            //vt kayıt yapılırken eklenen ilk veriler
            builder.HasData(new Author
            { ID=1,
            FirstName="Fisun",
            SurName="Atay",
            IsActive=true,
            IsDeleted=false,
            CreatedDate=DateTime.Now,


            },
            new Author
            {
                ID=2,
                FirstName="Ceylan",
                SurName= "Ertem",
                IsActive=true,
                IsDeleted=false,
                CreatedDate=DateTime.Now,
            }
            
            );

          
            
            

               

        }
    }
}
