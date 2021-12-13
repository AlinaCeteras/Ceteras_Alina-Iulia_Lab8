using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ceteras_Alina_Iulia_Lab8.Models
{
    public class BookData
    {
        public IEnumerable<Book> Books { get; set; }
        public IEnumerable<Category> Categories { get; set; }
        public IEnumerable<BookCategory> BookCategories { get; set; }
    }
}
