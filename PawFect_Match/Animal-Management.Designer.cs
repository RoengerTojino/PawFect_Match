namespace PawFect_Match
{
    partial class Animal_Management
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
            pnlSidebar = new Panel();
            bntLogOut = new Button();
            bntHistory = new Button();
            bntApplications = new Button();
            bntAdopters = new Button();
            bntMedicals = new Button();
            bntAnimal = new Button();
            bntDashboard = new Button();
            lblTitle = new Label();
            bntTitle = new Label();
            lblSubTitle = new Label();
            bntRefresh = new Button();
            lblSearch = new Label();
            txtSearch = new TextBox();
            lblSpecies = new Label();
            cmbSpecies = new ComboBox();
            cmbStatus = new ComboBox();
            lblStatus = new Label();
            dgvAnimals = new DataGridView();
            AnimalID = new DataGridViewTextBoxColumn();
            AnimalName = new DataGridViewTextBoxColumn();
            Species = new DataGridViewTextBoxColumn();
            Breed = new DataGridViewTextBoxColumn();
            Age = new DataGridViewTextBoxColumn();
            Gender = new DataGridViewTextBoxColumn();
            Size = new DataGridViewTextBoxColumn();
            Status = new DataGridViewTextBoxColumn();
            lblName = new Label();
            txtName = new TextBox();
            lblSpeciesAnimal = new Label();
            cmbSpeciesAnimal = new ComboBox();
            lblBreed = new Label();
            txtBreed = new TextBox();
            lblAge = new Label();
            numAge = new NumericUpDown();
            lblGender = new Label();
            cmbGender = new ComboBox();
            cmbSize = new ComboBox();
            lblSize = new Label();
            lblActivity = new Label();
            cmbActivity = new ComboBox();
            lblDescription = new Label();
            rtbDescription = new RichTextBox();
            lblPhoto = new Label();
            txtPhoto = new TextBox();
            bntBrowse = new Button();
            bntAdd = new Button();
            bntSave = new Button();
            bntUpdate = new Button();
            bntClear = new Button();
            btnArchive = new Button();
            lblTraining = new Label();
            pnlDogFields = new Panel();
            cmbTraining = new ComboBox();
            pnlCatsField = new Panel();
            cmbTemperement = new ComboBox();
            lblCat = new Label();
            lblIndoor = new Label();
            chkIndoor = new CheckBox();
            pnlSidebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAnimals).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numAge).BeginInit();
            pnlDogFields.SuspendLayout();
            pnlCatsField.SuspendLayout();
            SuspendLayout();
            // 
            // pnlSidebar
            // 
            pnlSidebar.Controls.Add(bntLogOut);
            pnlSidebar.Controls.Add(bntHistory);
            pnlSidebar.Controls.Add(bntApplications);
            pnlSidebar.Controls.Add(bntAdopters);
            pnlSidebar.Controls.Add(bntMedicals);
            pnlSidebar.Controls.Add(bntAnimal);
            pnlSidebar.Controls.Add(bntDashboard);
            pnlSidebar.Controls.Add(lblTitle);
            pnlSidebar.Location = new Point(12, 12);
            pnlSidebar.Name = "pnlSidebar";
            pnlSidebar.Size = new Size(188, 730);
            pnlSidebar.TabIndex = 0;
            // 
            // bntLogOut
            // 
            bntLogOut.Location = new Point(5, 639);
            bntLogOut.Name = "bntLogOut";
            bntLogOut.Size = new Size(180, 40);
            bntLogOut.TabIndex = 7;
            bntLogOut.Text = "Log-Out";
            bntLogOut.UseVisualStyleBackColor = true;
            // 
            // bntHistory
            // 
            bntHistory.Location = new Point(3, 396);
            bntHistory.Name = "bntHistory";
            bntHistory.Size = new Size(180, 40);
            bntHistory.TabIndex = 6;
            bntHistory.Text = "History";
            bntHistory.UseVisualStyleBackColor = true;
            // 
            // bntApplications
            // 
            bntApplications.Location = new Point(3, 327);
            bntApplications.Name = "bntApplications";
            bntApplications.Size = new Size(180, 40);
            bntApplications.TabIndex = 5;
            bntApplications.Text = "Applications";
            bntApplications.UseVisualStyleBackColor = true;
            // 
            // bntAdopters
            // 
            bntAdopters.Location = new Point(3, 255);
            bntAdopters.Name = "bntAdopters";
            bntAdopters.Size = new Size(180, 40);
            bntAdopters.TabIndex = 4;
            bntAdopters.Text = "Adopters";
            bntAdopters.UseVisualStyleBackColor = true;
            // 
            // bntMedicals
            // 
            bntMedicals.Location = new Point(3, 193);
            bntMedicals.Name = "bntMedicals";
            bntMedicals.Size = new Size(180, 40);
            bntMedicals.TabIndex = 3;
            bntMedicals.Text = "Medical Records";
            bntMedicals.UseVisualStyleBackColor = true;
            // 
            // bntAnimal
            // 
            bntAnimal.Location = new Point(3, 131);
            bntAnimal.Name = "bntAnimal";
            bntAnimal.Size = new Size(180, 40);
            bntAnimal.TabIndex = 2;
            bntAnimal.Text = "Animals";
            bntAnimal.UseVisualStyleBackColor = true;
            // 
            // bntDashboard
            // 
            bntDashboard.Location = new Point(3, 66);
            bntDashboard.Name = "bntDashboard";
            bntDashboard.Size = new Size(180, 40);
            bntDashboard.TabIndex = 1;
            bntDashboard.Text = "Dashboard";
            bntDashboard.UseVisualStyleBackColor = true;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Location = new Point(38, 13);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(105, 20);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Pawfect Match";
            // 
            // bntTitle
            // 
            bntTitle.AutoSize = true;
            bntTitle.Font = new Font("Segoe UI", 15F);
            bntTitle.Location = new Point(220, 12);
            bntTitle.Name = "bntTitle";
            bntTitle.Size = new Size(246, 35);
            bntTitle.TabIndex = 1;
            bntTitle.Text = "Animal Management";
            // 
            // lblSubTitle
            // 
            lblSubTitle.AutoSize = true;
            lblSubTitle.Location = new Point(220, 59);
            lblSubTitle.Name = "lblSubTitle";
            lblSubTitle.Size = new Size(219, 20);
            lblSubTitle.TabIndex = 2;
            lblSubTitle.Text = "Manage shelter Animal Records";
            // 
            // bntRefresh
            // 
            bntRefresh.Location = new Point(1010, 17);
            bntRefresh.Name = "bntRefresh";
            bntRefresh.Size = new Size(100, 35);
            bntRefresh.TabIndex = 4;
            bntRefresh.Text = "Refresh";
            bntRefresh.UseVisualStyleBackColor = true;
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Location = new Point(217, 93);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(53, 20);
            lblSearch.TabIndex = 5;
            lblSearch.Text = "Search";
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(276, 93);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(200, 27);
            txtSearch.TabIndex = 6;
            // 
            // lblSpecies
            // 
            lblSpecies.AutoSize = true;
            lblSpecies.Location = new Point(494, 96);
            lblSpecies.Name = "lblSpecies";
            lblSpecies.Size = new Size(59, 20);
            lblSpecies.TabIndex = 7;
            lblSpecies.Text = "Species";
            // 
            // cmbSpecies
            // 
            cmbSpecies.FormattingEnabled = true;
            cmbSpecies.Items.AddRange(new object[] { "All", "Dog", "Cat" });
            cmbSpecies.Location = new Point(559, 90);
            cmbSpecies.Name = "cmbSpecies";
            cmbSpecies.Size = new Size(151, 28);
            cmbSpecies.TabIndex = 8;
            // 
            // cmbStatus
            // 
            cmbStatus.FormattingEnabled = true;
            cmbStatus.Items.AddRange(new object[] { "All", "Available", "On Hold", "Adopted", "Archived" });
            cmbStatus.Location = new Point(788, 88);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(151, 28);
            cmbStatus.TabIndex = 9;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(733, 91);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(49, 20);
            lblStatus.TabIndex = 10;
            lblStatus.Text = "Status";
            // 
            // dgvAnimals
            // 
            dgvAnimals.AllowUserToAddRows = false;
            dgvAnimals.AllowUserToDeleteRows = false;
            dgvAnimals.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvAnimals.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAnimals.Columns.AddRange(new DataGridViewColumn[] { AnimalID, AnimalName, Species, Breed, Age, Gender, Size, Status });
            dgvAnimals.Location = new Point(226, 144);
            dgvAnimals.MultiSelect = false;
            dgvAnimals.Name = "dgvAnimals";
            dgvAnimals.RowHeadersVisible = false;
            dgvAnimals.RowHeadersWidth = 51;
            dgvAnimals.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAnimals.Size = new Size(811, 200);
            dgvAnimals.TabIndex = 11;
            // 
            // AnimalID
            // 
            AnimalID.HeaderText = "ID";
            AnimalID.MinimumWidth = 6;
            AnimalID.Name = "AnimalID";
            // 
            // AnimalName
            // 
            AnimalName.HeaderText = "Name";
            AnimalName.MinimumWidth = 6;
            AnimalName.Name = "AnimalName";
            // 
            // Species
            // 
            Species.HeaderText = "Species";
            Species.MinimumWidth = 6;
            Species.Name = "Species";
            // 
            // Breed
            // 
            Breed.HeaderText = "Breed";
            Breed.MinimumWidth = 6;
            Breed.Name = "Breed";
            // 
            // Age
            // 
            Age.HeaderText = "Age";
            Age.MinimumWidth = 6;
            Age.Name = "Age";
            // 
            // Gender
            // 
            Gender.HeaderText = "Gender";
            Gender.MinimumWidth = 6;
            Gender.Name = "Gender";
            // 
            // Size
            // 
            Size.HeaderText = "Size";
            Size.MinimumWidth = 6;
            Size.Name = "Size";
            // 
            // Status
            // 
            Status.HeaderText = "Status";
            Status.MinimumWidth = 6;
            Status.Name = "Status";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(222, 370);
            lblName.Name = "lblName";
            lblName.Size = new Size(49, 20);
            lblName.TabIndex = 12;
            lblName.Text = "Name";
            // 
            // txtName
            // 
            txtName.Location = new Point(277, 367);
            txtName.Name = "txtName";
            txtName.Size = new Size(125, 27);
            txtName.TabIndex = 13;
            // 
            // lblSpeciesAnimal
            // 
            lblSpeciesAnimal.AutoSize = true;
            lblSpeciesAnimal.Location = new Point(218, 418);
            lblSpeciesAnimal.Name = "lblSpeciesAnimal";
            lblSpeciesAnimal.Size = new Size(59, 20);
            lblSpeciesAnimal.TabIndex = 14;
            lblSpeciesAnimal.Text = "Species";
            // 
            // cmbSpeciesAnimal
            // 
            cmbSpeciesAnimal.FormattingEnabled = true;
            cmbSpeciesAnimal.Items.AddRange(new object[] { "Dog", "Cat" });
            cmbSpeciesAnimal.Location = new Point(279, 415);
            cmbSpeciesAnimal.Name = "cmbSpeciesAnimal";
            cmbSpeciesAnimal.Size = new Size(125, 28);
            cmbSpeciesAnimal.TabIndex = 15;
            // 
            // lblBreed
            // 
            lblBreed.AutoSize = true;
            lblBreed.Location = new Point(224, 464);
            lblBreed.Name = "lblBreed";
            lblBreed.Size = new Size(48, 20);
            lblBreed.TabIndex = 16;
            lblBreed.Text = "Breed";
            // 
            // txtBreed
            // 
            txtBreed.Location = new Point(277, 461);
            txtBreed.Name = "txtBreed";
            txtBreed.Size = new Size(125, 27);
            txtBreed.TabIndex = 17;
            // 
            // lblAge
            // 
            lblAge.AutoSize = true;
            lblAge.Location = new Point(231, 507);
            lblAge.Name = "lblAge";
            lblAge.Size = new Size(36, 20);
            lblAge.TabIndex = 18;
            lblAge.Text = "Age";
            // 
            // numAge
            // 
            numAge.Location = new Point(279, 507);
            numAge.Name = "numAge";
            numAge.Size = new Size(125, 27);
            numAge.TabIndex = 19;
            // 
            // lblGender
            // 
            lblGender.AutoSize = true;
            lblGender.Location = new Point(217, 558);
            lblGender.Name = "lblGender";
            lblGender.Size = new Size(57, 20);
            lblGender.TabIndex = 20;
            lblGender.Text = "Gender";
            // 
            // cmbGender
            // 
            cmbGender.FormattingEnabled = true;
            cmbGender.Items.AddRange(new object[] { "Male", "Female" });
            cmbGender.Location = new Point(279, 558);
            cmbGender.Name = "cmbGender";
            cmbGender.Size = new Size(126, 28);
            cmbGender.TabIndex = 21;
            // 
            // cmbSize
            // 
            cmbSize.FormattingEnabled = true;
            cmbSize.Items.AddRange(new object[] { "Small", "Medium", "Large" });
            cmbSize.Location = new Point(277, 598);
            cmbSize.Name = "cmbSize";
            cmbSize.Size = new Size(128, 28);
            cmbSize.TabIndex = 22;
            // 
            // lblSize
            // 
            lblSize.AutoSize = true;
            lblSize.Location = new Point(231, 598);
            lblSize.Name = "lblSize";
            lblSize.Size = new Size(36, 20);
            lblSize.TabIndex = 23;
            lblSize.Text = "Size";
            // 
            // lblActivity
            // 
            lblActivity.AutoSize = true;
            lblActivity.Location = new Point(213, 638);
            lblActivity.Name = "lblActivity";
            lblActivity.Size = new Size(58, 20);
            lblActivity.TabIndex = 24;
            lblActivity.Text = "Activity";
            // 
            // cmbActivity
            // 
            cmbActivity.FormattingEnabled = true;
            cmbActivity.Items.AddRange(new object[] { "Low", "Moderate", "High" });
            cmbActivity.Location = new Point(277, 642);
            cmbActivity.Name = "cmbActivity";
            cmbActivity.Size = new Size(128, 28);
            cmbActivity.TabIndex = 25;
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Location = new Point(426, 507);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(85, 20);
            lblDescription.TabIndex = 26;
            lblDescription.Text = "Description";
            // 
            // rtbDescription
            // 
            rtbDescription.Location = new Point(426, 536);
            rtbDescription.Name = "rtbDescription";
            rtbDescription.Size = new Size(200, 60);
            rtbDescription.TabIndex = 27;
            rtbDescription.Text = "";
            // 
            // lblPhoto
            // 
            lblPhoto.AutoSize = true;
            lblPhoto.Location = new Point(649, 374);
            lblPhoto.Name = "lblPhoto";
            lblPhoto.Size = new Size(80, 20);
            lblPhoto.TabIndex = 28;
            lblPhoto.Text = "Photo Path";
            // 
            // txtPhoto
            // 
            txtPhoto.Location = new Point(649, 397);
            txtPhoto.Name = "txtPhoto";
            txtPhoto.Size = new Size(125, 27);
            txtPhoto.TabIndex = 29;
            // 
            // bntBrowse
            // 
            bntBrowse.Location = new Point(780, 396);
            bntBrowse.Name = "bntBrowse";
            bntBrowse.Size = new Size(94, 29);
            bntBrowse.TabIndex = 30;
            bntBrowse.Text = "Browse";
            bntBrowse.UseVisualStyleBackColor = true;
            // 
            // bntAdd
            // 
            bntAdd.Location = new Point(334, 707);
            bntAdd.Name = "bntAdd";
            bntAdd.Size = new Size(120, 35);
            bntAdd.TabIndex = 31;
            bntAdd.Text = "Add";
            bntAdd.UseVisualStyleBackColor = true;
            // 
            // bntSave
            // 
            bntSave.Location = new Point(590, 707);
            bntSave.Name = "bntSave";
            bntSave.Size = new Size(120, 35);
            bntSave.TabIndex = 32;
            bntSave.Text = "Save";
            bntSave.UseVisualStyleBackColor = true;
            // 
            // bntUpdate
            // 
            bntUpdate.Location = new Point(460, 707);
            bntUpdate.Name = "bntUpdate";
            bntUpdate.Size = new Size(120, 35);
            bntUpdate.TabIndex = 33;
            bntUpdate.Text = "Update";
            bntUpdate.UseVisualStyleBackColor = true;
            // 
            // bntClear
            // 
            bntClear.Location = new Point(842, 707);
            bntClear.Name = "bntClear";
            bntClear.Size = new Size(100, 35);
            bntClear.TabIndex = 34;
            bntClear.Text = "Clear";
            bntClear.UseVisualStyleBackColor = true;
            // 
            // btnArchive
            // 
            btnArchive.Location = new Point(716, 707);
            btnArchive.Name = "btnArchive";
            btnArchive.Size = new Size(120, 35);
            btnArchive.TabIndex = 35;
            btnArchive.Text = "Archive";
            btnArchive.UseVisualStyleBackColor = true;
            // 
            // lblTraining
            // 
            lblTraining.AutoSize = true;
            lblTraining.Location = new Point(6, 6);
            lblTraining.Name = "lblTraining";
            lblTraining.Size = new Size(106, 20);
            lblTraining.TabIndex = 36;
            lblTraining.Text = "Training Status";
            // 
            // pnlDogFields
            // 
            pnlDogFields.Controls.Add(cmbTraining);
            pnlDogFields.Controls.Add(lblTraining);
            pnlDogFields.Location = new Point(426, 374);
            pnlDogFields.Name = "pnlDogFields";
            pnlDogFields.Size = new Size(217, 86);
            pnlDogFields.TabIndex = 37;
            // 
            // cmbTraining
            // 
            cmbTraining.FormattingEnabled = true;
            cmbTraining.Location = new Point(15, 41);
            cmbTraining.Name = "cmbTraining";
            cmbTraining.Size = new Size(191, 28);
            cmbTraining.TabIndex = 0;
            // 
            // pnlCatsField
            // 
            pnlCatsField.Controls.Add(chkIndoor);
            pnlCatsField.Controls.Add(lblIndoor);
            pnlCatsField.Controls.Add(lblCat);
            pnlCatsField.Controls.Add(cmbTemperement);
            pnlCatsField.Location = new Point(893, 374);
            pnlCatsField.Name = "pnlCatsField";
            pnlCatsField.Size = new Size(217, 199);
            pnlCatsField.TabIndex = 38;
            // 
            // cmbTemperement
            // 
            cmbTemperement.FormattingEnabled = true;
            cmbTemperement.Items.AddRange(new object[] { "Not Trained", "Basic Trained", "Trained", "in Training" });
            cmbTemperement.Location = new Point(14, 27);
            cmbTemperement.Name = "cmbTemperement";
            cmbTemperement.Size = new Size(191, 28);
            cmbTemperement.TabIndex = 0;
            // 
            // lblCat
            // 
            lblCat.AutoSize = true;
            lblCat.Location = new Point(38, 4);
            lblCat.Name = "lblCat";
            lblCat.Size = new Size(127, 20);
            lblCat.TabIndex = 39;
            lblCat.Text = "Cat Temperement";
            // 
            // lblIndoor
            // 
            lblIndoor.AutoSize = true;
            lblIndoor.Location = new Point(14, 81);
            lblIndoor.Name = "lblIndoor";
            lblIndoor.Size = new Size(133, 20);
            lblIndoor.TabIndex = 40;
            lblIndoor.Text = "Indoor Preferences";
            // 
            // chkIndoor
            // 
            chkIndoor.AutoSize = true;
            chkIndoor.Location = new Point(14, 105);
            chkIndoor.Name = "chkIndoor";
            chkIndoor.Size = new Size(109, 24);
            chkIndoor.TabIndex = 41;
            chkIndoor.Text = "Indoor Only";
            chkIndoor.UseVisualStyleBackColor = true;
            // 
            // Animal_Management
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1126, 754);
            Controls.Add(pnlCatsField);
            Controls.Add(pnlDogFields);
            Controls.Add(btnArchive);
            Controls.Add(bntClear);
            Controls.Add(bntUpdate);
            Controls.Add(bntSave);
            Controls.Add(bntAdd);
            Controls.Add(bntBrowse);
            Controls.Add(txtPhoto);
            Controls.Add(lblPhoto);
            Controls.Add(rtbDescription);
            Controls.Add(lblDescription);
            Controls.Add(cmbActivity);
            Controls.Add(lblActivity);
            Controls.Add(lblSize);
            Controls.Add(cmbSize);
            Controls.Add(cmbGender);
            Controls.Add(lblGender);
            Controls.Add(numAge);
            Controls.Add(lblAge);
            Controls.Add(txtBreed);
            Controls.Add(lblBreed);
            Controls.Add(cmbSpeciesAnimal);
            Controls.Add(lblSpeciesAnimal);
            Controls.Add(txtName);
            Controls.Add(lblName);
            Controls.Add(dgvAnimals);
            Controls.Add(lblStatus);
            Controls.Add(cmbStatus);
            Controls.Add(cmbSpecies);
            Controls.Add(lblSpecies);
            Controls.Add(txtSearch);
            Controls.Add(lblSearch);
            Controls.Add(bntRefresh);
            Controls.Add(lblSubTitle);
            Controls.Add(bntTitle);
            Controls.Add(pnlSidebar);
            Name = "Animal_Management";
            Text = "Animal_Management";
            pnlSidebar.ResumeLayout(false);
            pnlSidebar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAnimals).EndInit();
            ((System.ComponentModel.ISupportInitialize)numAge).EndInit();
            pnlDogFields.ResumeLayout(false);
            pnlDogFields.PerformLayout();
            pnlCatsField.ResumeLayout(false);
            pnlCatsField.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlSidebar;
        private Button bntDashboard;
        private Label lblTitle;
        private Button bntAnimal;
        private Button bntLogOut;
        private Label bntTitle;
        private Button bntHistory;
        private Button bntApplications;
        private Button bntAdopters;
        private Button bntMedicals;
        private Label lblName;
        private Label lblSubTitle;
        private Button bntRefresh;
        private Label lblSearch;
        private TextBox txtSearch;
        private Label lblSpecies;
        private ComboBox cmbSpecies;
        private ComboBox cmbStatus;
        private ComboBox cmbTraining;
        private Label lblStatus;
        private DataGridView dgvAnimals;
        private DataGridViewTextBoxColumn AnimalID;
        private DataGridViewTextBoxColumn AnimalName;
        private DataGridViewTextBoxColumn Species;
        private DataGridViewTextBoxColumn Breed;
        private DataGridViewTextBoxColumn Age;
        private DataGridViewTextBoxColumn Gender;
        private DataGridViewTextBoxColumn Size;
        private DataGridViewTextBoxColumn Status;
        private TextBox txtName;
        private Label lblSpeciesAnimal;
        private ComboBox cmbSpeciesAnimal;
        private ComboBox comboBox2;
        private Label lblBreed;
        private TextBox txtBreed;
        private Label lblAge;
        private NumericUpDown numAge;
        private Label lblGender;
        private ComboBox cmbGender;
        private ComboBox cmbSize;
        private ComboBox comboBox3;
        private Label lblSize;
        private Label lblActivity;
        private ComboBox cmbActivity;
        private Label lblDescription;
        private RichTextBox rtbDescription;
        private Label lblPhoto;
        private TextBox txtPhoto;
        private Button bntBrowse;
        private Button bntAdd;
        private Button bntSave;
        private Button bntUpdate;
        private Button bntClear;
        private Button btnArchive;
        private Label lblTraining;
        private Panel pnlDogFields;
        private Panel pnlCatsField;
        private ComboBox cmbTemperement;
        private Label lblCat;
        private CheckBox chkIndoor;
        private Label lblIndoor;
    }
}