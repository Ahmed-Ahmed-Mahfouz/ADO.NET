using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using System.Configuration;

namespace AdoLab2
{
    public partial class Form2 : Form
    {
        SqlConnection connection;
        SqlDataAdapter adapter;
        DataTable dt;
        int lastId = 0;
        int Ins_id;
        public Form2(int Ins_id)
        {
            InitializeComponent();
            this.Ins_id = Ins_id;

            connection = new SqlConnection(ConfigurationManager.ConnectionStrings["ITI"].ToString());
            adapter = new SqlDataAdapter();
            dt = new DataTable();
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

            SqlCommand selectCrs = new SqlCommand($"SELECT Course.Crs_id,Course.Crs_Name, Course.Crs_Duration, Topic.Top_Name FROM  Course INNER JOIN Ins_Course ON Course.Crs_Id = Ins_Course.Crs_Id INNER JOIN\r\nInstructor ON Ins_Course.Ins_Id = Instructor.Ins_Id and Instructor.Ins_Id={Ins_id} INNER JOIN Topic ON Course.Top_Id = Topic.Top_Id", connection);
            adapter.SelectCommand = selectCrs;
            dt.Clear();
            adapter.Fill(dt);
            lastId = (int)dt.Rows[dt.Rows.Count - 1]
                ["Crs_Id"];
            dt.Columns["Crs_Id"].AllowDBNull = false;
            dt.Columns["Crs_Id"].Unique = true;
            dataGridView1.DataSource = dt;
            dataGridView1.Columns["Crs_id"].Visible = false;
        }
        void GetTopics()
        {
            SqlCommand selectsTopics = new SqlCommand("select Top_Id id, Top_Name name from Topic", connection);
            adapter.SelectCommand = selectsTopics;
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            comboBox1.DataSource = dt;
            comboBox1.DisplayMember = "name";
            comboBox1.ValueMember = "id";
            comboBox1.SelectedIndex = -1;
        }
        int selectedId = 0;
        private void dataGridView1_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewCellCollection cells = dataGridView1.SelectedRows[0].Cells;
            selectedId = (int)cells["Crs_Id"].Value;
            numericUpDown1.Value = (int)cells["Crs_Duration"].Value;
            comboBox1.SelectedItem = cells["Top_Name"].Value;
            comboBox1.Text = cells["Top_Name"].Value.ToString();
            textBox1.Text = cells["Crs_Name"].Value.ToString();
            delete_btn.Visible = true;
            edit_btn.Visible = true;
            add_btn.Visible = false;
        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text) || comboBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Please enter course name and select a topic before adding.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DataRow row = dt.NewRow();
            row["Crs_Id"] = lastId += 100;
            row["Crs_Name"] = textBox1.Text;
            row["Crs_Duration"] = numericUpDown1.Value;
            row["Top_Name"] = comboBox1.Text;
            dt.Rows.Add(row);
            MessageBox.Show("Data Added");
        }

        private void edit_btn_Click(object sender, EventArgs e)
        {
            foreach (DataRow dr in dt.Rows)
            {
                if (dr.RowState != DataRowState.Deleted && (int)dr["Crs_Id"] == selectedId)
                {
                    dr["Crs_Name"] = textBox1.Text;
                    dr["Crs_Duration"] = numericUpDown1.Value;
                    dr["Top_Name"] = comboBox1.Text;
                    MessageBox.Show("Data modified");
                    delete_btn.Visible = false;
                    edit_btn.Visible = false;
                    add_btn.Visible = true;
                }
            }
        }

        private void delete_btn_Click(object sender, EventArgs e)
        {
            DataRow row = dt.NewRow();
            foreach (DataRow dr in dt.Rows)
            {
                if (dr.RowState != DataRowState.Deleted && (int)dr["Crs_Id"] == selectedId)
                {
                    row = dr;
                }
            }
            row.Delete();
            MessageBox.Show("Data deleted");
            delete_btn.Visible = false;
            edit_btn.Visible = false;
            add_btn.Visible = true;
        }

        private void save_btn_Click(object sender, EventArgs e)
        {
            SqlCommand crsInsert = new SqlCommand($@"INSERT INTO Course (Crs_Name, Crs_Duration, Top_Id)
                                     VALUES ('{textBox1.Text}', {numericUpDown1.Value}, {comboBox1.SelectedValue});

                                      DECLARE @CrsId INT;
                                      SET @CrsId = SCOPE_IDENTITY();

                                     INSERT INTO Ins_Course (Ins_Id, Crs_Id, Evaluation)
                                     VALUES ({Ins_id}, @CrsId, 'good')", connection);

            SqlCommand crsUpdate = new SqlCommand($"update course set Crs_Name='{textBox1.Text}' , Crs_Duration={numericUpDown1.Value},Top_Id={comboBox1.SelectedValue} where Crs_Id = {selectedId}", connection);

            SqlCommand crsDelete = new SqlCommand($@"delete from Ins_Course where Crs_Id = {selectedId};
                                                     delete from Course where Crs_id = {selectedId}", connection);

            adapter.InsertCommand = crsInsert;
            adapter.UpdateCommand = crsUpdate;
            adapter.DeleteCommand = crsDelete;

            adapter.Update(dt);

            GetCoursesData();
            MessageBox.Show("Data saved");
        }
    }
}
