using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ReadingApp.Data;

namespace ReadingApp.Models.Review
{
    public class ReviewDetail
    {
        public int ReviewId { get; set; }

        [Display(Name = "Book Id")]
        public int ReviewedBookId { get; set; }

        //public string Title { get; set; }

        //public string Author { get; set; }

        //[Display(Name = "Book Genre")]
        //public Genre BookGenre { get; set; }

        [Display(Name = "My Rating")]
        public int MyRating { get; set; }

        [Display(Name = "My Headline")]
        public string MyHeadline { get; set; }

        [Display(Name = "My Review")]
        public string MyReview { get; set; }
    }
}
