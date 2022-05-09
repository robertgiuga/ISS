using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using Grpc.Core;
using Model;
using Services;
using System.Net.Sockets;
using Model;

namespace VanzariClient
{
    public class Controller : IVanzariObserver
    {
        private VanzariProxy service;

        public EventHandler<VanzariEvent> userEvent;
        private Angajat loggedUser;

        public Controller(VanzariProxy service)
        {
            this.service = service;
        }

        public IEnumerable<Produs> findAllProduse()
        {
            return service.findAllProduse();
        }

        public void LogIn(Angajat angajat)
        {

            Angajat replayAngajat = service.LogIn(angajat,this);
            this.loggedUser = replayAngajat;
            if (replayAngajat.Role == Rol.agent)
            {
                //agent window
            }
            else
            {
                //admin window
                Manage manageWindow = new Manage(this);
                manageWindow.Show();

            }
        }

        public void LogOut()
        {
            service.LogOut(loggedUser);
            
        }
        private void OnEvent(VanzariEvent e)
        {
            if (userEvent != null)
                userEvent(this,e);

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
        public void UpdateProdusRequired(Produs produs)
        {
            VanzariEvent userEvent = new VanzariEvent(EventType.MODPRODUS, produs);
            OnEvent(userEvent);
        }

        public void AddProdusRequired(Produs produs)
        {
            VanzariEvent userEvent = new VanzariEvent(EventType.ADDPRODUS, produs);
            OnEvent(userEvent);           
        }

        public void DeleteProdusRequired(Produs produs)
        {
            VanzariEvent userEvent = new VanzariEvent(EventType.DELETEPRODUS, produs);
            OnEvent(userEvent);
        }
    }
}
