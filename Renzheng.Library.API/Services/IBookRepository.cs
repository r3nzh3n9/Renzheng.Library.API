using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Renzheng.Library.API.Models;

namespace Renzheng.Library.API.Services
{
    public interface IBookRepository
    {
        IEnumerable<BookDto> GetBooksForAuthor(Guid authorId);
        BookDto GetBookForAuthor(Guid authorId, Guid bookId);
    }
}
