using Microsoft.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace AdoLab2
{
    public partial class Form1 : Form
    {
        SqlConnection connection;
        public Form1()
        {
            InitializeComponent();
            connection = new SqlConnection("Server=.;Database=ITI;Trusted_Connection=True;TrustServerCertificate=True");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox2.Text))
            {
                MessageBox.Show("Please enter both username and password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Exit the method
            }
            if (!int.TryParse(textBox2.Text, out int insId))
            {
                MessageBox.Show("Please enter a valid numeric password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Exit the method
            }
            SqlCommand sqlCommand = new SqlCommand($"select [Ins_Name] from Instructor where Ins_Id = {int.Parse(textBox2.Text)}", connection);

            connection.Open();

            object? obj = sqlCommand.ExecuteScalar();

            connection.Close();

            string? fname = (string)obj;

            if(fname != null && fname == textBox1.Text) 
            {
                MessageBox.Show("Logged", "Logged in", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Form2 form2 = new Form2(int.Parse(textBox2.Text));
                this.Hide();
                form2.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Incorrect Usernamr or Passowrd!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
