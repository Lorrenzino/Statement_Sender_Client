using Statement_Sender_Client.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Statement_Sender_Client.WorkWithData
{
    internal class Client
    {
        public async void OutCommingCall ()
        {
            byte[] bytes = new byte[1024];

            string host = Current_user.Current.User_IP;
            int port = 20101;
            TcpClient client = new TcpClient();

            var socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            try
            {
                await socket.ConnectAsync(host, port);
                Console.WriteLine($"Подключение к {host} установлено");


                await socket.DisconnectAsync(true); // отключаемся
            }
            catch (SocketException)
            {
                Console.WriteLine($"Не удалось установить подключение к {host}");
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
