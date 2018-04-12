namespace TcpApp1
{
    partial class Form1
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
            this.start = new System.Windows.Forms.Button();
            this.stop = new System.Windows.Forms.Button();
            this.portNumber = new System.Windows.Forms.TextBox();
            this.localAddress = new System.Windows.Forms.TextBox();
            this.fileRepository = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.FilePath = new System.Windows.Forms.Label();
            this.txtConsole = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // start
            // 
            this.start.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.start.Location = new System.Drawing.Point(223, 125);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(143, 59);
            this.start.TabIndex = 3;
            this.start.Text = "Start Server";
            this.start.UseVisualStyleBackColor = true;
            this.start.Click += new System.EventHandler(this.StartServer);
            // 
            // stop
            // 
            this.stop.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.stop.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.stop.Location = new System.Drawing.Point(223, 385);
            this.stop.Name = "stop";
            this.stop.Size = new System.Drawing.Size(143, 59);
            this.stop.TabIndex = 4;
            this.stop.Text = "Stop Server";
            this.stop.UseVisualStyleBackColor = true;
            this.stop.Click += new System.EventHandler(this.StopServer);
            // 
            // portNumber
            // 
            this.portNumber.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.portNumber.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.portNumber.Location = new System.Drawing.Point(42, 68);
            this.portNumber.MaximumSize = new System.Drawing.Size(300, 200);
            this.portNumber.Name = "portNumber";
            this.portNumber.Size = new System.Drawing.Size(125, 20);
            this.portNumber.TabIndex = 0;
            this.portNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // localAddress
            // 
            this.localAddress.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.localAddress.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.localAddress.Location = new System.Drawing.Point(232, 68);
            this.localAddress.Name = "localAddress";
            this.localAddress.Size = new System.Drawing.Size(125, 20);
            this.localAddress.TabIndex = 1;
            this.localAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // fileRepository
            // 
            this.fileRepository.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.fileRepository.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.fileRepository.Location = new System.Drawing.Point(419, 68);
            this.fileRepository.Name = "fileRepository";
            this.fileRepository.Size = new System.Drawing.Size(125, 20);
            this.fileRepository.TabIndex = 2;
            this.fileRepository.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(74, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "&Port Number";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(271, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "&IPAddress";
            // 
            // FilePath
            // 
            this.FilePath.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.FilePath.AutoSize = true;
            this.FilePath.Location = new System.Drawing.Point(464, 52);
            this.FilePath.Name = "FilePath";
            this.FilePath.Size = new System.Drawing.Size(48, 13);
            this.FilePath.TabIndex = 3;
            this.FilePath.Text = "&File Path";
            // 
            // txtConsole
            // 
            this.txtConsole.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtConsole.Location = new System.Drawing.Point(77, 207);
            this.txtConsole.Multiline = true;
            this.txtConsole.Name = "txtConsole";
            this.txtConsole.Size = new System.Drawing.Size(435, 134);
            this.txtConsole.TabIndex = 5;
            // 
            // Form1
            // 
            this.AcceptButton = this.start;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.stop;
            this.ClientSize = new System.Drawing.Size(584, 461);
            this.Controls.Add(this.txtConsole);
            this.Controls.Add(this.FilePath);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.fileRepository);
            this.Controls.Add(this.localAddress);
            this.Controls.Add(this.portNumber);
            this.Controls.Add(this.stop);
            this.Controls.Add(this.start);
            this.MaximumSize = new System.Drawing.Size(1366, 768);
            this.MinimumSize = new System.Drawing.Size(600, 500);
            this.Name = "Form1";
            this.Text = "TcpServer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.DoubleClick += new System.EventHandler(this.StartServer);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button start;
        private System.Windows.Forms.Button stop;
        private System.Windows.Forms.TextBox portNumber;
        private System.Windows.Forms.TextBox localAddress;
        private System.Windows.Forms.TextBox fileRepository;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label FilePath;
        private System.Windows.Forms.TextBox txtConsole;
    }
}

