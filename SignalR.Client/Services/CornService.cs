using Microsoft.AspNetCore.SignalR.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalR.Client.Services
{
    public class CornService
    {

        public HubConnection Connection { get; set; }
        public event Action OnMessage;

        public string CreateConnection(string address)
        {
            Connection = new HubConnectionBuilder()
                .WithUrl(address)
                .Build();

            Connection.On("ReceiveIoResponse", () => OnMessage?.Invoke());

            return "Connection: " + Connection.ToString() + " was created";
        }    

        public async Task Connect()
        {
            await Connection.StartAsync();
        }

        public async Task SendMessage()
        {
            await Connection.SendAsync("DoPCA");
        }
    }
}
