namespace TwitterBot {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.startBot = new System.Windows.Forms.Button();
            this.accountCreatorTimer = new System.Windows.Forms.Timer(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.accountsList = new System.Windows.Forms.ListBox();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.webBrowser2 = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // startBot
            // 
            this.startBot.Location = new System.Drawing.Point(23, 320);
            this.startBot.Name = "startBot";
            this.startBot.Size = new System.Drawing.Size(182, 56);
            this.startBot.TabIndex = 0;
            this.startBot.Text = "Start Creating";
            this.startBot.UseVisualStyleBackColor = true;
            this.startBot.Click += new System.EventHandler(this.startBot_Click);
            // 
            // accountCreatorTimer
            // 
            this.accountCreatorTimer.Tick += new System.EventHandler(this.accountCreatorTimer_Tick);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(23, 290);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(182, 20);
            this.textBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 263);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Password for Accounts";
            // 
            // accountsList
            // 
            this.accountsList.FormattingEnabled = true;
            this.accountsList.Location = new System.Drawing.Point(23, 12);
            this.accountsList.Name = "accountsList";
            this.accountsList.Size = new System.Drawing.Size(182, 225);
            this.accountsList.TabIndex = 3;
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(223, 12);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.ScriptErrorsSuppressed = true;
            this.webBrowser1.Size = new System.Drawing.Size(625, 184);
            this.webBrowser1.TabIndex = 4;
            this.webBrowser1.Url = new System.Uri("https://temp-mail.org/en", System.UriKind.Absolute);
            // 
            // webBrowser2
            // 
            this.webBrowser2.Location = new System.Drawing.Point(223, 202);
            this.webBrowser2.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser2.Name = "webBrowser2";
            this.webBrowser2.Size = new System.Drawing.Size(625, 174);
            this.webBrowser2.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 387);
            this.Controls.Add(this.webBrowser2);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.accountsList);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.startBot);
            this.Name = "Form1";
            this.Text = "TwitterBot";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button startBot;
        private System.Windows.Forms.Timer accountCreatorTimer;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox accountsList;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.WebBrowser webBrowser2;
    }
}

