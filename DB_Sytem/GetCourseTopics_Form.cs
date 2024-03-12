using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using DB_Sytem.Models;

namespace DB_Sytem
{
    public partial class GetCourseTopics_Form : Form
    {
        private readonly ITIDBContext _context;

        public GetCourseTopics_Form()
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
                int courseID = (int)cb_crs.SelectedValue;
                //int courseID = 1;

                DataTable topics = GetCourseTopics(courseID);

                if (topics.Rows.Count > 0)
                {
                    reportViewer1.LocalReport.DataSources.Clear();
                    ReportDataSource reportDataSource = new ReportDataSource("GetCourseTopics_DataSet", topics);
                    reportViewer1.LocalReport.DataSources.Add(reportDataSource);
                    //reportViewer1.LocalReport.ReportPath = "E:\\ITI 9M  44\\6_DB\\Project\\ITI_Examination_System-master\\DB_Sytem\\GetCourseTopics_Report.rdlc"; // Specify the report definition file
                    reportViewer1.LocalReport.ReportPath = "GetCourseTopics_Report.rdlc";
                    reportViewer1.RefreshReport();
                }
                else
                {
                    MessageBox.Show("No topics available for the selected course.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private DataTable GetCourseTopics(int courseID)
        {
            DataTable dt = new DataTable();

            string connectionString = "Data Source=.;Initial Catalog=ITIFinalDBV2;Integrated Security=True;TrustServerCertificate=True";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "GetCourseTopics";
                SqlCommand command = new SqlCommand(query, connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@CourseID", courseID);

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

        private void GetCourseTopics_Form_Load(object sender, EventArgs e)
        {
            var courses = _context.courses.ToList();

            cb_crs.DataSource = courses;
            cb_crs.DisplayMember = "name";
            cb_crs.ValueMember = "course_ID";
        }
    }
}
