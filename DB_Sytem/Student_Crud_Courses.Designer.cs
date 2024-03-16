namespace DB_Sytem
{
    partial class Student_Crud_Courses
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
            dgv_Courses = new DataGridView();
            label1 = new Label();
            cb_stdNAme = new ComboBox();
            cb_Courses = new ComboBox();
            label2 = new Label();
            btn_insert = new Button();
            btn_delete = new Button();
            label3 = new Label();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dgv_Courses).BeginInit();
            SuspendLayout();
            // 
            // dgv_Courses
            // 
            dgv_Courses.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_Courses.Location = new Point(375, 48);
            dgv_Courses.Name = "dgv_Courses";
            dgv_Courses.Size = new Size(269, 240);
            dgv_Courses.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(10, 35);
            label1.Name = "label1";
            label1.Size = new Size(70, 21);
            label1.TabIndex = 2;
            label1.Text = "Student :";
            // 
            // cb_stdNAme
            // 
            cb_stdNAme.Font = new Font("Segoe UI", 12F);
            cb_stdNAme.FormattingEnabled = true;
            cb_stdNAme.Location = new Point(97, 31);
            cb_stdNAme.Name = "cb_stdNAme";
            cb_stdNAme.Size = new Size(157, 29);
            cb_stdNAme.TabIndex = 4;
            cb_stdNAme.Text = "Select Student";
            cb_stdNAme.SelectionChangeCommitted += cb_stdNAme_SelectionChangeCommitted;
            // 
            // cb_Courses
            // 
            cb_Courses.Font = new Font("Segoe UI", 12F);
            cb_Courses.FormattingEnabled = true;
            cb_Courses.Location = new Point(97, 95);
            cb_Courses.Name = "cb_Courses";
            cb_Courses.Size = new Size(157, 29);
            cb_Courses.TabIndex = 6;
            cb_Courses.Text = "Select Course";
            cb_Courses.SelectionChangeCommitted += cb_Courses_SelectionChangeCommitted;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(10, 99);
            label2.Name = "label2";
            label2.Size = new Size(73, 21);
            label2.TabIndex = 5;
            label2.Text = "Courses :";
            // 
            // btn_insert
            // 
            btn_insert.BackColor = Color.FromArgb(41, 128, 185);
            btn_insert.FlatStyle = FlatStyle.Flat;
            btn_insert.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btn_insert.ForeColor = Color.White;
            btn_insert.Location = new Point(97, 138);
            btn_insert.Name = "btn_insert";
            btn_insert.Size = new Size(153, 34);
            btn_insert.TabIndex = 16;
            btn_insert.Text = "Insert";
            btn_insert.UseVisualStyleBackColor = false;
            btn_insert.Click += btn_insert_Click;
            // 
            // btn_delete
            // 
            btn_delete.BackColor = Color.Crimson;
            btn_delete.FlatStyle = FlatStyle.Flat;
            btn_delete.Font = new Font("Segoe UI", 12F);
            btn_delete.ForeColor = Color.White;
            btn_delete.Location = new Point(97, 187);
            btn_delete.Name = "btn_delete";
            btn_delete.Size = new Size(153, 33);
            btn_delete.TabIndex = 15;
            btn_delete.Text = "Delete";
            btn_delete.UseVisualStyleBackColor = false;
            btn_delete.Click += btn_delete_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label3.Location = new Point(375, 9);
            label3.Name = "label3";
            label3.Size = new Size(69, 21);
            label3.TabIndex = 17;
            label3.Text = "Courses";
            // 
            // button1
            // 
            button1.BackColor = Color.DarkSlateGray;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 12F);
            button1.ForeColor = Color.White;
            button1.Location = new Point(97, 255);
            button1.Name = "button1";
            button1.Size = new Size(153, 33);
            button1.TabIndex = 18;
            button1.Text = "Back";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Student_Crud_Courses
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(657, 312);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(btn_insert);
            Controls.Add(btn_delete);
            Controls.Add(cb_Courses);
            Controls.Add(label2);
            Controls.Add(cb_stdNAme);
            Controls.Add(label1);
            Controls.Add(dgv_Courses);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Student_Crud_Courses";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Student_Crud_Courses";
            Load += Student_Crud_Courses_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_Courses).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgv_Courses;
        private Label label1;
        private ComboBox cb_stdNAme;
        private ComboBox cb_Courses;
        private Label label2;
        private Button btn_insert;
        private Button btn_delete;
        private Label label3;
        private Button button1;
    }
}