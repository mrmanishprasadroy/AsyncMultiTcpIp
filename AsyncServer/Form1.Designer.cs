namespace AsyncServer
{
    partial class Server
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btcloseform = new System.Windows.Forms.Button();
            this.lbbroadcast = new System.Windows.Forms.Label();
            this.textBoxPort = new System.Windows.Forms.TextBox();
            this.lbport = new System.Windows.Forms.Label();
            this.richTextBoxSendMsg = new System.Windows.Forms.RichTextBox();
            this.lbipAddress = new System.Windows.Forms.Label();
            this.textBoxIP = new System.Windows.Forms.TextBox();
            this.btSend = new System.Windows.Forms.Button();
            this.btClose = new System.Windows.Forms.Button();
            this.btStart = new System.Windows.Forms.Button();
            this.tbstatus = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rtbRcvMessage = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rtbRcvMessage);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tbstatus);
            this.groupBox1.Controls.Add(this.btcloseform);
            this.groupBox1.Controls.Add(this.lbbroadcast);
            this.groupBox1.Controls.Add(this.textBoxPort);
            this.groupBox1.Controls.Add(this.lbport);
            this.groupBox1.Controls.Add(this.richTextBoxSendMsg);
            this.groupBox1.Controls.Add(this.lbipAddress);
            this.groupBox1.Controls.Add(this.textBoxIP);
            this.groupBox1.Controls.Add(this.btSend);
            this.groupBox1.Controls.Add(this.btClose);
            this.groupBox1.Controls.Add(this.btStart);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(697, 539);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Server Box";
            // 
            // btcloseform
            // 
            this.btcloseform.Location = new System.Drawing.Point(596, 482);
            this.btcloseform.Name = "btcloseform";
            this.btcloseform.Size = new System.Drawing.Size(95, 51);
            this.btcloseform.TabIndex = 10;
            this.btcloseform.Text = "Close";
            this.btcloseform.UseVisualStyleBackColor = true;
            this.btcloseform.Click += new System.EventHandler(this.btcloseform_Click);
            // 
            // lbbroadcast
            // 
            this.lbbroadcast.AutoSize = true;
            this.lbbroadcast.Location = new System.Drawing.Point(12, 194);
            this.lbbroadcast.Name = "lbbroadcast";
            this.lbbroadcast.Size = new System.Drawing.Size(162, 13);
            this.lbbroadcast.TabIndex = 9;
            this.lbbroadcast.Text = "Broadcast Message to all clients ";
            // 
            // textBoxPort
            // 
            this.textBoxPort.Location = new System.Drawing.Point(295, 456);
            this.textBoxPort.Name = "textBoxPort";
            this.textBoxPort.Size = new System.Drawing.Size(109, 20);
            this.textBoxPort.TabIndex = 8;
            // 
            // lbport
            // 
            this.lbport.AutoSize = true;
            this.lbport.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbport.Location = new System.Drawing.Point(263, 460);
            this.lbport.Name = "lbport";
            this.lbport.Size = new System.Drawing.Size(26, 13);
            this.lbport.TabIndex = 7;
            this.lbport.Text = "Port";
            // 
            // richTextBoxSendMsg
            // 
            this.richTextBoxSendMsg.Location = new System.Drawing.Point(6, 210);
            this.richTextBoxSendMsg.Name = "richTextBoxSendMsg";
            this.richTextBoxSendMsg.Size = new System.Drawing.Size(685, 237);
            this.richTextBoxSendMsg.TabIndex = 6;
            this.richTextBoxSendMsg.Text = "";
            // 
            // lbipAddress
            // 
            this.lbipAddress.AutoSize = true;
            this.lbipAddress.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbipAddress.Location = new System.Drawing.Point(6, 459);
            this.lbipAddress.Name = "lbipAddress";
            this.lbipAddress.Size = new System.Drawing.Size(57, 13);
            this.lbipAddress.TabIndex = 5;
            this.lbipAddress.Text = "Ip Address";
            // 
            // textBoxIP
            // 
            this.textBoxIP.Location = new System.Drawing.Point(69, 453);
            this.textBoxIP.Name = "textBoxIP";
            this.textBoxIP.ReadOnly = true;
            this.textBoxIP.Size = new System.Drawing.Size(133, 20);
            this.textBoxIP.TabIndex = 4;
            // 
            // btSend
            // 
            this.btSend.Location = new System.Drawing.Point(6, 482);
            this.btSend.Name = "btSend";
            this.btSend.Size = new System.Drawing.Size(95, 51);
            this.btSend.TabIndex = 3;
            this.btSend.Text = "Send Message";
            this.btSend.UseVisualStyleBackColor = true;
            this.btSend.Click += new System.EventHandler(this.btSend_Click);
            // 
            // btClose
            // 
            this.btClose.Location = new System.Drawing.Point(309, 482);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(95, 51);
            this.btClose.TabIndex = 1;
            this.btClose.Text = "Stop Listening";
            this.btClose.UseVisualStyleBackColor = true;
            this.btClose.Click += new System.EventHandler(this.btClose_Click);
            // 
            // btStart
            // 
            this.btStart.Location = new System.Drawing.Point(194, 482);
            this.btStart.Name = "btStart";
            this.btStart.Size = new System.Drawing.Size(95, 51);
            this.btStart.TabIndex = 0;
            this.btStart.Text = "Start Listening";
            this.btStart.UseVisualStyleBackColor = true;
            this.btStart.Click += new System.EventHandler(this.btStart_Click);
            // 
            // tbstatus
            // 
            this.tbstatus.Location = new System.Drawing.Point(286, 191);
            this.tbstatus.Name = "tbstatus";
            this.tbstatus.ReadOnly = true;
            this.tbstatus.Size = new System.Drawing.Size(378, 20);
            this.tbstatus.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(216, 194);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Status";
            // 
            // rtbRcvMessage
            // 
            this.rtbRcvMessage.FormattingEnabled = true;
            this.rtbRcvMessage.Location = new System.Drawing.Point(4, 12);
            this.rtbRcvMessage.Name = "rtbRcvMessage";
            this.rtbRcvMessage.Size = new System.Drawing.Size(687, 173);
            this.rtbRcvMessage.TabIndex = 14;
            // 
            // Server
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(697, 539);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Server";
            this.Text = "AsyncServer";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btClose;
        private System.Windows.Forms.Button btStart;
        private System.Windows.Forms.TextBox textBoxPort;
        private System.Windows.Forms.Label lbport;
        private System.Windows.Forms.RichTextBox richTextBoxSendMsg;
        private System.Windows.Forms.Label lbipAddress;
        private System.Windows.Forms.TextBox textBoxIP;
        private System.Windows.Forms.Button btSend;
        private System.Windows.Forms.Label lbbroadcast;
        private System.Windows.Forms.Button btcloseform;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbstatus;
        private System.Windows.Forms.ListBox rtbRcvMessage;
    }
}

