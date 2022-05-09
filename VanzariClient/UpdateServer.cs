using ClientServer;
using Grpc.Core;
using Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace VanzariClient
{
    class UpdateServer : ClientServer.ClientServer.ClientServerBase
    {
        IVanzariObserver observer;

        public UpdateServer(IVanzariObserver observer)
        {
            this.observer = observer;
        }

        public override Task<ReplyClientGrpc> update(RequestClientGrpc request, ServerCallContext context)
        {
            Console.WriteLine("Am primit!");
            Model.Produs produs = new Model.Produs(request.Produs.Id, request.Produs.Descriere, request.Produs.Cantitate, request.Produs.Denumire);
            switch (request.Type)
            {
                case RequestClientGrpc.Types.RequestType.Add:
                    observer.AddProdusRequired(produs);
                    break;
                case RequestClientGrpc.Types.RequestType.Delete:
                    observer.DeleteProdusRequired(produs);
                    break;
                case RequestClientGrpc.Types.RequestType.Mod:
                    observer.UpdateProdusRequired(produs);
                    break;
            }
            
            return Task.FromResult(new ReplyClientGrpc { Type = ReplyClientGrpc.Types.ResponseType.Ok });
        }
    }
}
