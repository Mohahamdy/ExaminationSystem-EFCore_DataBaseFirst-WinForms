using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using DB_Sytem.Models;

namespace DB_Sytem
{
    public partial class GetExamQuestionsWithStudentAnswers_Form : Form
    {
        private readonly ITIDBContext _context;

        public GetExamQuestionsWithStudentAnswers_Form()
        {
            InitializeComponent();
            _context = new ITIDBContext();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Instructor_Exam home = new Instructor_Exam(1, "mostafa");
            home.ShowDialog();
            this.Close();
        }

        private void btn_display_Click(object sender, EventArgs e)
        {
            try
            {
                int examID = (int)cb_Exam.SelectedValue;
                int studentID = (int)cb_Student.SelectedValue;

                DataTable examQuestionsWithStudentAnswers = GetExamQuestionsWithStudentAnswers(examID, studentID);

                if (examQuestionsWithStudentAnswers.Rows.Count > 0)
                {
                    reportViewer1.LocalReport.DataSources.Clear();
                    ReportDataSource reportDataSource = new ReportDataSource("GetExamQuestionsWithStudentAnswers_DataSet", examQuestionsWithStudentAnswers);
                    reportViewer1.LocalReport.ReportPath = "GetExamQuestionsWithStudentAnswers_Report.rdlc";
                    /*                    reportViewer1.LocalReport.ReportPath = "E:\\ITI 9M  44\\6_DB\\Project\\ITI_Examination_System-master\\DB_Sytem\\GetExamQuestionsWithStudentAnswers_Report.rdlc";*/
                    reportViewer1.LocalReport.DataSources.Add(reportDataSource);

                    reportViewer1.RefreshReport();
                }
                else
                {
                    MessageBox.Show("this student not have question for this exams");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }



        }

        private DataTable GetExamQuestionsWithStudentAnswers(int examID, int studentID)
        {
            DataTable dt = new DataTable();

            string connectionString = "Data Source=.;Initial Catalog=ITIFinalDBV2;Integrated Security=True;TrustServerCertificate=True";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "GetExamQuestionsWithStudentAnswers";
                SqlCommand command = new SqlCommand(query, connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@ExamID", examID);
                command.Parameters.AddWithValue("@StudentID", studentID);

                try
                {
                    connection.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    adapter.Fill(dt);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }

            return dt;
        }


        private void GetExamQuestionsWithStudentAnswers_Form_Load(object sender, EventArgs e)
        {
            var exams = _context.exams.Select(e => new { ID = e.exam_ID, Name = e.course.name.Trim() }).ToList();

            cb_Exam.DataSource = exams;
            cb_Exam.DisplayMember = "Name";
            cb_Exam.ValueMember = "ID";
            cb_Student.SelectedIndex = -1;
            cb_Exam.SelectedIndex = -1;
        }

        private void cb_Student_SelectionChangeCommitted(object sender, EventArgs e)
        {

        }

        private void cb_Exam_SelectionChangeCommitted(object sender, EventArgs e)
        {
            var exam = (int)cb_Exam.SelectedValue;
            var students = _context.st_exams.Where(s => s.exam_ID == exam).Select(c => new
            {
                ID = c.st_ID,
                name = c.st.fname.Trim() + " " + c.st.lname.Trim()

            }).ToList();

            cb_Student.DataSource = students;
            cb_Student.DisplayMember = "name";
            cb_Student.ValueMember = "ID";
        }
    }
}
