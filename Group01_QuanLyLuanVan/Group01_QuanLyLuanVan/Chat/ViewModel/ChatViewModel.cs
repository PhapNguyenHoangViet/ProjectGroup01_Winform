using Group01_QuanLyLuanVan.Chat.Core;
using Group01_QuanLyLuanVan.Chat.Net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group01_QuanLyLuanVan.Chat.ViewModel
{
    public class ChatViewModel
    {
        public RelayCommand ConnectToServerCommand { get; set; }
        private Server _server;

        public ChatViewModel()
        {
            _server = new Server();
            ConnectToServerCommand = new RelayCommand(o => _server.ConnectToServer());
        }

    }
}
