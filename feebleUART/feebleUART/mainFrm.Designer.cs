namespace feebleUART
{
    partial class mainFrm
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
            this.comboBox_ports = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button_open = new System.Windows.Forms.Button();
            this.textBox_baudRate = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox_parityBit = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox_stopBits = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_dataBits = new System.Windows.Forms.TextBox();
            this.comboBox_handshake = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.checkBox_RtsEnable = new System.Windows.Forms.CheckBox();
            this.checkBox_DtrEnable = new System.Windows.Forms.CheckBox();
            this.textBox_sending = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.button_send = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox_recevied = new System.Windows.Forms.TextBox();
            this.checkBox_insertNewLine = new System.Windows.Forms.CheckBox();
            this.checkBox_insertTimeStamp = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // comboBox_ports
            // 
            this.comboBox_ports.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox_ports.FormattingEnabled = true;
            this.comboBox_ports.Location = new System.Drawing.Point(47, 12);
            this.comboBox_ports.Name = "comboBox_ports";
            this.comboBox_ports.Size = new System.Drawing.Size(267, 21);
            this.comboBox_ports.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Port:";
            // 
            // button_open
            // 
            this.button_open.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_open.Location = new System.Drawing.Point(563, 119);
            this.button_open.Name = "button_open";
            this.button_open.Size = new System.Drawing.Size(75, 23);
            this.button_open.TabIndex = 2;
            this.button_open.Text = "Open";
            this.button_open.UseVisualStyleBackColor = true;
            this.button_open.Click += new System.EventHandler(this.button_open_Click);
            // 
            // textBox_baudRate
            // 
            this.textBox_baudRate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_baudRate.Location = new System.Drawing.Point(382, 12);
            this.textBox_baudRate.Name = "textBox_baudRate";
            this.textBox_baudRate.Size = new System.Drawing.Size(146, 20);
            this.textBox_baudRate.TabIndex = 3;
            this.textBox_baudRate.Text = "9600";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(320, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Baud rate:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Parity bit:";
            // 
            // comboBox_parityBit
            // 
            this.comboBox_parityBit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox_parityBit.FormattingEnabled = true;
            this.comboBox_parityBit.Items.AddRange(new object[] {
            "None (No parity check occurs)",
            "Odd (Sets the parity bit so that the count of bits set is an odd number)",
            "Even (Sets the parity bit so that the count of bits set is an even number)",
            "Mark (Leaves the parity bit set to 1)",
            "Space (Leaves the parity bit set to 0)"});
            this.comboBox_parityBit.Location = new System.Drawing.Point(83, 38);
            this.comboBox_parityBit.Name = "comboBox_parityBit";
            this.comboBox_parityBit.Size = new System.Drawing.Size(555, 21);
            this.comboBox_parityBit.TabIndex = 6;
            this.comboBox_parityBit.Text = "None (No parity check occurs)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Stop bits:";
            // 
            // comboBox_stopBits
            // 
            this.comboBox_stopBits.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox_stopBits.FormattingEnabled = true;
            this.comboBox_stopBits.Items.AddRange(new object[] {
            "One (One stop bit is used)",
            "Two (Two stop bits are used)",
            "OnePointFive (1.5 stop bits are used)"});
            this.comboBox_stopBits.Location = new System.Drawing.Point(83, 65);
            this.comboBox_stopBits.Name = "comboBox_stopBits";
            this.comboBox_stopBits.Size = new System.Drawing.Size(555, 21);
            this.comboBox_stopBits.TabIndex = 8;
            this.comboBox_stopBits.Text = "One (One stop bit is used)";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(534, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Data bits:";
            // 
            // textBox_dataBits
            // 
            this.textBox_dataBits.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_dataBits.Location = new System.Drawing.Point(592, 12);
            this.textBox_dataBits.Name = "textBox_dataBits";
            this.textBox_dataBits.Size = new System.Drawing.Size(46, 20);
            this.textBox_dataBits.TabIndex = 9;
            this.textBox_dataBits.Text = "8";
            // 
            // comboBox_handshake
            // 
            this.comboBox_handshake.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox_handshake.FormattingEnabled = true;
            this.comboBox_handshake.Items.AddRange(new object[] {
            "None (No control is used for the handshake)",
            "XOnXOff (The XON/XOFF software control protocol is used, instead of RTS and CTS)",
            "RequestToSend (Request-to-Send (RTS) hardware flow control is used)",
            "RequestToSendXOnXOff (Both the RTS hardware control and the XON/XOFF software con" +
                "trols are used)"});
            this.comboBox_handshake.Location = new System.Drawing.Point(83, 92);
            this.comboBox_handshake.Name = "comboBox_handshake";
            this.comboBox_handshake.Size = new System.Drawing.Size(555, 21);
            this.comboBox_handshake.TabIndex = 11;
            this.comboBox_handshake.Text = "None (No control is used for the handshake)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 95);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Handshake:";
            // 
            // checkBox_RtsEnable
            // 
            this.checkBox_RtsEnable.AutoSize = true;
            this.checkBox_RtsEnable.Checked = true;
            this.checkBox_RtsEnable.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_RtsEnable.Location = new System.Drawing.Point(83, 123);
            this.checkBox_RtsEnable.Name = "checkBox_RtsEnable";
            this.checkBox_RtsEnable.Size = new System.Drawing.Size(77, 17);
            this.checkBox_RtsEnable.TabIndex = 13;
            this.checkBox_RtsEnable.Text = "Rts enable";
            this.checkBox_RtsEnable.UseVisualStyleBackColor = true;
            // 
            // checkBox_DtrEnable
            // 
            this.checkBox_DtrEnable.AutoSize = true;
            this.checkBox_DtrEnable.Location = new System.Drawing.Point(215, 123);
            this.checkBox_DtrEnable.Name = "checkBox_DtrEnable";
            this.checkBox_DtrEnable.Size = new System.Drawing.Size(75, 17);
            this.checkBox_DtrEnable.TabIndex = 14;
            this.checkBox_DtrEnable.Text = "Dtr enable";
            this.checkBox_DtrEnable.UseVisualStyleBackColor = true;
            // 
            // textBox_sending
            // 
            this.textBox_sending.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_sending.Location = new System.Drawing.Point(15, 167);
            this.textBox_sending.Multiline = true;
            this.textBox_sending.Name = "textBox_sending";
            this.textBox_sending.Size = new System.Drawing.Size(622, 80);
            this.textBox_sending.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 151);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Data to send:";
            // 
            // button_send
            // 
            this.button_send.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_send.Location = new System.Drawing.Point(563, 253);
            this.button_send.Name = "button_send";
            this.button_send.Size = new System.Drawing.Size(75, 23);
            this.button_send.TabIndex = 17;
            this.button_send.Text = "Send";
            this.button_send.UseVisualStyleBackColor = true;
            this.button_send.Click += new System.EventHandler(this.button_send_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 266);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(124, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Data has been received:";
            // 
            // textBox_recevied
            // 
            this.textBox_recevied.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_recevied.Location = new System.Drawing.Point(15, 282);
            this.textBox_recevied.Multiline = true;
            this.textBox_recevied.Name = "textBox_recevied";
            this.textBox_recevied.Size = new System.Drawing.Size(623, 224);
            this.textBox_recevied.TabIndex = 18;
            // 
            // checkBox_insertNewLine
            // 
            this.checkBox_insertNewLine.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.checkBox_insertNewLine.AutoSize = true;
            this.checkBox_insertNewLine.Checked = true;
            this.checkBox_insertNewLine.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_insertNewLine.Location = new System.Drawing.Point(15, 512);
            this.checkBox_insertNewLine.Name = "checkBox_insertNewLine";
            this.checkBox_insertNewLine.Size = new System.Drawing.Size(94, 17);
            this.checkBox_insertNewLine.TabIndex = 20;
            this.checkBox_insertNewLine.Text = "Insert new line";
            this.checkBox_insertNewLine.UseVisualStyleBackColor = true;
            // 
            // checkBox_insertTimeStamp
            // 
            this.checkBox_insertTimeStamp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.checkBox_insertTimeStamp.AutoSize = true;
            this.checkBox_insertTimeStamp.Checked = true;
            this.checkBox_insertTimeStamp.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_insertTimeStamp.Location = new System.Drawing.Point(115, 512);
            this.checkBox_insertTimeStamp.Name = "checkBox_insertTimeStamp";
            this.checkBox_insertTimeStamp.Size = new System.Drawing.Size(136, 17);
            this.checkBox_insertTimeStamp.TabIndex = 21;
            this.checkBox_insertTimeStamp.Text = "Insert time stamp prefix ";
            this.checkBox_insertTimeStamp.UseVisualStyleBackColor = true;
            // 
            // mainFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 541);
            this.Controls.Add(this.checkBox_insertTimeStamp);
            this.Controls.Add(this.checkBox_insertNewLine);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBox_recevied);
            this.Controls.Add(this.button_send);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox_sending);
            this.Controls.Add(this.checkBox_DtrEnable);
            this.Controls.Add(this.checkBox_RtsEnable);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboBox_handshake);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox_dataBits);
            this.Controls.Add(this.comboBox_stopBits);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBox_parityBit);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_baudRate);
            this.Controls.Add(this.button_open);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox_ports);
            this.Name = "mainFrm";
            this.Text = "feebleUART";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox_ports;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_open;
        private System.Windows.Forms.TextBox textBox_baudRate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox_parityBit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox_stopBits;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_dataBits;
        private System.Windows.Forms.ComboBox comboBox_handshake;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox checkBox_RtsEnable;
        private System.Windows.Forms.CheckBox checkBox_DtrEnable;
        private System.Windows.Forms.TextBox textBox_sending;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button_send;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox_recevied;
        private System.Windows.Forms.CheckBox checkBox_insertNewLine;
        private System.Windows.Forms.CheckBox checkBox_insertTimeStamp;
    }
}

