using System.Threading.Tasks;
using Microsoft.AspNet.SignalR;

namespace RealTimeAppWithSignalR.WebApp.PersistentConnections
{
    public class EchoConnection: PersistentConnection
    {
        protected override Task OnConnected(IRequest request, string connectionId)
        {
            return base.OnConnected(request, connectionId);
        }
    }
}
