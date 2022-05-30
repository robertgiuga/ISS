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
        Angajat LogIn(Angajat angajat, Observer client);
        void LogOut(Angajat angajat);
        IEnumerable<Produs> FindAllProduse();
        void AddProdus(Produs produs);
        void DeleteProdus(Produs produs);
        void UpdateProdus(Produs produs);
        void SendOrder(Comanda comanda, List<ComandaItem> items);
        IEnumerable<Comanda> FindAllComenzi();
        void UpdateComanda(Comanda comanda);
    }
}
