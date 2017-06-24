using Microsoft.AspNet.SignalR;
using System.Threading.Tasks;

namespace SignalrService.SignalR.Hubs
{
    public class Broadcaster : Hub
    {
        public Task Broadcast(string message)
        {
            return Clients.All.Message(message);
        }
        public override Task OnConnected()
        {
            return Clients.All.Message(">> New client arrived");
        }
        public override Task OnDisconnected(bool stopCalled)
        {
            return Clients.All.Message(">> Client disconnected");
        }
    }
}
