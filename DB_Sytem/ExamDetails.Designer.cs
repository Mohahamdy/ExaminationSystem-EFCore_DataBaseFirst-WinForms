namespace DB_Sytem
{
    partial class ExamDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExamDetails));
            dgv_ExamQuestionsMCQ = new DataGridView();
            cb_courseExams = new ComboBox();
            label2 = new Label();
            lbl_backtohome = new Label();
            btn_showExam = new Button();
            lbl_logout = new Label();
            dgv_ExamQuestionsTF = new DataGridView();
            groupBox1 = new GroupBox();
            label8 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            lbl_numOfStudents = new Label();
            lbl_course = new Label();
            lbl_duration = new Label();
            lbl_time = new Label();
            lbl_date = new Label();
            lbl_id = new Label();
            label1 = new Label();
            cb_courses = new ComboBox();
            label7 = new Label();
            PB_logout = new PictureBox();
            lbl_msg = new Label();
            ((System.ComponentModel.ISupportInitialize)dgv_ExamQuestionsMCQ).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgv_ExamQuestionsTF).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PB_logout).BeginInit();
            SuspendLayout();
            // 
            // dgv_ExamQuestionsMCQ
            // 
            dgv_ExamQuestionsMCQ.AllowUserToResizeRows = false;
            dgv_ExamQuestionsMCQ.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_ExamQuestionsMCQ.BackgroundColor = SystemColors.Control;
            dgv_ExamQuestionsMCQ.BorderStyle = BorderStyle.None;
            dgv_ExamQuestionsMCQ.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_ExamQuestionsMCQ.Location = new Point(26, 121);
            dgv_ExamQuestionsMCQ.Name = "dgv_ExamQuestionsMCQ";
            dgv_ExamQuestionsMCQ.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dgv_ExamQuestionsMCQ.Size = new Size(574, 199);
            dgv_ExamQuestionsMCQ.TabIndex = 10;
            dgv_ExamQuestionsMCQ.Tag = "";
            // 
            // cb_courseExams
            // 
            cb_courseExams.Font = new Font("Segoe UI", 12F);
            cb_courseExams.FormattingEnabled = true;
            cb_courseExams.Location = new Point(268, 73);
            cb_courseExams.Name = "cb_courseExams";
            cb_courseExams.Size = new Size(234, 29);
            cb_courseExams.TabIndex = 8;
            // 
            // dgv_ExamQuestions
            // 
            //dgv_ExamQuestions.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            //dgv_ExamQuestions.Location = new Point(27, 118);
            //dgv_ExamQuestions.Name = "dgv_ExamQuestions";
            //dgv_ExamQuestions.Size = new Size(575, 307);
            //dgv_ExamQuestions.TabIndex = 10;
            // 
            // cb_courses
            // 
            cb_courses.Font = new Font("Segoe UI", 12F);
            cb_courses.FormattingEnabled = true;
            cb_courses.Location = new Point(27, 73);
            cb_courses.Name = "cb_courses";
            cb_courses.Size = new Size(203, 29);
            cb_courses.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F);
            label2.ForeColor = Color.FromArgb(41, 128, 185);
            label2.Location = new Point(268, 51);
            label2.Name = "label2";
            label2.Size = new Size(47, 19);
            label2.TabIndex = 9;
            label2.Text = "Exams";
            // 
            // lbl_backtohome
            // 
            lbl_backtohome.AutoSize = true;
            lbl_backtohome.Cursor = Cursors.Hand;
            lbl_backtohome.Location = new Point(12, 9);
            lbl_backtohome.Name = "lbl_backtohome";
            lbl_backtohome.Size = new Size(102, 15);
            lbl_backtohome.TabIndex = 11;
            lbl_backtohome.Text = "<< Back To Home";
            lbl_backtohome.Click += lbl_backtohome_Click;
            // 
            // btn_showExam
            // 
            btn_showExam.BackColor = Color.FromArgb(41, 128, 185);
            btn_showExam.FlatStyle = FlatStyle.Flat;
            btn_showExam.ForeColor = Color.White;
            btn_showExam.Location = new Point(508, 73);
            btn_showExam.Name = "btn_showExam";
            btn_showExam.Size = new Size(92, 29);
            btn_showExam.TabIndex = 12;
            btn_showExam.Text = "Show";
            btn_showExam.UseVisualStyleBackColor = false;
            btn_showExam.Click += btn_showExam_Click;
            // 
            // lbl_logout
            // 
            lbl_logout.AutoSize = true;
            lbl_logout.Cursor = Cursors.Hand;
            lbl_logout.ForeColor = Color.Crimson;
            lbl_logout.Location = new Point(778, 9);
            lbl_logout.Name = "lbl_logout";
            lbl_logout.Size = new Size(50, 15);
            lbl_logout.TabIndex = 28;
            lbl_logout.Text = "Log Out";
            lbl_logout.Click += lbl_logout_Click;
            // 
            // dgv_ExamQuestionsTF
            // 
            dgv_ExamQuestionsTF.AllowUserToResizeRows = false;
            dgv_ExamQuestionsTF.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_ExamQuestionsTF.BackgroundColor = SystemColors.Control;
            dgv_ExamQuestionsTF.BorderStyle = BorderStyle.None;
            dgv_ExamQuestionsTF.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_ExamQuestionsTF.Location = new Point(25, 326);
            dgv_ExamQuestionsTF.Name = "dgv_ExamQuestionsTF";
            dgv_ExamQuestionsTF.Size = new Size(575, 191);
            dgv_ExamQuestionsTF.TabIndex = 10;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(lbl_numOfStudents);
            groupBox1.Controls.Add(lbl_course);
            groupBox1.Controls.Add(lbl_duration);
            groupBox1.Controls.Add(lbl_time);
            groupBox1.Controls.Add(lbl_date);
            groupBox1.Controls.Add(lbl_id);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(628, 114);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(200, 403);
            groupBox1.TabIndex = 29;
            groupBox1.TabStop = false;
            groupBox1.Text = "Exam Info";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(10, 331);
            label8.Name = "label8";
            label8.Size = new Size(129, 15);
            label8.TabIndex = 0;
            label8.Text = "Number Of Students :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(10, 267);
            label6.Name = "label6";
            label6.Size = new Size(51, 15);
            label6.TabIndex = 0;
            label6.Text = "Course :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(10, 205);
            label5.Name = "label5";
            label5.Size = new Size(62, 15);
            label5.TabIndex = 0;
            label5.Text = "Duration :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(11, 147);
            label4.Name = "label4";
            label4.Size = new Size(41, 15);
            label4.TabIndex = 0;
            label4.Text = "Time :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(11, 84);
            label3.Name = "label3";
            label3.Size = new Size(40, 15);
            label3.TabIndex = 0;
            label3.Text = "Date :";
            // 
            // lbl_numOfStudents
            // 
            lbl_numOfStudents.AutoSize = true;
            lbl_numOfStudents.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_numOfStudents.Location = new Point(59, 357);
            lbl_numOfStudents.Name = "lbl_numOfStudents";
            lbl_numOfStudents.Size = new Size(92, 15);
            lbl_numOfStudents.TabIndex = 0;
            lbl_numOfStudents.Text = "_________________";
            // 
            // lbl_course
            // 
            lbl_course.AutoSize = true;
            lbl_course.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_course.Location = new Point(59, 288);
            lbl_course.Name = "lbl_course";
            lbl_course.Size = new Size(92, 15);
            lbl_course.TabIndex = 0;
            lbl_course.Text = "_________________";
            // 
            // lbl_duration
            // 
            lbl_duration.AutoSize = true;
            lbl_duration.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_duration.Location = new Point(59, 227);
            lbl_duration.Name = "lbl_duration";
            lbl_duration.Size = new Size(92, 15);
            lbl_duration.TabIndex = 0;
            lbl_duration.Text = "_________________";
            // 
            // lbl_time
            // 
            lbl_time.AutoSize = true;
            lbl_time.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_time.Location = new Point(59, 171);
            lbl_time.Name = "lbl_time";
            lbl_time.Size = new Size(92, 15);
            lbl_time.TabIndex = 0;
            lbl_time.Text = "_________________";
            // 
            // lbl_date
            // 
            lbl_date.AutoSize = true;
            lbl_date.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_date.Location = new Point(59, 111);
            lbl_date.Name = "lbl_date";
            lbl_date.Size = new Size(92, 15);
            lbl_date.TabIndex = 0;
            lbl_date.Text = "_________________";
            // 
            // lbl_id
            // 
            lbl_id.AutoSize = true;
            lbl_id.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_id.Location = new Point(59, 60);
            lbl_id.Name = "lbl_id";
            lbl_id.Size = new Size(92, 15);
            lbl_id.TabIndex = 0;
            lbl_id.Text = "_________________";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(11, 35);
            label1.Name = "label1";
            label1.Size = new Size(26, 15);
            label1.TabIndex = 0;
            label1.Text = "ID :";
            // 
            // cb_courses
            // 
            cb_courses.Font = new Font("Segoe UI", 12F);
            cb_courses.FormattingEnabled = true;
            cb_courses.Location = new Point(26, 73);
            cb_courses.Name = "cb_courses";
            cb_courses.Size = new Size(236, 29);
            cb_courses.TabIndex = 8;
            cb_courses.SelectionChangeCommitted += cb_courses_SelectionChangeCommitted;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10F);
            label7.ForeColor = Color.FromArgb(41, 128, 185);
            label7.Location = new Point(26, 51);
            label7.Name = "label7";
            label7.Size = new Size(58, 19);
            label7.TabIndex = 9;
            label7.Text = "Courses";
            // 
            // PB_logout
            // 
            PB_logout.BackColor = SystemColors.ButtonFace;
            PB_logout.BackgroundImage = (Image)resources.GetObject("PB_logout.BackgroundImage");
            PB_logout.BackgroundImageLayout = ImageLayout.Zoom;
            PB_logout.Cursor = Cursors.Hand;
            PB_logout.Image = (Image)resources.GetObject("PB_logout.Image");
            PB_logout.Location = new Point(759, 4);
            PB_logout.Name = "PB_logout";
            PB_logout.Size = new Size(20, 26);
            PB_logout.TabIndex = 30;
            PB_logout.TabStop = false;
            PB_logout.Click += lbl_logout_Click;
            // 
            // lbl_msg
            // 
            lbl_msg.AutoSize = true;
            lbl_msg.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lbl_msg.ForeColor = SystemColors.ScrollBar;
            lbl_msg.Location = new Point(69, 263);
            lbl_msg.Name = "lbl_msg";
            lbl_msg.Size = new Size(474, 37);
            lbl_msg.TabIndex = 31;
            lbl_msg.Text = "Choose Exam To Show its Questions";
            // 
            // ExamDetails
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(849, 529);
            Controls.Add(lbl_msg);
            Controls.Add(PB_logout);
            Controls.Add(groupBox1);
            Controls.Add(lbl_logout);
            Controls.Add(btn_showExam);
            Controls.Add(lbl_backtohome);
            Controls.Add(dgv_ExamQuestionsTF);
            Controls.Add(dgv_ExamQuestionsMCQ);
            Controls.Add(label7);
            Controls.Add(label2);
            Controls.Add(Department);
            Controls.Add(cb_courses);
            Controls.Add(cb_courseExams);
            Name = "ExamDetails";
            Text = "ExamDetails";
            Load += ExamDetails_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_ExamQuestionsMCQ).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgv_ExamQuestionsTF).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)PB_logout).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dgv_ExamQuestionsMCQ;
        private ComboBox cb_courseExams;
        private Label label2;
        private Label lbl_backtohome;
        private Button btn_showExam;
        private Label lbl_logout;
        private DataGridView dgv_ExamQuestionsTF;
        private GroupBox groupBox1;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label1;
        private Label label6;
        private ComboBox cb_courses;
        private Label label7;
        private Label label8;
        private Label lbl_numOfStudents;
        private Label lbl_course;
        private Label lbl_duration;
        private Label lbl_time;
        private Label lbl_date;
        private Label lbl_id;
        private PictureBox PB_logout;
        private Label lbl_msg;

        public Control Department { get; private set; }
    }
}