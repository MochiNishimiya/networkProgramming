using System.Net.Sockets;
using System.Net;
using System.Threading;
namespace Project1._0
{
    static class connectServer
    {
        public static NetworkStream serverStream = default(NetworkStream);
        public static TcpClient clientSocket;
        public static byte[] key = new byte[16];
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
            connectServer.clientSocket.Connect(IPAddress.Parse("103.142.137.207"), 34214);   // Modified this
            connectServer.serverStream = connectServer.clientSocket.GetStream();

            Thread.Sleep(1000);
            connectServer.serverStream.Read(connectServer.key, 0, connectServer.key.Length);

            ApplicationConfiguration.Initialize();
            Application.Run(lg);
        }
    }
}