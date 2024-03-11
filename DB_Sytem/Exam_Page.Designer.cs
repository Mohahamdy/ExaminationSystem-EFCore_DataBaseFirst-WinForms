namespace DB_Sytem
{
    partial class Exam_Page
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
            components = new System.ComponentModel.Container();
            groupBox1 = new GroupBox();
            lbl_grade = new Label();
            lbl_time = new Label();
            lbl_crsName = new Label();
            btn_submit = new Button();
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            panel1 = new Panel();
            timer1 = new System.Windows.Forms.Timer(components);
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lbl_grade);
            groupBox1.Controls.Add(lbl_time);
            groupBox1.Controls.Add(lbl_crsName);
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(867, 76);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Exam Data";
            // 
            // lbl_grade
            // 
            lbl_grade.AutoSize = true;
            lbl_grade.Location = new Point(306, 34);
            lbl_grade.Name = "lbl_grade";
            lbl_grade.Size = new Size(55, 21);
            lbl_grade.TabIndex = 2;
            lbl_grade.Text = "Grade:";
            // 
            // lbl_time
            // 
            lbl_time.AutoSize = true;
            lbl_time.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_time.Location = new Point(572, 34);
            lbl_time.Name = "lbl_time";
            lbl_time.Size = new Size(89, 21);
            lbl_time.TabIndex = 1;
            lbl_time.Text = "Time Left :";
            // 
            // lbl_crsName
            // 
            lbl_crsName.AutoSize = true;
            lbl_crsName.Location = new Point(26, 34);
            lbl_crsName.Name = "lbl_crsName";
            lbl_crsName.Size = new Size(89, 21);
            lbl_crsName.TabIndex = 0;
            lbl_crsName.Text = "Crs_Name :";
            // 
            // btn_submit
            // 
            btn_submit.Font = new Font("Segoe UI", 12F);
            btn_submit.Location = new Point(318, 809);
            btn_submit.Name = "btn_submit";
            btn_submit.Size = new Size(165, 45);
            btn_submit.TabIndex = 3;
            btn_submit.Text = "Submit";
            btn_submit.UseVisualStyleBackColor = true;
            btn_submit.Click += btn_submit_Click;
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.EnableOptimizedParameterBinding = false;
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.Location = new Point(12, 94);
            panel1.Name = "panel1";
            panel1.Size = new Size(867, 709);
            panel1.TabIndex = 4;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // Exam_Page
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(891, 866);
            Controls.Add(btn_submit);
            Controls.Add(groupBox1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Exam_Page";
            Text = "Exam_Page";
            Load += Exam_Page_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label lbl_crsName;
        private Label lbl_grade;
        private Label lbl_time;
        private Button btn_submit;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private Panel panel1;
        private System.Windows.Forms.Timer timer1;
    }
}