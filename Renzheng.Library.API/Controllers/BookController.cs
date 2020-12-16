using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Renzheng.Library.API.Services;
using Renzheng.Library.API.Models;

namespace Renzheng.Library.API.Controllers
{
    [Route("api/authors/{authorId}/books")]
    [ApiController]
    public class BookController : ControllerBase
    {
        public IBookRepository BookRepository { get; set; }
        public IAuthorRepository AuthorRepository { get; set; }

        public BookController(IBookRepository bookRepository, IAuthorRepository authorRepository)
        {
            BookRepository = bookRepository;
            AuthorRepository = authorRepository;
        }

        [HttpGet]
        public ActionResult<List<BookDto>> GetBooks(Guid authorId)
        {
            if (!AuthorRepository.IsAuthorExists(authorId))
                return NotFound();

            return BookRepository.GetBooksForAuthor(authorId).ToList();
        }
    }
}
