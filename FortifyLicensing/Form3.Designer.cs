namespace TwitterBot {
    partial class Form3 {
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
            this.registerAccount = new System.Windows.Forms.Button();
            this.emailField = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.passwordField = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // registerAccount
            // 
            this.registerAccount.Enabled = false;
            this.registerAccount.Location = new System.Drawing.Point(168, 106);
            this.registerAccount.Name = "registerAccount";
            this.registerAccount.Size = new System.Drawing.Size(127, 36);
            this.registerAccount.TabIndex = 0;
            this.registerAccount.Text = "Register";
            this.registerAccount.UseVisualStyleBackColor = true;
            this.registerAccount.Click += new System.EventHandler(this.button1_Click);
            // 
            // emailField
            // 
            this.emailField.Location = new System.Drawing.Point(92, 29);
            this.emailField.Name = "emailField";
            this.emailField.Size = new System.Drawing.Size(175, 20);
            this.emailField.TabIndex = 1;
            this.emailField.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Email:";
            // 
            // passwordField
            // 
            this.passwordField.Location = new System.Drawing.Point(92, 67);
            this.passwordField.Name = "passwordField";
            this.passwordField.Size = new System.Drawing.Size(175, 20);
            this.passwordField.TabIndex = 3;
            this.passwordField.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Password:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 106);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 36);
            this.button1.TabIndex = 5;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(307, 154);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.passwordField);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.emailField);
            this.Controls.Add(this.registerAccount);
            this.Name = "Form3";
            this.Text = "Fortified Licensing - Registration";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button registerAccount;
        private System.Windows.Forms.TextBox emailField;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox passwordField;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
    }
}