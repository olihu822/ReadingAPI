using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ReadingApp.Data;

namespace ReadingApp.Models.Review
{
    public class ReviewEdit
    {        
        public int ReviewId { get; set; }
        
        public int ReviewedBookId { get; set; }

        //[Required]
        //public string Title { get; set; }

        //[Required]
        //public string Author { get; set; }

        //[Required]
        //[Display(Name = "Book Genre")]
        //public Genre BookGenre { get; set; }

        [Required]
        [Display(Name = "Rating")]
        public int MyRating { get; set; }

        [Required]
        [Display(Name = "Headline")]
        public string MyHeadline { get; set; }

        [Required]
        [Display(Name = "Review")]
        public string MyReview { get; set; }
    }
}
