using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Renzheng.Library.API.Models;
using Renzheng.Library.API.Data;

namespace Renzheng.Library.API.Services
{
    public class AuthorMockRepository : IAuthorRepository
    {
        public IEnumerable<AuthorDto> GetAuthors()
        {
            return LibraryMockData.Current.Authors;
        }

        public AuthorDto GetAuthor(Guid authorId)
        {
            return LibraryMockData.Current.Authors.FirstOrDefault(author => author.Id == authorId);
        }

        public bool IsAuthorExists(Guid authorId)
        {
            return LibraryMockData.Current.Authors.Any(author => author.Id == author.Id);
        }
    }
}
