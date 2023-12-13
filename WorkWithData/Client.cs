using Statement_Sender_Client.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http.Json;
using System.Net.Sockets;
using System.Reflection.Metadata;
using System.Security.Policy;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Windows.Markup;
using Newtonsoft.Json;
using System.Collections.ObjectModel;

namespace Statement_Sender_Client.WorkWithData
{
    internal class Client
    {
        public static string data = null;
        public async void OutCommingCallAsync(Request message_to_send)
        {
            byte[] bytes = new byte[1024];
            var hostName = "HelpClient";               
            IPHostEntry ipHost = Dns.GetHostEntry(hostName);
            IPAddress ipAddress = ipHost.AddressList[1];
            IPEndPoint remoteEP = new IPEndPoint(ipAddress, 20101);
            Socket sender = new Socket(ipAddress.AddressFamily, SocketType.Stream, ProtocolType.Tcp);

            try
            {
                sender.Connect(remoteEP);
                do
                {
                    
                    string send_string = JsonConvert.SerializeObject(message_to_send);
                    byte[] msg = Encoding.ASCII.GetBytes(send_string);
                    int byteSent = sender.Send(msg);
                    data = null;
                    while (true)
                    {
                        int byteRec = sender.Receive(bytes);
                        data += Encoding.ASCII.GetString(bytes, 0, byteRec);
                        if (sender.Available <= 0)
                            break;
                    }

                    Request Answer = JsonConvert.DeserializeObject<Request>(data);

                    //чтото что внесёт изменение в мои данные
                    ObservableCollection<Statement> state_collect = new ObservableCollection<Statement>();

                    if(Answer!=null)
                        DataWorker.DataWorkerOnWork(Answer);

                    

                    sender.Shutdown(SocketShutdown.Both);
                    sender.Close();
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
