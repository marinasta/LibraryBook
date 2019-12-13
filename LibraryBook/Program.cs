using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;
using DBModele;

namespace LibraryBook
{
    class Program
    {
        static void Main(string[] args)
        {
            var databasePath = "./403группа.db";

            var a = new Avtor { Name = "Ivan" };
            using (var db = new DbController<Avtor, int>(""))
            {
                db.Add(a);
                db.Update(a);
                db.Delete(2);
            }

            using (var db = new SQLiteConnection(databasePath))
            {
                db.CreateTable<Avtor>();
                var a = new Avtor { Name = "Ivan" };

                db.Insert(a);

                var aa = db.Table<Avtor>()
                    .Where(x => x.Id == 1).FirstOrDefault();

                Console.WriteLine("{0} {1}", aa.Id, aa.Name);
            }
        }
    }
}
