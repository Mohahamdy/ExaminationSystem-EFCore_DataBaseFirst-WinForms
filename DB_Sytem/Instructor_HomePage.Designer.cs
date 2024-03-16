namespace DB_Sytem
{
	partial class Instructor_HomePage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Instructor_HomePage));
            btn_allExams = new Button();
            btn_createExam = new Button();
            btn_answers = new Button();
            btn_studentsGrades = new Button();
            lbl_logout = new Label();
            lbl_insName = new Label();
            btn_createQues = new Button();
            PB_logout = new PictureBox();
            btn_student = new Button();
            btn_stdCrs = new Button();
            ((System.ComponentModel.ISupportInitialize)PB_logout).BeginInit();
            SuspendLayout();
            // 
            // btn_allExams
            // 
            btn_allExams.BackColor = Color.FromArgb(41, 128, 185);
            btn_allExams.FlatStyle = FlatStyle.Flat;
            btn_allExams.ForeColor = Color.White;
            btn_allExams.Location = new Point(116, 214);
            btn_allExams.Name = "btn_allExams";
            btn_allExams.Size = new Size(189, 34);
            btn_allExams.TabIndex = 1;
            btn_allExams.Text = "Show All Exams";
            btn_allExams.UseVisualStyleBackColor = false;
            btn_allExams.Click += btn_allExams_Click;
            // 
            // btn_createExam
            // 
            btn_createExam.BackColor = Color.FromArgb(41, 128, 185);
            btn_createExam.FlatStyle = FlatStyle.Flat;
            btn_createExam.ForeColor = Color.White;
            btn_createExam.Location = new Point(116, 254);
            btn_createExam.Name = "btn_createExam";
            btn_createExam.Size = new Size(189, 34);
            btn_createExam.TabIndex = 1;
            btn_createExam.Text = "Create Exam";
            btn_createExam.UseVisualStyleBackColor = false;
            btn_createExam.Click += btn_createExam_Click;
            // 
            // btn_answers
            // 
            btn_answers.BackColor = Color.FromArgb(41, 128, 185);
            btn_answers.FlatStyle = FlatStyle.Flat;
            btn_answers.ForeColor = Color.White;
            btn_answers.Location = new Point(116, 334);
            btn_answers.Name = "btn_answers";
            btn_answers.Size = new Size(189, 34);
            btn_answers.TabIndex = 1;
            btn_answers.Text = "Students Answers";
            btn_answers.UseVisualStyleBackColor = false;
            btn_answers.Click += btn_answers_Click;
            // 
            // btn_studentsGrades
            // 
            btn_studentsGrades.BackColor = Color.FromArgb(41, 128, 185);
            btn_studentsGrades.FlatStyle = FlatStyle.Flat;
            btn_studentsGrades.ForeColor = Color.White;
            btn_studentsGrades.Location = new Point(116, 374);
            btn_studentsGrades.Name = "btn_studentsGrades";
            btn_studentsGrades.Size = new Size(189, 34);
            btn_studentsGrades.TabIndex = 1;
            btn_studentsGrades.Text = "Students Grades";
            btn_studentsGrades.UseVisualStyleBackColor = false;
            btn_studentsGrades.Click += btn_studentsGrades_Click;
            // 
            // lbl_logout
            // 
            lbl_logout.AutoSize = true;
            lbl_logout.Cursor = Cursors.Hand;
            lbl_logout.ForeColor = Color.Crimson;
            lbl_logout.Location = new Point(30, 9);
            lbl_logout.Name = "lbl_logout";
            lbl_logout.Size = new Size(50, 15);
            lbl_logout.TabIndex = 35;
            lbl_logout.Text = "Log Out";
            lbl_logout.Click += lbl_logout_Click;
            // 
            // lbl_insName
            // 
            lbl_insName.AutoSize = true;
            lbl_insName.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_insName.ForeColor = Color.FromArgb(41, 128, 185);
            lbl_insName.Location = new Point(12, 67);
            lbl_insName.Name = "lbl_insName";
            lbl_insName.Size = new Size(284, 30);
            lbl_insName.TabIndex = 12;
            lbl_insName.Text = "Welcome Instructor's Name";
            lbl_insName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btn_createQues
            // 
            btn_createQues.BackColor = Color.FromArgb(41, 128, 185);
            btn_createQues.FlatStyle = FlatStyle.Flat;
            btn_createQues.ForeColor = Color.White;
            btn_createQues.Location = new Point(116, 294);
            btn_createQues.Name = "btn_createQues";
            btn_createQues.Size = new Size(189, 34);
            btn_createQues.TabIndex = 1;
            btn_createQues.Text = "Create and Update Questions";
            btn_createQues.UseVisualStyleBackColor = false;
            btn_createQues.Click += btn_createQues_Click;
            // 
            // PB_logout
            // 
            PB_logout.BackColor = SystemColors.ButtonFace;
            PB_logout.BackgroundImage = (Image)resources.GetObject("PB_logout.BackgroundImage");
            PB_logout.BackgroundImageLayout = ImageLayout.Zoom;
            PB_logout.Cursor = Cursors.Hand;
            PB_logout.Image = (Image)resources.GetObject("PB_logout.Image");
            PB_logout.Location = new Point(9, 6);
            PB_logout.Name = "PB_logout";
            PB_logout.Size = new Size(20, 20);
            PB_logout.TabIndex = 36;
            PB_logout.TabStop = false;
            // 
            // btn_student
            // 
            btn_student.BackColor = Color.FromArgb(41, 128, 185);
            btn_student.FlatStyle = FlatStyle.Flat;
            btn_student.ForeColor = Color.White;
            btn_student.Location = new Point(116, 134);
            btn_student.Name = "btn_student";
            btn_student.Size = new Size(189, 34);
            btn_student.TabIndex = 37;
            btn_student.Text = "Students";
            btn_student.UseVisualStyleBackColor = false;
            btn_student.Click += btn_student_Click;
            // 
            // btn_stdCrs
            // 
            btn_stdCrs.BackColor = Color.FromArgb(41, 128, 185);
            btn_stdCrs.FlatStyle = FlatStyle.Flat;
            btn_stdCrs.ForeColor = Color.White;
            btn_stdCrs.Location = new Point(116, 174);
            btn_stdCrs.Name = "btn_stdCrs";
            btn_stdCrs.Size = new Size(189, 34);
            btn_stdCrs.TabIndex = 38;
            btn_stdCrs.Text = "Students Courses";
            btn_stdCrs.UseVisualStyleBackColor = false;
            btn_stdCrs.Click += btn_stdCrs_Click;
            // 
            // Instructor_HomePage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(418, 415);
            Controls.Add(btn_stdCrs);
            Controls.Add(btn_student);
            Controls.Add(PB_logout);
            Controls.Add(lbl_logout);
            Controls.Add(lbl_insName);
            Controls.Add(btn_studentsGrades);
            Controls.Add(btn_createQues);
            Controls.Add(btn_answers);
            Controls.Add(btn_createExam);
            Controls.Add(btn_allExams);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Instructor_HomePage";
            Text = "Instructor_HomePage";
            Load += Instructor_HomePage_Load;
            ((System.ComponentModel.ISupportInitialize)PB_logout).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_allExams;
		private Button btn_createExam;
		private Button btn_answers;
		private Button btn_studentsGrades;
		private Label lbl_logout;
		private Label lbl_insName;
		private Button btn_createQues;
        private PictureBox PB_logout;
        private Button btn_student;
        private Button btn_stdCrs;
        //private Label lbl_logout;
    }
}