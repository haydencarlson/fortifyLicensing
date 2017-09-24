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
            this.label3 = new System.Windows.Forms.Label();
            this.passwordConfirmation = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // registerAccount
            // 
            this.registerAccount.Enabled = false;
            this.registerAccount.Location = new System.Drawing.Point(106, 171);
            this.registerAccount.Name = "registerAccount";
            this.registerAccount.Size = new System.Drawing.Size(92, 36);
            this.registerAccount.TabIndex = 0;
            this.registerAccount.Text = "Register";
            this.registerAccount.UseVisualStyleBackColor = true;
            this.registerAccount.Click += new System.EventHandler(this.button1_Click);
            // 
            // emailField
            // 
            this.emailField.Location = new System.Drawing.Point(23, 35);
            this.emailField.Name = "emailField";
            this.emailField.Size = new System.Drawing.Size(175, 20);
            this.emailField.TabIndex = 1;
            this.emailField.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(78, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Email:";
            // 
            // passwordField
            // 
            this.passwordField.Location = new System.Drawing.Point(23, 81);
            this.passwordField.Name = "passwordField";
            this.passwordField.Size = new System.Drawing.Size(175, 20);
            this.passwordField.TabIndex = 3;
            this.passwordField.UseSystemPasswordChar = true;
            this.passwordField.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(69, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Password:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(23, 171);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(77, 36);
            this.button1.TabIndex = 5;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(176, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Password Confirmation:";
            // 
            // passwordConfirmation
            // 
            this.passwordConfirmation.Location = new System.Drawing.Point(23, 132);
            this.passwordConfirmation.Name = "passwordConfirmation";
            this.passwordConfirmation.Size = new System.Drawing.Size(175, 20);
            this.passwordConfirmation.TabIndex = 6;
            this.passwordConfirmation.UseSystemPasswordChar = true;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(226, 227);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.passwordConfirmation);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.passwordField);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.emailField);
            this.Controls.Add(this.registerAccount);
            this.Name = "Form3";
            this.Text = "Fortified Licensing - Registration";
            this.Load += new System.EventHandler(this.Form3_Load);
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
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox passwordConfirmation;
    }
}