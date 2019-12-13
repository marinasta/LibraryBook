using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBModele
{
    public interface IEntity<Tid>
    {
        Tid Id { get; }

    }
}
