using Statement_Sender_Client.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Reflection.Metadata;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Markup;

namespace Statement_Sender_Client.WorkWithData
{
    internal class Client
    {
        public static string data = null;
        public async void OutCommingCall ()
        {
            byte[] bytes = new byte[1024];
            var hostName = "HelpClient";
            //IPHostEntry ipHost = Dns.GetHostEntry("HelpClient");
            //var hostName = "10.114.9.21";
            //Console.WriteLine(hostName);                
            IPHostEntry ipHost = Dns.GetHostEntry(hostName);
            IPAddress ipAddress = ipHost.AddressList[1];



            IPEndPoint localEndPoint = new IPEndPoint(ipAddress, 20101);
            Socket listener = new Socket(ipAddress.AddressFamily, SocketType.Stream, ProtocolType.Tcp);



            Console.WriteLine(ipAddress + "   " + localEndPoint.Port);

            try
            {
                listener.Bind(localEndPoint);
                listener.Listen(10);
                do
                {
                    Socket handler = listener.Accept();
                    data = null;
                    while (true)
                    {
                        int byteRec = handler.Receive(bytes);
                        data += Encoding.ASCII.GetString(bytes, 0, byteRec);
                        if (handler.Available <= 0)
                            break;
                    }


                    data += " ALL DATA HAS SENDED";
                    byte[] msg = Encoding.ASCII.GetBytes(data);
                    handler.Send(msg);

                    handler.Shutdown(SocketShutdown.Both);
                    handler.Close();
                }
                while (false);
            }
            catch
            (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("happend somthing BAD");
            }

            /*
            try
            {
                await socket.ConnectAsync(host, port);
                // определяем отправляемые данные
                var message = $"GET / HTTP/1.1\r\nHost: {host}\r\nConnection: close\r\n\r\n";
                // конвертируем данные в массив байтов
                var messageBytes = Encoding.UTF8.GetBytes(message);
                int bytesSent = await socket.SendAsync(messageBytes);
                Console.WriteLine($"на адрес {host} отправлено {bytesSent} байт(а)");
            }
            catch (SocketException ex)
            {
                Console.WriteLine(ex.Message);
            }
            */
        }
        //public Task<int> SendAsync(ArraySegment<byte> buffer);
        //public Task<int> SendAsync(ArraySegment<byte> buffer, SocketFlags socketFlags);
        
        
        //для теста
        void ForServer()
        {

        }

    }

}
