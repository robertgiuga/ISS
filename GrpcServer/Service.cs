using Grpc.Core;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using VanzariService;
using Persistence.interfaces;
using Model;

namespace GrpcServer
{
    class Service : VanzariService.Service.ServiceBase
    {
        public IAngajatRepository angajatRepository;
        public IProdusRepository produsRepository;
        private readonly IDictionary<String, ClientServer.ClientServer.ClientServerClient> loggedclients;

        public Service(IAngajatRepository angajatRepository, IProdusRepository produsRepository)
        {
            this.angajatRepository = angajatRepository;
            this.produsRepository = produsRepository;
            loggedclients = new Dictionary<String, ClientServer.ClientServer.ClientServerClient>();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public override Task<ReplyGrpc> addProdus(RequestGrpc request, ServerCallContext context)
        {
            
            try
            {
                Produs produs = new Produs(0, request.Produs.Descriere, request.Produs.Cantitate, request.Produs.Denumire);
                produsRepository.Add(produs);
                //notify the clients 
                NotifyClients(new ClientServer.RequestClientGrpc
                {
                    Type = ClientServer.RequestClientGrpc.Types.RequestType.Add,
                    Produs = new ClientServer.ProdusGrpc
                    {
                        Cantitate = produs.Cantitate,
                        Denumire = produs.Denumire,
                        Descriere = produs.Descriere,
                        Id = produs.Id
                    }
                });
                Console.WriteLine("Am trimis!");
            }
            catch (Exception e) { return Task.FromResult(new ReplyGrpc { Type=ReplyGrpc.Types.ResponseType.Error, Message=e.Message}); }
            return Task.FromResult(new ReplyGrpc { Type = ReplyGrpc.Types.ResponseType.Ok });
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public override Task<ReplyGrpc> deleteProdus(RequestGrpc request, ServerCallContext context)
        {
            try
            {
                produsRepository.Delete(new Produs(request.Produs.Id, "", 0, ""));
                NotifyClients(new ClientServer.RequestClientGrpc
                {
                    Type = ClientServer.RequestClientGrpc.Types.RequestType.Delete,
                    Produs = new ClientServer.ProdusGrpc { Id = request.Produs.Id }
                });
            }
            catch (Exception e) { return Task.FromResult(new ReplyGrpc { Type = ReplyGrpc.Types.ResponseType.Error, Message = e.Message }); }
            return Task.FromResult(new ReplyGrpc { Type = ReplyGrpc.Types.ResponseType.Ok });
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public override Task<ReplyGrpc> findAllProduse(RequestGrpc request, ServerCallContext context)
        {

            Console.WriteLine("findAllProduse...");
            List<Produs> produse = new List<Produs>();
            try
            {
                produse = (List<Produs>)produsRepository.FindAll();
            }
            catch { return Task.FromResult(new ReplyGrpc { Type=ReplyGrpc.Types.ResponseType.Error,Message="Error"}); }

            var replay = new ReplyGrpc { Type = ReplyGrpc.Types.ResponseType.Ok, };
            foreach (var item in produse)
            {
                replay.Produs.Add(new ProdusGrpc { Id = item.Id, Cantitate = item.Cantitate, Denumire = item.Denumire, Descriere = item.Descriere });
            }
            return Task.FromResult(replay);
        }

        /// <summary>
        /// Does the LogIn
        /// search for the request.angajat in the dataBase by the id if found and the recived password matched with the
        /// one in dataBase, it is created a client for the server on the client side and added to the map.
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <param name="context"></param>
        /// <returns>
        ///     -sends a respons with ok if everyting goes right
        ///     -sends a error response and the message is something wrong ocurrs
        /// </returns>
        public override Task<ReplyGrpc> logIn(RequestGrpc request, ServerCallContext context)
        {
            Console.WriteLine("logIn...");
            var angajat = angajatRepository.FindById(request.Angajat.UserName);
            if (angajat.Password == request.Angajat.Password)
            {
                String host = "127.0.0.1:"+request.Port ;
                Channel channel = new Channel(host, ChannelCredentials.Insecure);
                var client = new ClientServer.ClientServer.ClientServerClient(channel);
                loggedclients.Add(angajat.Id, client);
                return Task.FromResult(new ReplyGrpc
                {
                    Type = ReplyGrpc.Types.ResponseType.Ok,
                    Angajat= new AngajatGrpc
                    {
                        Nume = angajat.Name,
                        UserName = angajat.Id,
                        Password = "",
                        Role = (int)angajat.Role
                    }
                });
                
            }
            
            return Task.FromResult(new ReplyGrpc { Type = ReplyGrpc.Types.ResponseType.Error, Message = "Invalid Autentification!" });
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public override Task<ReplyGrpc> logOut(RequestGrpc request, ServerCallContext context)
        {
            try
            {
                loggedclients.Remove(request.Angajat.UserName);
            }
            catch(Exception e)
            {
                return Task.FromResult(new ReplyGrpc { Type = ReplyGrpc.Types.ResponseType.Error, Message ="Error" });
            }
            return Task.FromResult(new ReplyGrpc { Type = ReplyGrpc.Types.ResponseType.Ok});
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public override Task<ReplyGrpc> updateProdus(RequestGrpc request, ServerCallContext context)
        {
            try
            {
                Produs produs = new Produs(request.Produs.Id, request.Produs.Descriere, request.Produs.Cantitate, request.Produs.Denumire);
                produsRepository.Update(produs);
                NotifyClients(new ClientServer.RequestClientGrpc
                {
                    Type = ClientServer.RequestClientGrpc.Types.RequestType.Mod,
                    Produs = new ClientServer.ProdusGrpc
                    {
                        Id = produs.Id,
                        Cantitate=produs.Cantitate,
                        Denumire=produs.Denumire,
                        Descriere=produs.Descriere
                    }
                });
            }
            catch (Exception e) { return Task.FromResult(new ReplyGrpc { Type = ReplyGrpc.Types.ResponseType.Error, Message = e.Message }); }
            return Task.FromResult(new ReplyGrpc { Type = ReplyGrpc.Types.ResponseType.Ok });

        }

        private void NotifyClients(ClientServer.RequestClientGrpc request)
        {
            foreach (var item in loggedclients.Values)
            {
                Task.Run(() =>
                {
                    Console.WriteLine("**");
                    var replay = item.update(request);
                });
                
            }
        }
    }
}
