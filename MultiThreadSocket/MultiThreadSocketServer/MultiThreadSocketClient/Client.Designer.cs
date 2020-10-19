namespace MultiThreadSocketClient
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtChat = new System.Windows.Forms.RichTextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(137, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(179, 13);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Multithreaded Client Socket Program";
            // 
            // txtChat
            // 
            this.txtChat.Location = new System.Drawing.Point(12, 29);
            this.txtChat.Name = "txtChat";
            this.txtChat.Size = new System.Drawing.Size(453, 204);
            this.txtChat.TabIndex = 1;
            this.txtChat.Text = "";
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(12, 239);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(453, 23);
            this.btnSend.TabIndex = 2;
            this.btnSend.Text = "Send Data To Server";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 270);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.txtChat);
            this.Controls.Add(this.lblTitle);
            this.Name = "Client";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Client_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.RichTextBox txtChat;
        private System.Windows.Forms.Button btnSend;
    }
}

