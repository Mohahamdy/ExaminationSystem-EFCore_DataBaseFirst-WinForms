using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using DB_Sytem.Models;
using Microsoft.Reporting.WinForms;

namespace DB_Sytem
{
    public partial class GetStudentGrades_Form : Form
    {
        ITIDBContext context = new ITIDBContext();
        public GetStudentGrades_Form()
        {
            InitializeComponent();
        }

        private void btn_display_Click(object sender, EventArgs e)
        {
            try
            {
                int studentID = (int)cb_student.SelectedValue;

                DataTable studentGrades = GetStudentGrades(studentID);

                if (studentGrades.Rows.Count > 0)
                {

                    reportViewer1.LocalReport.DataSources.Clear();
                    ReportDataSource reportDataSource = new ReportDataSource("GetStudentGrades_DataSet", studentGrades);
                    //reportViewer1.LocalReport.ReportPath = "E:\\ITI 9M  44\\6_DB\\Project\\ITI_Examination_System-master\\DB_Sytem\\GetStudentGrades_Report.rdlc"; 
                    //reportViewer1.LocalReport.ReportPath = "C:\\Users\\SHaFiQ\\Downloads\\ITI_Examination_System-master\\ITI_Examination_System-master\\DB_Sytem\\GetStudentGrades_Report.rdlc";

                    reportViewer1.LocalReport.ReportPath = "GetStudentGrades_Report.rdlc";

                    reportViewer1.LocalReport.DataSources.Add(reportDataSource);
                    reportViewer1.RefreshReport();
                }
                else
                {
                    MessageBox.Show("No grades available for the selected student.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            // Assuming you have a form named Instructor_Exam to navigate back
            Instructor_Exam home = new Instructor_Exam(1, "mostafa");
            home.ShowDialog();
            this.Close();
            this.Close();
        }

        private DataTable GetStudentGrades(int studentID)
        {
            DataTable gradesTable = new DataTable();

            try
            {
                string connectionString = "Data Source=.;Initial Catalog=ITIFinalDBV2;Integrated Security=True;TrustServerCertificate=True";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("GetStudentGrades", connection);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@StudentID", studentID);

                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        adapter.Fill(gradesTable);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while retrieving student grades: " + ex.Message);
            }

            return gradesTable;
        }

        private void GetStudentGrades_Form_Load(object sender, EventArgs e)
        {
            var students = context.students.ToList();
            cb_student.DataSource = students;
            cb_student.DisplayMember = "fname";
            cb_student.ValueMember = "st_ID";
        }
    }
}
