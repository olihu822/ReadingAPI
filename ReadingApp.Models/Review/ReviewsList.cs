using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ReadingApp.Data;

namespace ReadingApp.Models.Review
{
    public class ReviewsList
    {
        public int ReviewId { get; set; }

        public int ReviewedBookId { get; set; }

        public string ReviewedBookTitle { get; set; }

        public string ReviewedBookAuthor { get; set; }

        public Genre ReviewedBookBookGenre { get; set; }

        public int MyRating { get; set; }

        public string MyHeadline { get; set; }

        public string MyReview { get; set; }
    }
}
