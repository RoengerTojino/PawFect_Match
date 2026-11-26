namespace PawFect_Match
{
    partial class Admin_Dashboard
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
            panel1 = new Panel();
            pnlSideBar = new Panel();
            bntLogOut = new Button();
            bntHistory = new Button();
            bntApplications = new Button();
            bntAdopters = new Button();
            bntMedicals = new Button();
            bntAnimals = new Button();
            bntDashboard = new Button();
            lblLogo = new Label();
            lblAdmin = new Label();
            lblWelcome = new Label();
            pnlAnimalcards = new Panel();
            lblTotalAnimalCounts = new Label();
            lblTotalAnimals = new Label();
            pnlApplications = new Panel();
            lblTotalApplications = new Label();
            lblApplications = new Label();
            pnlAdopters = new Panel();
            lblTotalAdoptions = new Label();
            lblCompletedAdoptions = new Label();
            pnlAvailable = new Panel();
            lblAvailableAnimals = new Label();
            bntRefresh = new Button();
            lblTotalAvailableAnimals = new Label();
            dgvRecentApplications = new DataGridView();
            lblRecent = new Label();
            pnlSideBar.SuspendLayout();
            pnlAnimalcards.SuspendLayout();
            pnlApplications.SuspendLayout();
            pnlAdopters.SuspendLayout();
            pnlAvailable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRecentApplications).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Location = new Point(3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(0, 0);
            panel1.TabIndex = 0;
            // 
            // pnlSideBar
            // 
            pnlSideBar.Controls.Add(bntLogOut);
            pnlSideBar.Controls.Add(bntHistory);
            pnlSideBar.Controls.Add(bntApplications);
            pnlSideBar.Controls.Add(bntAdopters);
            pnlSideBar.Controls.Add(bntMedicals);
            pnlSideBar.Controls.Add(bntAnimals);
            pnlSideBar.Controls.Add(bntDashboard);
            pnlSideBar.Controls.Add(lblLogo);
            pnlSideBar.Location = new Point(3, 2);
            pnlSideBar.Name = "pnlSideBar";
            pnlSideBar.Size = new Size(210, 600);
            pnlSideBar.TabIndex = 1;
            // 
            // bntLogOut
            // 
            bntLogOut.Location = new Point(18, 512);
            bntLogOut.Name = "bntLogOut";
            bntLogOut.Size = new Size(180, 40);
            bntLogOut.TabIndex = 7;
            bntLogOut.Text = "Log-Out";
            bntLogOut.UseVisualStyleBackColor = true;
            // 
            // bntHistory
            // 
            bntHistory.Location = new Point(18, 395);
            bntHistory.Name = "bntHistory";
            bntHistory.Size = new Size(180, 40);
            bntHistory.TabIndex = 6;
            bntHistory.Text = "Adaption History";
            bntHistory.UseVisualStyleBackColor = true;
            // 
            // bntApplications
            // 
            bntApplications.Location = new Point(18, 323);
            bntApplications.Name = "bntApplications";
            bntApplications.Size = new Size(180, 40);
            bntApplications.TabIndex = 5;
            bntApplications.Text = "Applications";
            bntApplications.UseVisualStyleBackColor = true;
            // 
            // bntAdopters
            // 
            bntAdopters.Location = new Point(18, 258);
            bntAdopters.Name = "bntAdopters";
            bntAdopters.Size = new Size(180, 40);
            bntAdopters.TabIndex = 4;
            bntAdopters.Text = "Manage Adopters";
            bntAdopters.UseVisualStyleBackColor = true;
            // 
            // bntMedicals
            // 
            bntMedicals.Location = new Point(18, 186);
            bntMedicals.Name = "bntMedicals";
            bntMedicals.Size = new Size(180, 40);
            bntMedicals.TabIndex = 3;
            bntMedicals.Text = "Medical Records";
            bntMedicals.UseVisualStyleBackColor = true;
            // 
            // bntAnimals
            // 
            bntAnimals.Location = new Point(18, 119);
            bntAnimals.Name = "bntAnimals";
            bntAnimals.Size = new Size(180, 40);
            bntAnimals.TabIndex = 2;
            bntAnimals.Text = "Manage Animals";
            bntAnimals.UseVisualStyleBackColor = true;
            // 
            // bntDashboard
            // 
            bntDashboard.Location = new Point(18, 59);
            bntDashboard.Name = "bntDashboard";
            bntDashboard.Size = new Size(180, 40);
            bntDashboard.TabIndex = 1;
            bntDashboard.Text = "Dashboard";
            bntDashboard.UseVisualStyleBackColor = true;
            // 
            // lblLogo
            // 
            lblLogo.AutoSize = true;
            lblLogo.Location = new Point(53, 7);
            lblLogo.Name = "lblLogo";
            lblLogo.Size = new Size(105, 20);
            lblLogo.TabIndex = 0;
            lblLogo.Text = "Pawfect Match";
            // 
            // lblAdmin
            // 
            lblAdmin.AutoSize = true;
            lblAdmin.Font = new Font("Segoe UI", 15F);
            lblAdmin.Location = new Point(230, 9);
            lblAdmin.Name = "lblAdmin";
            lblAdmin.Size = new Size(218, 35);
            lblAdmin.TabIndex = 2;
            lblAdmin.Text = "Admin Dashboard";
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.Font = new Font("Segoe UI", 12F);
            lblWelcome.Location = new Point(230, 61);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(160, 28);
            lblWelcome.TabIndex = 3;
            lblWelcome.Text = "Welcome, Admin";
            // 
            // pnlAnimalcards
            // 
            pnlAnimalcards.Controls.Add(lblTotalAnimalCounts);
            pnlAnimalcards.Controls.Add(lblTotalAnimals);
            pnlAnimalcards.Location = new Point(248, 121);
            pnlAnimalcards.Name = "pnlAnimalcards";
            pnlAnimalcards.Size = new Size(250, 115);
            pnlAnimalcards.TabIndex = 4;
            pnlAnimalcards.Paint += pnlAnimalcards_Paint;
            // 
            // lblTotalAnimalCounts
            // 
            lblTotalAnimalCounts.AutoSize = true;
            lblTotalAnimalCounts.Location = new Point(108, 72);
            lblTotalAnimalCounts.Name = "lblTotalAnimalCounts";
            lblTotalAnimalCounts.Size = new Size(17, 20);
            lblTotalAnimalCounts.TabIndex = 1;
            lblTotalAnimalCounts.Text = "0";
            // 
            // lblTotalAnimals
            // 
            lblTotalAnimals.AutoSize = true;
            lblTotalAnimals.Location = new Point(63, 20);
            lblTotalAnimals.Name = "lblTotalAnimals";
            lblTotalAnimals.Size = new Size(99, 20);
            lblTotalAnimals.TabIndex = 0;
            lblTotalAnimals.Text = "Total Animals";
            // 
            // pnlApplications
            // 
            pnlApplications.Controls.Add(lblTotalApplications);
            pnlApplications.Controls.Add(lblApplications);
            pnlApplications.Location = new Point(649, 121);
            pnlApplications.Name = "pnlApplications";
            pnlApplications.Size = new Size(250, 115);
            pnlApplications.TabIndex = 5;
            // 
            // lblTotalApplications
            // 
            lblTotalApplications.AutoSize = true;
            lblTotalApplications.Location = new Point(119, 59);
            lblTotalApplications.Name = "lblTotalApplications";
            lblTotalApplications.Size = new Size(17, 20);
            lblTotalApplications.TabIndex = 1;
            lblTotalApplications.Text = "0";
            // 
            // lblApplications
            // 
            lblApplications.AutoSize = true;
            lblApplications.Location = new Point(47, 20);
            lblApplications.Name = "lblApplications";
            lblApplications.Size = new Size(149, 20);
            lblApplications.TabIndex = 0;
            lblApplications.Text = "Pending Applications";
            // 
            // pnlAdopters
            // 
            pnlAdopters.Controls.Add(lblTotalAdoptions);
            pnlAdopters.Controls.Add(lblCompletedAdoptions);
            pnlAdopters.Location = new Point(248, 285);
            pnlAdopters.Name = "pnlAdopters";
            pnlAdopters.Size = new Size(250, 115);
            pnlAdopters.TabIndex = 6;
            // 
            // lblTotalAdoptions
            // 
            lblTotalAdoptions.AutoSize = true;
            lblTotalAdoptions.Location = new Point(108, 67);
            lblTotalAdoptions.Name = "lblTotalAdoptions";
            lblTotalAdoptions.Size = new Size(17, 20);
            lblTotalAdoptions.TabIndex = 1;
            lblTotalAdoptions.Text = "0";
            // 
            // lblCompletedAdoptions
            // 
            lblCompletedAdoptions.AutoSize = true;
            lblCompletedAdoptions.Location = new Point(44, 17);
            lblCompletedAdoptions.Name = "lblCompletedAdoptions";
            lblCompletedAdoptions.Size = new Size(156, 20);
            lblCompletedAdoptions.TabIndex = 0;
            lblCompletedAdoptions.Text = "Completed Adoptions";
            // 
            // pnlAvailable
            // 
            pnlAvailable.Controls.Add(lblTotalAvailableAnimals);
            pnlAvailable.Controls.Add(lblAvailableAnimals);
            pnlAvailable.Location = new Point(649, 275);
            pnlAvailable.Name = "pnlAvailable";
            pnlAvailable.Size = new Size(250, 125);
            pnlAvailable.TabIndex = 7;
            // 
            // lblAvailableAnimals
            // 
            lblAvailableAnimals.AutoSize = true;
            lblAvailableAnimals.Location = new Point(63, 17);
            lblAvailableAnimals.Name = "lblAvailableAnimals";
            lblAvailableAnimals.Size = new Size(133, 20);
            lblAvailableAnimals.TabIndex = 0;
            lblAvailableAnimals.Text = "Available Amimals";
            // 
            // bntRefresh
            // 
            bntRefresh.Location = new Point(867, 12);
            bntRefresh.Name = "bntRefresh";
            bntRefresh.Size = new Size(94, 29);
            bntRefresh.TabIndex = 8;
            bntRefresh.Text = "Refresh";
            bntRefresh.UseVisualStyleBackColor = true;
            // 
            // lblTotalAvailableAnimals
            // 
            lblTotalAvailableAnimals.AutoSize = true;
            lblTotalAvailableAnimals.Location = new Point(119, 67);
            lblTotalAvailableAnimals.Name = "lblTotalAvailableAnimals";
            lblTotalAvailableAnimals.Size = new Size(17, 20);
            lblTotalAvailableAnimals.TabIndex = 1;
            lblTotalAvailableAnimals.Text = "0";
            // 
            // dgvRecentApplications
            // 
            dgvRecentApplications.AllowUserToAddRows = false;
            dgvRecentApplications.AllowUserToDeleteRows = false;
            dgvRecentApplications.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRecentApplications.Location = new Point(230, 466);
            dgvRecentApplications.MultiSelect = false;
            dgvRecentApplications.Name = "dgvRecentApplications";
            dgvRecentApplications.ReadOnly = true;
            dgvRecentApplications.RowHeadersVisible = false;
            dgvRecentApplications.RowHeadersWidth = 51;
            dgvRecentApplications.Size = new Size(740, 125);
            dgvRecentApplications.TabIndex = 9;
            // 
            // lblRecent
            // 
            lblRecent.AutoSize = true;
            lblRecent.Location = new Point(232, 443);
            lblRecent.Name = "lblRecent";
            lblRecent.Size = new Size(141, 20);
            lblRecent.TabIndex = 10;
            lblRecent.Text = "Recent Applications";
            // 
            // Admin_Dashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(982, 603);
            Controls.Add(lblRecent);
            Controls.Add(dgvRecentApplications);
            Controls.Add(bntRefresh);
            Controls.Add(pnlAvailable);
            Controls.Add(pnlAdopters);
            Controls.Add(pnlApplications);
            Controls.Add(pnlAnimalcards);
            Controls.Add(lblWelcome);
            Controls.Add(lblAdmin);
            Controls.Add(pnlSideBar);
            Controls.Add(panel1);
            Name = "Admin_Dashboard";
            Text = "Admin_Dashboard";
            pnlSideBar.ResumeLayout(false);
            pnlSideBar.PerformLayout();
            pnlAnimalcards.ResumeLayout(false);
            pnlAnimalcards.PerformLayout();
            pnlApplications.ResumeLayout(false);
            pnlApplications.PerformLayout();
            pnlAdopters.ResumeLayout(false);
            pnlAdopters.PerformLayout();
            pnlAvailable.ResumeLayout(false);
            pnlAvailable.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRecentApplications).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Panel pnlSideBar;
        private Button bntDashboard;
        private Label lblLogo;
        private Button bntMedicals;
        private Button bntAnimals;
        private Button bntLogOut;
        private Button bntHistory;
        private Button bntApplications;
        private Button bntAdopters;
        private Label lblAdmin;
        private Label lblWelcome;
        private Panel pnlAnimalcards;
        private Panel pnlApplications;
        private Panel panel3;
        private Panel panel4;
        private Panel pnlAdopters;
        private Panel pnlAvailable;
        private Panel pnl;
        private Label lblTotalAnimalCounts;
        private Label lblTotalAnimals;
        private Button bntRefresh;
        private Label lblTotalApplications;
        private Label lblApplications;
        private Label lblTotalAdoptions;
        private Label lblCompletedAdoptions;
        private Label lblAvailableAnimals;
        private Label lblTotalAvailableAnimals;
        private DataGridView dgvRecentApplications;
        private Label lblRecent;
    }
}