namespace LOG_IN_FORM
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
            lblTitle = new Label();
            lblUser = new Label();
            txtUser = new TextBox();
            txtPass = new TextBox();
            lblPass = new Label();
            chkPassword = new CheckBox();
            linklblForgot = new LinkLabel();
            bntLogin = new Button();
            lblError = new Label();
            linklblSignup = new LinkLabel();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Location = new Point(74, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(219, 20);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "WELCOME TO PAWFECT MATCH";
            // 
            // lblUser
            // 
            lblUser.AutoSize = true;
            lblUser.Location = new Point(21, 59);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(118, 20);
            lblUser.TabIndex = 1;
            lblUser.Text = "Username/Email";
            // 
            // txtUser
            // 
            txtUser.Location = new Point(21, 82);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(320, 27);
            txtUser.TabIndex = 2;
            // 
            // txtPass
            // 
            txtPass.Location = new Point(21, 165);
            txtPass.Name = "txtPass";
            txtPass.Size = new Size(320, 27);
            txtPass.TabIndex = 3;
            txtPass.UseSystemPasswordChar = true;
            // 
            // lblPass
            // 
            lblPass.AutoSize = true;
            lblPass.Location = new Point(21, 142);
            lblPass.Name = "lblPass";
            lblPass.Size = new Size(70, 20);
            lblPass.TabIndex = 4;
            lblPass.Text = "Password";
            // 
            // chkPassword
            // 
            chkPassword.AutoSize = true;
            chkPassword.Location = new Point(21, 198);
            chkPassword.Name = "chkPassword";
            chkPassword.Size = new Size(132, 24);
            chkPassword.TabIndex = 5;
            chkPassword.Text = "Show Password";
            chkPassword.UseVisualStyleBackColor = true;
            chkPassword.CheckedChanged += chkPassword_CheckedChanged;
            // 
            // linklblForgot
            // 
            linklblForgot.AutoSize = true;
            linklblForgot.Location = new Point(21, 225);
            linklblForgot.Name = "linklblForgot";
            linklblForgot.Size = new Size(125, 20);
            linklblForgot.TabIndex = 6;
            linklblForgot.TabStop = true;
            linklblForgot.Text = "Forgot Password?";
            // 
            // bntLogin
            // 
            bntLogin.Location = new Point(31, 271);
            bntLogin.Name = "bntLogin";
            bntLogin.Size = new Size(320, 40);
            bntLogin.TabIndex = 7;
            bntLogin.Text = "Log-In";
            bntLogin.UseVisualStyleBackColor = true;
            // 
            // lblError
            // 
            lblError.AutoSize = true;
            lblError.Location = new Point(31, 323);
            lblError.Name = "lblError";
            lblError.Size = new Size(319, 20);
            lblError.TabIndex = 8;
            lblError.Text = "Invalid Username/Email and Password Entered!";
            // 
            // linklblSignup
            // 
            linklblSignup.AutoSize = true;
            linklblSignup.Location = new Point(74, 378);
            linklblSignup.Name = "linklblSignup";
            linklblSignup.Size = new Size(226, 20);
            linklblSignup.TabIndex = 9;
            linklblSignup.TabStop = true;
            linklblSignup.Text = "Don't Have an Account? Sign-Up";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(402, 473);
            Controls.Add(linklblSignup);
            Controls.Add(lblError);
            Controls.Add(bntLogin);
            Controls.Add(linklblForgot);
            Controls.Add(chkPassword);
            Controls.Add(lblPass);
            Controls.Add(txtPass);
            Controls.Add(txtUser);
            Controls.Add(lblUser);
            Controls.Add(lblTitle);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblUser;
        private TextBox txtUser;
        private TextBox txtPass;
        private Label lblPass;
        private CheckBox chkPassword;
        private LinkLabel linklblForgot;
        private Button bntLogin;
        private Label lblError;
        private LinkLabel linklblSignup;
    }
}