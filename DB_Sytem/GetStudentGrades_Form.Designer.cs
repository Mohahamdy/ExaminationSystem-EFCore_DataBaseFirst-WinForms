namespace DB_Sytem
{
    partial class GetStudentGrades_Form
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
            cb_student = new ComboBox();
            label1 = new Label();
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
            // cb_student
            // 
            cb_student.FormattingEnabled = true;
            cb_student.Location = new Point(415, 415);
            cb_student.Name = "cb_student";
            cb_student.Size = new Size(121, 23);
            cb_student.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(334, 417);
            label1.Name = "label1";
            label1.Size = new Size(63, 21);
            label1.TabIndex = 3;
            label1.Text = "Student";
            // 
            // button8
            // 
            button8.BackColor = Color.Crimson;
            button8.FlatStyle = FlatStyle.Flat;
            button8.Font = new Font("Segoe UI", 12F);
            button8.ForeColor = Color.White;
            button8.Location = new Point(699, 411);
            button8.Name = "button8";
            button8.Size = new Size(100, 33);
            button8.TabIndex = 9;
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
            btn_report_6.Location = new Point(572, 410);
            btn_report_6.Name = "btn_report_6";
            btn_report_6.Size = new Size(100, 33);
            btn_report_6.TabIndex = 8;
            btn_report_6.Text = "Display";
            btn_report_6.UseVisualStyleBackColor = false;
            btn_report_6.Click += btn_display_Click;
            // 
            // GetStudentGrades_Form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(984, 450);
            Controls.Add(button8);
            Controls.Add(btn_report_6);
            Controls.Add(label1);
            Controls.Add(cb_student);
            Controls.Add(reportViewer1);
            Name = "GetStudentGrades_Form";
            Text = "GetStudentGrades_Form";
            Load += GetStudentGrades_Form_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private ComboBox cb_student;
        private Label label1;
        private Button button8;
        private Button btn_report_6;
    }
}