using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Renzheng.Library.API.Entities
{
    public static class ModelBuilderExtension
    {
        public static void SeedData(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Author>().HasData(
                new Author
                {
                    Id = new Guid("c12e01e2-384e-4a80-a4e8-edf01378eb7d"),
                    Name = "Renzheng Zhang",
                    BirthDate = new DateTimeOffset(new DateTime(1998, 12, 6)),
                    BirthPlace = "Gaoan",
                    Email = "renzheng.zhang@gmail.com"
                },
                new Author
                {
                    Id = new Guid("2299cc36-b597-47af-a86d-88237471f575"),
                    Name = "Halbert Wood",
                    BirthDate = new DateTimeOffset(new DateTime(1968, 5, 25)),
                    BirthPlace = "New York",
                    Email = "halbert.wood@gmail.com"
                },
                new Author
                {
                    Id = new Guid("25bca7b2-903a-48f0-817c-4b5d2df36be8"),
                    Name = "Bernice Edwin",
                    BirthDate = new DateTimeOffset(new DateTime(1988, 10, 11)),
                    BirthPlace = "Sydeny",
                    Email = "bernice.edwin@gmail.com"
                });

            modelBuilder.Entity<Book>().HasData(
                new Book()
                {
                    Id = new Guid("28c2e75b-784b-4fdc-89fe-683f3551bf3a"),
                    Title = "Bleak House",
                    Description = "Some words on the same segment are still similar distances apart, even if new words have been interspersed.",
                    Pages = 120,
                    AuthorId = new Guid("c12e01e2-384e-4a80-a4e8-edf01378eb7d")
                },
                new Book()
                {
                    Id = new Guid("b564f709-a84b-4a98-9895-fc822fbd97b0"),
                    Title = "High-Rise",
                    Description = "That way lies intellectually corrupt AI projects which I'll not taunt by naming here.",
                    Pages = 120,
                    AuthorId = new Guid("c12e01e2-384e-4a80-a4e8-edf01378eb7d")
                },
                new Book()
                {
                    Id = new Guid("e18cccd6-7043-4389-a597-75c9034375b7"),
                    Title = "Cranford",
                    Description = "However, whether that really mattered.",
                    Pages = 120,
                    AuthorId = new Guid("c12e01e2-384e-4a80-a4e8-edf01378eb7d")
                },
                new Book()
                {
                    Id = new Guid("5745a101-5f8b-46c7-ba01-286d1917da52"),
                    Title = "The White Queen",
                    Description = "The influence of these bands is felt in nearly all branches of modern pop music.",
                    Pages = 120,
                    AuthorId = new Guid("c12e01e2-384e-4a80-a4e8-edf01378eb7d")
                });
        }
    }
}
