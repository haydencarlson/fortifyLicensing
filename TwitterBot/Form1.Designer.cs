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
            this.label2 = new System.Windows.Forms.Label();
            this.accountsCreated = new System.Windows.Forms.Label();
            this.totalAccounts = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.creatorBackgroundworker = new System.ComponentModel.BackgroundWorker();
            this.stopCreator = new MaterialSkin.Controls.MaterialRaisedButton();
            this.startCreator = new MaterialSkin.Controls.MaterialFlatButton();
            this.SuspendLayout();
            // 
            // accountCreatorTimer
            // 
            this.accountCreatorTimer.Interval = 500;
            this.accountCreatorTimer.Tick += new System.EventHandler(this.accountCreatorTimer_Tick);
            // 
            // passwordText
            // 
            this.passwordText.Location = new System.Drawing.Point(23, 289);
            this.passwordText.Name = "passwordText";
            this.passwordText.Size = new System.Drawing.Size(182, 20);
            this.passwordText.TabIndex = 1;
            this.passwordText.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(54, 273);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Password for Accounts";
            // 
            // accountsList
            // 
            this.accountsList.FormattingEnabled = true;
            this.accountsList.Location = new System.Drawing.Point(23, 75);
            this.accountsList.Name = "accountsList";
            this.accountsList.Size = new System.Drawing.Size(182, 186);
            this.accountsList.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Montserrat Alternates", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(34, 404);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "Accounts Created:";
            // 
            // accountsCreated
            // 
            this.accountsCreated.AutoSize = true;
            this.accountsCreated.BackColor = System.Drawing.Color.Transparent;
            this.accountsCreated.Font = new System.Drawing.Font("Montserrat Alternates SemiBold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accountsCreated.Location = new System.Drawing.Point(170, 404);
            this.accountsCreated.Name = "accountsCreated";
            this.accountsCreated.Size = new System.Drawing.Size(17, 18);
            this.accountsCreated.TabIndex = 6;
            this.accountsCreated.Text = "0";
            this.accountsCreated.Click += new System.EventHandler(this.label3_Click);
            // 
            // totalAccounts
            // 
            this.totalAccounts.AutoSize = true;
            this.totalAccounts.BackColor = System.Drawing.Color.Transparent;
            this.totalAccounts.Font = new System.Drawing.Font("Montserrat Alternates SemiBold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalAccounts.Location = new System.Drawing.Point(154, 425);
            this.totalAccounts.Name = "totalAccounts";
            this.totalAccounts.Size = new System.Drawing.Size(17, 18);
            this.totalAccounts.TabIndex = 8;
            this.totalAccounts.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Montserrat Alternates", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(35, 425);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 18);
            this.label5.TabIndex = 7;
            this.label5.Text = "Accounts Total:";
            // 
            // stopCreator
            // 
            this.stopCreator.Depth = 0;
            this.stopCreator.Location = new System.Drawing.Point(49, 362);
            this.stopCreator.MouseState = MaterialSkin.MouseState.HOVER;
            this.stopCreator.Name = "stopCreator";
            this.stopCreator.Primary = true;
            this.stopCreator.Size = new System.Drawing.Size(124, 35);
            this.stopCreator.TabIndex = 10;
            this.stopCreator.Text = "Stop Creator";
            this.stopCreator.UseVisualStyleBackColor = true;
            this.stopCreator.Click += new System.EventHandler(this.stopCreator_Click);
            // 
            // startCreator
            // 
            this.startCreator.AutoSize = true;
            this.startCreator.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.startCreator.Depth = 0;
            this.startCreator.Location = new System.Drawing.Point(49, 318);
            this.startCreator.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.startCreator.MouseState = MaterialSkin.MouseState.HOVER;
            this.startCreator.Name = "startCreator";
            this.startCreator.Primary = false;
            this.startCreator.Size = new System.Drawing.Size(124, 36);
            this.startCreator.TabIndex = 9;
            this.startCreator.Text = "Start Creating";
            this.startCreator.UseVisualStyleBackColor = true;
            this.startCreator.Click += new System.EventHandler(this.startCreator_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(228, 450);
            this.Controls.Add(this.stopCreator);
            this.Controls.Add(this.startCreator);
            this.Controls.Add(this.totalAccounts);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.accountsCreated);
            this.Controls.Add(this.label2);
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label accountsCreated;
        private System.Windows.Forms.Label totalAccounts;
        private System.Windows.Forms.Label label5;
        private System.ComponentModel.BackgroundWorker creatorBackgroundworker;
        private MaterialSkin.Controls.MaterialRaisedButton stopCreator;
        private MaterialSkin.Controls.MaterialFlatButton startCreator;
    }
}

