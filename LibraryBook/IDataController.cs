using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBModele;

namespace LibraryBook
{
    public interface IDataController<T, Tid> where T : IEntity<Tid>
    {
        void Add(T t);
        void Update(T t);
        void Delete(Tid id);
    }
}
