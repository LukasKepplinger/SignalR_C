using Microsoft.AspNetCore.SignalR.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalR.Client.Services
{
    public class ChatService
    {

        public HubConnection Connection { get; set; }
        public event Action<string> OnMessage;

        public string CreateConnection(string address)
        {
            try
            {
                Connection = new HubConnectionBuilder()
                .WithUrl(address)
                .Build();

                Connection.On<string>("ReceiveMessage", (messageX) => OnMessage?.Invoke(messageX));
            }
            catch (Exception ex)
            {
                return "Connection could not be created: " + ex.Message;
            }
            return "Connection: " + Connection.ToString() + " was created";
        }    

        public async Task Connect()
        {
            await Connection.StartAsync();
        }

        public async Task SendMessage(string message)
        {
            await Connection.SendAsync("SendMessage", message);
        }
    }
}
