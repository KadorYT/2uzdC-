using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace UdpSender
{
    class Program
    {
        static void Main(string[] args)
        {
            using (UdpClient udpClient = new UdpClient())
            {
                string receiverIpAddress = "127.0.0.1";
                int receiverPort = 25565;
                Console.Write("Message to send: ");
                string message = Console.ReadLine();
                byte[] messageBytes = Encoding.UTF8.GetBytes(message);
                udpClient.Send(messageBytes, messageBytes.Length, receiverIpAddress, receiverPort);
            }
        }
    }
}
