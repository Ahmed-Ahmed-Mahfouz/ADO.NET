namespace AdoLab1
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
            password = new TextBox();
            logIn = new Button();
            userName = new TextBox();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // password
            // 
            password.Location = new Point(313, 220);
            password.Name = "password";
            password.Size = new Size(278, 27);
            password.TabIndex = 1;
            password.UseSystemPasswordChar = true;
            // 
            // logIn
            // 
            logIn.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            logIn.ForeColor = Color.CadetBlue;
            logIn.Location = new Point(354, 304);
            logIn.Name = "logIn";
            logIn.Size = new Size(159, 53);
            logIn.TabIndex = 1;
            logIn.Text = "Log in";
            logIn.UseVisualStyleBackColor = true;
            logIn.Click += logIn_Click;
            // 
            // userName
            // 
            userName.Location = new Point(313, 144);
            userName.Name = "userName";
            userName.Size = new Size(278, 27);
            userName.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.WhiteSmoke;
            label1.Location = new Point(118, 130);
            label1.Name = "label1";
            label1.Size = new Size(172, 41);
            label1.TabIndex = 3;
            label1.Text = "User Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.WhiteSmoke;
            label2.Location = new Point(118, 206);
            label2.Name = "label2";
            label2.Size = new Size(150, 41);
            label2.TabIndex = 4;
            label2.Text = "Password";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.CadetBlue;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(userName);
            Controls.Add(logIn);
            Controls.Add(password);
            ForeColor = Color.Black;
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox password;
        private Button logIn;
        private TextBox userName;
        private Label label1;
        private Label label2;
    }
}
