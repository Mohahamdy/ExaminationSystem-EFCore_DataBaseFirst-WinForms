namespace DB_Sytem
{
    partial class GetCourseTopics_Form
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
            cb_crs = new ComboBox();
            SuspendLayout();
            // 
            // btn_display
            // 
            btn_display.Location = new Point(445, 415);
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
            btn_back.Location = new Point(554, 415);
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
            // cb_crs
            // 
            cb_crs.FormattingEnabled = true;
            cb_crs.Location = new Point(297, 415);
            cb_crs.Name = "cb_crs";
            cb_crs.Size = new Size(121, 23);
            cb_crs.TabIndex = 2;
            // 
            // GetCourseTopics_Form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(984, 450);
            Controls.Add(cb_crs);
            Controls.Add(btn_back);
            Controls.Add(btn_display);
            Controls.Add(reportViewer1);
            Name = "GetCourseTopics_Form";
            Text = "GetCourseTopics_Form";
            Load += GetCourseTopics_Form_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btn_display;
        private Button btn_back;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private ComboBox cb_crs;
    }
}