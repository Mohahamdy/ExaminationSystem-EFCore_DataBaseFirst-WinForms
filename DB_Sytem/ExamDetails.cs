using DB_Sytem.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DB_Sytem
{
	public partial class ExamDetails : Form
	{
        ITIDBContext db;
        int ins_id;
        string ins_name;
        public ExamDetails(int insId, string insName)
		{
			InitializeComponent();
            db = new ITIDBContext();
            ins_id = insId;
            ins_name = insName;
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

        private void ExamDetails_Load(object sender, EventArgs e)
        {
            try
            {
                var coursesIDs = db.ins_course_depts.Where(x => x.ins_ID == ins_id).Select(x => x.course_ID).Distinct().ToList();
                var allCourses = db.courses.ToList();

                List<course> list = new List<course>();

                foreach (var id in coursesIDs)
                {
                    foreach (var course in allCourses)
                    {
                        if (id == course.course_ID)
                        {
                            list.Add(course);
                        }
                    }
                }

                cb_courses.DataSource = list;
                cb_courses.DisplayMember = "name";
                cb_courses.ValueMember = "course_ID";

                cb_courses.SelectedIndex = -1;
            }catch(Exception ex)
            {
                MessageBox.Show("Something Went Wrong, Please try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void cb_courses_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                int.TryParse(cb_courses.SelectedValue.ToString(), out var selectedItem);
                var exams = db.exams.Where(x => x.course_ID == selectedItem).ToList();

                cb_courseExams.DataSource = exams;
                cb_courseExams.DisplayMember = "exam_ID";
                cb_courseExams.ValueMember = "exam_ID";
            }catch(Exception ex)
            {
                MessageBox.Show("Something Went Wrong, Please try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_showExam_Click(object sender, EventArgs e)
        {
            try
            {
                if (cb_courseExams.SelectedIndex != -1)
                {
                    //var cb = cb_courseExams.SelectedValue.ToString();

                    int.TryParse(cb_courseExams.SelectedValue.ToString(), out var selectedExamID);
                    var exam = db.exams.FirstOrDefault(x => x.exam_ID == selectedExamID);


                    lbl_id.Text = exam.exam_ID.ToString();
                    lbl_date.Text = exam.date.ToString();
                    lbl_time.Text = exam.time.ToString();
                    lbl_duration.Text = exam.duration.ToString();
                    lbl_course.Text = db.courses.Where(x => x.course_ID == exam.course_ID).Select(x => x.name).FirstOrDefault().ToString();
                    //lbl_numOfStudents.Text = db.st_exams.Where(x => x.exam_ID == exam.exam_ID).Count().ToString();

                    lbl_msg.Visible = false;

                    var examQuestions = db.questions.Where(q => q.exams.Any(e => e.exam_ID == selectedExamID));

                    //MCQ Questions
                    dgv_ExamQuestionsMCQ.DataSource = examQuestions.Where(x => x.type == "MCQ").ToList();
                    dgv_ExamQuestionsMCQ.Columns["course_ID"].Visible = false;
                    dgv_ExamQuestionsMCQ.Columns["type"].Visible = false;
                    dgv_ExamQuestionsMCQ.Columns["course"].Visible = false;
                    dgv_ExamQuestionsMCQ.Columns["question_option"].Visible = false;
                    dgv_ExamQuestionsMCQ.Columns["st_answers"].Visible = false;
                    dgv_ExamQuestionsMCQ.Columns["exams"].Visible = false;



                    //MCQ Questions                
                    dgv_ExamQuestionsTF.DataSource = examQuestions.Where(x => x.type == "True/False").ToList();
                    dgv_ExamQuestionsTF.Columns["course_ID"].Visible = false;
                    dgv_ExamQuestionsTF.Columns["type"].Visible = false;
                    dgv_ExamQuestionsTF.Columns["course"].Visible = false;
                    dgv_ExamQuestionsTF.Columns["question_option"].Visible = false;
                    dgv_ExamQuestionsTF.Columns["st_answers"].Visible = false;
                    dgv_ExamQuestionsTF.Columns["exams"].Visible = false;

                    //number of students
                    var numOfStds = db.st_exams.Where(x => x.exam_ID == selectedExamID).Count();
                    lbl_numOfStudents.Text = numOfStds.ToString();
                }
            }catch(Exception ex)
            {
                MessageBox.Show("Something Went Wrong, Please try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
	}
}
