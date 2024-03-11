namespace DB_Sytem
{
	partial class CreateQuestions
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateQuestions));
			btn_insert = new Button();
			label2 = new Label();
			type = new Label();
			cb_courses = new ComboBox();
			cb_types = new ComboBox();
			lbl_backtohome = new Label();
			dgv_CourseQuestions = new DataGridView();
			label1 = new Label();
			txt_questionText = new TextBox();
			label3 = new Label();
			txt_grade = new TextBox();
			label4 = new Label();
            txt_opt1 = new TextBox();
			label5 = new Label();
            txt_opt2 = new TextBox();
			label6 = new Label();
            txt_opt3 = new TextBox();
			label7 = new Label();
            txt_opt4 = new TextBox();
            rb_opt1 = new RadioButton();
            rb_opt2 = new RadioButton();
            rb_opt3 = new RadioButton();
            rb_opt4 = new RadioButton();
            rb_true = new RadioButton();
            rb_false = new RadioButton();
			btn_update = new Button();
            PB_logout = new PictureBox();
			lbl_logout = new Label();
            gb_corAnswerTrueOrFalse = new GroupBox();
            gb_corAnswerOption = new GroupBox();
			((System.ComponentModel.ISupportInitialize)dgv_CourseQuestions).BeginInit();
            gb_corAnswerTrueOrFalse.SuspendLayout();
            gb_corAnswerOption.SuspendLayout();
			SuspendLayout();
			// 
			// btn_insert
			// 
			btn_insert.BackColor = Color.FromArgb(41, 128, 185);
			btn_insert.FlatStyle = FlatStyle.Flat;
			btn_insert.ForeColor = Color.White;
            btn_insert.Location = new Point(323, 346);
			btn_insert.Name = "btn_insert";
			btn_insert.Size = new Size(120, 34);
			btn_insert.TabIndex = 17;
			btn_insert.Text = "Insert";
			btn_insert.UseVisualStyleBackColor = false;
            btn_insert.Click += btn_insert_Click;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Segoe UI", 10F);
			label2.ForeColor = Color.FromArgb(41, 128, 185);
			label2.Location = new Point(10, 58);
			label2.Name = "label2";
			label2.Size = new Size(52, 19);
			label2.TabIndex = 15;
			label2.Text = "Course";
			// 
			// type
			// 
			type.AutoSize = true;
			type.Font = new Font("Segoe UI", 10F);
			type.ForeColor = Color.FromArgb(41, 128, 185);
			type.Location = new Point(238, 58);
			type.Name = "type";
			type.Size = new Size(37, 19);
			type.TabIndex = 16;
			type.Text = "Type";
			// 
			// cb_courses
			// 
			cb_courses.Font = new Font("Segoe UI", 12F);
			cb_courses.FormattingEnabled = true;
			cb_courses.Location = new Point(12, 81);
			cb_courses.Name = "cb_courses";
			cb_courses.Size = new Size(203, 29);
			cb_courses.TabIndex = 13;
			// 
			// cb_types
			// 
			cb_types.Font = new Font("Segoe UI", 12F);
			cb_types.FormattingEnabled = true;
            cb_types.Items.AddRange(new object[] { "True/False", "MCQ" });
			cb_types.Location = new Point(238, 81);
			cb_types.Name = "cb_types";
			cb_types.Size = new Size(203, 29);
			cb_types.TabIndex = 14;
            cb_types.SelectedIndexChanged += cb_types_SelectedIndexChanged;
			// 
			// lbl_backtohome
			// 
			lbl_backtohome.AutoSize = true;
			lbl_backtohome.Cursor = Cursors.Hand;
			lbl_backtohome.Location = new Point(8, 9);
			lbl_backtohome.Name = "lbl_backtohome";
			lbl_backtohome.Size = new Size(102, 15);
			lbl_backtohome.TabIndex = 18;
			lbl_backtohome.Text = "<< Back To Home";
			lbl_backtohome.Click += lbl_backtohome_Click;
			// 
			// dgv_CourseQuestions
			// 
			dgv_CourseQuestions.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dgv_CourseQuestions.Location = new Point(465, 21);
			dgv_CourseQuestions.Name = "dgv_CourseQuestions";
			dgv_CourseQuestions.Size = new Size(508, 396);
			dgv_CourseQuestions.TabIndex = 19;
            dgv_CourseQuestions.RowHeaderMouseDoubleClick += dgv_CourseQuestions_RowHeaderMouseDoubleClick;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Segoe UI", 10F);
			label1.ForeColor = Color.FromArgb(41, 128, 185);
			label1.Location = new Point(12, 123);
			label1.Name = "label1";
			label1.Size = new Size(33, 19);
			label1.TabIndex = 16;
			label1.Text = "Text";
			// 
			// txt_questionText
			// 
			txt_questionText.Font = new Font("Segoe UI", 12F);
			txt_questionText.Location = new Point(12, 145);
			txt_questionText.Name = "txt_questionText";
			txt_questionText.Size = new Size(205, 29);
			txt_questionText.TabIndex = 20;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Font = new Font("Segoe UI", 10F);
			label3.ForeColor = Color.FromArgb(41, 128, 185);
			label3.Location = new Point(238, 123);
			label3.Name = "label3";
			label3.Size = new Size(46, 19);
			label3.TabIndex = 16;
			label3.Text = "Grade";
			// 
			// txt_grade
			// 
			txt_grade.Font = new Font("Segoe UI", 12F);
			txt_grade.Location = new Point(238, 145);
			txt_grade.Name = "txt_grade";
			txt_grade.Size = new Size(205, 29);
			txt_grade.TabIndex = 20;
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Font = new Font("Segoe UI", 10F);
			label4.ForeColor = Color.FromArgb(41, 128, 185);
			label4.Location = new Point(12, 196);
			label4.Name = "label4";
			label4.Size = new Size(57, 19);
			label4.TabIndex = 16;
			label4.Text = "option1";
			// 
            // txt_opt1
			// 
            txt_opt1.Font = new Font("Segoe UI", 12F);
            txt_opt1.Location = new Point(12, 218);
            txt_opt1.Name = "txt_opt1";
            txt_opt1.Size = new Size(205, 29);
            txt_opt1.TabIndex = 20;
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Font = new Font("Segoe UI", 10F);
			label5.ForeColor = Color.FromArgb(41, 128, 185);
			label5.Location = new Point(12, 250);
			label5.Name = "label5";
			label5.Size = new Size(57, 19);
			label5.TabIndex = 16;
			label5.Text = "option2";
			// 
            // txt_opt2
			// 
            txt_opt2.Font = new Font("Segoe UI", 12F);
            txt_opt2.Location = new Point(12, 272);
            txt_opt2.Name = "txt_opt2";
            txt_opt2.Size = new Size(205, 29);
            txt_opt2.TabIndex = 20;
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.Font = new Font("Segoe UI", 10F);
			label6.ForeColor = Color.FromArgb(41, 128, 185);
			label6.Location = new Point(12, 307);
			label6.Name = "label6";
			label6.Size = new Size(57, 19);
			label6.TabIndex = 16;
			label6.Text = "option3";
			// 
            // txt_opt3
			// 
            txt_opt3.Font = new Font("Segoe UI", 12F);
            txt_opt3.Location = new Point(12, 329);
            txt_opt3.Name = "txt_opt3";
            txt_opt3.Size = new Size(205, 29);
            txt_opt3.TabIndex = 20;
			// 
			// label7
			// 
			label7.AutoSize = true;
			label7.Font = new Font("Segoe UI", 10F);
			label7.ForeColor = Color.FromArgb(41, 128, 185);
			label7.Location = new Point(12, 361);
			label7.Name = "label7";
			label7.Size = new Size(57, 19);
			label7.TabIndex = 16;
			label7.Text = "option4";
			// 
            // txt_opt4
			// 
            txt_opt4.Font = new Font("Segoe UI", 12F);
            txt_opt4.Location = new Point(12, 383);
            txt_opt4.Name = "txt_opt4";
            txt_opt4.Size = new Size(205, 29);
            txt_opt4.TabIndex = 20;
			// 
            // rb_opt1
			// 
            rb_opt1.AutoSize = true;
            rb_opt1.ForeColor = Color.Black;
            rb_opt1.Location = new Point(6, 22);
            rb_opt1.Name = "rb_opt1";
            rb_opt1.Size = new Size(71, 21);
            rb_opt1.TabIndex = 21;
            rb_opt1.TabStop = true;
            rb_opt1.Text = "option1";
            rb_opt1.UseVisualStyleBackColor = true;
			// 
            // rb_opt2
			// 
            rb_opt2.AutoSize = true;
            rb_opt2.ForeColor = Color.Black;
            rb_opt2.Location = new Point(6, 49);
            rb_opt2.Name = "rb_opt2";
            rb_opt2.Size = new Size(71, 21);
            rb_opt2.TabIndex = 21;
            rb_opt2.TabStop = true;
            rb_opt2.Text = "option2";
            rb_opt2.UseVisualStyleBackColor = true;
			// 
            // rb_opt3
			// 
            rb_opt3.AutoSize = true;
            rb_opt3.ForeColor = Color.Black;
            rb_opt3.Location = new Point(78, 22);
            rb_opt3.Name = "rb_opt3";
            rb_opt3.Size = new Size(71, 21);
            rb_opt3.TabIndex = 21;
            rb_opt3.TabStop = true;
            rb_opt3.Text = "option3";
            rb_opt3.UseVisualStyleBackColor = true;
			// 
            // rb_opt4
			// 
            rb_opt4.AutoSize = true;
            rb_opt4.ForeColor = Color.Black;
            rb_opt4.Location = new Point(78, 49);
            rb_opt4.Name = "rb_opt4";
            rb_opt4.Size = new Size(71, 21);
            rb_opt4.TabIndex = 21;
            rb_opt4.TabStop = true;
            rb_opt4.Text = "option4";
            rb_opt4.UseVisualStyleBackColor = true;
			// 
            // rb_true
			// 
            rb_true.AutoSize = true;
            rb_true.ForeColor = Color.Black;
            rb_true.Location = new Point(6, 22);
            rb_true.Name = "rb_true";
            rb_true.Size = new Size(51, 21);
            rb_true.TabIndex = 21;
            rb_true.TabStop = true;
            rb_true.Text = "True";
            rb_true.UseVisualStyleBackColor = true;
			// 
            // rb_false
			// 
            rb_false.AutoSize = true;
            rb_false.ForeColor = Color.Black;
            rb_false.Location = new Point(6, 47);
            rb_false.Name = "rb_false";
            rb_false.Size = new Size(55, 21);
            rb_false.TabIndex = 21;
            rb_false.TabStop = true;
            rb_false.Text = "False";
            rb_false.UseVisualStyleBackColor = true;
			// 
			// btn_update
			// 
			btn_update.BackColor = Color.Green;
			btn_update.FlatStyle = FlatStyle.Flat;
			btn_update.ForeColor = Color.White;
            btn_update.Location = new Point(323, 386);
			btn_update.Name = "btn_update";
			btn_update.Size = new Size(120, 34);
			btn_update.TabIndex = 17;
			btn_update.Text = "Update";
			btn_update.UseVisualStyleBackColor = false;
            btn_update.Click += btn_update_Click;
			// 
			// lbl_logout
			// 
			lbl_logout.AutoSize = true;
			lbl_logout.Cursor = Cursors.Hand;
			lbl_logout.ForeColor = Color.Crimson;
			lbl_logout.Location = new Point(465, 3);
			lbl_logout.Name = "lbl_logout";
			lbl_logout.Size = new Size(50, 15);
			lbl_logout.TabIndex = 22;
			lbl_logout.Text = "Log Out";
			lbl_logout.Click += lbl_logout_Click;
			// 
            // gb_corAnswerTrueOrFalse
            // 
            gb_corAnswerTrueOrFalse.Controls.Add(rb_true);
            gb_corAnswerTrueOrFalse.Controls.Add(rb_false);
            gb_corAnswerTrueOrFalse.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            gb_corAnswerTrueOrFalse.ForeColor = Color.FromArgb(41, 128, 185);
            gb_corAnswerTrueOrFalse.Location = new Point(240, 180);
            gb_corAnswerTrueOrFalse.Name = "gb_corAnswerTrueOrFalse";
            gb_corAnswerTrueOrFalse.Size = new Size(203, 74);
            gb_corAnswerTrueOrFalse.TabIndex = 23;
            gb_corAnswerTrueOrFalse.TabStop = false;
            gb_corAnswerTrueOrFalse.Text = "Correct Answer";
            // 
            // gb_corAnswerOption
            // 
            gb_corAnswerOption.Controls.Add(rb_opt1);
            gb_corAnswerOption.Controls.Add(rb_opt2);
            gb_corAnswerOption.Controls.Add(rb_opt3);
            gb_corAnswerOption.Controls.Add(rb_opt4);
            gb_corAnswerOption.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            gb_corAnswerOption.ForeColor = Color.FromArgb(41, 128, 185);
            gb_corAnswerOption.Location = new Point(238, 260);
            gb_corAnswerOption.Name = "gb_corAnswerOption";
            gb_corAnswerOption.Size = new Size(205, 80);
            gb_corAnswerOption.TabIndex = 24;
            gb_corAnswerOption.TabStop = false;
            gb_corAnswerOption.Text = "Correct Answer";
            // 
			// CreateQuestions
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(985, 432);
            Controls.Add(gb_corAnswerOption);
            Controls.Add(gb_corAnswerTrueOrFalse);
			Controls.Add(lbl_logout);
            Controls.Add(txt_opt4);
            Controls.Add(txt_opt3);
            Controls.Add(txt_opt2);
            Controls.Add(txt_opt1);
			Controls.Add(txt_grade);
			Controls.Add(txt_questionText);
			Controls.Add(dgv_CourseQuestions);
			Controls.Add(lbl_backtohome);
			Controls.Add(btn_update);
			Controls.Add(btn_insert);
			Controls.Add(label7);
			Controls.Add(label6);
			Controls.Add(label9);
			Controls.Add(label8);
			Controls.Add(label5);
			Controls.Add(label4);
			Controls.Add(label3);
			Controls.Add(label2);
			Controls.Add(label1);
			Controls.Add(type);
			Controls.Add(cb_courses);
			Controls.Add(cb_types);
			Name = "CreateQuestions";
			Text = "CreateQuestions";
            Load += CreateQuestions_Load;
			((System.ComponentModel.ISupportInitialize)dgv_CourseQuestions).EndInit();
            gb_corAnswerTrueOrFalse.ResumeLayout(false);
            gb_corAnswerTrueOrFalse.PerformLayout();
            gb_corAnswerOption.ResumeLayout(false);
            gb_corAnswerOption.PerformLayout();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Button btn_insert;

		private Label label2;
		private Label type;
		private ComboBox cb_courses;
		private ComboBox cb_types;
		private Label lbl_backtohome;
		private DataGridView dgv_CourseQuestions;
		private Label label1;
		private TextBox txt_questionText;
		private Label label3;
		private TextBox txt_grade;
		private Label label4;

        private TextBox txt_opt1;
		private Label label5;
        private TextBox txt_opt2;
		private Label label6;
        private TextBox txt_opt3;
		private Label label7;
        private TextBox txt_opt4;
        private RadioButton rb_opt1;
        private RadioButton rb_opt2;
        private RadioButton rb_opt3;
        private RadioButton rb_opt4;
        private RadioButton rb_true;
        private RadioButton rb_false;
		private Button btn_update;
        private PictureBox PB_logout;
		private Label lbl_logout;
        private GroupBox gb_corAnswerTrueOrFalse;
        private GroupBox gb_corAnswerOption;
        private Control label9;
        private Control label8;
	}




}