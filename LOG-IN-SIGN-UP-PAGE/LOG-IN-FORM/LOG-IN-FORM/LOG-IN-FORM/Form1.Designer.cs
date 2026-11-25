namespace LOG_IN_FORM
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblTtile = new Label();
            lblUsername = new Label();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            lblPassword = new Label();
            chkPassword = new CheckBox();
            lnkForgot = new LinkLabel();
            bntLogin = new Button();
            lblError = new Label();
            lnkCreateAccount = new LinkLabel();
            SuspendLayout();
            // 
            // lblTtile
            // 
            lblTtile.AutoSize = true;
            lblTtile.Location = new Point(82, 9);
            lblTtile.Name = "lblTtile";
            lblTtile.Size = new Size(219, 20);
            lblTtile.TabIndex = 0;
            lblTtile.Text = "WELCOME TO PAWFECT MATCH";
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Location = new Point(43, 65);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(118, 20);
            lblUsername.TabIndex = 1;
            lblUsername.Text = "Username/Email";
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(43, 88);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(300, 27);
            txtUsername.TabIndex = 2;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(43, 186);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(300, 27);
            txtPassword.TabIndex = 3;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(43, 163);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(70, 20);
            lblPassword.TabIndex = 4;
            lblPassword.Text = "Password";
            // 
            // chkPassword
            // 
            chkPassword.AutoSize = true;
            chkPassword.Location = new Point(43, 219);
            chkPassword.Name = "chkPassword";
            chkPassword.Size = new Size(132, 24);
            chkPassword.TabIndex = 5;
            chkPassword.Text = "Show Password";
            chkPassword.UseVisualStyleBackColor = true;
            // 
            // lnkForgot
            // 
            lnkForgot.AutoSize = true;
            lnkForgot.Location = new Point(43, 246);
            lnkForgot.Name = "lnkForgot";
            lnkForgot.Size = new Size(125, 20);
            lnkForgot.TabIndex = 6;
            lnkForgot.TabStop = true;
            lnkForgot.Text = "Forgot Password?";
            // 
            // bntLogin
            // 
            bntLogin.Location = new Point(43, 292);
            bntLogin.Name = "bntLogin";
            bntLogin.Size = new Size(300, 45);
            bntLogin.TabIndex = 7;
            bntLogin.Text = "Login";
            bntLogin.UseVisualStyleBackColor = true;
            // 
            // lblError
            // 
            lblError.AutoSize = true;
            lblError.Location = new Point(69, 355);
            lblError.Name = "lblError";
            lblError.Size = new Size(251, 20);
            lblError.TabIndex = 8;
            lblError.Text = "Invalid Username/Email Or Password";
            // 
            // lnkCreateAccount
            // 
            lnkCreateAccount.AutoSize = true;
            lnkCreateAccount.Location = new Point(100, 398);
            lnkCreateAccount.Name = "lnkCreateAccount";
            lnkCreateAccount.Size = new Size(169, 20);
            lnkCreateAccount.TabIndex = 9;
            lnkCreateAccount.TabStop = true;
            lnkCreateAccount.Text = "Create Adopter Account";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(432, 503);
            Controls.Add(lnkCreateAccount);
            Controls.Add(lblError);
            Controls.Add(bntLogin);
            Controls.Add(lnkForgot);
            Controls.Add(chkPassword);
            Controls.Add(lblPassword);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(lblUsername);
            Controls.Add(lblTtile);
            MaximizeBox = false;
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTtile;
        private Label lblUsername;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private Label lblPassword;
        private CheckBox chkPassword;
        private LinkLabel lnkForgot;
        private Button bntLogin;
        private Label lblError;
        private LinkLabel lnkCreateAccount;
    }
}
