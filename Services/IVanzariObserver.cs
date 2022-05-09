using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public interface IVanzariObserver
    {
        void UpdateProdusRequired(Produs produs);
        void AddProdusRequired(Produs produs);
        void DeleteProdusRequired(Produs produs);
    }
}
