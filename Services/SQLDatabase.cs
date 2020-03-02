using System.Collections.Generic;
using System.Threading.Tasks;
using ExplorAppTeo.Models;
using SQLite;

namespace ExplorAppTeo.Services
{
    public class SQLDatabase
    {
        readonly SQLiteAsyncConnection _database;

        public SQLDatabase(string dbPath)
        {
            _database = new SQLiteAsyncConnection(dbPath);
            _database.CreateTableAsync<LugarItem>().Wait();
        }

        public Task<List<LugarItem>> GetLugarAsync()
        {
            return _database.Table<LugarItem>().ToListAsync();
        }

        public Task<int> InsertLugarAsync(LugarItem lugar)
        {
            return _database.InsertAsync(lugar);
        }

        public Task<List<LugarItem>> GetCatalogoLugarItems(string categoria)
        {
            return _database.QueryAsync<LugarItem>("SELECT * FROM [LugarItem] WHERE [Categoria] = ?", categoria);
        }

        public Task<int> CountAsync()
        {
            return _database.ExecuteScalarAsync<int>("SELECT COUNT(*) FROM [LugarItem]");
        }

        public async Task<int> LoadDatabaseAsync()
        {
            var count = await _database.ExecuteScalarAsync<int>("SELECT COUNT(*) FROM [LugarItem]");

            if (count == 0)
            {
                LugarList listaLugares = new LugarList();
                await _database.InsertAllAsync(listaLugares.List());
            }

            return count;
        }
    }
}
