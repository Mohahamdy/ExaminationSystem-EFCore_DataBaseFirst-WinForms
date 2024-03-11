using DB_Sytem.Models;
using Microsoft.EntityFrameworkCore;
using System;

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

	public partial class CreateQuestions : Form
	{
        ITIDBContext db = new ITIDBContext();


        int ins_id;
        string INS_name;
        public CreateQuestions(int insId, string insName)
		{
			InitializeComponent();
            ins_id = insId;
            INS_name = insName;
		}

		private void lbl_backtohome_Click(object sender, EventArgs e)
		{
			this.Hide();

            Instructor_HomePage home = new Instructor_HomePage(ins_id, INS_name);
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

        private void CreateQuestions_Load(object sender, EventArgs e)
        {
            dgv_CourseQuestions.DataSource = db.questions.Select(q => new
            {
                q.question_ID,
                CourseName = q.course.name,
                QuestionText = q.text,
                QuestionType = q.type,
                QuestionCorrectAnswer = q.correct_ans,
                QuestionGrade = q.grade,
                QuestionOption1 = q.question_option.opt1,
                QuestionOption2 = q.question_option.opt2,
                QuestionOption3 = q.question_option.opt3,
                QuestionOption4 = q.question_option.opt4
            }).OrderBy(c=>c.QuestionType).ToList();

            dgv_CourseQuestions.Columns[0].Visible = false;

            cb_courses.DataSource = db.ins_course_depts.Where(ic=> ic.ins_ID ==  ins_id).Select(ic=> ic.course).Distinct().ToList();
            cb_courses.DisplayMember = "name";
            cb_courses.ValueMember = "course_ID";
            cb_courses.SelectedIndex = -1;

            cb_types.SelectedIndex = -1;

            btn_update.Visible = false;
        }

        private void updateForm()
        {
            dgv_CourseQuestions.DataSource = db.questions.Select(q => new
            {
                q.question_ID,
                CourseName = q.course.name,
                QuestionText = q.text,
                QuestionType = q.type,
                QuestionCorrectAnswer = q.correct_ans,
                QuestionGrade = q.grade,
                QuestionOption1 = q.question_option.opt1,
                QuestionOption2 = q.question_option.opt2,
                QuestionOption3 = q.question_option.opt3,
                QuestionOption4 = q.question_option.opt4
            }).ToList();

            dgv_CourseQuestions.Columns[0].Visible = false;
            cb_courses.SelectedIndex = cb_types.SelectedIndex = -1;
            txt_grade.Text = txt_questionText.Text = txt_opt1.Text = txt_opt2.Text = txt_opt3.Text = txt_opt4.Text = string.Empty;
            rb_opt1.Checked = rb_opt2.Checked = rb_opt3.Checked = rb_opt4.Checked = rb_true.Checked = rb_false.Checked = false;
            txt_opt1.Enabled = txt_opt2.Enabled = txt_opt3.Enabled = txt_opt4.Enabled = gb_corAnswerOption.Enabled = gb_corAnswerTrueOrFalse.Enabled = true;

            MessageBox.Show("Great Job ....!", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private async void btn_insert_Click(object sender, EventArgs e)
        {
            ITIDBContextProcedures dbProc = new ITIDBContextProcedures(db);
            try
            {
                if (cb_types.SelectedIndex == 0)
                {
                    await dbProc.insert_QuestionAsync(
                            txt_questionText.Text,
                            cb_types.SelectedItem.ToString(),
                            (rb_true.Checked ? "True" : "False"),
                            int.Parse(txt_grade.Text),
                            (int)cb_courses.SelectedValue, null, null, null, null);

                    await db.SaveChangesAsync();

                    updateForm();
                }
                else
                {
                    string correctAnswer = "";
                    if (rb_opt1.Checked)
                        correctAnswer = txt_opt1.Text;
                    else if (rb_opt2.Checked)
                        correctAnswer = txt_opt2.Text;
                    else if (rb_opt3.Checked)
                        correctAnswer = txt_opt3.Text;
                    else
                        correctAnswer = txt_opt4.Text;

                    await dbProc.insert_QuestionAsync(
                            txt_questionText.Text,
                            cb_types.SelectedItem.ToString(),
                            correctAnswer,
                            int.Parse(txt_grade.Text),
                            (int)cb_courses.SelectedValue,
                            txt_opt1.Text,
                            txt_opt2.Text,
                            txt_opt3.Text,
                            txt_opt4.Text
                            );

                    await db.SaveChangesAsync();

                    updateForm();

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong, Check your Data and try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
	}

        private void cb_types_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cb_types.SelectedIndex == 0)
                {
                    txt_opt1.Enabled = txt_opt2.Enabled = txt_opt3.Enabled = txt_opt4.Enabled = gb_corAnswerOption.Enabled = false;
                    gb_corAnswerTrueOrFalse.Enabled = true;
                }
                else
                {
                    txt_opt1.Enabled = txt_opt2.Enabled = txt_opt3.Enabled = txt_opt4.Enabled = gb_corAnswerOption.Enabled = true;
                    gb_corAnswerTrueOrFalse.Enabled = false;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        int questionID = 0;
        private void dgv_CourseQuestions_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                question q = db.questions.Include(q => q.question_option).FirstOrDefault(q => q.question_ID == (int)dgv_CourseQuestions.SelectedRows[0].Cells[0].Value);
                questionID = q.question_ID;

                btn_insert.Visible = false;
                btn_update.Visible = true;
                cb_courses.SelectedValue = q.course_ID;
                txt_grade.Text = q.grade.ToString();
                txt_questionText.Text = q.text;

                if (q.type == "True/False")
                {
                    txt_opt1.Enabled = txt_opt2.Enabled = txt_opt3.Enabled = txt_opt4.Enabled = gb_corAnswerOption.Enabled = false;
                    cb_types.SelectedIndex = 0;
                    if (q.correct_ans == "True")
                        rb_true.Checked = true;
                    else
                        rb_false.Checked = true;
                }
                else
                {
                    gb_corAnswerTrueOrFalse.Enabled = false;
                    cb_types.SelectedIndex = 1;
                    txt_opt1.Text = q.question_option.opt1;
                    txt_opt2.Text = q.question_option.opt2;
                    txt_opt3.Text = q.question_option.opt3;
                    txt_opt4.Text = q.question_option.opt4;
                    if (q.correct_ans == q.question_option.opt1)
                        rb_opt1.Checked = true;
                    else if (q.correct_ans == q.question_option.opt2)
                        rb_opt2.Checked = true;
                    else if (q.correct_ans == q.question_option.opt3)
                        rb_opt3.Checked = true;
                    else
                        rb_opt4.Checked = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            try
            {
                question q = db.questions.FirstOrDefault(q => q.question_ID == questionID);

                q.course_ID = (int)cb_courses.SelectedValue;
                q.type = cb_types.SelectedItem.ToString();
                q.text = txt_questionText.Text;
                q.grade = int.Parse(txt_grade.Text);

                if (q.type == "True/False")
                {
                    q.correct_ans = (rb_true.Checked ? "True" : "False");
                }
                else
                {
                    question_option qOption = db.question_options.FirstOrDefault(q => q.question_ID == questionID);

                    qOption.opt1 = txt_opt1.Text;
                    qOption.opt2 = txt_opt2.Text;
                    qOption.opt3 = txt_opt3.Text;
                    qOption.opt4 = txt_opt4.Text;

                    if (rb_opt1.Checked)
                        q.correct_ans = txt_opt1.Text;
                    else if (rb_opt2.Checked)
                        q.correct_ans = txt_opt2.Text;
                    else if (rb_opt3.Checked)
                        q.correct_ans = txt_opt3.Text;
                    else
                        q.correct_ans = txt_opt4.Text;

                }

                db.SaveChanges();
                btn_insert.Visible = true;
                btn_update.Visible = false;
                updateForm();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong, Check your Data and try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }

}
