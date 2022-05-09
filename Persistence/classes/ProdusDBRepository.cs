using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using Persistence.interfaces;

namespace Persistence.classes
{
    public class ProdusDBRepository : IProdusRepository
    {
        public void Add(Produs elem)
        {
            throw new NotImplementedException();
        }

        public void Delete(Produs elem)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Produs> FindAll()
        {
            throw new NotImplementedException();
        }

        public Produs FindById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Produs newelem)
        {
            throw new NotImplementedException();
        }
    }
}
