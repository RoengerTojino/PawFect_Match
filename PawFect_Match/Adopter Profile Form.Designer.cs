namespace PawFect_Match
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
            label1 = new Label();
            txtFullName = new TextBox();
            label2 = new Label();
            textBox2 = new TextBox();
            label3 = new Label();
            textBox3 = new TextBox();
            cmbPrefferedAnimal = new ComboBox();
            lblPrefferedAnimal = new Label();
            cmbPreferredSize = new Label();
            comboBox1 = new ComboBox();
            cmbHomeType = new Label();
            comboBox2 = new ComboBox();
            chkHasYard = new CheckBox();
            chkHasFencedYard = new CheckBox();
            cmbActivityLevel = new Label();
            comboBox3 = new ComboBox();
            chkHasOtherPets = new CheckBox();
            txtOtherPetDetails = new Label();
            textBox4 = new TextBox();
            chkHasChildren = new CheckBox();
            cmbChildrenAgeGroup = new Label();
            comboBox4 = new ComboBox();
            label4 = new Label();
            comboBox5 = new ComboBox();
            btnSaveProfile = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 21);
            label1.Name = "label1";
            label1.Size = new Size(95, 25);
            label1.TabIndex = 0;
            label1.Text = "Full Name:";
            label1.Click += label1_Click;
            // 
            // txtFullName
            // 
            txtFullName.Location = new Point(141, 21);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(150, 31);
            txtFullName.TabIndex = 1;
            txtFullName.TextChanged += textBox1_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 82);
            label2.Name = "label2";
            label2.Size = new Size(121, 25);
            label2.TabIndex = 2;
            label2.Text = "Phone / Email";
            label2.Click += label2_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(141, 79);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(150, 31);
            textBox2.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(30, 127);
            label3.Name = "label3";
            label3.Size = new Size(81, 25);
            label3.TabIndex = 4;
            label3.Text = "Address:";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(141, 124);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(150, 46);
            textBox3.TabIndex = 5;
            // 
            // cmbPrefferedAnimal
            // 
            cmbPrefferedAnimal.FormattingEnabled = true;
            cmbPrefferedAnimal.Items.AddRange(new object[] { "Dog", "Cat", "Both" });
            cmbPrefferedAnimal.Location = new Point(166, 196);
            cmbPrefferedAnimal.Name = "cmbPrefferedAnimal";
            cmbPrefferedAnimal.Size = new Size(182, 33);
            cmbPrefferedAnimal.TabIndex = 6;
            // 
            // lblPrefferedAnimal
            // 
            lblPrefferedAnimal.AutoSize = true;
            lblPrefferedAnimal.Location = new Point(12, 199);
            lblPrefferedAnimal.Name = "lblPrefferedAnimal";
            lblPrefferedAnimal.Size = new Size(148, 25);
            lblPrefferedAnimal.TabIndex = 7;
            lblPrefferedAnimal.Text = "Preferred Animal:";
            // 
            // cmbPreferredSize
            // 
            cmbPreferredSize.AutoSize = true;
            cmbPreferredSize.Location = new Point(26, 243);
            cmbPreferredSize.Name = "cmbPreferredSize";
            cmbPreferredSize.Size = new Size(124, 25);
            cmbPreferredSize.TabIndex = 8;
            cmbPreferredSize.Text = "Preferred Size:";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Small", "Medium", "Large", "No preference" });
            comboBox1.Location = new Point(166, 243);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(182, 33);
            comboBox1.TabIndex = 9;
            // 
            // cmbHomeType
            // 
            cmbHomeType.AutoSize = true;
            cmbHomeType.Location = new Point(30, 289);
            cmbHomeType.Name = "cmbHomeType";
            cmbHomeType.Size = new Size(107, 25);
            cmbHomeType.TabIndex = 10;
            cmbHomeType.Text = "Home Type:";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Apartment", "House", "Other" });
            comboBox2.Location = new Point(166, 289);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(182, 33);
            comboBox2.TabIndex = 11;
            // 
            // chkHasYard
            // 
            chkHasYard.AutoSize = true;
            chkHasYard.Location = new Point(30, 356);
            chkHasYard.Name = "chkHasYard";
            chkHasYard.Size = new Size(107, 29);
            chkHasYard.TabIndex = 12;
            chkHasYard.Text = "Has Yard";
            chkHasYard.UseVisualStyleBackColor = true;
            // 
            // chkHasFencedYard
            // 
            chkHasFencedYard.AutoSize = true;
            chkHasFencedYard.Location = new Point(30, 391);
            chkHasFencedYard.Name = "chkHasFencedYard";
            chkHasFencedYard.Size = new Size(168, 29);
            chkHasFencedYard.TabIndex = 13;
            chkHasFencedYard.Text = "Has Fenced Yard";
            chkHasFencedYard.UseVisualStyleBackColor = true;
            // 
            // cmbActivityLevel
            // 
            cmbActivityLevel.AutoSize = true;
            cmbActivityLevel.Location = new Point(26, 440);
            cmbActivityLevel.Name = "cmbActivityLevel";
            cmbActivityLevel.Size = new Size(118, 25);
            cmbActivityLevel.TabIndex = 14;
            cmbActivityLevel.Text = "Activity Level:";
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Items.AddRange(new object[] { "Low", "Moderate", "High" });
            comboBox3.Location = new Point(166, 437);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(182, 33);
            comboBox3.TabIndex = 15;
            // 
            // chkHasOtherPets
            // 
            chkHasOtherPets.AutoSize = true;
            chkHasOtherPets.Location = new Point(30, 498);
            chkHasOtherPets.Name = "chkHasOtherPets";
            chkHasOtherPets.Size = new Size(155, 29);
            chkHasOtherPets.TabIndex = 16;
            chkHasOtherPets.Text = "Has Other Pets";
            chkHasOtherPets.UseVisualStyleBackColor = true;
            // 
            // txtOtherPetDetails
            // 
            txtOtherPetDetails.AutoSize = true;
            txtOtherPetDetails.Location = new Point(30, 554);
            txtOtherPetDetails.Name = "txtOtherPetDetails";
            txtOtherPetDetails.Size = new Size(148, 25);
            txtOtherPetDetails.TabIndex = 17;
            txtOtherPetDetails.Text = "Other Pet Details:";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(175, 551);
            textBox4.Multiline = true;
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(150, 46);
            textBox4.TabIndex = 18;
            // 
            // chkHasChildren
            // 
            chkHasChildren.AutoSize = true;
            chkHasChildren.Location = new Point(30, 621);
            chkHasChildren.Name = "chkHasChildren";
            chkHasChildren.Size = new Size(138, 29);
            chkHasChildren.TabIndex = 19;
            chkHasChildren.Text = "Has Children";
            chkHasChildren.UseVisualStyleBackColor = true;
            // 
            // cmbChildrenAgeGroup
            // 
            cmbChildrenAgeGroup.AutoSize = true;
            cmbChildrenAgeGroup.Location = new Point(30, 677);
            cmbChildrenAgeGroup.Name = "cmbChildrenAgeGroup";
            cmbChildrenAgeGroup.Size = new Size(173, 25);
            cmbChildrenAgeGroup.TabIndex = 20;
            cmbChildrenAgeGroup.Text = "Children Age Group:";
            // 
            // comboBox4
            // 
            comboBox4.FormattingEnabled = true;
            comboBox4.Location = new Point(209, 674);
            comboBox4.Name = "comboBox4";
            comboBox4.Size = new Size(182, 33);
            comboBox4.TabIndex = 21;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(30, 724);
            label4.Name = "label4";
            label4.Size = new Size(128, 25);
            label4.TabIndex = 22;
            label4.Text = "Pet Experience:";
            // 
            // comboBox5
            // 
            comboBox5.FormattingEnabled = true;
            comboBox5.Items.AddRange(new object[] { "First-Time", "Some experience", "Experienced" });
            comboBox5.Location = new Point(209, 724);
            comboBox5.Name = "comboBox5";
            comboBox5.Size = new Size(182, 33);
            comboBox5.TabIndex = 23;
            // 
            // btnSaveProfile
            // 
            btnSaveProfile.BackColor = Color.Lime;
            btnSaveProfile.Location = new Point(38, 782);
            btnSaveProfile.Name = "btnSaveProfile";
            btnSaveProfile.Size = new Size(112, 34);
            btnSaveProfile.TabIndex = 24;
            btnSaveProfile.Text = "Save Profile";
            btnSaveProfile.UseVisualStyleBackColor = false;
            btnSaveProfile.Click += btnSaveProfile_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.LightGray;
            btnCancel.Location = new Point(175, 782);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(112, 34);
            btnCancel.TabIndex = 25;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(728, 844);
            Controls.Add(btnCancel);
            Controls.Add(btnSaveProfile);
            Controls.Add(comboBox5);
            Controls.Add(label4);
            Controls.Add(comboBox4);
            Controls.Add(cmbChildrenAgeGroup);
            Controls.Add(chkHasChildren);
            Controls.Add(textBox4);
            Controls.Add(txtOtherPetDetails);
            Controls.Add(chkHasOtherPets);
            Controls.Add(comboBox3);
            Controls.Add(cmbActivityLevel);
            Controls.Add(chkHasFencedYard);
            Controls.Add(chkHasYard);
            Controls.Add(comboBox2);
            Controls.Add(cmbHomeType);
            Controls.Add(comboBox1);
            Controls.Add(cmbPreferredSize);
            Controls.Add(lblPrefferedAnimal);
            Controls.Add(cmbPrefferedAnimal);
            Controls.Add(textBox3);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(txtFullName);
            Controls.Add(label1);
            Name = "Form1";
            Text = "AdopterProfileForm";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtFullName;
        private Label label2;
        private TextBox textBox2;
        private Label label3;
        private TextBox textBox3;
        private ComboBox cmbPrefferedAnimal;
        private Label lblPrefferedAnimal;
        private Label cmbPreferredSize;
        private ComboBox comboBox1;
        private Label cmbHomeType;
        private ComboBox comboBox2;
        private CheckBox chkHasYard;
        private CheckBox chkHasFencedYard;
        private Label cmbActivityLevel;
        private ComboBox comboBox3;
        private CheckBox chkHasOtherPets;
        private Label txtOtherPetDetails;
        private TextBox textBox4;
        private CheckBox chkHasChildren;
        private Label cmbChildrenAgeGroup;
        private ComboBox comboBox4;
        private Label label4;
        private ComboBox comboBox5;
        private Button btnSaveProfile;
        private Button btnCancel;
    }
}
