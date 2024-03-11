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
            btn_display = new Button();
            btn_back = new Button();
            reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            cb_student = new ComboBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // btn_display
            // 
            btn_display.Location = new Point(578, 415);
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
            btn_back.Location = new Point(691, 415);
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
            // GetStudentGrades_Form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(984, 450);
            Controls.Add(label1);
            Controls.Add(cb_student);
            Controls.Add(btn_back);
            Controls.Add(btn_display);
            Controls.Add(reportViewer1);
            Name = "GetStudentGrades_Form";
            Text = "GetStudentGrades_Form";
            Load += GetStudentGrades_Form_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_display;
        private Button btn_back;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private ComboBox cb_student;
        private Label label1;
    }
}