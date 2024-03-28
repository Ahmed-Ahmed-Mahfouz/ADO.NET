namespace AdoLab2
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
            dataGridView1 = new DataGridView();
            add_btn = new Button();
            edit_btn = new Button();
            delete_btn = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBox1 = new TextBox();
            numericUpDown1 = new NumericUpDown();
            comboBox1 = new ComboBox();
            save_btn = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(-1, 256);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(802, 193);
            dataGridView1.TabIndex = 0;
            dataGridView1.RowHeaderMouseDoubleClick += dataGridView1_RowHeaderMouseDoubleClick;
            // 
            // add_btn
            // 
            add_btn.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            add_btn.Location = new Point(106, 186);
            add_btn.Name = "add_btn";
            add_btn.Size = new Size(120, 54);
            add_btn.TabIndex = 1;
            add_btn.Text = "Add";
            add_btn.UseVisualStyleBackColor = true;
            add_btn.Click += add_btn_Click;
            // 
            // edit_btn
            // 
            edit_btn.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            edit_btn.Location = new Point(347, 186);
            edit_btn.Name = "edit_btn";
            edit_btn.Size = new Size(120, 54);
            edit_btn.TabIndex = 2;
            edit_btn.Text = "Edit";
            edit_btn.UseVisualStyleBackColor = true;
            edit_btn.Click += edit_btn_Click;
            // 
            // delete_btn
            // 
            delete_btn.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            delete_btn.Location = new Point(608, 186);
            delete_btn.Name = "delete_btn";
            delete_btn.Size = new Size(120, 53);
            delete_btn.TabIndex = 3;
            delete_btn.Text = "Delete";
            delete_btn.UseVisualStyleBackColor = true;
            delete_btn.Click += delete_btn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(59, 25);
            label1.Name = "label1";
            label1.Size = new Size(205, 41);
            label1.TabIndex = 4;
            label1.Text = "Course Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(59, 77);
            label2.Name = "label2";
            label2.Size = new Size(247, 41);
            label2.TabIndex = 5;
            label2.Text = "Course Duration";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(59, 129);
            label3.Name = "label3";
            label3.Size = new Size(184, 41);
            label3.TabIndex = 6;
            label3.Text = "Topic Name";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(315, 39);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(194, 27);
            textBox1.TabIndex = 7;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(315, 92);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(194, 27);
            numericUpDown1.TabIndex = 8;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(315, 142);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(194, 28);
            comboBox1.TabIndex = 9;
            // 
            // save_btn
            // 
            save_btn.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            save_btn.Location = new Point(546, 60);
            save_btn.Name = "save_btn";
            save_btn.Size = new Size(221, 74);
            save_btn.TabIndex = 10;
            save_btn.Text = "Save Changes";
            save_btn.UseVisualStyleBackColor = true;
            save_btn.Click += save_btn_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(800, 450);
            Controls.Add(save_btn);
            Controls.Add(comboBox1);
            Controls.Add(numericUpDown1);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(delete_btn);
            Controls.Add(edit_btn);
            Controls.Add(add_btn);
            Controls.Add(dataGridView1);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button add_btn;
        private Button edit_btn;
        private Button delete_btn;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBox1;
        private NumericUpDown numericUpDown1;
        private ComboBox comboBox1;
        private Button save_btn;
    }
}