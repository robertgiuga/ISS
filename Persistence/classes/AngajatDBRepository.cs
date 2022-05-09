using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using Persistence.interfaces;

namespace Persistence.classes
{
    public class AngajatDBRepository : IAngajatRepository
    {
        public void Add(Angajat elem)
        {
            throw new NotImplementedException();
        }

        public void Delete(Angajat elem)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Angajat> FindAll()
        {
            throw new NotImplementedException();
        }

        public Angajat FindById(string id)
        {
            throw new NotImplementedException();
        }

        public void Update(Angajat newelem)
        {
            throw new NotImplementedException();
        }
    }
}
