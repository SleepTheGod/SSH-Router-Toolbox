using System;
using System.Threading.Tasks;
using Renci.SshNet;
using System.Windows.Forms;

namespace SSH_Router_Toolbox
{
    public partial class Main : Form
    {
        // ToolTip for help explanations
        private ToolTip helpTooltip = new ToolTip();

        public Main()
        {
            InitializeComponent();
            InitializeHelpTooltips();
            InitializeHelpMenu();
        }

        private void InitializeHelpTooltips()
        {
            // Set up tooltips for each field
            helpTooltip.SetToolTip(Host, "Enter the router's IP address or hostname.");
            helpTooltip.SetToolTip(Username, "Enter the SSH username for the router.");
            helpTooltip.SetToolTip(Password, "Enter the SSH password for the router.");
            helpTooltip.SetToolTip(Port, "Enter the SSH port (default: 22).");
            helpTooltip.SetToolTip(Timeout, "Enter the timeout for the SSH connection in seconds.");
            helpTooltip.SetToolTip(CommandField, "Enter the command to reset IP. Default: 'killall -SIGUSR2 udhcpc && killall -SIGUSR1 udhcpc'.");
        }

        private void InitializeHelpMenu()
        {
            // Add a Help menu to the form
            MenuStrip menuStrip = new MenuStrip();
            ToolStripMenuItem helpMenu = new ToolStripMenuItem("Help");
            ToolStripMenuItem connectionHelp = new ToolStripMenuItem("Connection Help", null, ConnectionHelp_Click);
            ToolStripMenuItem commandHelp = new ToolStripMenuItem("Command Help", null, CommandHelp_Click);
            helpMenu.DropDownItems.Add(connectionHelp);
            helpMenu.DropDownItems.Add(commandHelp);
            menuStrip.Items.Add(helpMenu);
            this.MainMenuStrip = menuStrip;
            this.Controls.Add(menuStrip);
        }

        private void ConnectionHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ensure you have the correct IP address, username, password, and SSH port for your router.", 
                            "Connection Help", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void CommandHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This tool allows you to reset the router IP using the 'killall -SIGUSR2 udhcpc && killall -SIGUSR1 udhcpc' command.\n" +
                            "You can modify this command in the command field if needed.", 
                            "Command Help", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private async void ResetIP_Click(object sender, EventArgs e)
        {
            // Validate fields
            if (string.IsNullOrWhiteSpace(Host.Text) || string.IsNullOrWhiteSpace(Username.Text) || string.IsNullOrWhiteSpace(Password.Text))
            {
                MessageBox.Show("Please fill in all fields before proceeding.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int port = 22;
            int timeout = 10;

            // Parse port and timeout, handle invalid input
            if (!int.TryParse(Port.Text, out port)) port = 22;
            if (!int.TryParse(Timeout.Text, out timeout)) timeout = 10;

            string command = string.IsNullOrWhiteSpace(CommandField.Text) 
                             ? "killall -SIGUSR2 udhcpc && killall -SIGUSR1 udhcpc" 
                             : CommandField.Text;

            try
            {
                await Task.Run(() =>
                {
                    using (var client = new SshClient(Host.Text, port, Username.Text, Password.Text))
                    {
                        client.ConnectionInfo.Timeout = TimeSpan.FromSeconds(timeout);
                        client.Connect();
                        
                        if (client.IsConnected)
                        {
                            // Run the custom or default command and retrieve the result
                            var result = client.RunCommand(command);
                            client.Disconnect();
                            
                            // Display command output to the user
                            Invoke((MethodInvoker)delegate
                            {
                                MessageBox.Show($"Command Output:\n{result.Result}", "Command Executed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            });
                        }
                    }
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
