using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBModele;
using SQLite;


namespace LibraryBook
{
    public class DbController<T, Tid> : IDisposable, IDataController<T, Tid> where T : IEntity<Tid>
    {
        private string databasePath;
        private SQLiteConnection _db;

        public DbController(string databasePath)
        {
            this.databasePath = databasePath;
            _db = new SQLiteConnection(databasePath);
        }

        public void Add(T t)
        {
            _db.Insert(t);
        }

        public void Delete(Tid id)
        {
            _db.Delete<T>(id);
        }

        public void Update(T t)
        {
            _db.Update(t);
        }

        public void Dispose()
        {
            _db?.Dispose();
        }
    }
}
