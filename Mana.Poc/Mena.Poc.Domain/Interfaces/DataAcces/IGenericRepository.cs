using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mena.Poc.Domain.Interfaces.DataAcces
{
    public interface IGenericRepository<T> where T : class
    {
        Task<IEnumerable<T>> GetAllAsync(string SqlQuery);
        Task<IEnumerable<T>> GetAllAsync(string SqlQuery, Dictionary<string, object> param);
        Task<T> GetAsync(string SqlQuery);
        Task<T> GetAsync(string SqlQuery, object param);
        Task<int> InsertAsync(string SqlQuery);
        Task<int> InsertAsync(string SqlQuery, object? param = null);
        Task<int> UpdateAsync(string SqlQuery, Dictionary<string, object> param);
        Task<int> DeleteAsync(string SqlQuery, object? param = null);



    }
}
