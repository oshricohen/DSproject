namespace DSproject
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
            this.btnConnect = new System.Windows.Forms.Button();
            this.tbPort = new System.Windows.Forms.TextBox();
            this.lbPort = new System.Windows.Forms.Label();
            this.btnSetting = new System.Windows.Forms.Button();
            this.tbMessege = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.tbChatBox = new System.Windows.Forms.TextBox();
            this.btnfileCh = new System.Windows.Forms.Button();
            this.btnSendFile = new System.Windows.Forms.Button();
            this.btnSendMess = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(183, 358);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(119, 23);
            this.btnConnect.TabIndex = 0;
            this.btnConnect.Text = "connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            // 
            // tbPort
            // 
            this.tbPort.Location = new System.Drawing.Point(77, 360);
            this.tbPort.Name = "tbPort";
            this.tbPort.Size = new System.Drawing.Size(100, 20);
            this.tbPort.TabIndex = 1;
            // 
            // lbPort
            // 
            this.lbPort.AutoSize = true;
            this.lbPort.Font = new System.Drawing.Font("Mistral", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPort.Location = new System.Drawing.Point(26, 360);
            this.lbPort.Name = "lbPort";
            this.lbPort.Size = new System.Drawing.Size(45, 26);
            this.lbPort.TabIndex = 2;
            this.lbPort.Text = "Port";
            // 
            // btnSetting
            // 
            this.btnSetting.Location = new System.Drawing.Point(410, 356);
            this.btnSetting.Name = "btnSetting";
            this.btnSetting.Size = new System.Drawing.Size(107, 23);
            this.btnSetting.TabIndex = 3;
            this.btnSetting.Text = "setting";
            this.btnSetting.UseVisualStyleBackColor = true;
            this.btnSetting.Click += new System.EventHandler(this.btnSetting_Click);
            // 
            // tbMessege
            // 
            this.tbMessege.Location = new System.Drawing.Point(31, 315);
            this.tbMessege.Name = "tbMessege";
            this.tbMessege.Size = new System.Drawing.Size(486, 20);
            this.tbMessege.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(31, 39);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(258, 20);
            this.textBox2.TabIndex = 5;
            // 
            // tbChatBox
            // 
            this.tbChatBox.Location = new System.Drawing.Point(31, 74);
            this.tbChatBox.Multiline = true;
            this.tbChatBox.Name = "tbChatBox";
            this.tbChatBox.Size = new System.Drawing.Size(588, 235);
            this.tbChatBox.TabIndex = 6;
            // 
            // btnfileCh
            // 
            this.btnfileCh.Location = new System.Drawing.Point(323, 39);
            this.btnfileCh.Name = "btnfileCh";
            this.btnfileCh.Size = new System.Drawing.Size(116, 23);
            this.btnfileCh.TabIndex = 7;
            this.btnfileCh.Text = "open file";
            this.btnfileCh.UseVisualStyleBackColor = true;
            // 
            // btnSendFile
            // 
            this.btnSendFile.Location = new System.Drawing.Point(475, 39);
            this.btnSendFile.Name = "btnSendFile";
            this.btnSendFile.Size = new System.Drawing.Size(116, 20);
            this.btnSendFile.TabIndex = 8;
            this.btnSendFile.Text = "send file";
            this.btnSendFile.UseVisualStyleBackColor = true;
            // 
            // btnSendMess
            // 
            this.btnSendMess.Location = new System.Drawing.Point(536, 315);
            this.btnSendMess.Name = "btnSendMess";
            this.btnSendMess.Size = new System.Drawing.Size(83, 20);
            this.btnSendMess.TabIndex = 9;
            this.btnSendMess.Text = "send";
            this.btnSendMess.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 392);
            this.Controls.Add(this.btnSendMess);
            this.Controls.Add(this.btnSendFile);
            this.Controls.Add(this.btnfileCh);
            this.Controls.Add(this.tbChatBox);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.tbMessege);
            this.Controls.Add(this.btnSetting);
            this.Controls.Add(this.lbPort);
            this.Controls.Add(this.tbPort);
            this.Controls.Add(this.btnConnect);
            this.Name = "Form1";
            this.Text = "DSproject";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.TextBox tbPort;
        private System.Windows.Forms.Label lbPort;
        private System.Windows.Forms.Button btnSetting;
        private System.Windows.Forms.TextBox tbMessege;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox tbChatBox;
        private System.Windows.Forms.Button btnfileCh;
        private System.Windows.Forms.Button btnSendFile;
        private System.Windows.Forms.Button btnSendMess;
    }
}

