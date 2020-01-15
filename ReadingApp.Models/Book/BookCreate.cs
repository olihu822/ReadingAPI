using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ReadingApp.Data;

namespace ReadingApp.Models.Book
{
    public class BookCreate
    {
        [Required]
        [MinLength(2, ErrorMessage = "Please enter at least 2 characters.")]
        [MaxLength(100, ErrorMessage = "Maximum amount of characters (100) reached.")]
        public string Title { get; set; }

        [Required]
        [MinLength(2, ErrorMessage = "Please enter at least 2 characters.")]
        [MaxLength(50, ErrorMessage = "Maximum amount of characters (50) reached.")]
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
