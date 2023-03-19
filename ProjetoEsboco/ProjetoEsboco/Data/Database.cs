using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using ProjetoEsboco.Models;
using SQLite;

namespace ProjetoEsboco.Data
{
    public class Database
    {
        private readonly SQLiteAsyncConnection _connection;

        public Database(string dbPath)
        {
            _connection = new SQLiteAsyncConnection(dbPath);
            _connection.CreateTableAsync<Renda>();
        }

        public Task<List<Renda>> GetRendaAsync() 
        {
            return _connection.Table<Renda>().ToListAsync();
        }

        public Task<int> SaveRendaAsync(Renda renda)
        {
            return _connection.InsertAsync(renda);
        }
    }
}
