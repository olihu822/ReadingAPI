using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadingApp.Data
{
    public class Review
    {
        [Key]
        public int ReviewId { get; set; }

        [Required]
        [ForeignKey(nameof(Book))]
        public int BookId { get; set; }
        public virtual Book Book { get; set; }

      //  [Required]
      //  [ForeignKey(nameof(Book))]
      //  public string Title { get; set; }

      //  [Required]
      //  [ForeignKey(nameof(Book))]
      //  public string Author { get; set; }

      //  [Required]
      //  [ForeignKey(nameof(Book))]
      //  [Display(Name = "Genre")]
      //  public Genre BookGenre { get; set; }

        [Required]
        [Display(Name = "My Rating")]
        public int MyRating { get; set; }

        [Required]
        [Display(Name = "My Headline")]
        public string MyHeadline { get; set; }

        [Required]
        [Display(Name = "My Review")]
        public string MyReview { get; set; }
    }
}

