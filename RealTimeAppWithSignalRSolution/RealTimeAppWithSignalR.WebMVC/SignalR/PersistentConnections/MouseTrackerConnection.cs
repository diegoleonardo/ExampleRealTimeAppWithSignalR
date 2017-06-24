using System.Threading.Tasks;
using Microsoft.AspNet.SignalR;

namespace RealTimeAppWithSignalR.WebMVC.SignalR.PersistentConnections
{
    public class MouseTrackerConnection: PersistentConnection
    {
        protected override Task OnReceived(IRequest request, string connectionId, string data)
        {
            return Connection.Broadcast(data);
        }
    }
}