namespace DB_Sytem
{
    partial class GetExamQuestionsWithStudentAnswers_Form
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
            reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            label2 = new Label();
            label1 = new Label();
            cb_Exam = new ComboBox();
            cb_Student = new ComboBox();
            button8 = new Button();
            btn_report_6 = new Button();
            SuspendLayout();
            // 
            // reportViewer1
            // 
            reportViewer1.Location = new Point(0, 0);
            reportViewer1.Name = "ReportViewer";
            reportViewer1.ServerReport.BearerToken = null;
            reportViewer1.Size = new Size(1000, 400);
            reportViewer1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(361, 417);
            label2.Name = "label2";
            label2.Size = new Size(70, 21);
            label2.TabIndex = 9;
            label2.Text = "Student :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(127, 417);
            label1.Name = "label1";
            label1.Size = new Size(58, 21);
            label1.TabIndex = 8;
            label1.Text = "Exam  :";
            // 
            // cb_Exam
            // 
            cb_Exam.FormattingEnabled = true;
            cb_Exam.Location = new Point(199, 416);
            cb_Exam.Name = "cb_Exam";
            cb_Exam.Size = new Size(121, 23);
            cb_Exam.TabIndex = 7;
            cb_Exam.SelectionChangeCommitted += cb_Exam_SelectionChangeCommitted;
            // 
            // cb_Student
            // 
            cb_Student.FormattingEnabled = true;
            cb_Student.Location = new Point(437, 415);
            cb_Student.Name = "cb_Student";
            cb_Student.Size = new Size(121, 23);
            cb_Student.TabIndex = 6;
            cb_Student.SelectionChangeCommitted += cb_Student_SelectionChangeCommitted;
            // 
            // button8
            // 
            button8.BackColor = Color.Crimson;
            button8.FlatStyle = FlatStyle.Flat;
            button8.Font = new Font("Segoe UI", 12F);
            button8.ForeColor = Color.White;
            button8.Location = new Point(732, 408);
            button8.Name = "button8";
            button8.Size = new Size(100, 33);
            button8.TabIndex = 11;
            button8.Text = "Back";
            button8.UseVisualStyleBackColor = false;
            button8.Click += btn_back_Click;
            // 
            // btn_report_6
            // 
            btn_report_6.BackColor = Color.FromArgb(41, 128, 185);
            btn_report_6.FlatStyle = FlatStyle.Flat;
            btn_report_6.Font = new Font("Segoe UI", 11F);
            btn_report_6.ForeColor = Color.White;
            btn_report_6.Location = new Point(605, 407);
            btn_report_6.Name = "btn_report_6";
            btn_report_6.Size = new Size(100, 33);
            btn_report_6.TabIndex = 10;
            btn_report_6.Text = "Display";
            btn_report_6.UseVisualStyleBackColor = false;
            btn_report_6.Click += btn_display_Click;
            // 
            // GetExamQuestionsWithStudentAnswers_Form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(984, 450);
            Controls.Add(button8);
            Controls.Add(btn_report_6);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cb_Exam);
            Controls.Add(cb_Student);
            Controls.Add(reportViewer1);
            Name = "GetExamQuestionsWithStudentAnswers_Form";
            Text = "GetExamQuestionsWithStudentAnswers_Form";
            Load += GetExamQuestionsWithStudentAnswers_Form_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private Label label2;
        private Label label1;
        private ComboBox cb_Exam;
        private ComboBox cb_Student;
        private Button button8;
        private Button btn_report_6;
    }
}