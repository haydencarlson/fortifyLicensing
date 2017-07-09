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
            this.passwordText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.accountsList = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.accountsCreated = new System.Windows.Forms.Label();
            this.totalAccounts = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // startBot
            // 
            this.startBot.Location = new System.Drawing.Point(23, 262);
            this.startBot.Name = "startBot";
            this.startBot.Size = new System.Drawing.Size(182, 32);
            this.startBot.TabIndex = 0;
            this.startBot.Text = "Start Creating";
            this.startBot.UseVisualStyleBackColor = true;
            this.startBot.Click += new System.EventHandler(this.startBot_Click);
            // 
            // accountCreatorTimer
            // 
            this.accountCreatorTimer.Interval = 1000;
            this.accountCreatorTimer.Tick += new System.EventHandler(this.accountCreatorTimer_Tick);
            // 
            // passwordText
            // 
            this.passwordText.Location = new System.Drawing.Point(23, 232);
            this.passwordText.Name = "passwordText";
            this.passwordText.Size = new System.Drawing.Size(182, 20);
            this.passwordText.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 216);
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
            this.accountsList.Size = new System.Drawing.Size(182, 199);
            this.accountsList.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(23, 300);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(182, 32);
            this.button1.TabIndex = 4;
            this.button1.Text = "Stop Creating";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Montserrat Alternates", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(34, 338);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "Accounts Created:";
            // 
            // accountsCreated
            // 
            this.accountsCreated.AutoSize = true;
            this.accountsCreated.Font = new System.Drawing.Font("Montserrat Alternates SemiBold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accountsCreated.Location = new System.Drawing.Point(170, 338);
            this.accountsCreated.Name = "accountsCreated";
            this.accountsCreated.Size = new System.Drawing.Size(17, 18);
            this.accountsCreated.TabIndex = 6;
            this.accountsCreated.Text = "0";
            this.accountsCreated.Click += new System.EventHandler(this.label3_Click);
            // 
            // totalAccounts
            // 
            this.totalAccounts.AutoSize = true;
            this.totalAccounts.Font = new System.Drawing.Font("Montserrat Alternates SemiBold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalAccounts.Location = new System.Drawing.Point(154, 360);
            this.totalAccounts.Name = "totalAccounts";
            this.totalAccounts.Size = new System.Drawing.Size(17, 18);
            this.totalAccounts.TabIndex = 8;
            this.totalAccounts.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Montserrat Alternates", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(35, 360);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 18);
            this.label5.TabIndex = 7;
            this.label5.Text = "Accounts Total:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(228, 387);
            this.Controls.Add(this.totalAccounts);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.accountsCreated);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.accountsList);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.passwordText);
            this.Controls.Add(this.startBot);
            this.Name = "Form1";
            this.Text = "TwitterBot";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button startBot;
        private System.Windows.Forms.Timer accountCreatorTimer;
        private System.Windows.Forms.TextBox passwordText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox accountsList;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label accountsCreated;
        private System.Windows.Forms.Label totalAccounts;
        private System.Windows.Forms.Label label5;
    }
}

