using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Renzheng.Library.API.Entities
{
    public class Author
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }

        [Required]
        [MaxLength(20)]
        public string Name { get; set; }

        [Required]
        public DateTimeOffset BirthDate { get; set; }

        [Required]
        [MaxLength(40)]
        public string BirthPlace { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        /// <summary>
        /// 集合导航属性, 为 Author 和 Book 两个实体建立关系
        /// </summary>
        public ICollection<Book> Books { get; set; } = new List<Book>();
    }
}
