using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBModele
{
   public class Avtor:IEntity<int>
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string FamilyName { get; set; }
        public string Name { get; set; }
        public  string Fatherland { get; set; }
        public int Year { get; set; }
    }
}
