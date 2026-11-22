namespace PawFect_Match
{
    public partial class Form1 : Form
    {
        public Form1()
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
            if
            (string.IsNullOrWhiteSpace(txtFullName.Text))
            {
                MessageBox.Show("Please enter your full name.");
                txtFullName.Focus();
                return;
            }
            MessageBox.Show("Adopter profile saved successfully.");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
