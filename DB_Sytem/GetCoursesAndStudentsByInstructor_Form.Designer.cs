using Microsoft.Reporting.WinForms;

namespace DB_Sytem
{
    partial class GetCoursesAndStudentsByInstructor_Form
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
            reportViewer1 = new ReportViewer();
            cb_ins = new ComboBox();
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
            // cb_ins
            // 
            cb_ins.FormattingEnabled = true;
            cb_ins.Location = new Point(302, 415);
            cb_ins.Name = "cb_ins";
            cb_ins.Size = new Size(121, 23);
            cb_ins.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(212, 415);
            label1.Name = "label1";
            label1.Size = new Size(84, 21);
            label1.TabIndex = 3;
            label1.Text = "Instructor :";
            // 
            // button8
            // 
            button8.BackColor = Color.Crimson;
            button8.FlatStyle = FlatStyle.Flat;
            button8.Font = new Font("Segoe UI", 12F);
            button8.ForeColor = Color.White;
            button8.Location = new Point(586, 407);
            button8.Name = "button8";
            button8.Size = new Size(100, 33);
            button8.TabIndex = 15;
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
            btn_report_6.Location = new Point(459, 407);
            btn_report_6.Name = "btn_report_6";
            btn_report_6.Size = new Size(100, 33);
            btn_report_6.TabIndex = 14;
            btn_report_6.Text = "Display";
            btn_report_6.UseVisualStyleBackColor = false;
            btn_report_6.Click += btn_display_Click;
            // 
            // GetCoursesAndStudentsByInstructor_Form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(984, 450);
            Controls.Add(button8);
            Controls.Add(btn_report_6);
            Controls.Add(label1);
            Controls.Add(cb_ins);
            Controls.Add(reportViewer1);
            Name = "GetCoursesAndStudentsByInstructor_Form";
            Text = "GetCoursesAndStudentsByInstructor_Form";
            Load += GetCoursesAndStudentsByInstructor_Form_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private ComboBox cb_ins;
        private Label label1;
        private Button button8;
        private Button btn_report_6;
    }
}