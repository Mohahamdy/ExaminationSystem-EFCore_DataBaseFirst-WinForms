
namespace DB_Sytem
{
    partial class Instructor_Exam
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Instructor_Exam));
            groupBox1 = new GroupBox();
            btn_report_5 = new Button();
            btn_report_6 = new Button();
            btn_report_4 = new Button();
            btn_report_3 = new Button();
            btn_report_2 = new Button();
            btn_report_1 = new Button();
            btn_create = new Button();
            button8 = new Button();
            cb_subject = new ComboBox();
            cb_exam = new ComboBox();
            groupBox2 = new GroupBox();
            groupBox3 = new GroupBox();
            dt_time = new DateTimePicker();
            dt_date = new DateTimePicker();
            txt_grade = new TextBox();
            label6 = new Label();
            label5 = new Label();
            num_duration = new NumericUpDown();
            label2 = new Label();
            label4 = new Label();
            label1 = new Label();
            dgv_ExamQuestions = new DataGridView();
            cb_crs = new ComboBox();
            btn_generate = new Button();
            lbl_backtohome = new Label();
            PB_logout = new PictureBox();
            lbl_logout = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)num_duration).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgv_ExamQuestions).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PB_logout).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btn_report_5);
            groupBox1.Controls.Add(btn_report_6);
            groupBox1.Controls.Add(btn_report_4);
            groupBox1.Controls.Add(btn_report_3);
            groupBox1.Controls.Add(btn_report_2);
            groupBox1.Controls.Add(btn_report_1);
            groupBox1.Font = new Font("Segoe UI", 12F);
            groupBox1.Location = new Point(688, 16);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(272, 293);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Reports";
            // 
            // btn_report_5
            // 
            btn_report_5.BackColor = Color.FromArgb(41, 128, 185);
            btn_report_5.FlatStyle = FlatStyle.Flat;
            btn_report_5.ForeColor = Color.White;
            btn_report_5.Location = new Point(6, 197);
            btn_report_5.Name = "btn_report_5";
            btn_report_5.Size = new Size(246, 34);
            btn_report_5.TabIndex = 5;
            btn_report_5.Text = "Exam Student Answers";
            btn_report_5.UseVisualStyleBackColor = false;
            btn_report_5.Click += btn_report_5_Click;
            // 
            // btn_report_6
            // 
            btn_report_6.BackColor = Color.FromArgb(41, 128, 185);
            btn_report_6.FlatStyle = FlatStyle.Flat;
            btn_report_6.ForeColor = Color.White;
            btn_report_6.Location = new Point(6, 237);
            btn_report_6.Name = "btn_report_6";
            btn_report_6.Size = new Size(246, 34);
            btn_report_6.TabIndex = 4;
            btn_report_6.Text = "Student Grades";
            btn_report_6.UseVisualStyleBackColor = false;
            btn_report_6.Click += btn_report_6_Click;
            // 
            // btn_report_4
            // 
            btn_report_4.BackColor = Color.FromArgb(41, 128, 185);
            btn_report_4.FlatStyle = FlatStyle.Flat;
            btn_report_4.ForeColor = Color.White;
            btn_report_4.Location = new Point(6, 157);
            btn_report_4.Name = "btn_report_4";
            btn_report_4.Size = new Size(246, 34);
            btn_report_4.TabIndex = 3;
            btn_report_4.Text = "Exam QuestionsAndChoices";
            btn_report_4.UseVisualStyleBackColor = false;
            btn_report_4.Click += btn_report_4_Click;
            // 
            // btn_report_3
            // 
            btn_report_3.BackColor = Color.FromArgb(41, 128, 185);
            btn_report_3.FlatStyle = FlatStyle.Flat;
            btn_report_3.ForeColor = Color.White;
            btn_report_3.Location = new Point(6, 117);
            btn_report_3.Name = "btn_report_3";
            btn_report_3.Size = new Size(246, 34);
            btn_report_3.TabIndex = 2;
            btn_report_3.Text = "CourseTopics";
            btn_report_3.UseVisualStyleBackColor = false;
            btn_report_3.Click += btn_report_3_Click;
            // 
            // btn_report_2
            // 
            btn_report_2.BackColor = Color.FromArgb(41, 128, 185);
            btn_report_2.FlatStyle = FlatStyle.Flat;
            btn_report_2.ForeColor = Color.White;
            btn_report_2.Location = new Point(6, 77);
            btn_report_2.Name = "btn_report_2";
            btn_report_2.Size = new Size(246, 34);
            btn_report_2.TabIndex = 1;
            btn_report_2.Text = "CoursesAndStudentsByInstructor";
            btn_report_2.UseVisualStyleBackColor = false;
            btn_report_2.Click += btn_report_2_Click;
            // 
            // btn_report_1
            // 
            btn_report_1.BackColor = Color.FromArgb(41, 128, 185);
            btn_report_1.FlatStyle = FlatStyle.Flat;
            btn_report_1.ForeColor = Color.White;
            btn_report_1.Location = new Point(6, 37);
            btn_report_1.Name = "btn_report_1";
            btn_report_1.Size = new Size(246, 34);
            btn_report_1.TabIndex = 0;
            btn_report_1.Text = "StudentsByDepartment";
            btn_report_1.UseVisualStyleBackColor = false;
            btn_report_1.Click += btn_report_1_Click;
            // 
            // btn_create
            // 
            btn_create.BackColor = Color.ForestGreen;
            btn_create.FlatStyle = FlatStyle.Flat;
            btn_create.Font = new Font("Segoe UI", 12F);
            btn_create.ForeColor = Color.White;
            btn_create.Location = new Point(31, 149);
            btn_create.Name = "btn_create";
            btn_create.Size = new Size(103, 33);
            btn_create.TabIndex = 1;
            btn_create.Text = "Launch";
            btn_create.UseVisualStyleBackColor = false;
            btn_create.Click += btn_create_Click;
            // 
            // button8
            // 
            button8.BackColor = Color.Crimson;
            button8.FlatStyle = FlatStyle.Flat;
            button8.Font = new Font("Segoe UI", 12F);
            button8.ForeColor = Color.White;
            button8.Location = new Point(152, 149);
            button8.Name = "button8";
            button8.Size = new Size(100, 33);
            button8.TabIndex = 2;
            button8.Text = "Delete";
            button8.UseVisualStyleBackColor = false;
            // 
            // cb_subject
            // 
            cb_subject.Font = new Font("Segoe UI", 12F);
            cb_subject.FormattingEnabled = true;
            cb_subject.Location = new Point(19, 45);
            cb_subject.Name = "cb_subject";
            cb_subject.Size = new Size(245, 29);
            cb_subject.TabIndex = 4;
            cb_subject.Text = "Subject";
            cb_subject.DropDown += cb_subject_DropDown;
            cb_subject.SelectionChangeCommitted += cb_subject_SelectionChangeCommitted;
            // 
            // cb_exam
            // 
            cb_exam.Font = new Font("Segoe UI", 12F);
            cb_exam.FormattingEnabled = true;
            cb_exam.Location = new Point(19, 80);
            cb_exam.Name = "cb_exam";
            cb_exam.Size = new Size(245, 29);
            cb_exam.TabIndex = 5;
            cb_exam.Text = "Exams";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(cb_exam);
            groupBox2.Controls.Add(cb_subject);
            groupBox2.Controls.Add(btn_create);
            groupBox2.Controls.Add(button8);
            groupBox2.Enabled = false;
            groupBox2.Font = new Font("Segoe UI", 12F);
            groupBox2.Location = new Point(688, 315);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(273, 207);
            groupBox2.TabIndex = 6;
            groupBox2.TabStop = false;
            groupBox2.Text = "pre-existing exams";
            groupBox2.Visible = false;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(dt_time);
            groupBox3.Controls.Add(dt_date);
            groupBox3.Controls.Add(txt_grade);
            groupBox3.Controls.Add(label6);
            groupBox3.Controls.Add(label5);
            groupBox3.Controls.Add(num_duration);
            groupBox3.Controls.Add(label2);
            groupBox3.Controls.Add(label4);
            groupBox3.Controls.Add(label1);
            groupBox3.Controls.Add(dgv_ExamQuestions);
            groupBox3.Controls.Add(cb_crs);
            groupBox3.Controls.Add(btn_generate);
            groupBox3.Font = new Font("Segoe UI", 12F);
            groupBox3.Location = new Point(31, 16);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(625, 506);
            groupBox3.TabIndex = 6;
            groupBox3.TabStop = false;
            groupBox3.Text = "New Exam";
            // 
            // dt_time
            // 
            dt_time.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dt_time.Format = DateTimePickerFormat.Time;
            dt_time.Location = new Point(228, 111);
            dt_time.Name = "dt_time";
            dt_time.Size = new Size(173, 26);
            dt_time.TabIndex = 15;
            // 
            // dt_date
            // 
            dt_date.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dt_date.Format = DateTimePickerFormat.Short;
            dt_date.ImeMode = ImeMode.Katakana;
            dt_date.Location = new Point(26, 111);
            dt_date.Name = "dt_date";
            dt_date.Size = new Size(173, 26);
            dt_date.TabIndex = 14;
            // 
            // txt_grade
            // 
            txt_grade.Enabled = false;
            txt_grade.Location = new Point(430, 54);
            txt_grade.Name = "txt_grade";
            txt_grade.Size = new Size(171, 29);
            txt_grade.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10F);
            label6.ForeColor = Color.FromArgb(41, 128, 185);
            label6.Location = new Point(430, 32);
            label6.Name = "label6";
            label6.Size = new Size(46, 19);
            label6.TabIndex = 7;
            label6.Text = "Grade";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F);
            label5.ForeColor = Color.FromArgb(41, 128, 185);
            label5.Location = new Point(230, 87);
            label5.Name = "label5";
            label5.Size = new Size(38, 19);
            label5.TabIndex = 7;
            label5.Text = "Time";
            // 
            // num_duration
            // 
            num_duration.Location = new Point(230, 54);
            num_duration.Maximum = new decimal(new int[] { 180, 0, 0, 0 });
            num_duration.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            num_duration.Name = "num_duration";
            num_duration.Size = new Size(171, 29);
            num_duration.TabIndex = 8;
            num_duration.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F);
            label2.ForeColor = Color.FromArgb(41, 128, 185);
            label2.Location = new Point(26, 88);
            label2.Name = "label2";
            label2.Size = new Size(38, 19);
            label2.TabIndex = 7;
            label2.Text = "Date";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F);
            label4.ForeColor = Color.FromArgb(41, 128, 185);
            label4.Location = new Point(230, 32);
            label4.Name = "label4";
            label4.Size = new Size(124, 19);
            label4.TabIndex = 7;
            label4.Text = "Duration (minutes)";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F);
            label1.ForeColor = Color.FromArgb(41, 128, 185);
            label1.Location = new Point(26, 31);
            label1.Name = "label1";
            label1.Size = new Size(52, 19);
            label1.TabIndex = 7;
            label1.Text = "Course";
            // 
            // dgv_ExamQuestions
            // 
            dgv_ExamQuestions.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_ExamQuestions.Location = new Point(26, 163);
            dgv_ExamQuestions.Name = "dgv_ExamQuestions";
            dgv_ExamQuestions.Size = new Size(575, 325);
            dgv_ExamQuestions.TabIndex = 5;
            // 
            // cb_crs
            // 
            cb_crs.Font = new Font("Segoe UI", 12F);
            cb_crs.FormattingEnabled = true;
            cb_crs.Location = new Point(26, 54);
            cb_crs.Name = "cb_crs";
            cb_crs.Size = new Size(171, 29);
            cb_crs.TabIndex = 4;
            cb_crs.SelectionChangeCommitted += cb_crs_SelectedIndexChanged;
            // 
            // btn_generate
            // 
            btn_generate.BackColor = Color.FromArgb(41, 128, 185);
            btn_generate.FlatStyle = FlatStyle.Flat;
            btn_generate.Font = new Font("Segoe UI", 12F);
            btn_generate.ForeColor = Color.White;
            btn_generate.Location = new Point(430, 104);
            btn_generate.Name = "btn_generate";
            btn_generate.Size = new Size(171, 33);
            btn_generate.TabIndex = 3;
            btn_generate.Text = "Generate";
            btn_generate.UseVisualStyleBackColor = false;
            btn_generate.Click += btn_generate_Click;
            // 
            // lbl_backtohome
            // 
            lbl_backtohome.AutoSize = true;
            lbl_backtohome.Cursor = Cursors.Hand;
            lbl_backtohome.Location = new Point(0, 0);
            lbl_backtohome.Name = "lbl_backtohome";
            lbl_backtohome.Size = new Size(102, 15);
            lbl_backtohome.TabIndex = 12;
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
            PB_logout.Location = new Point(585, 3);
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
            lbl_logout.Location = new Point(606, 6);
            lbl_logout.Name = "lbl_logout";
            lbl_logout.Size = new Size(50, 15);
            lbl_logout.TabIndex = 35;
            lbl_logout.Text = "Log Out";
            lbl_logout.Click += lbl_logout_Click;
            // 
            // Instructor_Exam
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(972, 530);
            Controls.Add(PB_logout);
            Controls.Add(lbl_logout);
            Controls.Add(lbl_backtohome);
            Controls.Add(groupBox1);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Name = "Instructor_Exam";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Instructor_HomePage";
            Load += Instructor_Exam_Load;
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)num_duration).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgv_ExamQuestions).EndInit();
            ((System.ComponentModel.ISupportInitialize)PB_logout).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void btn_create_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }



        #endregion

        private GroupBox groupBox1;
        private Button btn_report_5;
        private Button btn_report_6;
        private Button btn_report_4;
        private Button btn_report_3;
        private Button btn_report_2;
        private Button btn_report_1;
        private Button btn_create;
        private Button button8;
        private ComboBox cb_subject;
        private ComboBox cb_exam;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private ComboBox cb_crs;
        private Button btn_generate;
        private DataGridView dgv_ExamQuestions;
        private Label label1;
        private Label label2;
        private NumericUpDown num_duration;
        private Label label4;
        private Label label5;
        private TextBox txt_grade;
        private Label label6;
        private DateTimePicker dt_time;
        private DateTimePicker dt_date;
        private Label lbl_backtohome;
        private PictureBox PB_logout;
        private Label lbl_logout;
    }
}