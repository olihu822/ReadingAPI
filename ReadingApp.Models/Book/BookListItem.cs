using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ReadingApp.Data;

namespace ReadingApp.Models.Book
{
    public class BookListItem
    {
        public int BookId { get; set; }

        public string Title { get; set; }

        public string Author { get; set; }

        public Genre BookGenre { get; set; }

        public bool Owned { get; set; }

        public bool Reviewed { get; set; }
    }
}
