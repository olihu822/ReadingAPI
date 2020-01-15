using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ReadingApp.Data;
using ReadingApp.Models.Book;

namespace ReadingApp.Services
{
    public class BookService
    {
        public bool CreateBook(BookCreate model)
        {
            var entity =
                new Book()
                {
                    Title = model.Title,
                    Author = model.Author,
                    BookGenre = model.BookGenre,
                    Owned = model.Owned,
                    Reviewed = model.Reviewed
                };

            using (var ctx = new ApplicationDbContext())
            {
                ctx.Books.Add(entity);
                return ctx.SaveChanges() == 1;
            }
        }
        public IEnumerable<BookListItem> GetAllBooks()
        {
            using (var ctx = new ApplicationDbContext())
            {
                var bookListItems =
                    ctx
                    .Books
                    .Select(e =>
                        new BookListItem
                        {
                            BookId = e.BookId,
                            Title = e.Title,
                            Author = e.Author,
                            BookGenre = e.BookGenre,
                            Reviewed = e.Reviewed,
                            Owned = e.Owned
                        }).ToArray();

                return bookListItems;
            }
        }

        public BookDetail GetBookById(int id)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                        .Books
                        .Single(e => e.BookId == id);

                return
                    new BookDetail
                    {
                        Title = entity.Title,
                        Author = entity.Author,
                        BookGenre = entity.BookGenre,
                        Reviewed = entity.Reviewed,
                        Owned = entity.Owned
                    };
            }
        }

        public bool UpdateBook(BookEdit model)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                        .Books
                        .Single(e => e.BookId == model.BookId);

                entity.Title = model.Title;
                entity.Author = model.Author;
                entity.BookGenre = model.BookGenre;
                entity.Reviewed = model.Reviewed;
                entity.Owned = model.Owned;

                return ctx.SaveChanges() == 1;
            }
        }

        public bool DeleteBook(int id)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                        .Books
                        .Single(e => e.BookId == id);

                ctx.Books.Remove(entity);

                return ctx.SaveChanges() == 1;
            }
        }
    }
}
