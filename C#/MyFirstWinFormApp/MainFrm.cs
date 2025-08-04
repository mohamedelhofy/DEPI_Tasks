
using System.Security.Policy;
using System.Threading.Tasks.Dataflow;
using System.Windows.Forms;
namespace MyFirstWinFormApp
{
    public partial class MainFrm : Form
    {
        public MainFrm()
        {
            InitializeComponent();
            pageSetupDialog1.Document = printDocument1;
            printDialog1.Document = printDocument1;
            printPreviewDialog1.Document = printDocument1;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            progressBar1.Value = (int)numericUpDown1.Value;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String Name = txtName.Text;
            String DOB = dateTimePicker1.Value.ToShortDateString();
            String status = comboBox1.Text;
            String Gender = radioButton1.Checked ? "Male" : "Female";
            String CS_rate = numericUpDown1.Value.ToString();
            String hobbies = "";
            if (checkBox1.Checked)
                hobbies += checkBox1.Text + ", ";
            if (checkBox2.Checked)
                hobbies += checkBox2.Text + ", ";
            if (Handball.Checked)
                hobbies += Handball.Text + ", ";
            if (Robotics.Checked)
                hobbies += Robotics.Text + ", ";



            richTextBox1.Text = String.Format("Name: {0}\nDOB: {1}\nStatus: {2}\nGender: {3}\nCS Rate: {4}\nHobbies: {5}", Name, DOB, status, Gender, CS_rate, hobbies.TrimEnd(',', ' '));


        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            printDocument1.PrintPage += printDocument1_PrintPage;
            printDialog1.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            printDocument1.PrintPage += printDocument1_PrintPage;
            pageSetupDialog1.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            printDocument1.PrintPage += printDocument1_PrintPage;
            printPreviewDialog1.ShowDialog();
        }
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(richTextBox1.Text, new Font("Arial", 30), Brushes.Black, 10, 10);
        }
    }
}
