namespace DB_Sytem
{
    partial class Student_Crud
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
            label1 = new Label();
            txt_firstname = new TextBox();
            txt_lastname = new TextBox();
            label2 = new Label();
            txt_address = new TextBox();
            label3 = new Label();
            label4 = new Label();
            nb_age = new NumericUpDown();
            label5 = new Label();
            cb_Dept = new ComboBox();
            dgv_Students = new DataGridView();
            btn_insert = new Button();
            btn_update = new Button();
            btn_delete = new Button();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)nb_age).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgv_Students).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(25, 25);
            label1.Name = "label1";
            label1.Size = new Size(93, 21);
            label1.TabIndex = 0;
            label1.Text = "First Name :";
            // 
            // txt_firstname
            // 
            txt_firstname.Font = new Font("Segoe UI", 12F);
            txt_firstname.Location = new Point(139, 22);
            txt_firstname.Name = "txt_firstname";
            txt_firstname.Size = new Size(157, 29);
            txt_firstname.TabIndex = 1;
            // 
            // txt_lastname
            // 
            txt_lastname.Font = new Font("Segoe UI", 12F);
            txt_lastname.Location = new Point(139, 72);
            txt_lastname.Name = "txt_lastname";
            txt_lastname.Size = new Size(157, 29);
            txt_lastname.TabIndex = 3;
            txt_lastname.TextChanged += textBox2_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(27, 75);
            label2.Name = "label2";
            label2.Size = new Size(91, 21);
            label2.TabIndex = 2;
            label2.Text = "Last Name :";
            // 
            // txt_address
            // 
            txt_address.Font = new Font("Segoe UI", 12F);
            txt_address.Location = new Point(139, 123);
            txt_address.Name = "txt_address";
            txt_address.Size = new Size(157, 29);
            txt_address.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(45, 126);
            label3.Name = "label3";
            label3.Size = new Size(73, 21);
            label3.TabIndex = 4;
            label3.Text = "Address :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(74, 177);
            label4.Name = "label4";
            label4.Size = new Size(44, 21);
            label4.TabIndex = 6;
            label4.Text = "Age :";
            // 
            // nb_age
            // 
            nb_age.Font = new Font("Segoe UI", 12F);
            nb_age.Location = new Point(139, 174);
            nb_age.Name = "nb_age";
            nb_age.Size = new Size(157, 29);
            nb_age.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(18, 222);
            label5.Name = "label5";
            label5.Size = new Size(100, 21);
            label5.TabIndex = 9;
            label5.Text = "Department :";
            // 
            // cb_Dept
            // 
            cb_Dept.AccessibleName = "";
            cb_Dept.Font = new Font("Segoe UI", 12F);
            cb_Dept.FormattingEnabled = true;
            cb_Dept.Location = new Point(139, 219);
            cb_Dept.Name = "cb_Dept";
            cb_Dept.Size = new Size(157, 29);
            cb_Dept.TabIndex = 10;
            // 
            // dgv_Students
            // 
            dgv_Students.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_Students.Location = new Point(365, 2);
            dgv_Students.Name = "dgv_Students";
            dgv_Students.Size = new Size(450, 501);
            dgv_Students.TabIndex = 11;
            dgv_Students.RowHeaderMouseDoubleClick += dgv_Students_RowHeaderMouseDoubleClick;
            // 
            // btn_insert
            // 
            btn_insert.BackColor = Color.FromArgb(41, 128, 185);
            btn_insert.FlatStyle = FlatStyle.Flat;
            btn_insert.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btn_insert.ForeColor = Color.White;
            btn_insert.Location = new Point(50, 279);
            btn_insert.Name = "btn_insert";
            btn_insert.Size = new Size(246, 34);
            btn_insert.TabIndex = 14;
            btn_insert.Text = "Insert";
            btn_insert.UseVisualStyleBackColor = false;
            btn_insert.Click += btn_insert_Click;
            // 
            // btn_update
            // 
            btn_update.BackColor = Color.ForestGreen;
            btn_update.FlatStyle = FlatStyle.Flat;
            btn_update.Font = new Font("Segoe UI", 12F);
            btn_update.ForeColor = Color.White;
            btn_update.Location = new Point(50, 336);
            btn_update.Name = "btn_update";
            btn_update.Size = new Size(103, 33);
            btn_update.TabIndex = 12;
            btn_update.Text = "Update";
            btn_update.UseVisualStyleBackColor = false;
            btn_update.Click += btn_update_Click;
            // 
            // btn_delete
            // 
            btn_delete.BackColor = Color.Crimson;
            btn_delete.FlatStyle = FlatStyle.Flat;
            btn_delete.Font = new Font("Segoe UI", 12F);
            btn_delete.ForeColor = Color.White;
            btn_delete.Location = new Point(196, 336);
            btn_delete.Name = "btn_delete";
            btn_delete.Size = new Size(100, 33);
            btn_delete.TabIndex = 13;
            btn_delete.Text = "Delete";
            btn_delete.UseVisualStyleBackColor = false;
            btn_delete.Click += btn_delete_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.DarkSlateGray;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 12F);
            button1.ForeColor = Color.White;
            button1.Location = new Point(126, 393);
            button1.Name = "button1";
            button1.Size = new Size(100, 33);
            button1.TabIndex = 15;
            button1.Text = "Back";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Student_Crud
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(817, 501);
            Controls.Add(button1);
            Controls.Add(btn_insert);
            Controls.Add(btn_update);
            Controls.Add(btn_delete);
            Controls.Add(dgv_Students);
            Controls.Add(cb_Dept);
            Controls.Add(label5);
            Controls.Add(nb_age);
            Controls.Add(label4);
            Controls.Add(txt_address);
            Controls.Add(label3);
            Controls.Add(txt_lastname);
            Controls.Add(label2);
            Controls.Add(txt_firstname);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Student_Crud";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Student_Crud";
            Load += Student_Crud_Load;
            ((System.ComponentModel.ISupportInitialize)nb_age).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgv_Students).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txt_firstname;
        private TextBox txt_lastname;
        private Label label2;
        private TextBox txt_address;
        private Label label3;
        private Label label4;
        private NumericUpDown nb_age;
        private Label label5;
        private ComboBox cb_Dept;
        private DataGridView dgv_Students;
        private Button btn_insert;
        private Button btn_update;
        private Button btn_delete;
        private Button button1;
    }
}