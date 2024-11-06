using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace EcoServer
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            var ip = IPAddress.Parse("127.0.0.1");

            int port = 8000;

            Console.WriteLine("Server is starting");
            var listener = new TcpListener(ip,port);
            listener.Start();
            Console.WriteLine($"Listening to port:{port}");

            Socket socket = listener.AcceptSocket();
            Console.WriteLine("Client Connected");


            while (true)
            {
                var buffer = new byte[1024];
                var dataLength = socket.Receive(buffer);
                string message = Encoding.ASCII.GetString(buffer, 0, dataLength);

                byte[] responseData = Encoding.ASCII.GetBytes(message);
                socket.Send(responseData);
            }
            
        }
    }
}
