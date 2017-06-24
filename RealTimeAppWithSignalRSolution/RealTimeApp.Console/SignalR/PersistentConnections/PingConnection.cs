using System.Threading.Tasks;
using Microsoft.AspNet.SignalR;
using System;

namespace RealTimeApp.ConsoleApp.SignalR.PersistentConnections
{
    public class PingConnection: PersistentConnection
    {
        protected override Task OnConnected(IRequest request, string connectionId)
        {
            Console.WriteLine("[Connection] Ping Connected");
            return Connection.Send(connectionId, "Ok");
        }
        protected override Task OnReceived(IRequest request, string connectionId, string data)
        {
            if (data.Equals("Ping"))
            {
                Console.WriteLine("[Connection] Ping Received");
                return Connection.Send(connectionId, $"Ping received at {DateTime.Now.ToLongTimeString() }");
            }
            return base.OnReceived(request, connectionId, data);
        }
    }
}
