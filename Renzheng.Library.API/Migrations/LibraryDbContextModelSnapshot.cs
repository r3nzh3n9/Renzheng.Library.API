﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Renzheng.Library.API.Entities;

namespace Renzheng.Library.API.Migrations
{
    [DbContext(typeof(LibraryDbContext))]
    partial class LibraryDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.4")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Renzheng.Library.API.Entities.Author", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTimeOffset>("BirthDate")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("BirthPlace")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("nvarchar(40)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("Id");

                    b.ToTable("Authors");

                    b.HasData(
                        new
                        {
                            Id = new Guid("c12e01e2-384e-4a80-a4e8-edf01378eb7d"),
                            BirthDate = new DateTimeOffset(new DateTime(1998, 12, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 8, 0, 0, 0)),
                            BirthPlace = "Gaoan",
                            Email = "renzheng.zhang@gmail.com",
                            Name = "Renzheng Zhang"
                        },
                        new
                        {
                            Id = new Guid("2299cc36-b597-47af-a86d-88237471f575"),
                            BirthDate = new DateTimeOffset(new DateTime(1968, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 8, 0, 0, 0)),
                            BirthPlace = "New York",
                            Email = "halbert.wood@gmail.com",
                            Name = "Halbert Wood"
                        },
                        new
                        {
                            Id = new Guid("25bca7b2-903a-48f0-817c-4b5d2df36be8"),
                            BirthDate = new DateTimeOffset(new DateTime(1988, 10, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 8, 0, 0, 0)),
                            BirthPlace = "Sydeny",
                            Email = "bernice.edwin@gmail.com",
                            Name = "Bernice Edwin"
                        });
                });

            modelBuilder.Entity("Renzheng.Library.API.Entities.Book", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("AuthorId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<int>("Pages")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.HasIndex("AuthorId");

                    b.ToTable("Books");

                    b.HasData(
                        new
                        {
                            Id = new Guid("28c2e75b-784b-4fdc-89fe-683f3551bf3a"),
                            AuthorId = new Guid("c12e01e2-384e-4a80-a4e8-edf01378eb7d"),
                            Description = "Some words on the same segment are still similar distances apart, even if new words have been interspersed.",
                            Pages = 120,
                            Title = "Bleak House"
                        },
                        new
                        {
                            Id = new Guid("b564f709-a84b-4a98-9895-fc822fbd97b0"),
                            AuthorId = new Guid("c12e01e2-384e-4a80-a4e8-edf01378eb7d"),
                            Description = "That way lies intellectually corrupt AI projects which I'll not taunt by naming here.",
                            Pages = 120,
                            Title = "High-Rise"
                        },
                        new
                        {
                            Id = new Guid("e18cccd6-7043-4389-a597-75c9034375b7"),
                            AuthorId = new Guid("c12e01e2-384e-4a80-a4e8-edf01378eb7d"),
                            Description = "However, whether that really mattered.",
                            Pages = 120,
                            Title = "Cranford"
                        },
                        new
                        {
                            Id = new Guid("5745a101-5f8b-46c7-ba01-286d1917da52"),
                            AuthorId = new Guid("c12e01e2-384e-4a80-a4e8-edf01378eb7d"),
                            Description = "The influence of these bands is felt in nearly all branches of modern pop music.",
                            Pages = 120,
                            Title = "The White Queen"
                        });
                });

            modelBuilder.Entity("Renzheng.Library.API.Entities.Book", b =>
                {
                    b.HasOne("Renzheng.Library.API.Entities.Author", "Author")
                        .WithMany("Books")
                        .HasForeignKey("AuthorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Author");
                });

            modelBuilder.Entity("Renzheng.Library.API.Entities.Author", b =>
                {
                    b.Navigation("Books");
                });
#pragma warning restore 612, 618
        }
    }
}