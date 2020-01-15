using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ReadingApp.Data;

namespace ReadingApp.Models.Book
{
    public class BookEdit
    {
        public int BookId { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public string Author { get; set; }

        [Required]
        [Display(Name = "Genre")]
        public Genre BookGenre { get; set; }

        [Required]
        [Display(Name = "Owned?")]
        public bool Owned { get; set; }

        [Required]
        [Display(Name = "Reviewed?")]
        public bool Reviewed { get; set; }
    }
}
