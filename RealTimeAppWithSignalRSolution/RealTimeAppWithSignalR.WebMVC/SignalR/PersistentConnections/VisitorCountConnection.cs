using Microsoft.AspNet.SignalR;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;

namespace RealTimeAppWithSignalR.WebMVC.SignalR.PersistentConnections
{
    public class VisitorCountConnection : PersistentConnection
    {
        private static int connections = 0;

        protected override Task OnConnected(IRequest request, string connectionId)
        {
            Interlocked.Increment(ref connections);
            Debug.WriteLine($"Visitor: {connections}");
            Connection.Broadcast($"Visitante {connectionId} acabou de acessar a Home.", connectionId);
            return base.OnConnected(request, connectionId);
        }

        protected override Task OnDisconnected(IRequest request, string connectionId, bool stopCalled)
        {
            Interlocked.Decrement(ref connections);
            Debug.WriteLine($"Visitor: {connections}");

            return base.OnDisconnected(request, connectionId, stopCalled);
        }

        protected override Task OnReceived(IRequest request, string connectionId, string data)
        {
            var message = $"{connectionId} >>>> {data}";
            return Connection.Broadcast(message);
        }
    }
}