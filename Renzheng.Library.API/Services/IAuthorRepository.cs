using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Renzheng.Library.API.Models;

namespace Renzheng.Library.API.Services
{
    public interface IAuthorRepository
    {
        IEnumerable<AuthorDto> GetAuthors();
        AuthorDto GetAuthor(Guid authorId);
        bool IsAuthorExists(Guid authorId);
    }
}
