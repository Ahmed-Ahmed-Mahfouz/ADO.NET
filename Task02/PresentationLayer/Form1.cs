using BusinessLayer;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = InstructorService.GetAll();
            comboBox1.DataSource = DepartmentService.GetAll();
            comboBox1.DisplayMember = "Dept_Name";
            comboBox1.ValueMember = "Dept_Id";
            comboBox1.SelectedIndex = -1;
            dataGridView1.Columns["Ins_id"].Visible = false;
            delete_btn.Visible = false;
            edit_btn.Visible = false;
        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text) || comboBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Please enter instructor name and select a department before adding.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Instructor ins = new Instructor()
            {
                Ins_name = textBox1.Text,
                Ins_degree = textBox2.Text,
                Salary = (int)numericUpDown1.Value,
                Dept_Id = (int)comboBox1.SelectedValue
            };

            int rowsEffected = InstructorService.Insert(ins);
            if (rowsEffected > 0)
            {
                MessageBox.Show("Data added");
                dataGridView1.DataSource = InstructorService.GetAll();
                comboBox1.DataSource = DepartmentService.GetAll();
                comboBox1.DisplayMember = "Dept_Name";
                comboBox1.ValueMember = "Dept_Id";
            }
        }

        private void edit_btn_Click(object sender, EventArgs e)
        {
            Instructor ins = new Instructor()
            {
                Ins_id = selectedId,
                Ins_name = textBox1.Text,
                Ins_degree = textBox2.Text,
                Salary = numericUpDown1.Value,
                Dept_Id = (int)comboBox1.SelectedValue
            };

            int rowsEffected = InstructorService.Update(ins);
            if (rowsEffected > 0)
            {
                MessageBox.Show("Data Updated");
                dataGridView1.DataSource = InstructorService.GetAll();
                comboBox1.DataSource = DepartmentService.GetAll();
                comboBox1.DisplayMember = "Dept_Name";
                comboBox1.ValueMember = "Dept_Id";
            }
            delete_btn.Visible = false;
            edit_btn.Visible = false;
            add_btn.Visible = true;
        }

        private void delete_btn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure?", "Delete", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                int rowsEffected = InstructorService.Delete(selectedId);
                if (rowsEffected > 0)
                {
                    MessageBox.Show("Data deleted");
                    dataGridView1.DataSource = InstructorService.GetAll();
                    comboBox1.DataSource = DepartmentService.GetAll();
                    comboBox1.DisplayMember = "Dept_Name";
                    comboBox1.ValueMember = "Dept_Id";
                }
                delete_btn.Visible = false;
                edit_btn.Visible = false;
                add_btn.Visible = true;
            }
        }
        int selectedId = 0;
        private void dataGridView1_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewCellCollection cells = ((DataGridView)sender).SelectedRows[0].Cells;
            selectedId = (int)cells["Ins_id"].Value;
            numericUpDown1.Value = (decimal)cells["Salary"].Value;
            comboBox1.SelectedValue = (int)cells["Dept_Id"].Value;
            textBox1.Text = cells["Ins_name"].Value.ToString();
            textBox2.Text = cells["Ins_degree"].Value.ToString();
            delete_btn.Visible = true;
            edit_btn.Visible = true;
            add_btn.Visible = false;
        }
    }
}
