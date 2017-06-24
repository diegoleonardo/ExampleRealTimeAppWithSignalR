using Microsoft.AspNet.SignalR.Client;
using System;

namespace RealTimeApp.DrawingConsoleApp
{
    class Program
    {
        private static ConsoleColor[]
         _colors = new[]
         {
            ConsoleColor.Black, ConsoleColor.Red,
            ConsoleColor.Green, ConsoleColor.Blue,
            ConsoleColor.Yellow, ConsoleColor.Magenta,
            ConsoleColor.White
         };
        static void Main(string[] args)
        {
            Console.Title = "Console drawing board viewer";
            Console.SetWindowSize(80, 40);
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();
            
            var server = "http://localhost:1640/signalr"; // Change to your server's port number
            var hubConn = new HubConnection(server);
            var hubProxy = hubConn.CreateHubProxy("drawingBoard");

            hubProxy.On("clear", () =>
            {
                Console.BackgroundColor = ConsoleColor.White;
                Console.Clear();
            }
 );
            hubProxy.On("drawPoint", (int x, int y, int color) =>
            {
                DrawPoint(x, y, color);
            }
            );
            hubProxy.On("update", (int[,] buffer) =>
            {
                for (int x = 0; x < buffer.GetLength(0); x++)
                {
                    for (int y = 0; y < buffer.GetLength(1); y++)
                    {
                        if (buffer[x, y] != 0)
                            DrawPoint(x, y, buffer[x, y]);
                    }
                }
            }
            );
            hubConn.Start().ContinueWith(t =>
            {
                if (t.IsFaulted)
                {
                    Console.WriteLine("Error connecting to "
                    + server + ". Are you using the right URL?");
                }
            }
            );
            Console.ReadLine();
            hubConn.Stop();
        }

        private static void DrawPoint(int x, int y, int color)
        {
            int translatedx = Console.WindowWidth * x / 300;
            int translatedy = Console.WindowHeight * y / 300;
            Console.SetCursorPosition(translatedx, translatedy);
            Console.BackgroundColor = _colors[color - 1];
            Console.Write(" ");
        }
    }
}
