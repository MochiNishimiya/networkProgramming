using System.Net.Sockets;
using System.Net;

namespace Project1._0
{
    static class connectServer
    {
        public static NetworkStream serverStream = default(NetworkStream);
        public static TcpClient clientSocket;
    }

    internal static class Program
    {
        public static Login lg = new Login();
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]

        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            connectServer.clientSocket = new TcpClient();
            connectServer.clientSocket.Connect(IPAddress.Parse("127.0.0.1"), 8080);   // Modified this
            connectServer.serverStream = connectServer.clientSocket.GetStream();

            ApplicationConfiguration.Initialize();
            Application.Run(lg);
        }
    }
}