using Mena.Poc.Application.DtoModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mena.Poc.Application.Interfaces
{
    public interface IBooksServices
    {
        IEnumerable<Books> GetAllBooks();
        int AddBook(Books books);
        Books GetBookByID(int Id);
    }
}
