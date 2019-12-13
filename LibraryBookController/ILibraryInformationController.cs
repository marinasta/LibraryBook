using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryBookModels;

namespace LibraryBookController
{
   public interface ILibraryInformationController
    {
        void Save(LibraryInfoModels book);
    }
}
