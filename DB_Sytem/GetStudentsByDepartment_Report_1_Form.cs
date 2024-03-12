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
using Microsoft.Reporting.WinForms;
using Microsoft.EntityFrameworkCore;

namespace DB_Sytem
{
    public partial class GetStudentsByDepartment_Report_1_Form : Form
    {
        private readonly ITIDBContext _context;
        private readonly GetStudentsByDepartment_DataSet _DataSet;

        public GetStudentsByDepartment_Report_1_Form()
        {
            InitializeComponent();
            _context = new ITIDBContext();
            _DataSet = new GetStudentsByDepartment_DataSet();
        }

        private void GetStudentsByDepartment_Report_1_Form_Load(object sender, EventArgs e)
        {
            var depts = _context.departments.ToList();

            cb_depts.DataSource = depts;
            cb_depts.DisplayMember = "name";
            cb_depts.ValueMember = "dept_ID";

        }
        private void cb_Dept_Num_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }
        private void btn_display_Click(object sender, EventArgs e)
        {

            int departmentID = (int)cb_depts.SelectedValue;

            var students = _context.Database.SqlQuery<GetStudentsByDepartment_class>($"EXEC dbo.GetStudentsByDepartment {departmentID}")
                                           .AsNoTracking()
                                           .ToList();

            _DataSet.GetStudentsByDepartment.Clear();

            foreach (var student in students)
            {
                var row = _DataSet.GetStudentsByDepartment.NewGetStudentsByDepartmentRow();
                row.st_ID = student.st_ID;
                row.fname = student.fname;
                row.lname = student.lname;
                //row.age = student.age;
                row.age = student.age.GetValueOrDefault(); // Assigns the default value (0) if age is null

                row.address = student.address;
                _DataSet.GetStudentsByDepartment.AddGetStudentsByDepartmentRow(row);
            }


            reportViewer1.LocalReport.DataSources.Clear();

            reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("GetStudentsByDepartment_DataSet", _DataSet.Tables["GetStudentsByDepartment"]));

            reportViewer1.LocalReport.ReportPath = "Report_GetStudentsByDepartment.rdlc";

            reportViewer1.RefreshReport();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Instructor_Exam home = new Instructor_Exam(1, "mostafa");
            home.ShowDialog();
            this.Close();
        }
    }

    internal class GetStudentsByDepartment_class
    {
        public int st_ID { get; set; }

        public string fname { get; set; }

        public string lname { get; set; }

        public int? age { get; set; }

        public string address { get; set; }

        public int? dept_ID { get; set; }
    }

}















//using DB_Sytem.Models;
//using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
//using System.Drawing;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Windows.Forms;
//using Microsoft.Reporting.WinForms;
//using Microsoft.EntityFrameworkCore;

//namespace DB_Sytem
//{
//    public partial class GetStudentsByDepartment_Report_1_Form : Form
//    {
//        private readonly ITIDBContext _context;
//        private readonly GetStudentsByDepartment_DataSet _DataSet;

//        public GetStudentsByDepartment_Report_1_Form()
//        {
//            InitializeComponent();
//            _context = new ITIDBContext();
//            _DataSet = new GetStudentsByDepartment_DataSet();
//        }

//        private void GetStudentsByDepartment_Report_1_Form_Load(object sender, EventArgs e)
//        {
//            // Load your form or do any necessary initialization here.

//            // Load departments into the ComboBox
//            var departments = _context.departments.ToList();
//            foreach (var department in departments)
//            {
//                cb_Dept_Num.Items.Add(department.dept_ID);
//            }
//        }

//        private void cb_Dept_Num_SelectedIndexChanged_1(object sender, EventArgs e)
//        {
//            // You may need to add some validation here to handle when nothing is selected
//            int selectedDepartmentID = (int)cb_Dept_Num.SelectedItem;

//            // Call your method to display data based on selected department ID
//            DisplayDataForDepartment(selectedDepartmentID);
//        }

//        private void DisplayDataForDepartment(int departmentID)
//        {
//            var students = _context.Database.SqlQuery<GetStudentsByDepartment_class>($"EXEC dbo.GetStudentsByDepartment {departmentID}")
//                                           .AsNoTracking()
//                                           .ToList();

//            _DataSet.GetStudentsByDepartment.Clear();

//            foreach (var student in students)
//            {
//                var row = _DataSet.GetStudentsByDepartment.NewGetStudentsByDepartmentRow();
//                row.st_ID = student.st_ID;
//                row.fname = student.fname;
//                row.lname = student.lname;
//                row.age = student.age.GetValueOrDefault();
//                row.address = student.address;
//                _DataSet.GetStudentsByDepartment.AddGetStudentsByDepartmentRow(row);
//            }

//            reportViewer1.LocalReport.DataSources.Clear();
//            reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("GetStudentsByDepartment_DataSet", _DataSet.Tables["GetStudentsByDepartment"]));
//            reportViewer1.RefreshReport();
//        }

//        private void btn_display_Click(object sender, EventArgs e)
//        {
//            // Get the selected department ID from the ComboBox
//            if (cb_Dept_Num.SelectedIndex != -1) // Make sure an item is selected
//            {
//                int departmentID = (int)cb_Dept_Num.SelectedItem;

//                // Call the method to display data based on the selected department ID
//                DisplayDataForDepartment(departmentID);
//            }
//            else
//            {
//                MessageBox.Show("Please select a department first.");
//            }
//        }

//    }

//    internal class GetStudentsByDepartment_class
//    {
//        public int st_ID { get; set; }

//        public string fname { get; set; }

//        public string lname { get; set; }

//        public int? age { get; set; }

//        public string address { get; set; }

//        public int? dept_ID { get; set; }
//    }
//}

