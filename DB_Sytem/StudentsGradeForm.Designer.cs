namespace DB_Sytem
{
    partial class StudentsGradeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentsGradeForm));
            cb_courses = new ComboBox();
            cb_departments = new ComboBox();
            dataGridView1 = new DataGridView();
            label1 = new Label();
            PB_logout = new PictureBox();
            lbl_logout = new Label();
            btn_report_6 = new Button();
            label2 = new Label();
            button8 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PB_logout).BeginInit();
            SuspendLayout();
            // 
            // cb_courses
            // 
            cb_courses.FormattingEnabled = true;
            cb_courses.Location = new Point(132, 104);
            cb_courses.Name = "cb_courses";
            cb_courses.Size = new Size(121, 23);
            cb_courses.TabIndex = 0;
            // 
            // cb_departments
            // 
            cb_departments.FormattingEnabled = true;
            cb_departments.Location = new Point(132, 164);
            cb_departments.Name = "cb_departments";
            cb_departments.Size = new Size(121, 23);
            cb_departments.TabIndex = 1;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(294, 6);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(494, 432);
            dataGridView1.TabIndex = 2;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.InactiveCaptionText;
            label1.Location = new Point(48, 106);
            label1.Name = "label1";
            label1.Size = new Size(66, 21);
            label1.TabIndex = 6;
            label1.Text = "Course ";
            // 
            // PB_logout
            // 
            PB_logout.BackColor = SystemColors.ButtonFace;
            PB_logout.BackgroundImage = (Image)resources.GetObject("PB_logout.BackgroundImage");
            PB_logout.BackgroundImageLayout = ImageLayout.Zoom;
            PB_logout.Cursor = Cursors.Hand;
            PB_logout.Image = (Image)resources.GetObject("PB_logout.Image");
            PB_logout.Location = new Point(3, 6);
            PB_logout.Name = "PB_logout";
            PB_logout.Size = new Size(20, 20);
            PB_logout.TabIndex = 38;
            PB_logout.TabStop = false;
            // 
            // lbl_logout
            // 
            lbl_logout.AutoSize = true;
            lbl_logout.Cursor = Cursors.Hand;
            lbl_logout.ForeColor = Color.Crimson;
            lbl_logout.Location = new Point(24, 9);
            lbl_logout.Name = "lbl_logout";
            lbl_logout.Size = new Size(50, 15);
            lbl_logout.TabIndex = 37;
            lbl_logout.Text = "Log Out";
            lbl_logout.Click += lbl_logout_Click;
            // 
            // btn_report_6
            // 
            btn_report_6.BackColor = Color.FromArgb(41, 128, 185);
            btn_report_6.FlatStyle = FlatStyle.Flat;
            btn_report_6.Font = new Font("Segoe UI", 11F);
            btn_report_6.ForeColor = Color.White;
            btn_report_6.Location = new Point(87, 239);
            btn_report_6.Name = "btn_report_6";
            btn_report_6.Size = new Size(100, 33);
            btn_report_6.TabIndex = 39;
            btn_report_6.Text = "Display";
            btn_report_6.UseVisualStyleBackColor = false;
            btn_report_6.Click += btn_show_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.InactiveCaptionText;
            label2.Location = new Point(12, 166);
            label2.Name = "label2";
            label2.Size = new Size(102, 21);
            label2.TabIndex = 40;
            label2.Text = "Department";
            // 
            // button8
            // 
            button8.BackColor = Color.Crimson;
            button8.FlatStyle = FlatStyle.Flat;
            button8.Font = new Font("Segoe UI", 12F);
            button8.ForeColor = Color.White;
            button8.Location = new Point(87, 292);
            button8.Name = "button8";
            button8.Size = new Size(100, 33);
            button8.TabIndex = 41;
            button8.Text = "Back";
            button8.UseVisualStyleBackColor = false;
            button8.Click += btn_Back_To_Home_Click;
            // 
            // StudentsGradeForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            ClientSize = new Size(800, 450);
            Controls.Add(button8);
            Controls.Add(label2);
            Controls.Add(btn_report_6);
            Controls.Add(PB_logout);
            Controls.Add(lbl_logout);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Controls.Add(cb_departments);
            Controls.Add(cb_courses);
            Name = "StudentsGradeForm";
            Text = "StudentsGradeForm";
            Load += StudentsGradeForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)PB_logout).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cb_courses;
        private ComboBox cb_departments;
        private DataGridView dataGridView1;
        private Label label1;
        private PictureBox PB_logout;
        private Label lbl_logout;
        private Button btn_report_6;
        private Label label2;
        private Button button8;
    }
}