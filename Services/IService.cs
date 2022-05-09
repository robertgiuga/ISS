using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace Services
{
    public interface IService
    {
        Angajat LogIn(Angajat angajat, IVanzariObserver client);
        void LogOut(Angajat angajat);
        IEnumerable<Produs> findAllProduse();
        void AddProdus(Produs produs);
        void DeleteProdus(Produs produs);
        void UpdateProdus(Produs produs);
    }
}
