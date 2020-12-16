using Microsoft.AspNetCore.Mvc;
using Renzheng.Library.API.Models;
using Renzheng.Library.API.Services;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Renzheng.Library.API.Controllers
{
    [Route("api/authors")]
    [ApiController]
    public class AuthorController : ControllerBase
    {
        public IAuthorRepository AuthorRepository { get; }

        public AuthorController(IAuthorRepository authorRepository)
        {
            AuthorRepository = authorRepository;
        }

        [HttpGet]
        public ActionResult<List<AuthorDto>> GetAuthors()
        {
            return AuthorRepository.GetAuthors().ToList();
        }

        [HttpGet("{authorId}")]
        public ActionResult<AuthorDto> GetAuthor(Guid authorId)
        {
            var author = AuthorRepository.GetAuthor(authorId);

            if (author == null)
            {
                return NotFound();
            }
            else
            {
                return author;
            }
        }
    }
}
