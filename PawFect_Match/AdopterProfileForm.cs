namespace PawFect_Match
{
    public partial class AdopterProfileForm : Form
    {
        public AdopterProfileForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void lblPreferredAnimal_Click(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void btnSaveProfile_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txtFullName.Text))
            {
                MessageBox.Show("Please enter your full name.");
                txtFullName.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(textBox2.Text))
            {
                MessageBox.Show("Please enter your phone number or email.");
                textBox2.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(textBox3.Text))
            {
                MessageBox.Show("Please enter your address.");
                textBox3.Focus();
                return;
            }

            MessageBox.Show("Adopter profile saved successfully!");
        }



        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            txtOtherPetDetails.Visible = chkHasOtherPets.Checked;

        }
        private void chkHasChildren_CheckedChanged(object sender, EventArgs e)
        {
            cmbChildrenAgeGroup.Visible = chkHasChildren.Checked;

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void chkHasOtherPets_CheckedChanged(object sender, EventArgs e)
        {
            txtOtherPetDetails.Visible = chkHasOtherPets.Checked;
            textBox4.Visible = chkHasOtherPets.Checked;


        }

        private void chkHasChildren_CheckedChanged_1(object sender, EventArgs e)
        {
            cmbChildrenAgeGroup.Visible = chkHasChildren.Checked;
            comboBox4.Visible = chkHasChildren.Checked;


        }

        private void chkHasYard_CheckedChanged(object sender, EventArgs e)
        {
            chkHasFencedYard.Enabled = chkHasYard.Checked;

            if (!chkHasYard.Checked)
            {
                chkHasFencedYard.Checked = false;
            }

        }
    }
}

