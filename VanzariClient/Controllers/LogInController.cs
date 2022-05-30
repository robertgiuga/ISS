using Model;
using Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace VanzariClient.Controllers
{
    public class LogInController
    {
        private VanzariProxy service;
        private Angajat loggedUser;

        public LogInController(VanzariProxy service)
        {
            this.service = service;
        }
        public void LogIn(Angajat angajat)
        {
            Observer observer = new Observer();
            Angajat replayAngajat = service.LogIn(angajat, observer);
            this.loggedUser = replayAngajat;
            if (replayAngajat.Role == Rol.agent)
            {
                //agent window
                AngajatController angajatController = new AngajatController(service, loggedUser);
                observer.Instance = angajatController;
                Vanzari vanzariWindow = new Vanzari(angajatController);
                vanzariWindow.Show();
            }
            else
            {
                AdminController adminController= new AdminController(service, loggedUser);
                observer.Instance= adminController;
                //admin window
                Manage manageWindow = new Manage(adminController);
                manageWindow.Show();

            }
        }

    }


}
