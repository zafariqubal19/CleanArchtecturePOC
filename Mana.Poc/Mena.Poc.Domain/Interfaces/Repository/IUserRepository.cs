using Mena.Poc.Domain.Interfaces.DataAcces;
using Mena.Poc.Domain.Models.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mena.Poc.Domain.Interfaces.Repository
{
    public interface IUserRepository:IGenericRepository<User>
    {
    }
}
