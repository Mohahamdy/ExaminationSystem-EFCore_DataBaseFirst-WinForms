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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DB_Sytem
{
    public partial class Student_Crud_Courses : Form
    {
        ITIDBContext context = new ITIDBContext();

        int INS_ID = 0;
        string INS_NAME = "";
        int Selected_Courseindex = 0;
        int selected_StudentIndex = 0;
        public Student_Crud_Courses(int ins_id = 1, string ins_name = "mostafa")
        {
            InitializeComponent();
            INS_ID = ins_id;
            INS_NAME = ins_name;

        }

        private void Student_Crud_Courses_Load(object sender, EventArgs e)
        {
            var studentsWithCourses = context.students.SelectMany(s => s.courses, (s, obj) => new
            {
                Name = s.fname.Trim(),
                Course = obj.name.Trim()
            }).ToList();
            //dgv_Courses.DataSource = studentsWithCourses;



            var students = context.students.Select(s => new
            {
                ID = s.st_ID,
                Name = s.fname.Trim() + ' ' + s.lname.Trim()
            }).ToList();

            cb_stdNAme.DataSource = students;

            cb_stdNAme.DisplayMember = "Name";
            cb_stdNAme.ValueMember = "ID";
            cb_stdNAme.SelectedIndex = -1;

            btn_delete.Enabled = false;
            btn_insert.Enabled = false;
        }

        private void cb_stdNAme_SelectionChangeCommitted(object sender, EventArgs e)
        {

            Refresh();

            var courses = context.courses.Select(e => new
            {

                name = e.name.Trim(),
                e.course_ID
            }).ToList();
            cb_Courses.DataSource = courses;
            cb_Courses.DisplayMember = "name";
            cb_Courses.ValueMember = "course_ID";
            cb_Courses.SelectedIndex = -1;

        }

        private void cb_Courses_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Selected_Courseindex = (int)cb_Courses.SelectedValue;
            selected_StudentIndex = (int)cb_stdNAme.SelectedValue;


            bool exists = context.students.Any(s =>
                s.st_ID == selected_StudentIndex &&
                s.courses.Any(c => c.course_ID == Selected_Courseindex)
                    );

            if (exists)
            {

                btn_delete.Enabled = true;
                btn_insert.Enabled = false;


            }
            else
            {
                btn_insert.Enabled = true;
                btn_delete.Enabled = false;

            }

        }

        private async void btn_delete_Click(object sender, EventArgs e)
        {
            ITIDBContextProcedures dbProc = new ITIDBContextProcedures(context);
            try
            {
                int result = await dbProc.DeleteStudentCourseAsync(selected_StudentIndex, Selected_Courseindex);
                if (result != 0)
                {

                    MessageBox.Show("Course Deleted Successfully ", "Info", MessageBoxButtons.OK);
                }
                Refresh();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private async void btn_insert_Click(object sender, EventArgs e)
        {
            ITIDBContextProcedures dbProc = new ITIDBContextProcedures(context);
            try
            {
                student s = new student();

                var result = await dbProc.ins_Stud_CrsAsync(selected_StudentIndex, Selected_Courseindex);
                if (result != null)
                {

                    MessageBox.Show("Course Added Successfully ", "Info", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("Course Added Successfully ", "Info", MessageBoxButtons.OK);

                }

                Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        void Refresh()
        {
            btn_insert.Enabled = false;
            btn_delete.Enabled = false;

            var selectedIndex = (int)cb_stdNAme.SelectedValue;
            var Student_courses = context.students.Where(c => c.st_ID == selectedIndex).SelectMany(s => s.courses, (s, obj) => new
            {
                //Name = s.fname.Trim(),
                Course = obj.name.Trim(),
                Duration = obj.duration,

            }).ToList();

            dgv_Courses.DataSource = Student_courses;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Instructor_HomePage home = new Instructor_HomePage(INS_ID, INS_NAME);
            home.ShowDialog();
            this.Close();
        }
    }
}
