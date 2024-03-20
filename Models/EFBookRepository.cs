﻿
namespace Mission11_Corfield.Models
{
    public class EFBookRepository : IBookRepository
    {
        private BookstoreContext _context;

        public EFBookRepository(BookstoreContext temp) {
            _context = temp;
        }

        public IQueryable<Book> Books => _context.Books;

    }
}
