﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.NetworkInformation;
using System.Text;
using Grpc.Core;
using Model;
using Services;
using VanzariService;

namespace VanzariClient
{
    public class VanzariProxy : IService
    {
        private Service.ServiceClient client;
        private Server server;

        public VanzariProxy(Service.ServiceClient client)
        {
            this.client = client;
        }

        public IEnumerable<Produs> findAllProduse()
        {
            var reply = client.findAllProduse(new RequestGrpc { });
            List<Produs> produse = new List<Produs>();
            if (reply.Type == ReplyGrpc.Types.ResponseType.Ok)
            {
                foreach (var item in reply.Produs)
                {
                    produse.Add(new Produs(item.Id, item.Descriere, item.Cantitate, item.Denumire));
                }
            }
            else throw new ValidationExcetion(reply.Message);
            return produse;
        }

        public void LogOut(Angajat angajat)
        {
            server.ShutdownAsync();
            var reply = client.logOut(new RequestGrpc
            {
                Angajat = new AngajatGrpc
                {
                    UserName = angajat.Id
                }
            });
            if (reply.Type == ReplyGrpc.Types.ResponseType.Error)
                throw new ValidationExcetion(reply.Message);
        }

        public Angajat LogIn(Angajat angajat,IVanzariObserver observer)
        {

            Console.WriteLine("Login...");
            int port = 3006;
            while (PortInUse(port)== true) port++;
            Console.WriteLine("**");
            Server clientServer = new Server
            {
                Services = { ClientServer.ClientServer.BindService(new UpdateServer(observer)) },
                Ports = { new ServerPort("localhost", port, ServerCredentials.Insecure) }
            };
            clientServer.Start();
            this.server = clientServer;
            // clientServer.ShutdownAsync().Wait();

            Console.WriteLine(port);


            Console.WriteLine("***");
            Console.WriteLine("Login...");
            var reply = client.logIn(new RequestGrpc { Angajat = new AngajatGrpc { Password = angajat.Password, UserName = angajat.Id },Port=port });

            Angajat returnAngajat = null;
            if (reply.Type == ReplyGrpc.Types.ResponseType.Ok)
                returnAngajat = new Angajat(reply.Angajat.Nume, reply.Angajat.UserName, reply.Angajat.Password, (Rol)reply.Angajat.Role);
            else
            {
                server.ShutdownAsync();
                throw new ValidationExcetion(reply.Message);
            }

            return returnAngajat;
        }

        public void AddProdus(Produs produs)
        {
            var reply = client.addProdus(new RequestGrpc
            {
                Produs = new ProdusGrpc
                {
                    Cantitate = produs.Cantitate,
                    Denumire = produs.Denumire,
                    Descriere = produs.Descriere
                }
            });
            if (reply.Type == ReplyGrpc.Types.ResponseType.Error)
                throw new ValidationExcetion(reply.Message);
           
        }

        public void DeleteProdus(Produs produs)
        {
            var reply = client.deleteProdus(new RequestGrpc
            {
                Produs = new ProdusGrpc
                {
                    Id = produs.Id
                }
            });
            if (reply.Type == ReplyGrpc.Types.ResponseType.Error)
                throw new ValidationExcetion(reply.Message);
        }

        public void UpdateProdus(Produs produs)
        {
            var reply = client.updateProdus(new RequestGrpc
            {
                Produs = new ProdusGrpc
                {
                    Id = produs.Id,
                    Cantitate = produs.Cantitate,
                    Denumire=produs.Denumire,
                    Descriere=produs.Descriere
                }
            });
            if (reply.Type == ReplyGrpc.Types.ResponseType.Error)
                throw new ValidationExcetion(reply.Message);
        }

        public static bool PortInUse(int port)
        {
            bool inUse = false;

            IPGlobalProperties ipProperties = IPGlobalProperties.GetIPGlobalProperties();
            IPEndPoint[] ipEndPoints = ipProperties.GetActiveTcpListeners();


            foreach (IPEndPoint endPoint in ipEndPoints)
            {
                if (endPoint.Port == port)
                {
                    inUse = true;
                    break;
                }
            }


            return inUse;
        }
    }
}
