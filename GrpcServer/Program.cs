using Grpc.Core;
using System;
using Persistence.interfaces;
using Persistence.classes;
using GrpcServer.DBContexts;
using Model;
using GrpcServer.Persistence.classes;

namespace GrpcServer
{
    class Program
    {
        static void Main(string[] args)
        {
            
            IProdusRepository produsRepository = new ProdusDBRepository();
            IAngajatRepository angajatRepository = new AngajatDBRepository();
            IComandaRepository comandaRepository = new ComandaDBRepository();
            Server server = new Server
            {
                Services = { VanzariService.Service.BindService(new Service(angajatRepository,produsRepository,comandaRepository)) },
                Ports = { new ServerPort("localhost", 3001, ServerCredentials.Insecure) }
            };
            server.Start();

            Console.WriteLine("Greeter server listening on port " + 3001);
            Console.WriteLine("Press any key to stop the server...");
            Console.ReadKey();

            server.ShutdownAsync().Wait();
            
        }


    }

}
