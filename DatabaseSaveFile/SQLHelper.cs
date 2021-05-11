using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
using System.Threading.Tasks;


namespace DatabaseSaveFile
{

    public class SQLHelper
    {
        SQLiteAsyncConnection db;
        public SQLHelper(string dbPath)
        {
            db = new SQLiteAsyncConnection(dbPath);
            db.CreateTableAsync<Rhysindb>().Wait();
        }

        public Task<int> SaveItem(Rhysindb rhysindb)
        {
            return db.InsertAsync(rhysindb);
        }

        public Task<List<Rhysindb>> DisplayItem()
        {
            return db.Table<Rhysindb>().ToListAsync();
        }


    }
}
