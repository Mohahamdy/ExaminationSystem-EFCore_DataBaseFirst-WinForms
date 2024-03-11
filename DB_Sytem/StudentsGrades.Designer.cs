namespace DB_Sytem
{
	partial class StudentsGrades
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentsGrades));
            btn_show = new Button();
            dgv_ExamGrades = new DataGridView();
            label2 = new Label();
            Department = new Label();
            cb_courses = new ComboBox();
            cb_departments = new ComboBox();
            lbl_backtohome = new Label();
            PB_logout = new PictureBox();
            lbl_logout = new Label();
            ((System.ComponentModel.ISupportInitialize)dgv_ExamGrades).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PB_logout).BeginInit();
            SuspendLayout();
            // 
            // btn_show
            // 
            btn_show.BackColor = Color.FromArgb(41, 128, 185);
            btn_show.FlatStyle = FlatStyle.Flat;
            btn_show.ForeColor = Color.White;
            btn_show.Location = new Point(488, 67);
            btn_show.Name = "btn_show";
            btn_show.Size = new Size(120, 34);
            btn_show.TabIndex = 18;
            btn_show.Text = "Show";
            btn_show.UseVisualStyleBackColor = false;
            // 
            // dgv_ExamGrades
            // 
            dgv_ExamGrades.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_ExamGrades.Location = new Point(33, 117);
            dgv_ExamGrades.Name = "dgv_ExamGrades";
            dgv_ExamGrades.Size = new Size(575, 307);
            dgv_ExamGrades.TabIndex = 17;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F);
            label2.ForeColor = Color.FromArgb(41, 128, 185);
            label2.Location = new Point(31, 49);
            label2.Name = "label2";
            label2.Size = new Size(52, 19);
            label2.TabIndex = 15;
            label2.Text = "Course";
            // 
            // Department
            // 
            Department.AutoSize = true;
            Department.Font = new Font("Segoe UI", 10F);
            Department.ForeColor = Color.FromArgb(41, 128, 185);
            Department.Location = new Point(242, 49);
            Department.Name = "Department";
            Department.Size = new Size(83, 19);
            Department.TabIndex = 16;
            Department.Text = "Department";
            // 
            // cb_courses
            // 
            cb_courses.Font = new Font("Segoe UI", 12F);
            cb_courses.FormattingEnabled = true;
            cb_courses.Location = new Point(33, 72);
            cb_courses.Name = "cb_courses";
            cb_courses.Size = new Size(203, 29);
            cb_courses.TabIndex = 13;
            // 
            // cb_departments
            // 
            cb_departments.Font = new Font("Segoe UI", 12F);
            cb_departments.FormattingEnabled = true;
            cb_departments.Location = new Point(242, 72);
            cb_departments.Name = "cb_departments";
            cb_departments.Size = new Size(203, 29);
            cb_departments.TabIndex = 14;
            // 
            // lbl_backtohome
            // 
            lbl_backtohome.AutoSize = true;
            lbl_backtohome.Cursor = Cursors.Hand;
            lbl_backtohome.Location = new Point(12, 9);
            lbl_backtohome.Name = "lbl_backtohome";
            lbl_backtohome.Size = new Size(102, 15);
            lbl_backtohome.TabIndex = 19;
            lbl_backtohome.Text = "<< Back To Home";
            lbl_backtohome.Click += lbl_backtohome_Click;
            // 
            // PB_logout
            // 
            PB_logout.BackColor = SystemColors.ButtonFace;
            PB_logout.BackgroundImage = (Image)resources.GetObject("PB_logout.BackgroundImage");
            PB_logout.BackgroundImageLayout = ImageLayout.Zoom;
            PB_logout.Cursor = Cursors.Hand;
            PB_logout.Image = (Image)resources.GetObject("PB_logout.Image");
            PB_logout.Location = new Point(537, 6);
            PB_logout.Name = "PB_logout";
            PB_logout.Size = new Size(20, 20);
            PB_logout.TabIndex = 36;
            PB_logout.TabStop = false;
            // 
            // lbl_logout
            // 
            lbl_logout.AutoSize = true;
            lbl_logout.Cursor = Cursors.Hand;
            lbl_logout.ForeColor = Color.Crimson;
            lbl_logout.Location = new Point(558, 9);
            lbl_logout.Name = "lbl_logout";
            lbl_logout.Size = new Size(50, 15);
            lbl_logout.TabIndex = 35;
            lbl_logout.Text = "Log Out";
			lbl_logout.Click += lbl_logout_Click;
            // 
            // StudentsGrades
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(640, 450);
            Controls.Add(PB_logout);
            Controls.Add(lbl_logout);
            Controls.Add(lbl_backtohome);
            Controls.Add(btn_show);
            Controls.Add(dgv_ExamGrades);
            Controls.Add(label2);
            Controls.Add(Department);
            Controls.Add(cb_courses);
            Controls.Add(cb_departments);
            Name = "StudentsGrades";
            Text = "StudentsGrades";
            ((System.ComponentModel.ISupportInitialize)dgv_ExamGrades).EndInit();
            ((System.ComponentModel.ISupportInitialize)PB_logout).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_show;
		private DataGridView dgv_ExamGrades;
		private Label label2;
		private Label Department;
		private ComboBox cb_courses;
		private ComboBox cb_departments;
		private Label lbl_backtohome;
        private PictureBox PB_logout;
        private Label lbl_logout;
    }
}