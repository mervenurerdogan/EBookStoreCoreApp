﻿// <auto-generated />
using System;
using EBookStoreDataAccess.Concrete.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EBookStoreDataAccess.Migrations
{
    [DbContext(typeof(EBookStoreContext))]
    [Migration("20230325232311_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("EBookStoreModel.Concrete.Author", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("EMail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("SurName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("ID");

                    b.ToTable("Authors", (string)null);

                    b.HasData(
                        new
                        {
                            ID = 1,
                            CreatedDate = new DateTime(2023, 3, 26, 2, 23, 10, 960, DateTimeKind.Local).AddTicks(2612),
                            EMail = "fisun@gmail.com",
                            FirstName = "Fisun",
                            IsActive = true,
                            IsDeleted = false,
                            SurName = "Atay"
                        },
                        new
                        {
                            ID = 2,
                            CreatedDate = new DateTime(2023, 3, 26, 2, 23, 10, 960, DateTimeKind.Local).AddTicks(2615),
                            EMail = "Ceylan@gmail.com",
                            FirstName = "Ceylan",
                            IsActive = true,
                            IsDeleted = false,
                            SurName = "Ertem"
                        });
                });

            modelBuilder.Entity("EBookStoreModel.Concrete.Book", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("BookImage")
                        .IsRequired()
                        .HasMaxLength(300)
                        .HasColumnType("nvarchar(300)");

                    b.Property<int>("CategoryID")
                        .HasColumnType("int");

                    b.Property<int>("Condition")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("NVARCHAR(MAX)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Language")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<int>("NumberOfPages")
                        .HasColumnType("int");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("PublishYear")
                        .HasColumnType("int");

                    b.Property<int>("PublisherHomeID")
                        .HasColumnType("int");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<int>("Stock")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("CategoryID");

                    b.HasIndex("PublisherHomeID");

                    b.ToTable("Books", (string)null);

                    b.HasData(
                        new
                        {
                            ID = 1,
                            BookImage = "https://encrypted-tbn0.gstatic.com/images?q=tbn%3AANd9GcSX4wVGjMQ37PaO4PdUVEAliSLi8-c2gJ1zvQ&usqp=CAU ",
                            CategoryID = 1,
                            Condition = 3,
                            CreatedDate = new DateTime(2023, 3, 26, 2, 23, 10, 959, DateTimeKind.Local).AddTicks(8908),
                            Description = "Lorem Ipsum, dizgi ve baskı endüstrisinde kullanılan mıgır metinlerdir. Lorem Ipsum, adı bilinmeyen bir matbaacının bir hurufat numune kitabı oluşturmak üzere bir yazı galerisini alarak karıştırdığı 1500'lerden beri endüstri standardı sahte metinler olarak kullanılmıştır. Beşyüz yıl boyunca varlığını sürdürmekle kalmamış, aynı zamanda pek değişmeden elektronik dizgiye de sıçramıştır. 1960'larda Lorem Ipsum pasajları da içeren Letraset yapraklarının yayınlanması ile ve yakın zamanda Aldus PageMaker gibi Lorem Ipsum sürümleri içeren masaüstü yayıncılık yazılımları ile popüler olmuştur.",
                            IsActive = true,
                            IsDeleted = false,
                            Language = "Türkçe",
                            Name = "Lorem Ipsum Nedir?",
                            NumberOfPages = 256,
                            Price = 5m,
                            PublishYear = 2018,
                            PublisherHomeID = 1,
                            Status = 1,
                            Stock = 2
                        });
                });

            modelBuilder.Entity("EBookStoreModel.Concrete.BookAuthor", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<int>("AuthorID")
                        .HasColumnType("int");

                    b.Property<int>("BookID")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.HasKey("ID");

                    b.HasIndex("AuthorID");

                    b.HasIndex("BookID");

                    b.ToTable("BookAuthors", (string)null);

                    b.HasData(
                        new
                        {
                            ID = 1,
                            AuthorID = 1,
                            BookID = 1,
                            CreatedDate = new DateTime(2023, 3, 26, 2, 23, 10, 960, DateTimeKind.Local).AddTicks(1528),
                            IsActive = true,
                            IsDeleted = false
                        });
                });

            modelBuilder.Entity("EBookStoreModel.Concrete.Category", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(80)
                        .HasColumnType("nvarchar(80)");

                    b.HasKey("ID");

                    b.ToTable("Categories", (string)null);

                    b.HasData(
                        new
                        {
                            ID = 1,
                            CreatedDate = new DateTime(2023, 3, 26, 2, 23, 10, 960, DateTimeKind.Local).AddTicks(6070),
                            Description = "Roman türüne ait kitaplar bu kategoride bulunmaktadır",
                            IsActive = true,
                            IsDeleted = false,
                            Name = "Roman"
                        },
                        new
                        {
                            ID = 2,
                            CreatedDate = new DateTime(2023, 3, 26, 2, 23, 10, 960, DateTimeKind.Local).AddTicks(6072),
                            Description = "Hikaye türüne ait kitaplar bu kategoride bulunmaktadır",
                            IsActive = true,
                            IsDeleted = false,
                            Name = "Hikaye"
                        });
                });

            modelBuilder.Entity("EBookStoreModel.Concrete.City", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Cities", (string)null);

                    b.HasData(
                        new
                        {
                            ID = 1,
                            CreatedDate = new DateTime(2023, 3, 26, 2, 23, 10, 960, DateTimeKind.Local).AddTicks(9456),
                            IsActive = true,
                            IsDeleted = false,
                            Name = "Aksaray"
                        });
                });

            modelBuilder.Entity("EBookStoreModel.Concrete.Comment", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<int>("BookID")
                        .HasColumnType("int");

                    b.Property<DateTime>("CommentAddDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Text")
                        .IsRequired()
                        .HasMaxLength(300)
                        .HasColumnType("nvarchar(300)");

                    b.Property<int>("UserID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("BookID");

                    b.HasIndex("UserID");

                    b.ToTable("Comments", (string)null);

                    b.HasData(
                        new
                        {
                            ID = 1,
                            BookID = 1,
                            CommentAddDate = new DateTime(2023, 3, 26, 2, 23, 10, 960, DateTimeKind.Local).AddTicks(8624),
                            CreatedDate = new DateTime(2023, 3, 26, 2, 23, 10, 960, DateTimeKind.Local).AddTicks(8624),
                            IsActive = true,
                            IsDeleted = false,
                            Text = "Lorem Ipsum pasajlarınLorem Ipsum ",
                            UserID = 1
                        });
                });

            modelBuilder.Entity("EBookStoreModel.Concrete.Order", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<DateTime>("OrderDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("Payment")
                        .HasColumnType("int");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("Stok")
                        .HasColumnType("int");

                    b.Property<int>("UserID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("UserID");

                    b.ToTable("Orders", (string)null);
                });

            modelBuilder.Entity("EBookStoreModel.Concrete.OrderList", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<int>("BookID")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<int>("OrderID")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<int>("TotalOrder")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("BookID");

                    b.HasIndex("OrderID");

                    b.ToTable("OrderList", (string)null);
                });

            modelBuilder.Entity("EBookStoreModel.Concrete.PublisherHome", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(300)
                        .HasColumnType("nvarchar(300)");

                    b.Property<int>("CityID")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasMaxLength(11)
                        .HasColumnType("nvarchar(11)");

                    b.HasKey("ID");

                    b.HasIndex("CityID");

                    b.ToTable("PublisherHomes", (string)null);

                    b.HasData(
                        new
                        {
                            ID = 1,
                            Address = "Blla balaaa",
                            CityID = 1,
                            CreatedDate = new DateTime(2023, 3, 26, 2, 23, 10, 960, DateTimeKind.Local).AddTicks(5200),
                            IsActive = true,
                            IsDeleted = false,
                            Name = "A YayınEvi",
                            PhoneNumber = "22258884"
                        });
                });

            modelBuilder.Entity("EBookStoreModel.Concrete.Role", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("VARCHAR(MAX)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<int>("Roles")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.ToTable("Roles", (string)null);

                    b.HasData(
                        new
                        {
                            ID = 1,
                            CreatedDate = new DateTime(2023, 3, 26, 2, 23, 10, 960, DateTimeKind.Local).AddTicks(3425),
                            Description = "Admininn yapacağı işlevlerin gerekli açıklamaları",
                            IsActive = true,
                            IsDeleted = false,
                            Roles = 3
                        });
                });

            modelBuilder.Entity("EBookStoreModel.Concrete.User", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("EMail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RoleID")
                        .HasColumnType("int");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("UserImage")
                        .IsRequired()
                        .HasMaxLength(300)
                        .HasColumnType("nvarchar(300)");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("ID");

                    b.HasIndex("RoleID");

                    b.ToTable("Users", (string)null);

                    b.HasData(
                        new
                        {
                            ID = 1,
                            Address = "Merkezz dskfjf",
                            BirthDate = new DateTime(2023, 3, 26, 2, 23, 10, 961, DateTimeKind.Local).AddTicks(5771),
                            CreatedDate = new DateTime(2023, 3, 26, 2, 23, 10, 961, DateTimeKind.Local).AddTicks(5772),
                            EMail = "merveee@gmail.com",
                            IsActive = true,
                            IsDeleted = false,
                            Name = "Merve",
                            Password = "avavav",
                            PhoneNumber = "222222222",
                            RoleID = 1,
                            Surname = "Erdoğan",
                            UserImage = "https://encrypted-tbn0.gstatic.com/images?q=tbn%3AANd9GcSX4wVGjMQ37PaO4PdUVEAliSLi8-c2gJ1zvQ&usqp=CAU ",
                            UserName = "merveeeeenureeee"
                        });
                });

            modelBuilder.Entity("EBookStoreModel.Concrete.Book", b =>
                {
                    b.HasOne("EBookStoreModel.Concrete.Category", "Category")
                        .WithMany("Books")
                        .HasForeignKey("CategoryID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EBookStoreModel.Concrete.PublisherHome", "PublisherHome")
                        .WithMany("Books")
                        .HasForeignKey("PublisherHomeID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");

                    b.Navigation("PublisherHome");
                });

            modelBuilder.Entity("EBookStoreModel.Concrete.BookAuthor", b =>
                {
                    b.HasOne("EBookStoreModel.Concrete.Author", "Author")
                        .WithMany("BookAuthors")
                        .HasForeignKey("AuthorID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EBookStoreModel.Concrete.Book", "Book")
                        .WithMany("BookAuthors")
                        .HasForeignKey("BookID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Author");

                    b.Navigation("Book");
                });

            modelBuilder.Entity("EBookStoreModel.Concrete.Comment", b =>
                {
                    b.HasOne("EBookStoreModel.Concrete.Book", "Book")
                        .WithMany("Comments")
                        .HasForeignKey("BookID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EBookStoreModel.Concrete.User", "User")
                        .WithMany("Comments")
                        .HasForeignKey("UserID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Book");

                    b.Navigation("User");
                });

            modelBuilder.Entity("EBookStoreModel.Concrete.Order", b =>
                {
                    b.HasOne("EBookStoreModel.Concrete.User", "User")
                        .WithMany("Orders")
                        .HasForeignKey("UserID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("EBookStoreModel.Concrete.OrderList", b =>
                {
                    b.HasOne("EBookStoreModel.Concrete.Book", "Book")
                        .WithMany("OrderLists")
                        .HasForeignKey("BookID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EBookStoreModel.Concrete.Order", "Order")
                        .WithMany("OrderLists")
                        .HasForeignKey("OrderID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Book");

                    b.Navigation("Order");
                });

            modelBuilder.Entity("EBookStoreModel.Concrete.PublisherHome", b =>
                {
                    b.HasOne("EBookStoreModel.Concrete.City", "City")
                        .WithMany("PublisherHomes")
                        .HasForeignKey("CityID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("City");
                });

            modelBuilder.Entity("EBookStoreModel.Concrete.User", b =>
                {
                    b.HasOne("EBookStoreModel.Concrete.Role", "Role")
                        .WithMany("Users")
                        .HasForeignKey("RoleID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Role");
                });

            modelBuilder.Entity("EBookStoreModel.Concrete.Author", b =>
                {
                    b.Navigation("BookAuthors");
                });

            modelBuilder.Entity("EBookStoreModel.Concrete.Book", b =>
                {
                    b.Navigation("BookAuthors");

                    b.Navigation("Comments");

                    b.Navigation("OrderLists");
                });

            modelBuilder.Entity("EBookStoreModel.Concrete.Category", b =>
                {
                    b.Navigation("Books");
                });

            modelBuilder.Entity("EBookStoreModel.Concrete.City", b =>
                {
                    b.Navigation("PublisherHomes");
                });

            modelBuilder.Entity("EBookStoreModel.Concrete.Order", b =>
                {
                    b.Navigation("OrderLists");
                });

            modelBuilder.Entity("EBookStoreModel.Concrete.PublisherHome", b =>
                {
                    b.Navigation("Books");
                });

            modelBuilder.Entity("EBookStoreModel.Concrete.Role", b =>
                {
                    b.Navigation("Users");
                });

            modelBuilder.Entity("EBookStoreModel.Concrete.User", b =>
                {
                    b.Navigation("Comments");

                    b.Navigation("Orders");
                });
#pragma warning restore 612, 618
        }
    }
}