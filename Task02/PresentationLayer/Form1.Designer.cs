namespace PresentationLayer
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
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
            label4 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            numericUpDown1 = new NumericUpDown();
            comboBox1 = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(353, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(584, 451);
            dataGridView1.TabIndex = 0;
            dataGridView1.RowHeaderMouseDoubleClick += dataGridView1_RowHeaderMouseDoubleClick;
            // 
            // add_btn
            // 
            add_btn.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            add_btn.ForeColor = Color.DarkSlateGray;
            add_btn.Location = new Point(90, 321);
            add_btn.Name = "add_btn";
            add_btn.Size = new Size(169, 56);
            add_btn.TabIndex = 1;
            add_btn.Text = "Add";
            add_btn.UseVisualStyleBackColor = true;
            add_btn.Click += add_btn_Click;
            // 
            // edit_btn
            // 
            edit_btn.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            edit_btn.ForeColor = Color.DarkSlateGray;
            edit_btn.Location = new Point(36, 383);
            edit_btn.Name = "edit_btn";
            edit_btn.Size = new Size(139, 56);
            edit_btn.TabIndex = 2;
            edit_btn.Text = "Edit";
            edit_btn.UseVisualStyleBackColor = true;
            edit_btn.Click += edit_btn_Click;
            // 
            // delete_btn
            // 
            delete_btn.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            delete_btn.ForeColor = Color.DarkSlateGray;
            delete_btn.Location = new Point(181, 383);
            delete_btn.Name = "delete_btn";
            delete_btn.Size = new Size(139, 56);
            delete_btn.TabIndex = 3;
            delete_btn.Text = "Delete";
            delete_btn.UseVisualStyleBackColor = true;
            delete_btn.Click += delete_btn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.WhiteSmoke;
            label1.Location = new Point(39, 9);
            label1.Name = "label1";
            label1.Size = new Size(101, 41);
            label1.TabIndex = 5;
            label1.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.WhiteSmoke;
            label2.Location = new Point(39, 86);
            label2.Name = "label2";
            label2.Size = new Size(119, 41);
            label2.TabIndex = 6;
            label2.Text = "Degree";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.WhiteSmoke;
            label3.Location = new Point(39, 160);
            label3.Name = "label3";
            label3.Size = new Size(105, 41);
            label3.TabIndex = 7;
            label3.Text = "Salary";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.WhiteSmoke;
            label4.Location = new Point(39, 234);
            label4.Name = "label4";
            label4.Size = new Size(189, 41);
            label4.TabIndex = 8;
            label4.Text = "Department";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(39, 56);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(275, 27);
            textBox1.TabIndex = 9;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(39, 130);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(275, 27);
            textBox2.TabIndex = 10;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(39, 204);
            numericUpDown1.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(275, 27);
            numericUpDown1.TabIndex = 11;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(39, 278);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(275, 28);
            comboBox1.TabIndex = 12;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateGray;
            ClientSize = new Size(938, 451);
            Controls.Add(comboBox1);
            Controls.Add(numericUpDown1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(delete_btn);
            Controls.Add(edit_btn);
            Controls.Add(add_btn);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
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
        private Label label4;
        private TextBox textBox1;
        private TextBox textBox2;
        private NumericUpDown numericUpDown1;
        private ComboBox comboBox1;
    }
}
