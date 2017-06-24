using System.ServiceProcess;

namespace RealTimeApp.WindowsServiceApp
{
    static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        static void Main()
        {
            ServiceBase[] ServicesToRun;
            ServicesToRun = new ServiceBase[]
            {
                new BroadcasterService()
            };
            ServiceBase.Run(ServicesToRun);
        }
    }
}
