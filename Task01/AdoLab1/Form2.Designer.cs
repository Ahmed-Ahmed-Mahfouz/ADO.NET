namespace AdoLab1
{
    partial class Form2
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            cb_topic = new ComboBox();
            dgv_courses = new DataGridView();
            textBox1 = new TextBox();
            add_btn = new Button();
            edit_btn = new Button();
            delete_btn = new Button();
            numericUpDown1 = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)dgv_courses).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.WhiteSmoke;
            label1.Location = new Point(71, 127);
            label1.Name = "label1";
            label1.Size = new Size(247, 41);
            label1.TabIndex = 0;
            label1.Text = "Course Duration";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.WhiteSmoke;
            label2.Location = new Point(71, 75);
            label2.Name = "label2";
            label2.Size = new Size(199, 41);
            label2.TabIndex = 1;
            label2.Text = "Course name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.WhiteSmoke;
            label3.Location = new Point(71, 22);
            label3.Name = "label3";
            label3.Size = new Size(197, 41);
            label3.TabIndex = 2;
            label3.Text = "Course Topic";
            // 
            // cb_topic
            // 
            cb_topic.FormattingEnabled = true;
            cb_topic.Location = new Point(348, 36);
            cb_topic.Name = "cb_topic";
            cb_topic.Size = new Size(226, 28);
            cb_topic.TabIndex = 3;
            // 
            // dgv_courses
            // 
            dgv_courses.BackgroundColor = Color.WhiteSmoke;
            dgv_courses.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_courses.Location = new Point(0, 273);
            dgv_courses.Name = "dgv_courses";
            dgv_courses.RowHeadersWidth = 51;
            dgv_courses.Size = new Size(799, 176);
            dgv_courses.TabIndex = 4;
            dgv_courses.RowHeaderMouseDoubleClick += dgv_courses_RowHeaderMouseDoubleClick;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(348, 89);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(226, 27);
            textBox1.TabIndex = 5;
            // 
            // add_btn
            // 
            add_btn.BackColor = Color.WhiteSmoke;
            add_btn.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            add_btn.ForeColor = Color.CadetBlue;
            add_btn.Location = new Point(119, 192);
            add_btn.Name = "add_btn";
            add_btn.Size = new Size(119, 57);
            add_btn.TabIndex = 7;
            add_btn.Text = "Add";
            add_btn.UseVisualStyleBackColor = false;
            add_btn.Click += add_btn_Click;
            // 
            // edit_btn
            // 
            edit_btn.BackColor = Color.WhiteSmoke;
            edit_btn.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            edit_btn.ForeColor = Color.CadetBlue;
            edit_btn.Location = new Point(348, 192);
            edit_btn.Name = "edit_btn";
            edit_btn.Size = new Size(119, 57);
            edit_btn.TabIndex = 8;
            edit_btn.Text = "Edit";
            edit_btn.UseVisualStyleBackColor = false;
            edit_btn.Click += edit_btn_Click;
            // 
            // delete_btn
            // 
            delete_btn.BackColor = Color.WhiteSmoke;
            delete_btn.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            delete_btn.ForeColor = Color.CadetBlue;
            delete_btn.Location = new Point(604, 192);
            delete_btn.Name = "delete_btn";
            delete_btn.Size = new Size(119, 57);
            delete_btn.TabIndex = 9;
            delete_btn.Text = "Delete";
            delete_btn.UseVisualStyleBackColor = false;
            delete_btn.Click += delete_btn_Click;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(348, 142);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(226, 27);
            numericUpDown1.TabIndex = 12;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.CadetBlue;
            ClientSize = new Size(800, 450);
            Controls.Add(numericUpDown1);
            Controls.Add(delete_btn);
            Controls.Add(edit_btn);
            Controls.Add(add_btn);
            Controls.Add(textBox1);
            Controls.Add(dgv_courses);
            Controls.Add(cb_topic);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_courses).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private ComboBox cb_topic;
        private DataGridView dgv_courses;
        private TextBox textBox1;
        private Button add_btn;
        private Button edit_btn;
        private Button delete_btn;
        private NumericUpDown numericUpDown1;
    }
}