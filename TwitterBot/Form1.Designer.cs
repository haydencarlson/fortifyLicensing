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
            this.accountCreatorTimer = new System.Windows.Forms.Timer(this.components);
            this.passwordText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.accountsList = new System.Windows.Forms.ListBox();
            this.creatorBackgroundworker = new System.ComponentModel.BackgroundWorker();
            this.startBot = new System.Windows.Forms.Button();
            this.stopBot = new System.Windows.Forms.Button();
            this.accountsCreatedLabel = new System.Windows.Forms.Label();
            this.accountsCreated = new System.Windows.Forms.Label();
            this.totalAccountsLabel = new System.Windows.Forms.Label();
            this.totalAccounts = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // accountCreatorTimer
            // 
            this.accountCreatorTimer.Interval = 500;
            this.accountCreatorTimer.Tick += new System.EventHandler(this.accountCreatorTimer_Tick);
            // 
            // passwordText
            // 
            this.passwordText.Location = new System.Drawing.Point(14, 289);
            this.passwordText.Name = "passwordText";
            this.passwordText.Size = new System.Drawing.Size(182, 20);
            this.passwordText.TabIndex = 1;
            this.passwordText.UseSystemPasswordChar = true;
            this.passwordText.TextChanged += new System.EventHandler(this.passwordText_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(49, 267);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Password for Accounts";
            // 
            // accountsList
            // 
            this.accountsList.FormattingEnabled = true;
            this.accountsList.Location = new System.Drawing.Point(14, 12);
            this.accountsList.Name = "accountsList";
            this.accountsList.Size = new System.Drawing.Size(182, 186);
            this.accountsList.TabIndex = 3;
            // 
            // startBot
            // 
            this.startBot.Enabled = false;
            this.startBot.Location = new System.Drawing.Point(14, 204);
            this.startBot.Name = "startBot";
            this.startBot.Size = new System.Drawing.Size(182, 23);
            this.startBot.TabIndex = 14;
            this.startBot.Text = "Start Creating";
            this.startBot.UseVisualStyleBackColor = true;
            this.startBot.Click += new System.EventHandler(this.button1_Click);
            // 
            // stopBot
            // 
            this.stopBot.Location = new System.Drawing.Point(14, 233);
            this.stopBot.Name = "stopBot";
            this.stopBot.Size = new System.Drawing.Size(182, 23);
            this.stopBot.TabIndex = 15;
            this.stopBot.Text = "Stop Creating";
            this.stopBot.UseVisualStyleBackColor = true;
            this.stopBot.Click += new System.EventHandler(this.button2_Click);
            // 
            // accountsCreatedLabel
            // 
            this.accountsCreatedLabel.AutoSize = true;
            this.accountsCreatedLabel.Font = new System.Drawing.Font("Montserrat ExtraBold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accountsCreatedLabel.Location = new System.Drawing.Point(27, 317);
            this.accountsCreatedLabel.Name = "accountsCreatedLabel";
            this.accountsCreatedLabel.Size = new System.Drawing.Size(140, 18);
            this.accountsCreatedLabel.TabIndex = 16;
            this.accountsCreatedLabel.Text = "Accounts Created:";
            // 
            // accountsCreated
            // 
            this.accountsCreated.AutoSize = true;
            this.accountsCreated.Font = new System.Drawing.Font("Montserrat ExtraBold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accountsCreated.Location = new System.Drawing.Point(165, 317);
            this.accountsCreated.Name = "accountsCreated";
            this.accountsCreated.Size = new System.Drawing.Size(17, 18);
            this.accountsCreated.TabIndex = 17;
            this.accountsCreated.Text = "0";
            // 
            // totalAccountsLabel
            // 
            this.totalAccountsLabel.AutoSize = true;
            this.totalAccountsLabel.Font = new System.Drawing.Font("Montserrat ExtraBold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalAccountsLabel.Location = new System.Drawing.Point(27, 344);
            this.totalAccountsLabel.Name = "totalAccountsLabel";
            this.totalAccountsLabel.Size = new System.Drawing.Size(118, 18);
            this.totalAccountsLabel.TabIndex = 18;
            this.totalAccountsLabel.Text = "Accounts Total:";
            // 
            // totalAccounts
            // 
            this.totalAccounts.AutoSize = true;
            this.totalAccounts.Font = new System.Drawing.Font("Montserrat ExtraBold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalAccounts.Location = new System.Drawing.Point(144, 344);
            this.totalAccounts.Name = "totalAccounts";
            this.totalAccounts.Size = new System.Drawing.Size(17, 18);
            this.totalAccounts.TabIndex = 19;
            this.totalAccounts.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(214, 376);
            this.Controls.Add(this.totalAccounts);
            this.Controls.Add(this.totalAccountsLabel);
            this.Controls.Add(this.accountsCreated);
            this.Controls.Add(this.accountsCreatedLabel);
            this.Controls.Add(this.stopBot);
            this.Controls.Add(this.startBot);
            this.Controls.Add(this.accountsList);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.passwordText);
            this.Name = "Form1";
            this.Text = "TwitterBot";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer accountCreatorTimer;
        private System.Windows.Forms.TextBox passwordText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox accountsList;
        private System.ComponentModel.BackgroundWorker creatorBackgroundworker;
        private System.Windows.Forms.Button startBot;
        private System.Windows.Forms.Button stopBot;
        private System.Windows.Forms.Label accountsCreatedLabel;
        private System.Windows.Forms.Label accountsCreated;
        private System.Windows.Forms.Label totalAccountsLabel;
        private System.Windows.Forms.Label totalAccounts;
    }
}

