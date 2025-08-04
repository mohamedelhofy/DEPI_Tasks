namespace MyFirstWinFormApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text.Trim() == "hofy" && txtPassword.Text.Trim() == "2004")
            {
                //Form 2
                MainFrm mainFrm = new MainFrm();
                this.Hide();
                mainFrm.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Username Or Password Invalid ...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Optional: Initialize any components or settings when the form loads
            txtUsername.Text = string.Empty;
            txtPassword.Text = string.Empty;
            txtUsername.Focus();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

    }
}
