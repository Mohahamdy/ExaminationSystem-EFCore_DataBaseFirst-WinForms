namespace DB_Sytem
{
    partial class Student_HomePage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Student_HomePage));
            label2 = new Label();
            lbl_studentName = new Label();
            dgv_exams = new DataGridView();
            btn_start = new Button();
            PB_logout = new PictureBox();
            lbl_logout = new Label();
            ((System.ComponentModel.ISupportInitialize)dgv_exams).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PB_logout).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(41, 128, 185);
            label2.Location = new Point(12, 57);
            label2.Name = "label2";
            label2.Size = new Size(103, 25);
            label2.TabIndex = 2;
            label2.Text = "Welcome :";
            // 
            // lbl_studentName
            // 
            lbl_studentName.AutoSize = true;
            lbl_studentName.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lbl_studentName.ForeColor = Color.Maroon;
            lbl_studentName.Location = new Point(121, 57);
            lbl_studentName.Name = "lbl_studentName";
            lbl_studentName.Size = new Size(0, 25);
            lbl_studentName.TabIndex = 3;
            // 
            // dgv_exams
            // 
            dgv_exams.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_exams.Location = new Point(260, 57);
            dgv_exams.Name = "dgv_exams";
            dgv_exams.Size = new Size(453, 381);
            dgv_exams.TabIndex = 4;
            dgv_exams.RowHeaderMouseDoubleClick += dgv_exams_RowHeaderMouseDoubleClick;
            // 
            // btn_start
            // 
            btn_start.BackColor = Color.FromArgb(41, 128, 185);
            btn_start.FlatStyle = FlatStyle.Flat;
            btn_start.Font = new Font("Segoe UI", 11F);
            btn_start.ForeColor = Color.White;
            btn_start.Location = new Point(29, 167);
            btn_start.Name = "btn_start";
            btn_start.Size = new Size(100, 33);
            btn_start.TabIndex = 40;
            btn_start.Text = "Start Exam";
            btn_start.UseVisualStyleBackColor = false;
            btn_start.Click += btn_start_Click;
            // 
            // PB_logout
            // 
            PB_logout.BackColor = SystemColors.ButtonFace;
            PB_logout.BackgroundImage = (Image)resources.GetObject("PB_logout.BackgroundImage");
            PB_logout.BackgroundImageLayout = ImageLayout.Zoom;
            PB_logout.Cursor = Cursors.Hand;
            PB_logout.Image = (Image)resources.GetObject("PB_logout.Image");
            PB_logout.Location = new Point(8, 6);
            PB_logout.Name = "PB_logout";
            PB_logout.Size = new Size(20, 20);
            PB_logout.TabIndex = 42;
            PB_logout.TabStop = false;
            PB_logout.Click += PB_logout_Click;
            // 
            // lbl_logout
            // 
            lbl_logout.AutoSize = true;
            lbl_logout.Cursor = Cursors.Hand;
            lbl_logout.ForeColor = Color.Crimson;
            lbl_logout.Location = new Point(29, 9);
            lbl_logout.Name = "lbl_logout";
            lbl_logout.Size = new Size(50, 15);
            lbl_logout.TabIndex = 41;
            lbl_logout.Text = "Log Out";
            lbl_logout.Click += lbl_logout_Click;
            // 
            // Student_HomePage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(716, 450);
            Controls.Add(PB_logout);
            Controls.Add(lbl_logout);
            Controls.Add(btn_start);
            Controls.Add(dgv_exams);
            Controls.Add(lbl_studentName);
            Controls.Add(label2);
            Name = "Student_HomePage";
            Text = "Student_HomePage";
            Load += Student_HomePage_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_exams).EndInit();
            ((System.ComponentModel.ISupportInitialize)PB_logout).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label lbl_studentName;
        private DataGridView dgv_exams;
        private Button btn_start;
        private PictureBox PB_logout;
        private Label lbl_logout;
    }
}