using System;
using System.Web.Http;
using Microsoft.AspNet.Identity;
using ReadingApp.Models.Review;
using ReadingApp.Services;

namespace ReadingApp.Controllers
{
    [RoutePrefix("api/Review")]
    [Authorize]
    public class ReviewController : ApiController
    {
        [Route("AllReviews")]
        public IHttpActionResult GetAllReviews()
        {
            ReviewService reviewService =
                CreateReviewService();
            var reviews = reviewService.GetReviews();
            return Ok(reviews);
        }

        [Route("Review")]
        public IHttpActionResult GetReview(int id)
        {
            ReviewService reviewService =
                CreateReviewService();
            var review = reviewService.GetReviewByBookId(id);
            return Ok(review);
        }

        [Route("CreateReview")]
        public IHttpActionResult Post(ReviewCreate review)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var service = CreateReviewService();

            if (!service.CreateReview(review))
                return InternalServerError();

            return Ok();
        }

        [Route("EditReview")]
        public IHttpActionResult Put(ReviewEdit review)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var service = CreateReviewService();

            if (!service.UpdateReview(review))
                return InternalServerError();

            return Ok();
        }

        [Route("DeleteReview")]
        public IHttpActionResult Delete(int id)
        {
            var service = CreateReviewService();

            if (!service.DeleteReview(id))
                return InternalServerError();

            return Ok();
        }

        private ReviewService CreateReviewService()
        {
            var ReviewService = new ReviewService();
            return ReviewService;
        }

    }
}
