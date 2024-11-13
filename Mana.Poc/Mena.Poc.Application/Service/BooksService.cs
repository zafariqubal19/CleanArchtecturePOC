using Dto=Mena.Poc.Application.DtoModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using AutoMapper;
using Mena.Poc.Application.Interfaces;
using Mena.Poc.Domain.Interfaces.Repository;
using System.Xml.XPath;
using Mena.Poc.Application.DtoModels;


namespace Mena.Poc.Application.Service
{
    public class BooksService: IBooksServices
    {
        private readonly IBookRepository _bookRepository;
        //private readonly IMapper _mapper;
        public BooksService(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;
            
        }
        public IEnumerable<Dto.Books> GetAllBooks()
        {
            string SqlQuery = "Select * from Books";
            List<Dto.Books> books = new List<Books>();    
            var result = _bookRepository.GetAllAsync(SqlQuery).Result;
            foreach (var item in result) 
            {
                Books books1 = new Books();
                books1.Id= item.Id;
                books1.Author_Name = item.Author_Name;
                books1.Book_Name = item.Book_Name;
                books1.Price = item.Usd_Price * 80;
                books.Add(books1);
            }
            return books;
            //IEnumerable<Dto.Books> books=_mapper.Map<IEnumerable< Dto.Books>>(result);
           
        }

        public int AddBook(Books books)
        {
            
            string SqlQuery = $"Insert into Books values('{books.Book_Name}','{books.Author_Name}',{books.Price/80})";

            var result = _bookRepository.InsertAsync(SqlQuery).Result;

            return result ;
        }
        public Books GetBookByID(int Id) 
        {
            string SqlQuery = $"Select * from Books where Id={Id}";
            Books book= new Books();    
            var result = _bookRepository.GetAsync(SqlQuery).Result;
            if (result != null)
            {
                book.Id = result.Id;
                book.Author_Name = result.Author_Name;
                book.Book_Name = result.Book_Name;
                book.Price = result.Usd_Price * 80;
                return book;
            }
            else
            {
                return new Books();
            }
            
        }
    }
}
