using DB_Sytem.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Windows.Forms;

namespace DB_Sytem
{
    public partial class StudentsGradeForm : Form
    {
        ITIDBContext dbContext = new ITIDBContext();
        int ins_id = 0;
        string ins_name = "";
        public StudentsGradeForm(int id, string name)
        {
            InitializeComponent();
            ins_id = id;
            ins_name = name;
        }

        private void StudentsGradeForm_Load(object sender, EventArgs e)
        {
            try
            {
                LoadCourses();
                LoadDepartments();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while loading data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadCourses()
        {
            cb_courses.DataSource = dbContext.courses.ToList();
            cb_courses.DisplayMember = "name";
            cb_courses.ValueMember = "course_ID";
        }

        private void LoadDepartments()
        {
            cb_departments.DataSource = dbContext.departments.ToList();
            cb_departments.DisplayMember = "name";
            cb_departments.ValueMember = "dept_ID";
        }

        private void btn_show_Click(object sender, EventArgs e)
        {
            try
            {
                int selectedCourseID = (int)cb_courses.SelectedValue;
                int selectedDepartmentID = (int)cb_departments.SelectedValue;


                var studentExams = dbContext.students
    .Where(s => s.dept_ID == selectedDepartmentID && s.st_exams.Any(e => e.exam.course_ID == selectedCourseID))
    .SelectMany(s => s.st_exams)
    .Select(e => new
    {
        StudentID = e.st.fname.Trim() + " " + e.st.lname.Trim(),
        ExamID = e.exam_ID,
        TotalDegree = e.total_degree
    })
    .ToList();

                dataGridView1.DataSource = studentExams;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while retrieving data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_Log_out_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.ShowDialog();
            this.Close();
        }

        private void btn_Back_To_Home_Click(object sender, EventArgs e)
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
    }
}
