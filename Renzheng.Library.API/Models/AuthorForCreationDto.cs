using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Renzheng.Library.API.Models
{
    public class AuthorForCreationDto
    {
        [Required(ErrorMessage = "Name is required.")]
        [MaxLength(20, ErrorMessage = "Maximum name length is 20 characters.")]
        public string Name { get; set; }

        [Range(0, 150, ErrorMessage = "Age is not in a reasonable range.")]
        public int Age { get; set; }

        [EmailAddress(ErrorMessage = "Email format error.")]
        public string Email { get; set; }
    }
}
