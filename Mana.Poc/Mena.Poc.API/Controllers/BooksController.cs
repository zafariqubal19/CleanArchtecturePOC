using Mena.Poc.Application.DtoModels;
using Mena.Poc.Application.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Mena.Poc.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        private readonly IBooksServices _booksService;
        public BooksController(IBooksServices booksService)
        {
            _booksService = booksService;
        }
        [HttpGet]
        [Route("GetAllBooks")]
        public IEnumerable<Books> GetAllBooks()
      {
            IEnumerable<Books> Books = _booksService.GetAllBooks();
            return Books;
        }
        [HttpGet]
        [Route("GetBook")]
        public Books GetBook(int id) 
        {
            return _booksService.GetBookByID(id);
        }
        [HttpPost]
        [Route("AddBook")]
        public string AddBook(Books book)
        {
            if (book.Price>100) { return "Books that has more than 100USD value are not allowed to add"; }
            int result  = _booksService.AddBook(book);
            if (result == 0) { return "No Row Affected"; }
            if (result == 1) { return "1 Row Affected"; }
            return "";
        }

    }
}
