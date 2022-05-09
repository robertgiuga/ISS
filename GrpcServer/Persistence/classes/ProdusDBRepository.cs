using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GrpcServer.DBContexts;
using Model;
using Persistence.interfaces;

namespace Persistence.classes
{
    public class ProdusDBRepository : IProdusRepository
    {
        public void Add(Produs elem)
        {
            using(var context = new VanzariDbContext())
            {
                context.Produse.Add(elem);
                context.SaveChanges();
            }
        }

        public void Delete(Produs elem)
        {
            using (var context = new VanzariDbContext())
            {
                context.Produse.Remove(elem);
                context.SaveChanges();
            }
        }

        public IEnumerable<Produs> FindAll()
        {
            List<Produs> produse = new List<Produs>();
            using (var contex = new VanzariDbContext())
            {
                produse = contex.Produse.ToList();
            }
            return produse;
        }

        public Produs FindById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Produs newelem)
        {
            using(var context = new VanzariDbContext())
            {
                context.Produse.Update(newelem);
                context.SaveChanges();
            }
        }
    }
}
