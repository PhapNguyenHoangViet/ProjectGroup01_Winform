using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Group01_QuanLyLuanVan.Chat.Net
{
    public class Server
    {
        TcpClient tcpClient;

        public Server() 
        {
            tcpClient = new TcpClient();
        }

        public void ConnectToServer()
        {
            if (!tcpClient.Connected)
            {
                tcpClient.Connect("127.0.0.1", 7891);
            }
        }
    }
}
