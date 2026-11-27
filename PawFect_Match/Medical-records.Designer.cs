namespace PawFect_Match
{
    partial class Medical_records
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
            pnlMedical = new Panel();
            lblPawfect = new Label();
            bntDashboard = new Button();
            bntAnimals = new Button();
            bntMedicalRecord = new Button();
            bntAdopters = new Button();
            bntApplications = new Button();
            bntHistory = new Button();
            bntLogOut = new Button();
            lblMedical = new Label();
            lblSelect = new Label();
            cmbSelect = new ComboBox();
            dataGridView1 = new DataGridView();
            RecordsID = new DataGridViewTextBoxColumn();
            Date = new DataGridViewTextBoxColumn();
            Type = new DataGridViewTextBoxColumn();
            Description = new DataGridViewTextBoxColumn();
            ProviderNotes = new DataGridViewTextBoxColumn();
            NextDueDate = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            lblRecord = new Label();
            cmbRecord = new ComboBox();
            lblRecordDate = new Label();
            dtpRecordDate = new DateTimePicker();
            lblDescription = new Label();
            rtbDescription = new RichTextBox();
            lblNextDate = new Label();
            dtpNextDueDate = new DateTimePicker();
            bntAdd = new Button();
            bntUpdateRecord = new Button();
            bntArchiveRecord = new Button();
            bntRefresh = new Button();
            pnlMedical.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // pnlMedical
            // 
            pnlMedical.Controls.Add(bntLogOut);
            pnlMedical.Controls.Add(bntHistory);
            pnlMedical.Controls.Add(bntApplications);
            pnlMedical.Controls.Add(bntAdopters);
            pnlMedical.Controls.Add(bntMedicalRecord);
            pnlMedical.Controls.Add(bntAnimals);
            pnlMedical.Controls.Add(bntDashboard);
            pnlMedical.Controls.Add(lblPawfect);
            pnlMedical.Location = new Point(12, 12);
            pnlMedical.Name = "pnlMedical";
            pnlMedical.Size = new Size(200, 650);
            pnlMedical.TabIndex = 0;
            // 
            // lblPawfect
            // 
            lblPawfect.AutoSize = true;
            lblPawfect.Location = new Point(40, 14);
            lblPawfect.Name = "lblPawfect";
            lblPawfect.Size = new Size(105, 20);
            lblPawfect.TabIndex = 0;
            lblPawfect.Text = "Pawfect Match";
            // 
            // bntDashboard
            // 
            bntDashboard.Location = new Point(24, 67);
            bntDashboard.Name = "bntDashboard";
            bntDashboard.Size = new Size(140, 40);
            bntDashboard.TabIndex = 1;
            bntDashboard.Text = "Dashboard";
            bntDashboard.UseVisualStyleBackColor = true;
            // 
            // bntAnimals
            // 
            bntAnimals.Location = new Point(24, 130);
            bntAnimals.Name = "bntAnimals";
            bntAnimals.Size = new Size(140, 40);
            bntAnimals.TabIndex = 2;
            bntAnimals.Text = "Animals";
            bntAnimals.UseVisualStyleBackColor = true;
            // 
            // bntMedicalRecord
            // 
            bntMedicalRecord.Location = new Point(24, 201);
            bntMedicalRecord.Name = "bntMedicalRecord";
            bntMedicalRecord.Size = new Size(140, 40);
            bntMedicalRecord.TabIndex = 3;
            bntMedicalRecord.Text = "Medical Records";
            bntMedicalRecord.UseVisualStyleBackColor = true;
            // 
            // bntAdopters
            // 
            bntAdopters.Location = new Point(24, 273);
            bntAdopters.Name = "bntAdopters";
            bntAdopters.Size = new Size(140, 40);
            bntAdopters.TabIndex = 4;
            bntAdopters.Text = "Adopters";
            bntAdopters.UseVisualStyleBackColor = true;
            // 
            // bntApplications
            // 
            bntApplications.Location = new Point(24, 341);
            bntApplications.Name = "bntApplications";
            bntApplications.Size = new Size(140, 40);
            bntApplications.TabIndex = 5;
            bntApplications.Text = "Applications";
            bntApplications.UseVisualStyleBackColor = true;
            // 
            // bntHistory
            // 
            bntHistory.Location = new Point(24, 415);
            bntHistory.Name = "bntHistory";
            bntHistory.Size = new Size(140, 40);
            bntHistory.TabIndex = 6;
            bntHistory.Text = "History";
            bntHistory.UseVisualStyleBackColor = true;
            // 
            // bntLogOut
            // 
            bntLogOut.Location = new Point(24, 607);
            bntLogOut.Name = "bntLogOut";
            bntLogOut.Size = new Size(140, 40);
            bntLogOut.TabIndex = 7;
            bntLogOut.Text = "Log-Out";
            bntLogOut.UseVisualStyleBackColor = true;
            // 
            // lblMedical
            // 
            lblMedical.AutoSize = true;
            lblMedical.Font = new Font("Segoe UI", 15F);
            lblMedical.Location = new Point(232, 12);
            lblMedical.Name = "lblMedical";
            lblMedical.Size = new Size(198, 35);
            lblMedical.TabIndex = 1;
            lblMedical.Text = "Medical Records";
            // 
            // lblSelect
            // 
            lblSelect.AutoSize = true;
            lblSelect.Location = new Point(239, 76);
            lblSelect.Name = "lblSelect";
            lblSelect.Size = new Size(100, 20);
            lblSelect.TabIndex = 2;
            lblSelect.Text = "Select Animal";
            // 
            // cmbSelect
            // 
            cmbSelect.FormattingEnabled = true;
            cmbSelect.Location = new Point(345, 73);
            cmbSelect.Name = "cmbSelect";
            cmbSelect.Size = new Size(151, 28);
            cmbSelect.TabIndex = 3;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { RecordsID, Date, Type, Description, ProviderNotes, NextDueDate, Column1 });
            dataGridView1.Location = new Point(232, 120);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(740, 260);
            dataGridView1.TabIndex = 4;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // RecordsID
            // 
            RecordsID.HeaderText = "Record ID";
            RecordsID.MinimumWidth = 6;
            RecordsID.Name = "RecordsID";
            RecordsID.Width = 125;
            // 
            // Date
            // 
            Date.HeaderText = "Date";
            Date.MinimumWidth = 6;
            Date.Name = "Date";
            Date.Width = 125;
            // 
            // Type
            // 
            Type.HeaderText = "Type";
            Type.MinimumWidth = 6;
            Type.Name = "Type";
            Type.Width = 125;
            // 
            // Description
            // 
            Description.HeaderText = "Description";
            Description.MinimumWidth = 6;
            Description.Name = "Description";
            Description.Width = 125;
            // 
            // ProviderNotes
            // 
            ProviderNotes.HeaderText = "Provider/Notes";
            ProviderNotes.MinimumWidth = 6;
            ProviderNotes.Name = "ProviderNotes";
            ProviderNotes.Width = 125;
            // 
            // NextDueDate
            // 
            NextDueDate.HeaderText = "Next Due Date";
            NextDueDate.MinimumWidth = 6;
            NextDueDate.Name = "NextDueDate";
            NextDueDate.Width = 125;
            // 
            // Column1
            // 
            Column1.HeaderText = "Column1";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.Width = 125;
            // 
            // lblRecord
            // 
            lblRecord.AutoSize = true;
            lblRecord.Location = new Point(239, 399);
            lblRecord.Name = "lblRecord";
            lblRecord.Size = new Size(91, 20);
            lblRecord.TabIndex = 5;
            lblRecord.Text = "Record Type";
            // 
            // cmbRecord
            // 
            cmbRecord.FormattingEnabled = true;
            cmbRecord.Items.AddRange(new object[] { "Vaccination", "Examination", "Treatment", "Condition", "Sterilization", "Other" });
            cmbRecord.Location = new Point(336, 399);
            cmbRecord.Name = "cmbRecord";
            cmbRecord.Size = new Size(151, 28);
            cmbRecord.TabIndex = 6;
            // 
            // lblRecordDate
            // 
            lblRecordDate.AutoSize = true;
            lblRecordDate.Location = new Point(561, 402);
            lblRecordDate.Name = "lblRecordDate";
            lblRecordDate.Size = new Size(92, 20);
            lblRecordDate.TabIndex = 7;
            lblRecordDate.Text = "Record Date";
            // 
            // dtpRecordDate
            // 
            dtpRecordDate.Location = new Point(659, 399);
            dtpRecordDate.Name = "dtpRecordDate";
            dtpRecordDate.Size = new Size(250, 27);
            dtpRecordDate.TabIndex = 8;
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Location = new Point(239, 448);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(85, 20);
            lblDescription.TabIndex = 9;
            lblDescription.Text = "Description";
            // 
            // rtbDescription
            // 
            rtbDescription.Location = new Point(232, 471);
            rtbDescription.Name = "rtbDescription";
            rtbDescription.Size = new Size(330, 90);
            rtbDescription.TabIndex = 10;
            rtbDescription.Text = "";
            // 
            // lblNextDate
            // 
            lblNextDate.AutoSize = true;
            lblNextDate.Location = new Point(623, 448);
            lblNextDate.Name = "lblNextDate";
            lblNextDate.Size = new Size(107, 20);
            lblNextDate.TabIndex = 11;
            lblNextDate.Text = "Next Due Date";
            // 
            // dtpNextDueDate
            // 
            dtpNextDueDate.Location = new Point(623, 471);
            dtpNextDueDate.Name = "dtpNextDueDate";
            dtpNextDueDate.Size = new Size(250, 27);
            dtpNextDueDate.TabIndex = 12;
            // 
            // bntAdd
            // 
            bntAdd.Location = new Point(293, 603);
            bntAdd.Name = "bntAdd";
            bntAdd.Size = new Size(160, 40);
            bntAdd.TabIndex = 13;
            bntAdd.Text = "Add Record";
            bntAdd.UseVisualStyleBackColor = true;
            // 
            // bntUpdateRecord
            // 
            bntUpdateRecord.Location = new Point(493, 603);
            bntUpdateRecord.Name = "bntUpdateRecord";
            bntUpdateRecord.Size = new Size(160, 40);
            bntUpdateRecord.TabIndex = 14;
            bntUpdateRecord.Text = "Update Record";
            bntUpdateRecord.UseVisualStyleBackColor = true;
            // 
            // bntArchiveRecord
            // 
            bntArchiveRecord.Location = new Point(677, 603);
            bntArchiveRecord.Name = "bntArchiveRecord";
            bntArchiveRecord.Size = new Size(160, 40);
            bntArchiveRecord.TabIndex = 15;
            bntArchiveRecord.Text = "Archive Record";
            bntArchiveRecord.UseVisualStyleBackColor = true;
            // 
            // bntRefresh
            // 
            bntRefresh.Location = new Point(812, 7);
            bntRefresh.Name = "bntRefresh";
            bntRefresh.Size = new Size(160, 40);
            bntRefresh.TabIndex = 16;
            bntRefresh.Text = "Refresh";
            bntRefresh.UseVisualStyleBackColor = true;
            // 
            // Medical_records
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(982, 674);
            Controls.Add(bntRefresh);
            Controls.Add(bntArchiveRecord);
            Controls.Add(bntUpdateRecord);
            Controls.Add(bntAdd);
            Controls.Add(dtpNextDueDate);
            Controls.Add(lblNextDate);
            Controls.Add(rtbDescription);
            Controls.Add(lblDescription);
            Controls.Add(dtpRecordDate);
            Controls.Add(lblRecordDate);
            Controls.Add(cmbRecord);
            Controls.Add(lblRecord);
            Controls.Add(dataGridView1);
            Controls.Add(cmbSelect);
            Controls.Add(lblSelect);
            Controls.Add(lblMedical);
            Controls.Add(pnlMedical);
            Name = "Medical_records";
            Text = "Medical_records";
            pnlMedical.ResumeLayout(false);
            pnlMedical.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlMedical;
        private Button bntDashboard;
        private Label lblPawfect;
        private Button bntAnimals;
        private Button bntMedicalRecord;
        private Button bntAdopters;
        private Button bntLogOut;
        private Button bntHistory;
        private Button bntApplications;
        private Label lblMedical;
        private Label lblSelect;
        private ComboBox cmbSelect;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn RecordsID;
        private DataGridViewTextBoxColumn Date;
        private DataGridViewTextBoxColumn Type;
        private DataGridViewTextBoxColumn Description;
        private DataGridViewTextBoxColumn ProviderNotes;
        private DataGridViewTextBoxColumn NextDueDate;
        private DataGridViewTextBoxColumn Column1;
        private Label lblRecord;
        private ComboBox cmbRecord;
        private Label lblRecordDate;
        private DateTimePicker dtpRecordDate;
        private Label lblDescription;
        private RichTextBox rtbDescription;
        private Label lblNextDate;
        private DateTimePicker dtpNextDueDate;
        private Button bntAdd;
        private Button bntUpdateRecord;
        private Button bntArchiveRecord;
        private Button bntRefresh;
    }
}