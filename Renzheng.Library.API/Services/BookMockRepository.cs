using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Renzheng.Library.API.Models;
using Renzheng.Library.API.Data;

namespace Renzheng.Library.API.Services
{
    public class BookMockRepository : IBookRepository
    {
        public IEnumerable<BookDto> GetBooksForAuthor(Guid authorId)
        {
            return LibraryMockData.Current.Books.Where(book => book.AuthorId == authorId).ToList();
        }

        public BookDto GetBookForAuthor(Guid authorId, Guid bookId)
        {
            return LibraryMockData.Current.Books.FirstOrDefault(book => book.AuthorId == authorId && book.Id == bookId);
        }

        public void AddBook(BookDto bookDto)
        {
            LibraryMockData.Current.Books.Add(bookDto);
        }

        public void DeleteBook(BookDto bookDto)
        {
            LibraryMockData.Current.Books.Remove(bookDto);
        }

        public void UpdateBook(Guid authorId, Guid bookId, BookForUpdateDto book)
        {
            var originalBook = GetBookForAuthor(authorId, bookId);

            originalBook.Title = book.Title;
            originalBook.Description = book.Description;
            originalBook.Pages = book.Pages;
        }
    }
}
