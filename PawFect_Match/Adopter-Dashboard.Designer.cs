namespace PawFect_Match
{
    partial class Adopter_Dashboard
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
            lblWelcome = new Label();
            flpRecommendedAnimals = new FlowLayoutPanel();
            lblRecommended = new Label();
            panel1 = new Panel();
            bntBrowse = new Button();
            lblPawfect = new Label();
            bntMyApplications = new Button();
            bntProfile = new Button();
            bntAdoptionHistory = new Button();
            bntLogOut = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.Font = new Font("Segoe UI", 15F);
            lblWelcome.Location = new Point(223, 9);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(232, 35);
            lblWelcome.TabIndex = 0;
            lblWelcome.Text = "Welcome, Adopters";
            // 
            // flpRecommendedAnimals
            // 
            flpRecommendedAnimals.Location = new Point(223, 113);
            flpRecommendedAnimals.Name = "flpRecommendedAnimals";
            flpRecommendedAnimals.Size = new Size(730, 430);
            flpRecommendedAnimals.TabIndex = 1;
            flpRecommendedAnimals.Paint += flpRecommendedAnimals_Paint;
            // 
            // lblRecommended
            // 
            lblRecommended.AutoSize = true;
            lblRecommended.Location = new Point(223, 90);
            lblRecommended.Name = "lblRecommended";
            lblRecommended.Size = new Size(167, 20);
            lblRecommended.TabIndex = 0;
            lblRecommended.Text = "Recommended Animals";
            lblRecommended.Click += label1_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(bntLogOut);
            panel1.Controls.Add(bntAdoptionHistory);
            panel1.Controls.Add(bntProfile);
            panel1.Controls.Add(bntMyApplications);
            panel1.Controls.Add(lblPawfect);
            panel1.Controls.Add(bntBrowse);
            panel1.Location = new Point(12, 9);
            panel1.Name = "panel1";
            panel1.Size = new Size(185, 582);
            panel1.TabIndex = 2;
            // 
            // bntBrowse
            // 
            bntBrowse.Location = new Point(3, 156);
            bntBrowse.Name = "bntBrowse";
            bntBrowse.Size = new Size(180, 40);
            bntBrowse.TabIndex = 0;
            bntBrowse.Text = "Browse Animals";
            bntBrowse.UseVisualStyleBackColor = true;
            bntBrowse.Click += bntBrowse_Click;
            // 
            // lblPawfect
            // 
            lblPawfect.AutoSize = true;
            lblPawfect.Location = new Point(31, 15);
            lblPawfect.Name = "lblPawfect";
            lblPawfect.Size = new Size(15, 20);
            lblPawfect.TabIndex = 1;
            lblPawfect.Text = "s";
            // 
            // bntMyApplications
            // 
            bntMyApplications.Location = new Point(2, 228);
            bntMyApplications.Name = "bntMyApplications";
            bntMyApplications.Size = new Size(180, 40);
            bntMyApplications.TabIndex = 2;
            bntMyApplications.Text = "My Applications";
            bntMyApplications.UseVisualStyleBackColor = true;
            // 
            // bntProfile
            // 
            bntProfile.Location = new Point(2, 81);
            bntProfile.Name = "bntProfile";
            bntProfile.Size = new Size(180, 40);
            bntProfile.TabIndex = 3;
            bntProfile.Text = "My Profile";
            bntProfile.UseVisualStyleBackColor = true;
            // 
            // bntAdoptionHistory
            // 
            bntAdoptionHistory.Location = new Point(2, 305);
            bntAdoptionHistory.Name = "bntAdoptionHistory";
            bntAdoptionHistory.Size = new Size(180, 40);
            bntAdoptionHistory.TabIndex = 4;
            bntAdoptionHistory.Text = "Adoption History";
            bntAdoptionHistory.UseVisualStyleBackColor = true;
            // 
            // bntLogOut
            // 
            bntLogOut.Location = new Point(0, 494);
            bntLogOut.Name = "bntLogOut";
            bntLogOut.Size = new Size(180, 40);
            bntLogOut.TabIndex = 5;
            bntLogOut.Text = "Log-Out";
            bntLogOut.UseVisualStyleBackColor = true;
            // 
            // Adopter_Dashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(982, 603);
            Controls.Add(panel1);
            Controls.Add(lblRecommended);
            Controls.Add(flpRecommendedAnimals);
            Controls.Add(lblWelcome);
            Name = "Adopter_Dashboard";
            Text = "Adopter_Dashboard";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblWelcome;
        private FlowLayoutPanel flpRecommendedAnimals;
        private Label lblRecommended;
        private Panel panel1;
        private Button bntBrowse;
        private Label lblPawfect;
        private Button bntMyApplications;
        private Button bntProfile;
        private Button bntLogOut;
        private Button bntAdoptionHistory;
    }
}