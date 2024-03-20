using Microsoft.AspNetCore.Mvc;
using Mission11_Corfield.Models;
using System.Diagnostics;

namespace Mission11_Corfield.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private IBookRepository _bookRepository;
        public BookController(IBookRepository temp)
        {
            _bookRepository = temp;
        }

        [HttpGet]
        public IEnumerable<Book> Get()
        {
            var bookData = _bookRepository.Books
                .ToArray();

            return bookData;
        }

    }
}