using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ReadingApp.Data;

namespace ReadingApp.Models.Review
{
    public class ReviewCreate
    {
        [Required]
        [Display(Name = "Book ID")]
        public int BookId { get; set; }

        [Required]
        [Display(Name = "My Rating")]
        [Range(1, 5, ErrorMessage = "Must be a number between 1 and 5.")]
        public int MyRating { get; set; }

        [Required]
        [Display(Name = "My Headline")]
        [MinLength(2, ErrorMessage = "Please enter at least 2 characters.")]
        [MaxLength(100, ErrorMessage = "Maximum amount of characters (100) reached.")]
        public string MyHeadline { get; set; }

        [Required]
        [Display(Name = "My Review")]
        [MinLength(2, ErrorMessage = "Please enter at least 2 characters.")]
        [MaxLength(10000, ErrorMessage = "Maximum amount of characters (10000) reached.")]
        public string MyReview { get; set; }
    }
}
