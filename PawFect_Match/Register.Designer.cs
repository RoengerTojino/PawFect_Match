namespace PawFect_Match
{
    partial class Register
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
            lblPawfectMatch = new Label();
            lblTitle = new Label();
            lblFullName = new Label();
            txtFullName = new TextBox();
            txtUsername = new TextBox();
            txtEmail = new TextBox();
            lblUsername = new Label();
            lblEmail = new Label();
            lblPassword = new Label();
            lblConfirmPassword = new Label();
            txtPassword = new TextBox();
            txtConfirmPassword = new TextBox();
            txtPhoneNumber = new TextBox();
            txtAddress = new TextBox();
            lblPhoneNumber = new Label();
            lblAddress = new Label();
            bntRegister = new Button();
            lblError = new Label();
            bntBackToLogin = new Button();
            SuspendLayout();
            // 
            // lblPawfectMatch
            // 
            lblPawfectMatch.AutoSize = true;
            lblPawfectMatch.Location = new Point(147, 9);
            lblPawfectMatch.Name = "lblPawfectMatch";
            lblPawfectMatch.Size = new Size(124, 20);
            lblPawfectMatch.TabIndex = 0;
            lblPawfectMatch.Text = "PAWFECT MATCH";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Location = new Point(142, 32);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(132, 20);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "Create An Account";
            // 
            // lblFullName
            // 
            lblFullName.AutoSize = true;
            lblFullName.Location = new Point(32, 74);
            lblFullName.Name = "lblFullName";
            lblFullName.Size = new Size(76, 20);
            lblFullName.TabIndex = 2;
            lblFullName.Text = "Full Name";
            // 
            // txtFullName
            // 
            txtFullName.Location = new Point(32, 97);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(400, 27);
            txtFullName.TabIndex = 3;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(32, 159);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(400, 27);
            txtUsername.TabIndex = 4;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(32, 223);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(400, 27);
            txtEmail.TabIndex = 5;
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Location = new Point(32, 136);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(75, 20);
            lblUsername.TabIndex = 6;
            lblUsername.Text = "Username";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(32, 200);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(46, 20);
            lblEmail.TabIndex = 7;
            lblEmail.Text = "Email";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(32, 266);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(70, 20);
            lblPassword.TabIndex = 8;
            lblPassword.Text = "Password";
            // 
            // lblConfirmPassword
            // 
            lblConfirmPassword.AutoSize = true;
            lblConfirmPassword.Location = new Point(32, 328);
            lblConfirmPassword.Name = "lblConfirmPassword";
            lblConfirmPassword.Size = new Size(127, 20);
            lblConfirmPassword.TabIndex = 9;
            lblConfirmPassword.Text = "Confirm Password";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(34, 289);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(400, 27);
            txtPassword.TabIndex = 10;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.Location = new Point(34, 351);
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.Size = new Size(400, 27);
            txtConfirmPassword.TabIndex = 11;
            txtConfirmPassword.UseSystemPasswordChar = true;
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.Location = new Point(34, 409);
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.Size = new Size(400, 27);
            txtPhoneNumber.TabIndex = 12;
            txtPhoneNumber.TextChanged += textBox1_TextChanged;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(34, 473);
            txtAddress.Multiline = true;
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(400, 60);
            txtAddress.TabIndex = 13;
            // 
            // lblPhoneNumber
            // 
            lblPhoneNumber.AutoSize = true;
            lblPhoneNumber.Location = new Point(34, 386);
            lblPhoneNumber.Name = "lblPhoneNumber";
            lblPhoneNumber.Size = new Size(108, 20);
            lblPhoneNumber.TabIndex = 14;
            lblPhoneNumber.Text = "Phone Number";
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.Location = new Point(34, 450);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(62, 20);
            lblAddress.TabIndex = 15;
            lblAddress.Text = "Address";
            // 
            // bntRegister
            // 
            bntRegister.Location = new Point(57, 539);
            bntRegister.Name = "bntRegister";
            bntRegister.Size = new Size(350, 45);
            bntRegister.TabIndex = 16;
            bntRegister.Text = "Register";
            bntRegister.UseVisualStyleBackColor = true;
            // 
            // lblError
            // 
            lblError.AutoSize = true;
            lblError.Location = new Point(82, 587);
            lblError.Name = "lblError";
            lblError.Size = new Size(301, 20);
            lblError.TabIndex = 17;
            lblError.Text = "Please check your information and try again.";
            // 
            // bntBackToLogin
            // 
            bntBackToLogin.Location = new Point(34, 624);
            bntBackToLogin.Name = "bntBackToLogin";
            bntBackToLogin.Size = new Size(400, 45);
            bntBackToLogin.TabIndex = 18;
            bntBackToLogin.Text = "Back To Login";
            bntBackToLogin.UseVisualStyleBackColor = true;
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(482, 703);
            Controls.Add(bntBackToLogin);
            Controls.Add(lblError);
            Controls.Add(bntRegister);
            Controls.Add(lblAddress);
            Controls.Add(lblPhoneNumber);
            Controls.Add(txtAddress);
            Controls.Add(txtPhoneNumber);
            Controls.Add(txtConfirmPassword);
            Controls.Add(txtPassword);
            Controls.Add(lblConfirmPassword);
            Controls.Add(lblPassword);
            Controls.Add(lblEmail);
            Controls.Add(lblUsername);
            Controls.Add(txtEmail);
            Controls.Add(txtUsername);
            Controls.Add(txtFullName);
            Controls.Add(lblFullName);
            Controls.Add(lblTitle);
            Controls.Add(lblPawfectMatch);
            Name = "Register";
            Text = "Register";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblPawfectMatch;
        private Label lblTitle;
        private Label lblFullName;
        private TextBox txtFullName;
        private TextBox txtUsername;
        private TextBox txtEmail;
        private Label lblUsername;
        private Label lblEmail;
        private Label lblPassword;
        private Label lblConfirmPassword;
        private TextBox txtPassword;
        private TextBox txtConfirmPassword;
        private TextBox txtPhoneNumber;
        private TextBox textBox1;
        private TextBox txtAddress;
        private Label lblPhoneNumber;
        private Label lblAddress;
        private Button bntRegister;
        private Label lblError;
        private Button bntBackToLogin;
    }
}