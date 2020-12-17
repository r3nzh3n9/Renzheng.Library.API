using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Renzheng.Library.API.Models
{
    public class BookForCreationDto
    {
        [Required(ErrorMessage = "Title is required.")]
        [MaxLength(100, ErrorMessage = "Maximum title length is 100 characters.")]
        public string Title { get; set; }

        [MaxLength(500, ErrorMessage = "Maximum description length is 100 characters.")]
        public string Description { get; set; }

        [Range(0, Int32.MaxValue, ErrorMessage = "The number of pages exceeds a reasonable range.")]
        public int Pages { get; set; }
    }
}
