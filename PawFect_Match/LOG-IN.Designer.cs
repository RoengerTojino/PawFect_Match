namespace PawFect_Match
{
    partial class LOG_IN
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
            lblTitle = new Label();
            lblUsername = new Label();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            lblPassword = new Label();
            chkPassword = new CheckBox();
            lnkForgot = new LinkLabel();
            bntLogin = new Button();
            lblError = new Label();
            lblCreateAccount = new Label();
            lnkCreateAccount = new LinkLabel();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Location = new Point(91, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(219, 20);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "WELCOME TO PAWFECT MATCH";
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Location = new Point(39, 76);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(134, 20);
            lblUsername.TabIndex = 1;
            lblUsername.Text = "Username or Email";
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(43, 103);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(320, 27);
            txtUsername.TabIndex = 2;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(43, 197);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(320, 27);
            txtPassword.TabIndex = 3;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(43, 174);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(70, 20);
            lblPassword.TabIndex = 4;
            lblPassword.Text = "Password";
            // 
            // chkPassword
            // 
            chkPassword.AutoSize = true;
            chkPassword.Location = new Point(43, 230);
            chkPassword.Name = "chkPassword";
            chkPassword.Size = new Size(132, 24);
            chkPassword.TabIndex = 5;
            chkPassword.Text = "Show Password";
            chkPassword.UseVisualStyleBackColor = true;
            // 
            // lnkForgot
            // 
            lnkForgot.AutoSize = true;
            lnkForgot.Location = new Point(39, 267);
            lnkForgot.Name = "lnkForgot";
            lnkForgot.Size = new Size(125, 20);
            lnkForgot.TabIndex = 6;
            lnkForgot.TabStop = true;
            lnkForgot.Text = "Forgot Password?";
            // 
            // bntLogin
            // 
            bntLogin.Location = new Point(43, 300);
            bntLogin.Name = "bntLogin";
            bntLogin.Size = new Size(320, 45);
            bntLogin.TabIndex = 7;
            bntLogin.Text = "Log-In";
            bntLogin.UseVisualStyleBackColor = true;
            // 
            // lblError
            // 
            lblError.AutoSize = true;
            lblError.Location = new Point(75, 358);
            lblError.Name = "lblError";
            lblError.Size = new Size(251, 20);
            lblError.TabIndex = 9;
            lblError.Text = "Invalid Username/Email Or Password";
            // 
            // lblCreateAccount
            // 
            lblCreateAccount.AutoSize = true;
            lblCreateAccount.Location = new Point(91, 402);
            lblCreateAccount.Name = "lblCreateAccount";
            lblCreateAccount.Size = new Size(227, 20);
            lblCreateAccount.TabIndex = 10;
            lblCreateAccount.Text = "Don't Have an Adopter Account?";
            // 
            // lnkCreateAccount
            // 
            lnkCreateAccount.AutoSize = true;
            lnkCreateAccount.Location = new Point(117, 431);
            lnkCreateAccount.Name = "lnkCreateAccount";
            lnkCreateAccount.Size = new Size(169, 20);
            lnkCreateAccount.TabIndex = 11;
            lnkCreateAccount.TabStop = true;
            lnkCreateAccount.Text = "Create Adopter Account";
            // 
            // LOG_IN
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(432, 503);
            Controls.Add(lnkCreateAccount);
            Controls.Add(lblCreateAccount);
            Controls.Add(lblError);
            Controls.Add(bntLogin);
            Controls.Add(lnkForgot);
            Controls.Add(chkPassword);
            Controls.Add(lblPassword);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(lblUsername);
            Controls.Add(lblTitle);
            Name = "LOG_IN";
            Text = "LOG_IN";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblUsername;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private Label lblPassword;
        private CheckBox chkPassword;
        private LinkLabel lnkForgot;
        private Button bntLogin;
        private Label lblError;
        private Label lblCreateAccount;
        private LinkLabel lnkCreateAccount;
    }
}