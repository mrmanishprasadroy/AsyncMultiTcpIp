namespace AsyncClient
{
    partial class Client
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
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbPort = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.richTextBoxmsg = new System.Windows.Forms.RichTextBox();
            this.btSendmsg = new System.Windows.Forms.Button();
            this.buttonConn = new System.Windows.Forms.Button();
            this.buttondisconn = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxServerIP = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.labelState = new System.Windows.Forms.Label();
            this.btclose = new System.Windows.Forms.Button();
            this.rTbrcvmsg = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(2, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(221, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Return message from Server";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tbPort);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.richTextBoxmsg);
            this.groupBox1.Controls.Add(this.btSendmsg);
            this.groupBox1.Controls.Add(this.buttonConn);
            this.groupBox1.Controls.Add(this.buttondisconn);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.textBoxServerIP);
            this.groupBox1.Location = new System.Drawing.Point(6, 314);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(687, 186);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Setting area";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(6, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 20);
            this.label3.TabIndex = 21;
            this.label3.Text = "Message To Server";
            // 
            // tbPort
            // 
            this.tbPort.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tbPort.Location = new System.Drawing.Point(364, 27);
            this.tbPort.Name = "tbPort";
            this.tbPort.Size = new System.Drawing.Size(101, 29);
            this.tbPort.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(289, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 20);
            this.label1.TabIndex = 19;
            this.label1.Text = "Set Port";
            // 
            // richTextBoxmsg
            // 
            this.richTextBoxmsg.Location = new System.Drawing.Point(7, 82);
            this.richTextBoxmsg.Name = "richTextBoxmsg";
            this.richTextBoxmsg.Size = new System.Drawing.Size(458, 98);
            this.richTextBoxmsg.TabIndex = 18;
            this.richTextBoxmsg.Text = "";
            // 
            // btSendmsg
            // 
            this.btSendmsg.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btSendmsg.Location = new System.Drawing.Point(471, 143);
            this.btSendmsg.Name = "btSendmsg";
            this.btSendmsg.Size = new System.Drawing.Size(208, 37);
            this.btSendmsg.TabIndex = 17;
            this.btSendmsg.Text = "send";
            this.btSendmsg.UseVisualStyleBackColor = true;
            this.btSendmsg.Click += new System.EventHandler(this.btSendmsg_Click);
            // 
            // buttonConn
            // 
            this.buttonConn.BackColor = System.Drawing.Color.Blue;
            this.buttonConn.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.buttonConn.ForeColor = System.Drawing.Color.Red;
            this.buttonConn.Location = new System.Drawing.Point(471, 19);
            this.buttonConn.Name = "buttonConn";
            this.buttonConn.Size = new System.Drawing.Size(208, 57);
            this.buttonConn.TabIndex = 3;
            this.buttonConn.Text = "Connect";
            this.buttonConn.UseVisualStyleBackColor = false;
            this.buttonConn.Click += new System.EventHandler(this.buttonConn_Click);
            // 
            // buttondisconn
            // 
            this.buttondisconn.BackColor = System.Drawing.Color.Red;
            this.buttondisconn.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.buttondisconn.Location = new System.Drawing.Point(471, 82);
            this.buttondisconn.Name = "buttondisconn";
            this.buttondisconn.Size = new System.Drawing.Size(210, 55);
            this.buttondisconn.TabIndex = 10;
            this.buttondisconn.Text = "Dissconect";
            this.buttondisconn.UseVisualStyleBackColor = false;
            this.buttondisconn.Click += new System.EventHandler(this.buttondisconn_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label6.Location = new System.Drawing.Point(6, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 20);
            this.label6.TabIndex = 14;
            this.label6.Text = "Set host IP";
            // 
            // textBoxServerIP
            // 
            this.textBoxServerIP.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBoxServerIP.Location = new System.Drawing.Point(110, 27);
            this.textBoxServerIP.Name = "textBoxServerIP";
            this.textBoxServerIP.Size = new System.Drawing.Size(173, 29);
            this.textBoxServerIP.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.Location = new System.Drawing.Point(2, 510);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(162, 20);
            this.label5.TabIndex = 17;
            this.label5.Text = "Connection status：";
            // 
            // labelState
            // 
            this.labelState.AutoSize = true;
            this.labelState.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labelState.ForeColor = System.Drawing.Color.Red;
            this.labelState.Location = new System.Drawing.Point(219, 510);
            this.labelState.Name = "labelState";
            this.labelState.Size = new System.Drawing.Size(122, 20);
            this.labelState.TabIndex = 18;
            this.labelState.Text = "Not connected";
            // 
            // btclose
            // 
            this.btclose.Location = new System.Drawing.Point(477, 506);
            this.btclose.Name = "btclose";
            this.btclose.Size = new System.Drawing.Size(208, 24);
            this.btclose.TabIndex = 19;
            this.btclose.Text = "close";
            this.btclose.UseVisualStyleBackColor = true;
            this.btclose.Click += new System.EventHandler(this.btclose_Click);
            // 
            // rTbrcvmsg
            // 
            this.rTbrcvmsg.FormattingEnabled = true;
            this.rTbrcvmsg.Location = new System.Drawing.Point(6, 32);
            this.rTbrcvmsg.Name = "rTbrcvmsg";
            this.rTbrcvmsg.Size = new System.Drawing.Size(687, 277);
            this.rTbrcvmsg.TabIndex = 20;
            // 
            // Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(697, 539);
            this.Controls.Add(this.rTbrcvmsg);
            this.Controls.Add(this.btclose);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.labelState);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Client";
            this.Text = "AsyncClient";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonConn;
        private System.Windows.Forms.Button buttondisconn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxServerIP;
        private System.Windows.Forms.Button btSendmsg;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelState;
        private System.Windows.Forms.TextBox tbPort;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox richTextBoxmsg;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btclose;
        private System.Windows.Forms.ListBox rTbrcvmsg;
    }
}

