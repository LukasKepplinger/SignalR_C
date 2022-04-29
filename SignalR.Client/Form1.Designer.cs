namespace SignalR.Client
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btCreateConnection = new System.Windows.Forms.Button();
            this.btSend = new System.Windows.Forms.Button();
            this.tbText = new System.Windows.Forms.TextBox();
            this.lbResponse = new System.Windows.Forms.ListBox();
            this.tbPin = new System.Windows.Forms.TextBox();
            this.btSetPin = new System.Windows.Forms.Button();
            this.btWritePin = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btHighOrLow = new System.Windows.Forms.Button();
            this.btInOrOutput = new System.Windows.Forms.Button();
            this.btConnect = new System.Windows.Forms.Button();
            this.btCreateIoConnection = new System.Windows.Forms.Button();
            this.btConnectIo = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnCreateCorn = new System.Windows.Forms.Button();
            this.btnConnectCorn = new System.Windows.Forms.Button();
            this.btnSendCorn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btCreateConnection
            // 
            this.btCreateConnection.Location = new System.Drawing.Point(27, 36);
            this.btCreateConnection.Name = "btCreateConnection";
            this.btCreateConnection.Size = new System.Drawing.Size(131, 23);
            this.btCreateConnection.TabIndex = 0;
            this.btCreateConnection.Text = "Create Connection";
            this.btCreateConnection.UseVisualStyleBackColor = true;
            this.btCreateConnection.Click += new System.EventHandler(this.btCreateConnection_Click);
            // 
            // btSend
            // 
            this.btSend.Location = new System.Drawing.Point(27, 183);
            this.btSend.Name = "btSend";
            this.btSend.Size = new System.Drawing.Size(131, 23);
            this.btSend.TabIndex = 1;
            this.btSend.Text = "Send";
            this.btSend.UseVisualStyleBackColor = true;
            this.btSend.Click += new System.EventHandler(this.btSend_Click);
            // 
            // tbText
            // 
            this.tbText.Location = new System.Drawing.Point(27, 154);
            this.tbText.Name = "tbText";
            this.tbText.Size = new System.Drawing.Size(131, 23);
            this.tbText.TabIndex = 2;
            // 
            // lbResponse
            // 
            this.lbResponse.FormattingEnabled = true;
            this.lbResponse.ItemHeight = 15;
            this.lbResponse.Location = new System.Drawing.Point(30, 278);
            this.lbResponse.Name = "lbResponse";
            this.lbResponse.Size = new System.Drawing.Size(485, 274);
            this.lbResponse.TabIndex = 3;
            this.lbResponse.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lbResponse_KeyDown);
            this.lbResponse.KeyUp += new System.Windows.Forms.KeyEventHandler(this.lbResponse_KeyUp);
            // 
            // tbPin
            // 
            this.tbPin.Location = new System.Drawing.Point(103, 125);
            this.tbPin.Name = "tbPin";
            this.tbPin.Size = new System.Drawing.Size(131, 23);
            this.tbPin.TabIndex = 5;
            // 
            // btSetPin
            // 
            this.btSetPin.Location = new System.Drawing.Point(103, 154);
            this.btSetPin.Name = "btSetPin";
            this.btSetPin.Size = new System.Drawing.Size(131, 23);
            this.btSetPin.TabIndex = 6;
            this.btSetPin.Text = "Pin setzen";
            this.btSetPin.UseVisualStyleBackColor = true;
            this.btSetPin.Click += new System.EventHandler(this.btSetPin_Click);
            // 
            // btWritePin
            // 
            this.btWritePin.Location = new System.Drawing.Point(103, 183);
            this.btWritePin.Name = "btWritePin";
            this.btWritePin.Size = new System.Drawing.Size(131, 23);
            this.btWritePin.TabIndex = 7;
            this.btWritePin.Text = "Pin schreiben";
            this.btWritePin.UseVisualStyleBackColor = true;
            this.btWritePin.Click += new System.EventHandler(this.btWritePin_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "Pin:";
            // 
            // btHighOrLow
            // 
            this.btHighOrLow.Location = new System.Drawing.Point(22, 183);
            this.btHighOrLow.Name = "btHighOrLow";
            this.btHighOrLow.Size = new System.Drawing.Size(75, 23);
            this.btHighOrLow.TabIndex = 14;
            this.btHighOrLow.Text = "High";
            this.btHighOrLow.UseVisualStyleBackColor = true;
            this.btHighOrLow.Click += new System.EventHandler(this.btHighOrLow_Click);
            // 
            // btInOrOutput
            // 
            this.btInOrOutput.Location = new System.Drawing.Point(22, 154);
            this.btInOrOutput.Name = "btInOrOutput";
            this.btInOrOutput.Size = new System.Drawing.Size(75, 23);
            this.btInOrOutput.TabIndex = 15;
            this.btInOrOutput.Text = "Output";
            this.btInOrOutput.UseVisualStyleBackColor = true;
            this.btInOrOutput.Click += new System.EventHandler(this.btInOrOutput_Click);
            // 
            // btConnect
            // 
            this.btConnect.Location = new System.Drawing.Point(27, 65);
            this.btConnect.Name = "btConnect";
            this.btConnect.Size = new System.Drawing.Size(131, 23);
            this.btConnect.TabIndex = 17;
            this.btConnect.Text = "Connect";
            this.btConnect.UseVisualStyleBackColor = true;
            this.btConnect.Click += new System.EventHandler(this.btConnect_Click);
            // 
            // btCreateIoConnection
            // 
            this.btCreateIoConnection.Location = new System.Drawing.Point(103, 36);
            this.btCreateIoConnection.Name = "btCreateIoConnection";
            this.btCreateIoConnection.Size = new System.Drawing.Size(131, 23);
            this.btCreateIoConnection.TabIndex = 18;
            this.btCreateIoConnection.Text = "Create Connection";
            this.btCreateIoConnection.UseVisualStyleBackColor = true;
            this.btCreateIoConnection.Click += new System.EventHandler(this.btCreateIoConnection_Click);
            // 
            // btConnectIo
            // 
            this.btConnectIo.Location = new System.Drawing.Point(103, 65);
            this.btConnectIo.Name = "btConnectIo";
            this.btConnectIo.Size = new System.Drawing.Size(131, 23);
            this.btConnectIo.TabIndex = 19;
            this.btConnectIo.Text = "Connect";
            this.btConnectIo.UseVisualStyleBackColor = true;
            this.btConnectIo.Click += new System.EventHandler(this.btConnectIo_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btConnectIo);
            this.groupBox1.Controls.Add(this.btCreateIoConnection);
            this.groupBox1.Controls.Add(this.btInOrOutput);
            this.groupBox1.Controls.Add(this.btWritePin);
            this.groupBox1.Controls.Add(this.btHighOrLow);
            this.groupBox1.Controls.Add(this.tbPin);
            this.groupBox1.Controls.Add(this.btSetPin);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(251, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(264, 241);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "IO-Controller";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btCreateConnection);
            this.groupBox2.Controls.Add(this.btConnect);
            this.groupBox2.Controls.Add(this.btSend);
            this.groupBox2.Controls.Add(this.tbText);
            this.groupBox2.Location = new System.Drawing.Point(30, 31);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(191, 241);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Message-Controller";
            // 
            // btnCreateCorn
            // 
            this.btnCreateCorn.Location = new System.Drawing.Point(547, 67);
            this.btnCreateCorn.Name = "btnCreateCorn";
            this.btnCreateCorn.Size = new System.Drawing.Size(131, 23);
            this.btnCreateCorn.TabIndex = 22;
            this.btnCreateCorn.Text = "Create Cornnection";
            this.btnCreateCorn.UseVisualStyleBackColor = true;
            // 
            // btnConnectCorn
            // 
            this.btnConnectCorn.Location = new System.Drawing.Point(547, 96);
            this.btnConnectCorn.Name = "btnConnectCorn";
            this.btnConnectCorn.Size = new System.Drawing.Size(131, 23);
            this.btnConnectCorn.TabIndex = 23;
            this.btnConnectCorn.Text = "Cornnect";
            this.btnConnectCorn.UseVisualStyleBackColor = true;
            // 
            // btnSendCorn
            // 
            this.btnSendCorn.Location = new System.Drawing.Point(547, 125);
            this.btnSendCorn.Name = "btnSendCorn";
            this.btnSendCorn.Size = new System.Drawing.Size(131, 23);
            this.btnSendCorn.TabIndex = 24;
            this.btnSendCorn.Text = "Send Corn";
            this.btnSendCorn.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(936, 619);
            this.Controls.Add(this.btnSendCorn);
            this.Controls.Add(this.btnConnectCorn);
            this.Controls.Add(this.btnCreateCorn);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbResponse);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Button btCreateConnection;
        private Button btSend;
        private TextBox tbText;
        private ListBox lbResponse;
        private TextBox tbPin;
        private Button btSetPin;
        private Button btWritePin;
        private Label label1;
        private Button btConnectIo;
        private Button btHighOrLow;
        private Button btInOrOutput;
        private Button btConnect;
        private Button btCreateIoConnection;
        private Button btConnectId;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Button btnCreateCorn;
        private Button btnConnectCorn;
        private Button btnSendCorn;
    }
}