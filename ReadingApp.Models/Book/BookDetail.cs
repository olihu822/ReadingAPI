using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ReadingApp.Data;

namespace ReadingApp.Models.Book
{
    public class BookDetail
    {
        public int BookId { get; set; }
        public string Title { get; set; }

        public string Author { get; set; }

        [Display(Name = "Genre")]
        public Genre BookGenre { get; set; }

        [Display(Name = "Owned?")]
        public bool Owned { get; set; }

        [Display(Name = "Reviewed?")]
        public bool Reviewed { get; set; }
    }
}
