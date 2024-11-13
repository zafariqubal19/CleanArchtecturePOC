using Mena.Poc.Domain.Interfaces.DataAcces;
using Mena.Poc.Domain.Models.Books;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mena.Poc.Domain.Interfaces.Repository
{
    public interface IBookRepository:IGenericRepository<Books>
    {
    }
}
