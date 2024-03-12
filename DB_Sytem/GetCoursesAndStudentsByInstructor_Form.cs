using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using Microsoft.EntityFrameworkCore;
using DB_Sytem.Models;

namespace DB_Sytem
{
    public partial class GetCoursesAndStudentsByInstructor_Form : Form
    {
        private readonly ITIDBContext _context;
        private readonly GetCoursesAndStudentsByInstructor_DataSet _DataSet;

        public GetCoursesAndStudentsByInstructor_Form()
        {
            InitializeComponent();
            _context = new ITIDBContext();
            _DataSet = new GetCoursesAndStudentsByInstructor_DataSet();
        }

        private void btn_display_Click(object sender, EventArgs e)
        {
            int instructorID = (int)cb_ins.SelectedValue;

            var courses = _context.Database.SqlQuery<GetCoursesAndStudentsByInstructor_class>(
                $"EXEC dbo.GetCoursesAndStudentsByInstructor {instructorID}"
            )
            .AsNoTracking()
            .ToList();

            _DataSet.GetCoursesAndStudentsByInstructor.Clear();

            foreach (var course in courses)
            {
                var row = _DataSet.GetCoursesAndStudentsByInstructor.NewGetCoursesAndStudentsByInstructorRow();
                row.course_name = course.course_name; // Adjusted property name
                row.num_students = course.num_students;
                _DataSet.GetCoursesAndStudentsByInstructor.AddGetCoursesAndStudentsByInstructorRow(row);
            }

            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("GetCoursesAndStudentsByInstructor_DataSet", _DataSet.Tables["GetCoursesAndStudentsByInstructor"]));
            reportViewer1.LocalReport.ReportPath = "GetCoursesAndStudentsByInstructor_Report.rdlc";
            reportViewer1.RefreshReport();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Instructor_Exam home = new Instructor_Exam(1, "mostafa");
            home.ShowDialog();
            this.Close();
        }

        private void GetCoursesAndStudentsByInstructor_Form_Load(object sender, EventArgs e)
        {
            var instructors = _context.instructors.ToList();
            cb_ins.DataSource = instructors;

            cb_ins.DisplayMember = "fname";
            cb_ins.ValueMember = "ins_ID";
        }
    }

    internal class GetCoursesAndStudentsByInstructor_class
    {
        public string course_name { get; set; } // This should match the column alias "course_name" in the stored procedure

        public int num_students { get; set; } // This should match the column alias "num_students" in the stored procedure
    }

}
