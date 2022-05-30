using Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Persistence.interfaces
{
    public interface IComandaRepository :IRepository<int,Comanda>
    {
        void Add(Comanda comanda, IEnumerable<ComandaItem> items);
    }
}
