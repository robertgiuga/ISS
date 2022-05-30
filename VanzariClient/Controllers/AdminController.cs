using Model;
using Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace VanzariClient.Controllers
{
    public class AdminController : Observer
    {
        private VanzariProxy service;
        public Angajat LoggedUser { get; set; }
        public EventHandler<VanzariEvent> userEvent;

        public AdminController(VanzariProxy service, Angajat loggedUser) 
        {
            this.service = service;
            LoggedUser = loggedUser;
        }

        public IEnumerable<Produs> FindAllProduse()
        {
            return service.FindAllProduse();
        }

        private void OnEvent(VanzariEvent e)
        {
            if (userEvent != null)
                userEvent(this, e);

        }

        internal void AddProdus(Produs produs)
        {
            service.AddProdus(produs);
        }

        internal void UpdateProdus(Produs produs)
        {
            service.UpdateProdus(produs);
        }

        internal void DeleteProdus(Produs produsSelected)
        {
            service.DeleteProdus(produsSelected);
        }
        public override void UpdateProdusRequired(Produs produs)
        {
            VanzariEvent userEvent = new VanzariEvent(EventType.MODPRODUS, produs);
            OnEvent(userEvent);
        }

        public override void AddProdusRequired(Produs produs)
        {
            VanzariEvent userEvent = new VanzariEvent(EventType.ADDPRODUS, produs);
            OnEvent(userEvent);
        }

        public override void DeleteProdusRequired(Produs produs)
        {
            VanzariEvent userEvent = new VanzariEvent(EventType.DELETEPRODUS, produs);
            OnEvent(userEvent);
        }

        public void LogOut()
        {
            service.LogOut(LoggedUser);

        }


    }
}
