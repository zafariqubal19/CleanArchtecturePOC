using Mena.Poc.Domain.Interfaces.DataAcces;
using Mena.Poc.Persistance.Extensions;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mena.Poc.Persistance.DataAccess
{
    public abstract class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private readonly MenaPocDbContext _context;
        public GenericRepository(MenaPocDbContext dbContext)
        {
            _context = dbContext;
        }
        public async Task<IEnumerable<T>> GetAllAsync(string SqlQuery)
        {
            return await _context.ExecuteQueryAsync<T>(SqlQuery);
        }
        public async Task<IEnumerable<T>> GetAllAsync(string SqlQuery, Dictionary<string, object> param)
        {
            SqlParameter[] item2 = param.Keys.Select((string key) => new SqlParameter(key, param[key] ?? DBNull.Value)).ToArray();
            return await _context.ExecuteQueryAsync<T>(SqlQuery, param);
        }

        public async Task<T> GetAsync(string SqlQuery)
        {
            var result= await _context.ExecuteQueryAsyncSingleOrDefault<T>(SqlQuery);
            return result;
        }
        public async Task<T> GetAsync(string SqlQuery, object param)
        {
            return await _context.ExecuteQueryAsyncSingleOrDefault<T>(SqlQuery, param);
        }
        public async Task<int> InsertAsync(string SqlQuery)
        {
            return await _context.ExecuteQueryAsync(SqlQuery);
        }
        public async Task<int> InsertAsync(string SqlQuery, object? param = null)
        {
            return await _context.ExecuteQueryAsync(SqlQuery, param);
        }
        public async Task<int> UpdateAsync(string SqlQuery, Dictionary<string, object> param)

        {
            //var sqlParam = param?.Select(p => new SqlParameter(p.Key, p.Value ?? DBNull.Value)).ToArray();
            SqlParameter[] item2 = param.Keys.Select((string key) => new SqlParameter(key, param[key] ?? DBNull.Value)).ToArray();

            return await _context.ExecuteQueryAsync(SqlQuery, param);
        }
        public async Task<int> DeleteAsync(string SqlQuery, object? param = null)
        {
            return await _context.ExecuteQueryAsync(SqlQuery, param);
        }

    }
}
