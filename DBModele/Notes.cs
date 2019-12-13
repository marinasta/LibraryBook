using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace DBModele
{
     public class Notes:IEntity<int>
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        [Indexed]
        public int IdBook { get; set;}
        public string Comment { get; set; }


    }
}
