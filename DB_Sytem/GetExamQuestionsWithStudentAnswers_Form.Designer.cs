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
            btn_display = new Button();
            btn_back = new Button();
            reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            label2 = new Label();
            label1 = new Label();
            cb_Exam = new ComboBox();
            cb_Student = new ComboBox();
            SuspendLayout();
            // 
            // btn_display
            // 
            btn_display.Location = new Point(639, 415);
            btn_display.Name = "btn_display";
            btn_display.Size = new Size(75, 23);
            btn_display.TabIndex = 0;
            btn_display.Text = "Display";
            btn_display.UseVisualStyleBackColor = true;
            btn_display.Click += btn_display_Click;
            // 
            // btn_back
            // 
            btn_back.BackColor = Color.Red;
            btn_back.Location = new Point(736, 415);
            btn_back.Name = "btn_back";
            btn_back.Size = new Size(75, 23);
            btn_back.TabIndex = 1;
            btn_back.Text = "Back";
            btn_back.UseVisualStyleBackColor = false;
            btn_back.Click += btn_back_Click;
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
            // GetExamQuestionsWithStudentAnswers_Form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(984, 450);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cb_Exam);
            Controls.Add(cb_Student);
            Controls.Add(btn_back);
            Controls.Add(btn_display);
            Controls.Add(reportViewer1);
            Name = "GetExamQuestionsWithStudentAnswers_Form";
            Text = "GetExamQuestionsWithStudentAnswers_Form";
            Load += GetExamQuestionsWithStudentAnswers_Form_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_display;
        private Button btn_back;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private Label label2;
        private Label label1;
        private ComboBox cb_Exam;
        private ComboBox cb_Student;
    }
}