namespace LOG_IN_FORM
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private Label lblTitle;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private Label lblPassword;
        private CheckBox chkPassword;
        private LinkLabel inkForgotPassword;
        private Button bntLogin;
        private Label lblError;
        private LinkLabel lnkCreateAccount;
        private Label lblUsername;

        private void InitializeComponent()
        {
            lblTitle = new Label();
            lblUsername = new Label();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            lblPassword = new Label();
            chkPassword = new CheckBox();
            inkForgotPassword = new LinkLabel();
            bntLogin = new Button();
            lblError = new Label();
            lnkCreateAccount = new LinkLabel();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Location = new Point(95, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(219, 20);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "WELCOME TO PAWFECT MATCH";
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Location = new Point(59, 92);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(118, 20);
            lblUsername.TabIndex = 1;
            lblUsername.Text = "Username/Email";
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(59, 115);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(300, 27);
            txtUsername.TabIndex = 2;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(59, 198);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(300, 27);
            txtPassword.TabIndex = 3;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(59, 175);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(70, 20);
            lblPassword.TabIndex = 4;
            lblPassword.Text = "Password";
            // 
            // chkPassword
            // 
            chkPassword.AutoSize = true;
            chkPassword.Location = new Point(59, 231);
            chkPassword.Name = "chkPassword";
            chkPassword.Size = new Size(132, 24);
            chkPassword.TabIndex = 5;
            chkPassword.Text = "Show Password";
            chkPassword.UseVisualStyleBackColor = true;
            // 
            // inkForgotPassword
            // 
            inkForgotPassword.AutoSize = true;
            inkForgotPassword.Location = new Point(59, 258);
            inkForgotPassword.Name = "inkForgotPassword";
            inkForgotPassword.Size = new Size(125, 20);
            inkForgotPassword.TabIndex = 6;
            inkForgotPassword.TabStop = true;
            inkForgotPassword.Text = "Forgot Password?";
            // 
            // bntLogin
            // 
            bntLogin.Location = new Point(59, 300);
            bntLogin.Name = "bntLogin";
            bntLogin.Size = new Size(300, 45);
            bntLogin.TabIndex = 7;
            bntLogin.Text = "LOGIN";
            bntLogin.UseVisualStyleBackColor = true;
            // 
            // lblError
            // 
            lblError.AutoSize = true;
            lblError.Location = new Point(83, 360);
            lblError.Name = "lblError";
            lblError.Size = new Size(251, 20);
            lblError.TabIndex = 8;
            lblError.Text = "Invalid Username/Email Or Password";
            // 
            // lnkCreateAccount
            // 
            lnkCreateAccount.AutoSize = true;
            lnkCreateAccount.Location = new Point(121, 407);
            lnkCreateAccount.Name = "lnkCreateAccount";
            lnkCreateAccount.Size = new Size(169, 20);
            lnkCreateAccount.TabIndex = 9;
            lnkCreateAccount.TabStop = true;
            lnkCreateAccount.Text = "Create Adopter Account";
            // 
            // Form1
            // 
            ClientSize = new Size(432, 503);
            Controls.Add(lnkCreateAccount);
            Controls.Add(lblError);
            Controls.Add(bntLogin);
            Controls.Add(inkForgotPassword);
            Controls.Add(chkPassword);
            Controls.Add(lblPassword);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(lblUsername);
            Controls.Add(lblTitle);
            Name = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
