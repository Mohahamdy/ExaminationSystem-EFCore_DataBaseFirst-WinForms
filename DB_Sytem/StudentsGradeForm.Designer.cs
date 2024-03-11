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
            cb_courses = new ComboBox();
            cb_departments = new ComboBox();
            dataGridView1 = new DataGridView();
            btn_show = new Button();
            btn_Back_To_Home = new Button();
            btn_Log_out = new Button();
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // cb_courses
            // 
            cb_courses.FormattingEnabled = true;
            cb_courses.Location = new Point(59, 49);
            cb_courses.Name = "cb_courses";
            cb_courses.Size = new Size(121, 23);
            cb_courses.TabIndex = 0;
            // 
            // cb_departments
            // 
            cb_departments.FormattingEnabled = true;
            cb_departments.Location = new Point(291, 49);
            cb_departments.Name = "cb_departments";
            cb_departments.Size = new Size(121, 23);
            cb_departments.TabIndex = 1;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(59, 106);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(714, 202);
            dataGridView1.TabIndex = 2;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // btn_show
            // 
            btn_show.BackColor = SystemColors.MenuHighlight;
            btn_show.Location = new Point(607, 23);
            btn_show.Name = "btn_show";
            btn_show.Size = new Size(122, 36);
            btn_show.TabIndex = 3;
            btn_show.Text = "Show";
            btn_show.UseVisualStyleBackColor = false;
            btn_show.Click += btn_show_Click;
            // 
            // btn_Back_To_Home
            // 
            btn_Back_To_Home.BackColor = Color.LightGreen;
            btn_Back_To_Home.Location = new Point(426, 375);
            btn_Back_To_Home.Name = "btn_Back_To_Home";
            btn_Back_To_Home.Size = new Size(153, 31);
            btn_Back_To_Home.TabIndex = 4;
            btn_Back_To_Home.Text = "Back To Home";
            btn_Back_To_Home.UseVisualStyleBackColor = false;
            btn_Back_To_Home.Click += btn_Back_To_Home_Click;
            // 
            // btn_Log_out
            // 
            btn_Log_out.BackColor = Color.Red;
            btn_Log_out.Location = new Point(654, 369);
            btn_Log_out.Name = "btn_Log_out";
            btn_Log_out.Size = new Size(75, 37);
            btn_Log_out.TabIndex = 5;
            btn_Log_out.Text = "Log Out";
            btn_Log_out.UseVisualStyleBackColor = false;
            btn_Log_out.Click += btn_Log_out_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.InactiveCaptionText;
            label1.Location = new Point(80, 9);
            label1.Name = "label1";
            label1.Size = new Size(86, 30);
            label1.TabIndex = 6;
            label1.Text = "Course ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.HighlightText;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(280, 0);
            label2.Name = "label2";
            label2.Size = new Size(132, 30);
            label2.TabIndex = 7;
            label2.Text = "DepartMent";
            // 
            // StudentsGradeForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btn_Log_out);
            Controls.Add(btn_Back_To_Home);
            Controls.Add(btn_show);
            Controls.Add(dataGridView1);
            Controls.Add(cb_departments);
            Controls.Add(cb_courses);
            Name = "StudentsGradeForm";
            Text = "StudentsGradeForm";
            Load += StudentsGradeForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cb_courses;
        private ComboBox cb_departments;
        private DataGridView dataGridView1;
        private Button btn_show;
        private Button btn_Back_To_Home;
        private Button btn_Log_out;
        private Label label1;
        private Label label2;
    }
}