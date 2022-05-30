using Model;
using Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace VanzariClient.Controllers
{
    public class AngajatController : Observer
    {
        private VanzariProxy Service;
        public Angajat LoggedUser { get; set; }
        public EventHandler<VanzariEvent> userEvent;

        public AngajatController(VanzariProxy service, Angajat loggedUser)
        {
            this.Service = service;
            LoggedUser = loggedUser;
        }

        public IEnumerable<Produs> FindAllProduse()
        {
            return Service.FindAllProduse();
        }

        public void SendOrder(Comanda comanda, List<ComandaItem> items)
        {
            Service.SendOrder(comanda,items);
        }

        public IEnumerable<Comanda> FindAllComenzi()
        {
            return Service.FindAllComenzi();
        }

        public void UpdateComanda(Comanda comanda)
        {
            Service.UpdateComanda(comanda);
        }

        public override void UpdateComandaRequired(Comanda comanda)
        {
            VanzariEvent userEvent = new VanzariEvent(EventType.UPDATECOMANDA, comanda);
            OnEvent(userEvent);
        }

        private void OnEvent(VanzariEvent e)
        {
            if (userEvent != null)
                userEvent(this, e);

        }
        public override void ReloadProduseRequired()
        {
            VanzariEvent userEvent = new VanzariEvent(EventType.RELOADPRODUSE, null);
            OnEvent(userEvent);
        }
    }
}
