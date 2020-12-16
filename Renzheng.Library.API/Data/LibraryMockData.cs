using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Renzheng.Library.API.Models;

namespace Renzheng.Library.API.Data
{
    public class LibraryMockData
    {
        public static LibraryMockData Current { get; } = new LibraryMockData();
        public List<AuthorDto> Authors { get; set; }
        public List<BookDto> Books { get; set; }

        public LibraryMockData()
        {
            Authors = new List<AuthorDto>
            {
                new AuthorDto() { Id = new Guid("e5e219fe-d927-45aa-8b97-c4590daffe49"), Name = "Author 1", Age = 46, Email = "author1@xxx.com" },
                new AuthorDto() { Id = new Guid("862ddc63-9bfe-4231-8faf-df16a0e05964"), Name = "Author 2", Age = 38, Email = "author2@xxx.com" }
            };

            Books = new List<BookDto>
            {
                new BookDto() { Id = new Guid("175569d6-60d9-4636-a5dd-3a8d66df5d4f"), Title = "Book 1", Description = "Discription of Book 1", Pages = 281, AuthorId = new Guid("e5e219fe-d927-45aa-8b97-c4590daffe49") },
                new BookDto() { Id = new Guid("ee5682fb-cfa5-472b-ab13-b2abc7d6fbd0"), Title = "Book 2", Description = "Discription of Book 2", Pages = 370, AuthorId = new Guid("e5e219fe-d927-45aa-8b97-c4590daffe49") },
                new BookDto() { Id = new Guid("cbda417f-bd8c-433f-8e02-9dfb003a128a"), Title = "Book 3", Description = "Discription of Book 3", Pages = 229, AuthorId = new Guid("862ddc63-9bfe-4231-8faf-df16a0e05964") },
                new BookDto() { Id = new Guid("7af14a18-35fe-4793-9864-17eb396e17af"), Title = "Book 4", Description = "Discription of Book 4", Pages = 440, AuthorId = new Guid("862ddc63-9bfe-4231-8faf-df16a0e05964") },
            };
        }
    }
}
