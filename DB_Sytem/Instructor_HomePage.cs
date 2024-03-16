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

namespace DB_Sytem
{
    public partial class Instructor_HomePage : Form
    {
        ITIDBContext context = new ITIDBContext();
        string INS_name = "";
        int ins_id;
        public Instructor_HomePage(int insId, string ins_name = "")
        {
            InitializeComponent();
            INS_name = ins_name;
            ins_id = insId;
        }

        //private void button1_Click(object sender, EventArgs e)
        //{
        //	this.Hide();
        //	Instructor_Exam examWindow = new Instructor_Exam();
        //	examWindow.ShowDialog();
        //	this.Close();
        //}

        private void btn_allExams_Click(object sender, EventArgs e)
        {
            this.Hide();
            ExamDetails examDetails = new ExamDetails(ins_id, INS_name);
            examDetails.ShowDialog();
            this.Close();
        }
        private void btn_createExam_Click(object sender, EventArgs e)
        {
            this.Hide();
            Instructor_Exam examWindow = new Instructor_Exam(ins_id, INS_name);
            examWindow.ShowDialog();
            this.Close();
        }
        private void btn_createQues_Click(object sender, EventArgs e)
        {
            this.Hide();
            CreateQuestions ques = new CreateQuestions(ins_id, INS_name);
            ques.ShowDialog();
            this.Close();
        }
        private void btn_answers_Click(object sender, EventArgs e)
        {
            this.Hide();
            ExamAnswers stsAnswers = new ExamAnswers(ins_id, INS_name);
            stsAnswers.ShowDialog();
            this.Close();
        }
        private void btn_studentsGrades_Click(object sender, EventArgs e)
        {
            this.Hide();
            StudentsGradeForm stsGrades = new StudentsGradeForm(ins_id, INS_name);
            stsGrades.ShowDialog();
            this.Close();
        }


        private void lbl_logout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.ShowDialog();
            this.Close();
        }

        private void Instructor_HomePage_Load(object sender, EventArgs e)
        {
            lbl_insName.Text = $"Welcome {INS_name}";
        }

        private void btn_student_Click(object sender, EventArgs e)
        {
            this.Hide();
            Student_Crud st = new Student_Crud(ins_id, INS_name);
            st.ShowDialog();
            this.Close();
        }

        private void btn_stdCrs_Click(object sender, EventArgs e)
        {
            this.Hide();
            Student_Crud_Courses st = new Student_Crud_Courses(ins_id, INS_name);
            st.ShowDialog();
            this.Close();
        }
    }
}
