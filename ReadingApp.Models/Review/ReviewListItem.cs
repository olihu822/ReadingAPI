using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadingApp.Models.Review
{
    public class ReviewListItem
    {
        public int ReviewId { get; set; }
        public int BookId { get; set; }
        public int MyRating { get; set; }
        public string MyHeadline { get; set; }
        public string MyReview { get; set; }
    }
}
