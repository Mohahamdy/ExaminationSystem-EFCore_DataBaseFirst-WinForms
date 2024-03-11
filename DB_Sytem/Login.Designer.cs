namespace DB_Sytem
{
    partial class Login
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
			txt_name = new TextBox();
			label1 = new Label();
			label2 = new Label();
			btn_login = new Button();
			rad_stud = new RadioButton();
			rad_ins = new RadioButton();
			panel1 = new Panel();
			label4 = new Label();
			label5 = new Label();
			label3 = new Label();
			pictureBox1 = new PictureBox();
			panel2 = new Panel();
			txt_pass = new TextBox();
			panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
			panel2.SuspendLayout();
			SuspendLayout();
			// 
			// txt_name
			// 
			txt_name.Font = new Font("Segoe UI", 12F);
			txt_name.Location = new Point(398, 159);
			txt_name.Name = "txt_name";
			txt_name.Size = new Size(264, 29);
			txt_name.TabIndex = 0;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
			label1.ForeColor = Color.FromArgb(41, 128, 185);
			label1.Location = new Point(398, 131);
			label1.Name = "label1";
			label1.Size = new Size(64, 25);
			label1.TabIndex = 1;
			label1.Text = "Name";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
			label2.ForeColor = Color.FromArgb(41, 128, 185);
			label2.Location = new Point(398, 222);
			label2.Name = "label2";
			label2.Size = new Size(97, 25);
			label2.TabIndex = 3;
			label2.Text = "Password";
			// 
			// btn_login
			// 
			btn_login.BackColor = Color.FromArgb(41, 128, 185);
			btn_login.FlatStyle = FlatStyle.Flat;
			btn_login.Font = new Font("Segoe UI", 12F);
			btn_login.ForeColor = Color.White;
			btn_login.Location = new Point(454, 373);
			btn_login.Name = "btn_login";
			btn_login.Size = new Size(155, 38);
			btn_login.TabIndex = 4;
			btn_login.Text = "Login";
			btn_login.UseVisualStyleBackColor = false;
			btn_login.Click += btn_login_Click;
			// 
			// rad_stud
			// 
			rad_stud.AutoSize = true;
			rad_stud.Font = new Font("Segoe UI", 12F);
			rad_stud.ForeColor = Color.FromArgb(41, 128, 185);
			rad_stud.Location = new Point(425, 306);
			rad_stud.Name = "rad_stud";
			rad_stud.Size = new Size(81, 25);
			rad_stud.TabIndex = 5;
			rad_stud.TabStop = true;
			rad_stud.Text = "Student";
			rad_stud.UseVisualStyleBackColor = true;
			// 
			// rad_ins
			// 
			rad_ins.AutoSize = true;
			rad_ins.Font = new Font("Segoe UI", 12F);
			rad_ins.Location = new Point(547, 306);
			rad_ins.Name = "rad_ins";
			rad_ins.Size = new Size(95, 25);
			rad_ins.TabIndex = 6;
			rad_ins.TabStop = true;
			rad_ins.Text = "Instructor";
			rad_ins.UseVisualStyleBackColor = true;
			// 
			// panel1
			// 
			panel1.BackColor = Color.FromArgb(41, 128, 185);
			panel1.Controls.Add(label4);
			panel1.Controls.Add(label5);
			panel1.Controls.Add(label3);
			panel1.Controls.Add(pictureBox1);
			panel1.Dock = DockStyle.Left;
			panel1.Location = new Point(0, 0);
			panel1.Name = "panel1";
			panel1.Size = new Size(300, 530);
			panel1.TabIndex = 7;
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label4.ForeColor = Color.White;
			label4.Location = new Point(32, 306);
			label4.Name = "label4";
			label4.Size = new Size(243, 28);
			label4.TabIndex = 1;
			label4.Text = "Examination System";
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Font = new Font("Century Gothic", 10F, FontStyle.Bold);
			label5.ForeColor = Color.White;
			label5.Location = new Point(253, 489);
			label5.Name = "label5";
			label5.Size = new Size(22, 17);
			label5.TabIndex = 1;
			label5.Text = "ITI";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Font = new Font("Century Gothic", 13F, FontStyle.Bold);
			label3.ForeColor = Color.White;
			label3.Location = new Point(68, 263);
			label3.Name = "label3";
			label3.Size = new Size(156, 22);
			label3.TabIndex = 1;
			label3.Text = "Welcome To The";
			// 
			// pictureBox1
			// 
			pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
			pictureBox1.Location = new Point(73, 33);
			pictureBox1.Name = "pictureBox1";
			pictureBox1.Size = new Size(151, 144);
			pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
			pictureBox1.TabIndex = 0;
			pictureBox1.TabStop = false;
			// 
			// panel2
			// 
			panel2.Controls.Add(txt_pass);
			panel2.Controls.Add(label2);
			panel2.Controls.Add(btn_login);
			panel2.Controls.Add(rad_ins);
			panel2.Controls.Add(label1);
			panel2.Controls.Add(rad_stud);
			panel2.Controls.Add(txt_name);
			panel2.ForeColor = Color.FromArgb(41, 128, 185);
			panel2.Location = new Point(0, 0);
			panel2.Name = "panel2";
			panel2.Size = new Size(750, 530);
			panel2.TabIndex = 0;
			// 
			// txt_pass
			// 
			txt_pass.Font = new Font("Segoe UI", 12F);
			txt_pass.Location = new Point(398, 250);
			txt_pass.Name = "txt_pass";
			txt_pass.PasswordChar = '*';
			txt_pass.Size = new Size(264, 29);
			txt_pass.TabIndex = 2;
			// 
			// Login
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			AutoSize = true;
			ClientSize = new Size(750, 530);
			Controls.Add(panel1);
			Controls.Add(panel2);
			Name = "Login";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Login";
			panel1.ResumeLayout(false);
			panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
			panel2.ResumeLayout(false);
			panel2.PerformLayout();
			ResumeLayout(false);
		}

		#endregion

		private TextBox txt_name;
        private Label label1;
        private Label label2;
        private Button btn_login;
        private RadioButton rad_stud;
        private RadioButton rad_ins;
        private Panel panel1;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Label label3;
        private Label label4;
		private Label label5;
		private TextBox txt_pass;
	}
}
