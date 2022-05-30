using GrpcServer.DBContexts;
using Model;
using Persistence.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GrpcServer.Persistence.classes
{
    class ComandaDBRepository : IComandaRepository
    {
        public void Add(Comanda elem)
        {
            throw new NotImplementedException();
        }

        public void Add(Comanda comanda, IEnumerable<ComandaItem> items)
        {
            using (var contex = new VanzariDbContext())
            {
                contex.Comenzi.Add(comanda);
                contex.SaveChanges();
                foreach (var item in items)
                {
                    item.ComandaId = comanda.Id;
                    contex.ComandaItems.Add(item);
                }
                contex.SaveChanges();
            }
        }

        public void Delete(Comanda elem)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Comanda> FindAll()
        {
            List<Comanda> comenzi = new List<Comanda>();
            using (var contex = new VanzariDbContext())
            {
                comenzi = contex.Comenzi.ToList();
            }
            return comenzi;
        }

        public Comanda FindById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Comanda newelem)
        {
            using (var contex = new VanzariDbContext())
            {
                contex.Comenzi.Update(newelem);
                contex.SaveChanges();
            }

        }
    }
}
