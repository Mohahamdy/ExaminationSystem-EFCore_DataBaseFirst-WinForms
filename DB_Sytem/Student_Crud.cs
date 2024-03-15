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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DB_Sytem
{
    public partial class Student_Crud : Form
    {
        ITIDBContext context = new ITIDBContext();
        int Selected_ID = 0;
        int INS_ID = 0;
        string INS_NAME = "";

        public Student_Crud(int ins_id, string INS_name)
        {
            InitializeComponent();
            INS_ID = ins_id;
            INS_NAME = INS_name;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Student_Crud_Load(object sender, EventArgs e)
        {


            Refresh();
        }

        private void btn_insert_Click(object sender, EventArgs e)
        {
            try
            {
                student st = new student()
                {
                    fname = txt_firstname.Text.Trim(),
                    lname = txt_lastname.Text.Trim(),
                    address = txt_address.Text.Trim(),
                    age = (int)nb_age.Value,
                    dept_ID = cb_Dept.SelectedIndex,
                };

                context.Add(st);
                context.SaveChanges();
                Refresh();
            }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); }

        }


        public void Refresh()
        {
            var depts = context.departments.Select(e => new { name = e.name.Trim(), dept_ID = e.dept_ID }).ToList();


            var students = context.students.Select(s => new
            {
                ID = s.st_ID,
                Name = s.fname.Trim() + " " + s.lname.Trim(),
                Address = s.address.Trim(),
                Age = s.age,
                Department = s.dept.name.TrimEnd(),
                //Courses = string.Join(", ", s.courses.Select(c => c.name))

            }).ToList();
            cb_Dept.DataSource = depts;
            cb_Dept.DisplayMember = "name";
            cb_Dept.ValueMember = "dept_ID";
            cb_Dept.SelectedIndex = -1;

            dgv_Students.DataSource = students;
            dgv_Students.Columns[0].Visible = false;

            txt_firstname.Text = "";
            txt_lastname.Text = "";
            txt_address.Text = "";
            nb_age.Value = 0;
            btn_delete.Enabled = false;
            btn_update.Enabled = false;
            btn_insert.Enabled = true;



        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            student? st = context.students.FirstOrDefault(i => i.st_ID == Selected_ID);
            if (st != null)
            {

                context.students.Remove(st);
                context.SaveChanges();
            }
            Refresh();
        }

        private void dgv_Students_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Selected_ID = (int)dgv_Students.SelectedRows[0].Cells[0].Value;
            student? st = context.students.FirstOrDefault(i => i.st_ID == Selected_ID);
            txt_firstname.Text = st.fname.Trim();
            txt_lastname.Text = st.lname.Trim();
            txt_address.Text = st.address.Trim();
            nb_age.Value = (decimal)st.age;
            cb_Dept.SelectedIndex = (int)st.dept_ID;

            btn_delete.Enabled = true;
            btn_update.Enabled = true;
            btn_insert.Enabled = false;
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            try
            {
                student st = context.students.FirstOrDefault(i => i.st_ID == Selected_ID);

                st.fname = txt_firstname.Text.Trim();
                st.lname = txt_lastname.Text.Trim();
                st.address = txt_address.Text.Trim();
                st.age = (int)nb_age.Value;
                st.dept_ID = cb_Dept.SelectedIndex;



                context.SaveChanges();
                Refresh();
            }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Instructor_HomePage ins_h = new Instructor_HomePage(INS_ID, INS_NAME);
            ins_h.ShowDialog();
            this.Close();
        }
    }
}
