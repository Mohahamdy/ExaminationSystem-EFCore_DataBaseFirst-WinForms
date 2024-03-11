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
    public partial class Student_HomePage : Form
    {
        string St_name = "";
        int st_ID = 0;
        int Left_Duration = 0;
        int St_exam_ID = 0;
        ITIDBContext context = new ITIDBContext();
        int SelectedRow = 0;
        

        public Student_HomePage(string st_name = "", int id = 0)
        {
            InitializeComponent();
            St_name = st_name;
            st_ID = id;
        }

        private void Student_HomePage_Load(object sender, EventArgs e)
        {
            try
            {
                lbl_studentName.Text = St_name;


                btn_start.Enabled = false;

                var st_exams = context.exams
                .Where(s => s.st_exams.Any(c => c.st_ID == st_ID))
                .Select(e => new { e.exam_ID, Coures = e.course.name.Trim(), e.time, e.date, e.duration, e.course.grade })
                .ToList();
                dgv_exams.DataSource = st_exams;
                dgv_exams.Columns[0].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something Went Wrong, Please try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void dgv_exams_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                SelectedRow = (int)dgv_exams.SelectedRows[0].Cells[0].Value;


                var exam = context.exams.Where(e => e.exam_ID == SelectedRow).FirstOrDefault();


                if (exam != null && exam.date != null && exam.time != null && exam.duration != null)
                {
                    // Calculate the end time of the exam
                    DateTime examEndTime = exam.date.Value.Date.Add(exam.time.Value).AddMinutes(exam.duration.Value);

                    // Get the current time
                    DateTime currentTime = DateTime.Now;

                    TimeSpan timeLeft = examEndTime - currentTime;

                    // Convert time left to minutes
                    Left_Duration = (int)timeLeft.TotalMinutes;
                    St_exam_ID = exam.exam_ID;
                    // Check if the current time is within the exam duration
                    if (DateTime.Now >= exam.date.Value.Date.Add(exam.time.Value) && DateTime.Now <= examEndTime)
                    {
                        btn_start.Enabled = true;
                    }
                    else
                    {
                        btn_start.Enabled = false;
                        //this.Hide();
                        //Exam_Page ep = new Exam_Page(St_exam_ID, st_ID, Left_Duration);
                        //ep.ShowDialog();
                        //this.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something Went Wrong, Please try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            this.Hide();
            Exam_Page ep = new Exam_Page(St_exam_ID, st_ID, Left_Duration);
            ep.ShowDialog();
            this.Close();
        }
    }
}
