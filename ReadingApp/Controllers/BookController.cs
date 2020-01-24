using System.Web.Http;
using ReadingApp.Models.Book;
using ReadingApp.Services;

namespace ReadingApp.Controllers
{
    [RoutePrefix("api/Book")]
    [Authorize]
    public class BookController : ApiController
    {
        [Route("AllBooks")]
        public IHttpActionResult GetAllBooks()
        {
            BookService bookService =
                CreateBookService();
            var books = bookService.GetAllBooks();
            return Ok(books);
        }

        [Route("{id:int}")]
        public IHttpActionResult GetBook(int id)
        {
            BookService bookService =
                CreateBookService();
            var book = bookService.GetBookById(id);
            return Ok(book);
        }

        [Route("CreateBook")]
        public IHttpActionResult Post(BookCreate book)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var service = CreateBookService();

            if (!service.CreateBook(book))
                return InternalServerError();

            return Ok();
        }

        [Route("EditBook")]
        public IHttpActionResult Put(BookEdit book)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var service = CreateBookService();

            if (!service.UpdateBook(book))
                return InternalServerError();

            return Ok();
        }

        [Route("DeleteBook/{id:int}")]
        public IHttpActionResult Delete(int id)
        {
            var service = CreateBookService();

            if (!service.DeleteBook(id))
                return InternalServerError();

            return Ok();
        }

        private BookService CreateBookService()
        {
            var BookService = new BookService();
            return BookService;
        }
    }
}
