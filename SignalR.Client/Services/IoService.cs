

using Microsoft.AspNetCore.SignalR.Client;

namespace SignalR.Client.Services
{
    public class IoService
    {
        public HubConnection Connection { get; set; }
        public event Action<int, bool> OnMessage;

        public string CreateConnection(string address)
        {
            Connection = new HubConnectionBuilder()
                .WithUrl(address)
                .Build();

            Connection.On<int, bool>("ReceiveIoResponse", (pin, setTo) => OnMessage?.Invoke(pin, setTo));

            return "Connection: " + Connection.ToString() + " was created";
        }

        public string Connect()
        {
            try
            {
                Connection.StartAsync();
            }
            catch (Exception)
            {            
                return "Io-Connection could not be activated";
            }
            return "Io-Connection is active";
        }

        public async Task SetIo(int pin, bool setTo)
        {
            await Connection.SendAsync("SetIo", pin, setTo);
        }
        public async Task WriteIo(int pin, bool setTo)
        {
            await Connection.SendAsync("WriteIo", pin, setTo);
        }
    }
}
