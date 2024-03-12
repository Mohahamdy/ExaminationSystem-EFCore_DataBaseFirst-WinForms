using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using DB_Sytem.Models;
using System.Diagnostics.Metrics;

namespace DB_Sytem
{
    public partial class GetExamQuestionsAndChoices_Form : Form
    {
        private readonly ITIDBContext _context;

        public GetExamQuestionsAndChoices_Form()
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
                //int examID = 1;
                int examID = (int)cb_exams.SelectedValue;

                DataTable examQuestionsAndChoices = GetExamQuestionsAndChoices(examID);

                if (examQuestionsAndChoices.Rows.Count > 0)
                {
                    reportViewer1.LocalReport.DataSources.Clear();
                    ReportDataSource reportDataSource = new ReportDataSource("GetExamQuestionsAndChoices_DataSet", examQuestionsAndChoices);
                    reportViewer1.LocalReport.DataSources.Add(reportDataSource);

                    /*        reportViewer1.LocalReport.ReportPath = "C:\\Users\\SHaFiQ\\Downloads\\ITI_Examination_System-master\\ITI_Examination_System-master\\DB_Sytem\\GetExamQuestionsAndChoices_Report.rdlc";   */
                    reportViewer1.LocalReport.ReportPath = "GetExamQuestionsAndChoices_Report.rdlc";
                    reportViewer1.RefreshReport();
                }
                else
                {
                    MessageBox.Show("No data available for the selected exam.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }


        private DataTable GetExamQuestionsAndChoices(int examID)
        {
            DataTable dt = new DataTable();

            string connectionString = "Data Source=.;Initial Catalog=ITIFinalDBV2;Integrated Security=True;TrustServerCertificate=True";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "GetExamQuestionsAndChoices";
                SqlCommand command = new SqlCommand(query, connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@ExamID", examID);

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

        private void GetExamQuestionsAndChoices_Form_Load(object sender, EventArgs e)
        {

            var courses = _context.courses.ToList();

            cb_subjects.DataSource = courses;
            cb_subjects.DisplayMember = "name";
            cb_subjects.ValueMember = "course_ID";
            cb_exams.SelectedIndex = -1;
            cb_subjects.SelectedIndex = -1;

        }

        private void cb_subjects_SelectionChangeCommitted(object sender, EventArgs e)
        {
            int crs = (int)cb_subjects.SelectedValue;
            var exams = _context.exams.Where(e => e.course_ID == crs).ToList();

            cb_exams.DataSource = exams;
            cb_exams.DisplayMember = "exam_ID";
            cb_exams.ValueMember = "exam_ID";
            cb_exams.SelectedIndex = -1;

        }
    }
}
