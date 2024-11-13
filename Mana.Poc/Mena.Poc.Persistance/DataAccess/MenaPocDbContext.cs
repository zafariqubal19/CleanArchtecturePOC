using Mena.Poc.Domain.Models.Books;
using Mena.Poc.Domain.Models.User;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Mena.Poc.Persistance.DataAccess
{
    public class MenaPocDbContext:DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Books> Books { get; set; }
        public MenaPocDbContext(DbContextOptions<MenaPocDbContext> dbContext):base(dbContext)
        {
            
        }
        public void SaveChange()
        {
            base.SaveChanges();
        }
    }
}
