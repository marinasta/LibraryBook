using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace DBModele
{
    public class Book : IEntity<int>
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        [Indexed]
        public string Avtor { get; set; }
        public string NameBook { get; set; }
        public int Year { get; set; }
        public string Descroption { get; set; }
        public bool Read { get; set; }
    }
}
