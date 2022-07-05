using System;
using Renci.SshNet;
using System.Windows.Forms;

namespace SSH_Router_Toolbox
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private async void ResetIP_Click(object sender, EventArgs e)
        {
            using (var client = new SshClient(Host.Text, Username.Text, Password.Text))
            {
                client.Connect();
                client.RunCommand("killall -SIGUSR2 udhcpc && killall -SIGUSR1 udhcpc");
                client.Disconnect();
            }
        }
    }
}
