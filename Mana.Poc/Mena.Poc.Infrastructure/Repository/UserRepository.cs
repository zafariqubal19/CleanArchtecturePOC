using Mena.Poc.Domain.Interfaces.Repository;
using Mena.Poc.Domain.Models.User;
using Mena.Poc.Persistance.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mena.Poc.Infrastructure.Repository
{
    public class UserRepository:GenericRepository<User>,IUserRepository
    {
        public UserRepository(MenaPocDbContext context):base(context) { }
       
    }
}
