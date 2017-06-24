using System.Threading.Tasks;
using Microsoft.AspNet.SignalR;
using System.Linq;

namespace RealTimeAppWithSignalR.WebMVC.SignalR.PersistentConnections
{
    public class WebBrowserGroupsConnection: PersistentConnection
    {
        protected override Task OnConnected(IRequest request, string connectionId)
        {
      
            var headers = request.Headers;
            var userAgent = headers.GetValues("User-Agent");
            var grupo = "Chrome";
            if (userAgent.Where(x => x.Contains("Firefox/")).Any())
                grupo = "Firefox";

            Groups.Add(connectionId, grupo);
            Groups.Send(grupo, $"Usuário { connectionId} entrou na página pelo browser {grupo}.");
            return base.OnConnected(request, connectionId);
        }

        protected override Task OnReceived(IRequest request, string connectionId, string data)
        {
            var headers = request.Headers;
            var userAgent = headers.GetValues("User-Agent");
            var grupo = "Chrome";
            if (userAgent.GetEnumerator().Current.Contains("Firefox/"))
                grupo = "Firefox";

            return Groups.Send(grupo, data);
        }
    }
}