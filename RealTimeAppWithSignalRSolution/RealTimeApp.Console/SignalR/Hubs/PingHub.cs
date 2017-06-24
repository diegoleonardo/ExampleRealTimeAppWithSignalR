using Microsoft.AspNet.SignalR;
using System;
using System.Threading.Tasks;

namespace RealTimeApp.ConsoleApp.SignalR.Hubs
{
    public class PingHub: Hub
    {
        public Task Ping()
        {
            Console.WriteLine("[Hub] Ping received");
            return Clients.Caller.Message($"Ping received at {DateTime.Now.ToLongTimeString() }");
        }
    }
}
