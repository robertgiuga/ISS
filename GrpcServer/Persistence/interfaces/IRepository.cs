using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace Persistence.interfaces
{
    public interface IRepository<Tid, T> where T : Entity<Tid>
    {

        void Add(T elem);
        void Delete(T elem);
        void Update(T newelem);
        T FindById(Tid id);
        IEnumerable<T> FindAll();

    }
}
