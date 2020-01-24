using System;
using System.Collections.Generic;
using System.Linq;
using ReadingApp.Data;
using ReadingApp.Models.Review;

namespace ReadingApp.Services
{
    public class ReviewService
    {

        public IEnumerable<ReviewsList> GetReviews()
        {
            using (var ctx = new ApplicationDbContext())
            {
                var reviewsLists =
                    ctx
                        .Reviews
                        .Select(e => 
                            new ReviewsList 
                            {
                                ReviewId = e.ReviewId,
                                ReviewedBookId = e.ReviewedBook.BookId,
                                ReviewedBookTitle = e.ReviewedBook.Title,
                                ReviewedBookAuthor = e.ReviewedBook.Author,
                                ReviewedBookBookGenre = e.ReviewedBook.BookGenre,
                                MyRating = e.MyRating,
                                MyHeadline = e.MyHeadline,
                                MyReview = e.MyReview
                            }).ToArray();

                return reviewsLists;
            }
        }

        public ReviewDetail GetReviewByBookId(int id)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                        .Reviews
                        .Single(e => e.ReviewId == id);

                return
                    new ReviewDetail
                    {
                        ReviewId = entity.ReviewId,
                        ReviewedBookId = entity.ReviewedBookId,
                        MyRating = entity.MyRating,
                        MyHeadline = entity.MyHeadline,
                        MyReview = entity.MyReview
                    };
            }
        }

        public bool CreateReview(ReviewCreate model)
        {
            var entity =
                new Review()
                {
                    ReviewedBookId = model.ReviewedBookId,
                    MyRating = model.MyRating,
                    MyHeadline = model.MyHeadline,
                    MyReview = model.MyReview
                };

            using (var ctx = new ApplicationDbContext())
            {
                ctx.Reviews.Add(entity);
                return ctx.SaveChanges() == 1;
            }
        }

        public bool UpdateReview(ReviewEdit model)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                        .Reviews
                        .Single(e => e.ReviewId == model.ReviewId);

                entity.ReviewedBookId = model.ReviewedBookId;
                entity.MyRating = model.MyRating;
                entity.MyHeadline = model.MyHeadline;
                entity.MyReview = model.MyReview;

                return ctx.SaveChanges() == 1;
            }
        }

        public bool DeleteReview(int id)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                        .Reviews
                        .Single(e => e.ReviewId == id);

                ctx.Reviews.Remove(entity);

                return ctx.SaveChanges() == 1;
            }
        }
    }
}
