namespace SSH_Router_Toolbox
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ResetIP = new System.Windows.Forms.Button();
            this.HostLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Host = new System.Windows.Forms.TextBox();
            this.Username = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ResetIP
            // 
            this.ResetIP.Location = new System.Drawing.Point(10, 11);
            this.ResetIP.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ResetIP.Name = "ResetIP";
            this.ResetIP.Size = new System.Drawing.Size(56, 19);
            this.ResetIP.TabIndex = 0;
            this.ResetIP.Text = "Reset IP";
            this.ResetIP.UseVisualStyleBackColor = true;
            this.ResetIP.Click += new System.EventHandler(this.ResetIP_Click);
            // 
            // HostLabel
            // 
            this.HostLabel.AutoSize = true;
            this.HostLabel.Location = new System.Drawing.Point(4, 20);
            this.HostLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.HostLabel.Name = "HostLabel";
            this.HostLabel.Size = new System.Drawing.Size(73, 13);
            this.HostLabel.TabIndex = 1;
            this.HostLabel.Text = "Hostname/IP:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 41);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Username:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 61);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Password:";
            // 
            // Host
            // 
            this.Host.Location = new System.Drawing.Point(76, 20);
            this.Host.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Host.Name = "Host";
            this.Host.Size = new System.Drawing.Size(193, 20);
            this.Host.TabIndex = 4;
            this.Host.Text = "192.168.1.1";
            // 
            // Username
            // 
            this.Username.Location = new System.Drawing.Point(76, 43);
            this.Username.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(193, 20);
            this.Username.TabIndex = 5;
            this.Username.Text = "admin";
            // 
            // Password
            // 
            this.Password.Location = new System.Drawing.Point(76, 66);
            this.Password.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Password.Name = "Password";
            this.Password.PasswordChar = '*';
            this.Password.Size = new System.Drawing.Size(193, 20);
            this.Password.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.Password);
            this.groupBox1.Controls.Add(this.HostLabel);
            this.groupBox1.Controls.Add(this.Username);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.Host);
            this.groupBox1.Location = new System.Drawing.Point(14, 34);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(273, 97);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Settings";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 133);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "By Professional";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 150);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ResetIP);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Main";
            this.Text = "Router Toolbox";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ResetIP;
        private System.Windows.Forms.Label HostLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Host;
        private System.Windows.Forms.TextBox Username;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
    }
}

