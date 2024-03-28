using Microsoft.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace AdoLab1
{
    public partial class Form2 : Form
    {
        SqlConnection connection;
        int Ins_id;

        public Form2(int Ins_id)
        {
            InitializeComponent();
            this.Ins_id = Ins_id;

            connection = new SqlConnection("Server=.;Database=ITI;Trusted_Connection=True;TrustServerCertificate=True");
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            GetCoursesData();
            GetTopics();
            delete_btn.Visible = false;
            edit_btn.Visible = false;
        }

        void GetCoursesData()
        {
            if (Ins_id == 0)
            {
                MessageBox.Show("Ins_id is not initialized properly.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            SqlCommand cmd = new SqlCommand($"SELECT Course.Crs_id,Course.Crs_Name, Course.Crs_Duration, Topic.Top_Name FROM  Course INNER JOIN Ins_Course ON Course.Crs_Id = Ins_Course.Crs_Id INNER JOIN\r\nInstructor ON Ins_Course.Ins_Id = Instructor.Ins_Id and Instructor.Ins_Id={Ins_id} INNER JOIN Topic ON Course.Top_Id = Topic.Top_Id", connection);
            connection.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);
            connection.Close();
            dgv_courses.DataSource = dt;
            dgv_courses.Columns["Crs_id"].Visible = false;
        }
        void GetTopics()
        {
            SqlCommand cmd = new SqlCommand("select Top_Id id, Top_Name name from Topic", connection);
            connection.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);
            connection.Close();
            cb_topic.DataSource = dt;
            cb_topic.DisplayMember = "name";
            cb_topic.ValueMember = "id";
            cb_topic.SelectedIndex = -1;
        }
        int SelectedId = 0;
        private void dgv_courses_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewCellCollection cells = dgv_courses.SelectedRows[0].Cells;

            SelectedId = (int)cells["Crs_Id"].Value;

            numericUpDown1.Value = (int)cells["Crs_Duration"].Value;
            cb_topic.SelectedItem = cells["Top_Name"].Value;
            cb_topic.Text = cells["Top_Name"].Value.ToString();

            textBox1.Text = cells["Crs_Name"].Value.ToString();

            delete_btn.Visible = true;
            edit_btn.Visible = true;
            add_btn.Visible = false;
        }
        private void add_btn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text) || cb_topic.SelectedIndex == -1)
            {
                MessageBox.Show("Please enter course name and select a topic before adding.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int rowsEffected = ExecuteNonQuery($@"INSERT INTO Course (Crs_Name, Crs_Duration, Top_Id)
                                     VALUES ('{textBox1.Text}', {numericUpDown1.Value}, {cb_topic.SelectedValue});

                                      DECLARE @CrsId INT;
                                      SET @CrsId = SCOPE_IDENTITY();

                                     INSERT INTO Ins_Course (Ins_Id, Crs_Id, Evaluation)
                                     VALUES ({Ins_id}, @CrsId, 'good')");

            if (rowsEffected > 0)
            {
                MessageBox.Show("Data Added");
                GetCoursesData();
            }
        }

        private void edit_btn_Click(object sender, EventArgs e)
        {
            int rowsEffected = ExecuteNonQuery($"update course set Crs_Name='{textBox1.Text}' , Crs_Duration={numericUpDown1.Value},Top_Id={cb_topic.SelectedValue} where Crs_Id = {SelectedId}");
            if (rowsEffected > 0)
            {
                MessageBox.Show("Data modified");
                GetCoursesData();
            }
            delete_btn.Visible = false;
            edit_btn.Visible = false;
            add_btn.Visible = true;
        }

        int ExecuteNonQuery(string comd)
        {
            SqlCommand command = new SqlCommand(comd, connection);

            connection.Open();

            int rowsEffected = command.ExecuteNonQuery();

            connection.Close();

            return rowsEffected;
        }

        private void delete_btn_Click(object sender, EventArgs e)
        {
            {
                int rowsEffected = ExecuteNonQuery($@"delete from Ins_Course where Crs_Id = {SelectedId};
                                                     delete from Course where Crs_id = {SelectedId}");

                if (rowsEffected > 0)
                {
                    MessageBox.Show("Data deleted");
                    GetCoursesData();
                }
                delete_btn.Visible = false;
                edit_btn.Visible = false;
                add_btn.Visible = true;
            }
        }
    }
}