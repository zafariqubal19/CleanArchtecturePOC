using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mena.Poc.Domain.Models.Books
{
    public class Books
    {
        public int Id { get; set; } 
        public string Book_Name { get; set; }
        public string Author_Name { get; set; }
        public int Usd_Price { get; set; }
    }
}
