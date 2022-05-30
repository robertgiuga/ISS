using ClientServer;
using Grpc.Core;
using Services;
using System;
using System.Threading.Tasks;

namespace VanzariClient
{
    class UpdateServer : ClientServer.ClientServer.ClientServerBase
    {
        Observer observer;

        public UpdateServer(Observer observer)
        {
            this.observer = observer;
        }

        public override Task<ReplyClientGrpc> update(RequestClientGrpc request, ServerCallContext context)
        {
            Console.WriteLine("Am primit!");
            Model.Produs produs=null;
            Model.Comanda comanda=null;
            if (request.Produs != null)
                produs = new Model.Produs(request.Produs.Id, request.Produs.Descriere, request.Produs.Cantitate, request.Produs.Denumire);
            else if(request.Comanda!=null)
                comanda = new Model.Comanda(request.Comanda.Id, request.Comanda.Descriere,(Model.Status)request.Comanda.Status);
            switch (request.Type)
            {
                case RequestClientGrpc.Types.RequestType.Add:
                    observer.Instance.AddProdusRequired(produs);
                    break;
                case RequestClientGrpc.Types.RequestType.Delete:
                    observer.Instance.DeleteProdusRequired(produs);
                    break;
                case RequestClientGrpc.Types.RequestType.Mod:
                    observer.Instance.UpdateProdusRequired(produs);
                    break;
                case RequestClientGrpc.Types.RequestType.Updcom:
                    observer.Instance.UpdateComandaRequired(comanda);
                    break;
                case RequestClientGrpc.Types.RequestType.Reload:
                    observer.Instance.ReloadProduseRequired();
                    break;
            }
            //TODO add comanda to update server and services update

            return Task.FromResult(new ReplyClientGrpc { Type = ReplyClientGrpc.Types.ResponseType.Ok });
        }
    }
}
