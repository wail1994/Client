using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {

        private const int portNum = 80;
        private const string hostName = "192.168.1.12";

        static void Main(string[] args)
        {
            TcpClient client = new TcpClient(hostName, portNum);
            NetworkStream ns = client.GetStream();
            string message = "Actualy date is " + DateTime.Now;
            byte[] bytes = ASCIIEncoding.ASCII.GetBytes(message);
            ns.Write(bytes,0,bytes.Length);
            
            int bytesRead = ns.Read(bytes, 0, bytes.Length);
            Console.WriteLine(Encoding.ASCII.GetString(bytes, 0, bytesRead));
            client.Close();



        }
    }
}
