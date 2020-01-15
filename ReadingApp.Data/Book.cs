using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadingApp.Data
{
    public enum Genre
    {
        Nonfiction = 1,
        Fantasy = 2,
        SciFi = 3,
        Mystery = 4,
        Romance = 5,
        Horror = 6,
        Historical = 7,
        Realism = 8
    }

    public class Book
    {
        [Key]
        public int BookId { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public string Author { get; set; }

        [Required]
        public Genre BookGenre { get; set; }

        [Required]
        public bool Owned { get; set; }

        [Required]
        public bool Reviewed { get; set; }
    }
}
