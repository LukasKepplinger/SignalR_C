using Microsoft.AspNetCore.SignalR.Client;
using SignalR.Client.Services;

namespace SignalR.Client
{
    public partial class Form1 : Form
    {
        public ChatService chatService { get; set; }
        public IoService ioService { get; set; }
        public CornService cornService { get; set; }

        public Form1()
        {
            InitializeComponent();

        }






        private async void btCreateConnection_Click(object sender, EventArgs e)
        {
            chatService = new ChatService();
            string address = "http://172.17.243.232:5100/chat";
            lbResponse.Items.Add(chatService.CreateConnection(address));
        }

        private void btConnect_Click(object sender, EventArgs e)
        {
            chatService.Connect();
            lbResponse.Items.Add("Chat-Connection is active");
        }

        private async void btSend_Click(object sender, EventArgs e)
        {
            try
            {
                await chatService.SendMessage(Text = tbText.Text);
                lbResponse.Items.Add(tbText.Text + " was sent");
            }
            catch (Exception)
            {
                lbResponse.Items.Add(tbText.Text + " could not be sent");
            }
        }










        private async void btnCreateCorn_Click(object sender, EventArgs e)
        {
            cornService = new CornService();
            string address = "http://172.17.243.232:5100/chat";
            lbResponse.Items.Add(cornService.CreateConnection(address));
        }

        private void btnConnectCorn_Click(object sender, EventArgs e)
        {
            cornService.Connect();
            lbResponse.Items.Add("Corn-Connection is active");
        }

        private async void btnSendCorn_Click(object sender, EventArgs e)
        {
            try
            {
                await cornService.SendMessage();
                lbResponse.Items.Add("Corn was sent");
            }
            catch (Exception)
            {
                lbResponse.Items.Add(tbText.Text + " could not be sent");
            }
        }












        private void btCreateIoConnection_Click(object sender, EventArgs e)
        {
            ioService = new IoService();
            string address = "http://172.17.243.232:5100/io";
            lbResponse.Items.Add(ioService.CreateConnection(address));
        }

        private void btConnectIo_Click(object sender, EventArgs e)
        {
            lbResponse.Items.Add(ioService.Connect());
        }

        private async void btSetPin_Click(object sender, EventArgs e)
        {
            try
            {
                if (btInOrOutput.Text == "Output")
                {
                    await ioService.SetIo(Convert.ToInt32(tbPin.Text), true);
                    lbResponse.Items.Add("Pin " + tbPin.Text + " was set to Output");
                }
                else
                {
                    await ioService.SetIo(Convert.ToInt32(tbPin.Text), false);
                    lbResponse.Items.Add("Pin " + tbPin.Text + " was set to Input");
                }

            }
            catch (Exception)
            {
                lbResponse.Items.Add("Pin " + tbPin.Text + " could not be set");
            }
        }

        private async void btWritePin_Click(object sender, EventArgs e)
        {
            try
            {
                if (btHighOrLow.Text == "High")
                {
                    await ioService.WriteIo(Convert.ToInt32(tbPin.Text), true);
                    lbResponse.Items.Add("Pin " + tbPin.Text + " was written to High");
                }
                else
                {
                    await ioService.WriteIo(Convert.ToInt32(tbPin.Text), false);
                    lbResponse.Items.Add("Pin " + tbPin.Text + " was written to Low");
                }
            }
            catch (Exception)
            {
                lbResponse.Items.Add("Pin " + tbPin.Text + " could not be written");
            }
        }




        private void btHighOrLow_Click(object sender, EventArgs e)
        {
            if (btHighOrLow.Text == "High")
            {
                btHighOrLow.Text = "Low";
            }
            else
            {
                btHighOrLow.Text = "High";
            }
        }

        private void btInOrOutput_Click(object sender, EventArgs e)
        {
            if (btInOrOutput.Text == "Output")
            {
                btInOrOutput.Text = "Input";
            }
            else
            {
                btInOrOutput.Text = "Output";
            }
        }






        public bool noticedDownE { get; set; }
        private async void lbResponse_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.W)
            {
                await ioService.WriteIo(21, false);
                lbResponse.Items.Add("W was released");
                noticedDownE = false;
            }
        }

        private async void lbResponse_KeyDown(object sender, KeyEventArgs e)
        {          
            if (e.KeyCode == Keys.W)
            {
                if (!noticedDownE)
                {
                    await ioService.WriteIo(21, true);
                    lbResponse.Items.Add("W was pressed");
                    noticedDownE = true;
                }                             
            }
        }

        private async void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.W)
            {
                if (!noticedDownE)
                {
                    await ioService.WriteIo(21, true);
                    lbResponse.Items.Add("W was pressed");
                    noticedDownE = true;
                }
            }
        }

        private async void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.W)
            {
                await ioService.WriteIo(21, false);
                lbResponse.Items.Add("W was released");
                noticedDownE = false;
            }
        }
    }
}