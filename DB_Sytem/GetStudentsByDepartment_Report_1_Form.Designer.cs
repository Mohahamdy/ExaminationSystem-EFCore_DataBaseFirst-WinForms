namespace DB_Sytem
{
    partial class GetStudentsByDepartment_Report_1_Form
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
            btn_display = new Button();
            btn_back = new Button();
            cb_depts = new ComboBox();
            SuspendLayout();
            // 
            // reportViewer1
            // 
            reportViewer1.DocumentMapWidth = 300;
            reportViewer1.Location = new Point(0, 0);
            reportViewer1.Name = "ReportViewer";
            reportViewer1.ServerReport.BearerToken = null;
            reportViewer1.Size = new Size(1000, 400);
            reportViewer1.TabIndex = 0;
            // 
            // btn_display
            // 
            btn_display.Location = new Point(436, 414);
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
            btn_back.Location = new Point(542, 414);
            btn_back.Name = "btn_back";
            btn_back.Size = new Size(75, 23);
            btn_back.TabIndex = 1;
            btn_back.Text = "Back";
            btn_back.UseVisualStyleBackColor = false;
            btn_back.Click += btn_back_Click;
            // 
            // cb_depts
            // 
            cb_depts.FormattingEnabled = true;
            cb_depts.Location = new Point(275, 414);
            cb_depts.Name = "cb_depts";
            cb_depts.Size = new Size(121, 23);
            cb_depts.TabIndex = 2;
            // 
            // GetStudentsByDepartment_Report_1_Form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1004, 449);
            Controls.Add(cb_depts);
            Controls.Add(btn_back);
            Controls.Add(btn_display);
            Controls.Add(reportViewer1);
            Name = "GetStudentsByDepartment_Report_1_Form";
            Text = "Report_1_Form";
            Load += GetStudentsByDepartment_Report_1_Form_Load;
            ResumeLayout(false);
        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private Button btn_display;
        private Button btn_back;
        private ComboBox cb_depts;
    }
}