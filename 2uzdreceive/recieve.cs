using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace UdpReceiver
{
    class Program
    {
        static void Main(string[] args)
        {
            using (UdpClient udpReceiver = new UdpClient(25565)) 
            {
                IPEndPoint senderEndPoint = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 0);
                byte[] receivedBytes = udpReceiver.Receive(ref senderEndPoint);
                string receivedMsg = Encoding.UTF8.GetString(receivedBytes);
                Console.WriteLine($"Received: {receivedMsg}");
            }
        }
    }
}
