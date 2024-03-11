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
            label2 = new Label();
            lbl_studentName = new Label();
            dgv_exams = new DataGridView();
            btn_start = new Button();
            ((System.ComponentModel.ISupportInitialize)dgv_exams).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(41, 128, 185);
            label2.Location = new Point(39, 40);
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
            lbl_studentName.Location = new Point(159, 40);
            lbl_studentName.Name = "lbl_studentName";
            lbl_studentName.Size = new Size(0, 25);
            lbl_studentName.TabIndex = 3;
            // 
            // dgv_exams
            // 
            dgv_exams.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_exams.Location = new Point(12, 118);
            dgv_exams.Name = "dgv_exams";
            dgv_exams.Size = new Size(749, 227);
            dgv_exams.TabIndex = 4;
            // 
            // btn_start
            // 
            btn_start.Location = new Point(57, 378);
            btn_start.Name = "btn_start";
            btn_start.Size = new Size(127, 42);
            btn_start.TabIndex = 5;
            btn_start.Text = "Start Exam";
            btn_start.UseVisualStyleBackColor = true;
            // 
            // Student_HomePage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_start);
            Controls.Add(dgv_exams);
            Controls.Add(lbl_studentName);
            Controls.Add(label2);
            Name = "Student_HomePage";
            Text = "Student_HomePage";
            Load += Student_HomePage_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_exams).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label lbl_studentName;
        private DataGridView dgv_exams;
        private Button btn_start;
    }
}