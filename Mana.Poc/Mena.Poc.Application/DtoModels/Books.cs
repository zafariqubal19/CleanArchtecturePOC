using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mena.Poc.Application.DtoModels
{
    public class Books
    {
        public int Id { get; set; }
        public string Book_Name { get; set; }
        public string Author_Name { get; set; }
        public int Price { get; set; }
    }
}
