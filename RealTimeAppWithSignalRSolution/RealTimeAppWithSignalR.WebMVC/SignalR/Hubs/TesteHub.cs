using System.Threading.Tasks;
using Microsoft.AspNet.SignalR;
using Microsoft.AspNet.SignalR.Hubs;

namespace RealTimeAppWithSignalR.WebMVC.SignalR.Hubs
{
    [HubName("Teste")]
    public class TesteHub : Hub
    {
        public override Task OnConnected()
        {
            return Clients.All.newUser(Context.ConnectionId);
        }
        
        public Task Alert(string username, string mensagem)
        {
            Clients.Caller.UserName = username;

            var alerta = $"#{Clients.Caller.MsgId++} alert from {Clients.Caller.UserName}: {mensagem}";

            return Clients.Caller.showAlert(alerta);
        }
    }
}