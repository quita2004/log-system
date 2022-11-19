
using Application.Interfaces;
using Core.Entities;
using Dapper;
using DapperExtensions;

namespace Infrastructure.Repository
{
    public class LogsRepository : ILogsRepostory
    {
        private readonly DapperContext _context;

        public LogsRepository(DapperContext context)
        {
            _context = context;
        }

        public async Task<object> Add(Logs entity)
        {
            using var connection = _context.CreateConnection();
            connection.Open();
            var data = await connection.InsertAsync(entity);
            //connection.Close();
            return data;
        }

        public Task<int> Delete(object id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Logs>> Get()
        {
            var query = "Select * from Logs";

            using var connection = _context.CreateConnection();
            connection.Open();
            var data = await connection.QueryAsync<Logs>(query);
            //connection.Close();

            return data.ToList();
        }

        public Task<IEnumerable<Logs>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<Logs> GetById(object id)
        {
            throw new NotImplementedException();
        }

        public Task<int> Update(Logs entity)
        {
            throw new NotImplementedException();
        }
    }
}
