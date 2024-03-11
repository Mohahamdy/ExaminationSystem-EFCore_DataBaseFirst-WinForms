using DB_Sytem.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DB_Sytem
{
	public partial class ExamAnswers : Form
	{
        ITIDBContext db = new ITIDBContext();
        int ins_id = 0;
        string ins_name = "";
        public ExamAnswers(int in_id, string in_name)
		{
			InitializeComponent();
            ins_id = in_id;
            ins_name = in_name;
		}

		private void lbl_backtohome_Click(object sender, EventArgs e)
		{
			this.Hide();
            Instructor_HomePage home = new Instructor_HomePage(ins_id, ins_name);
			home.ShowDialog();
			this.Close();
		}

		private void lbl_logout_Click(object sender, EventArgs e)
		{
			this.Hide();
			Login login = new Login();
			login.ShowDialog();
			this.Close();
		}



        private void ExamAnswers_Load(object sender, EventArgs e)
        {
            try
            {
                //cb_departments.DataSource = db.departments.Select(n => new { Key = n.dept_ID, Value = n.name }).ToList();
                //cb_departments.DisplayMember = "Value";
                //cb_departments.ValueMember = "Key";
                cb_courses.DataSource = db.courses.Select(n => new { key = n.course_ID, Value = n.name }).ToList();
                cb_courses.DisplayMember = "Value";
                cb_courses.ValueMember = "Key";
                cb_students.DataSource = db.students.Select(n => new { Key = n.st_ID, Value = n.fname + n.lname }).ToList();
                cb_students.DisplayMember = "Value";
                cb_students.ValueMember = "Key";
            }catch(Exception ex)
            {
                MessageBox.Show("Something Went Wrong, Please try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_show_Click(object sender, EventArgs e)
        {
            try
            {
                int chooseStudentID = (int)cb_students.SelectedValue;
                //int chooseDepartmentID = (int)cb_departments.SelectedValue;
                int chooseCourseID = (int)cb_courses.SelectedValue;

                //var studentAnswer = db.st_answers.Where(n => n.st_ID == chooseStudentID && n.st.dept_ID == chooseDepartmentID && n.exam.course_ID == chooseCourseID)
                //    .Select(n => new { n.answer }).ToList();
                var studentAnswer = db.st_answers.Where(n => n.st_ID == chooseStudentID && n.exam.course_ID == chooseCourseID).Select(e => new { e.exam_ID, e.question.text, e.answer, e.question.correct_ans, e.grade }).ToList();
                if (studentAnswer.Count == 0)
                {
                    dgv_ExamAnswers.DataSource = null;
                }
                else
                {
                    dgv_ExamAnswers.DataSource = studentAnswer;
                }
            }catch(Exception ex)
            {
                MessageBox.Show("Something Went Wrong, Please try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
	}
}
