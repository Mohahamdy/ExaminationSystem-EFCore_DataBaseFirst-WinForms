namespace DB_Sytem
{
    partial class ExamAnswers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExamAnswers));
            lbl_backtohome = new Label();
            btn_show = new Button();
            dgv_ExamAnswers = new DataGridView();
            label2 = new Label();
            cb_courses = new ComboBox();
            cb_students = new ComboBox();
            label1 = new Label();
            PB_logout = new PictureBox();
            lbl_logout = new Label();
            ((System.ComponentModel.ISupportInitialize)dgv_ExamAnswers).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PB_logout).BeginInit();
            SuspendLayout();
            // 
            // lbl_backtohome
            // 
            lbl_backtohome.AutoSize = true;
            lbl_backtohome.Cursor = Cursors.Hand;
            lbl_backtohome.Location = new Point(21, 12);
            lbl_backtohome.Name = "lbl_backtohome";
            lbl_backtohome.Size = new Size(102, 15);
            lbl_backtohome.TabIndex = 26;
            lbl_backtohome.Text = "<< Back To Home";
            lbl_backtohome.Click += lbl_backtohome_Click;
            // 
            // btn_show
            // 
            btn_show.BackColor = Color.FromArgb(41, 128, 185);
            btn_show.FlatStyle = FlatStyle.Flat;
            btn_show.ForeColor = Color.White;
            btn_show.Location = new Point(497, 57);
            btn_show.Name = "btn_show";
            btn_show.Size = new Size(120, 34);
            btn_show.TabIndex = 25;
            btn_show.Text = "Show";
            btn_show.UseVisualStyleBackColor = false;
            btn_show.Click += btn_show_Click;
            // 
            // dgv_ExamAnswers
            // 
            dgv_ExamAnswers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_ExamAnswers.Location = new Point(42, 131);
            dgv_ExamAnswers.Name = "dgv_ExamAnswers";
            dgv_ExamAnswers.Size = new Size(575, 307);
            dgv_ExamAnswers.TabIndex = 24;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F);
            label2.ForeColor = Color.FromArgb(41, 128, 185);
            label2.Location = new Point(245, 39);
            label2.Name = "label2";
            label2.Size = new Size(52, 19);
            label2.TabIndex = 22;
            label2.Text = "Course";
            // 
            // cb_courses
            // 
            cb_courses.Font = new Font("Segoe UI", 12F);
            cb_courses.FormattingEnabled = true;
            cb_courses.Location = new Point(247, 62);
            cb_courses.Name = "cb_courses";
            cb_courses.Size = new Size(203, 29);
            cb_courses.TabIndex = 20;
            // 
            // cb_students
            // 
            cb_students.Font = new Font("Segoe UI", 12F);
            cb_students.FormattingEnabled = true;
            cb_students.Location = new Point(42, 62);
            cb_students.Name = "cb_students";
            cb_students.Size = new Size(161, 29);
            cb_students.TabIndex = 21;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F);
            label1.ForeColor = Color.FromArgb(41, 128, 185);
            label1.Location = new Point(42, 40);
            label1.Name = "label1";
            label1.Size = new Size(57, 19);
            label1.TabIndex = 23;
            label1.Text = "Student";
            // 
            // PB_logout
            // 
            PB_logout.BackColor = SystemColors.ButtonFace;
            PB_logout.BackgroundImage = (Image)resources.GetObject("PB_logout.BackgroundImage");
            PB_logout.BackgroundImageLayout = ImageLayout.Zoom;
            PB_logout.Cursor = Cursors.Hand;
            PB_logout.Image = (Image)resources.GetObject("PB_logout.Image");
            PB_logout.Location = new Point(578, 6);
            PB_logout.Name = "PB_logout";
            PB_logout.Size = new Size(20, 20);
            PB_logout.TabIndex = 34;
            PB_logout.TabStop = false;
            PB_logout.Click += lbl_logout_Click;
            // 
            // lbl_logout
            // 
            lbl_logout.AutoSize = true;
            lbl_logout.Cursor = Cursors.Hand;
            lbl_logout.ForeColor = Color.Crimson;
            lbl_logout.Location = new Point(599, 9);
            lbl_logout.Name = "lbl_logout";
            lbl_logout.Size = new Size(50, 15);
            lbl_logout.TabIndex = 33;
            lbl_logout.Text = "Log Out";
            lbl_logout.Click += lbl_logout_Click;
            // 
            // ExamAnswers
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(661, 450);
            Controls.Add(PB_logout);
            Controls.Add(lbl_logout);
            Controls.Add(lbl_backtohome);
            Controls.Add(btn_show);
            Controls.Add(dgv_ExamAnswers);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cb_courses);
            Controls.Add(cb_students);
            Name = "ExamAnswers";
            Text = "ExamAnswers";
            Load += ExamAnswers_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_ExamAnswers).EndInit();
            ((System.ComponentModel.ISupportInitialize)PB_logout).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_backtohome;
        private Button btn_show;
        private DataGridView dgv_ExamAnswers;
        private Label label2;
        private ComboBox cb_courses;
        private ComboBox cb_students;
        private Label label1;
        private PictureBox PB_logout;
        private Label lbl_logout;
        private Control btn_chooseStudent;
    }
}