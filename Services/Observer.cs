using Model;
using Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class Observer
    {
        public Observer Instance { get; set; }

        public virtual void UpdateProdusRequired(Produs produs) { throw new NotImplementedException(); }
        public virtual void AddProdusRequired(Produs produs) { throw new NotImplementedException(); }
        public virtual void DeleteProdusRequired(Produs produs) { throw new NotImplementedException(); }
        public virtual void UpdateComandaRequired(Comanda comanda) { throw new NotImplementedException(); }
        public virtual void ReloadProduseRequired(){throw new NotImplementedException();}
    }
}
