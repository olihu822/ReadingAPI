using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadingApp.Data
{
    [Table("Reviews")]
    public class Review
    {
        [Key]
        public int ReviewId { get; set; }

        [ForeignKey("ReviewedBook")]
        public int ReviewedBookId { get; set; }
        
        //public string Title { get; set; }

        //public string Author { get; set; }

        //[Display(Name = "Book Genre")]
        //public Genre BookGenre { get; set; }

        [Required]
        [Display(Name = "My Rating")]
        public int MyRating { get; set; }

        [Required]
        [Display(Name = "My Headline")]
        public string MyHeadline { get; set; }

        [Required]
        [Display(Name = "My Review")]
        public string MyReview { get; set; }

        public Guid Reviewer { get; set; }

        public virtual Book ReviewedBook { get; set; }        
        
        //[ForeignKey("Title")]
        //public virtual Book BookTitle { get; set; }

        //[ForeignKey("Author")]
        //public virtual Book BookAuthor { get; set; }

        //[ForeignKey("BookGenre")]
        //public virtual Book GenreOfBook { get; set; }

    }
}

