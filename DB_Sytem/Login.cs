using DB_Sytem.Models;
using System.Net;

namespace DB_Sytem
{
    public partial class Login : Form
    {
        ITIDBContext DB = new ITIDBContext();
        public Login()
        {
            InitializeComponent();
        }
        //Scaffold-DbContext "Server=.;Database=ITIDB;Trusted_Connection=True;TrustServerCertificate=True" Microsoft.EntityFrameworkCore.SqlServer -OutputDir Models


        private void btn_login_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(txt_name.ToString() + " " + txt_pass.ToString() + " " + rad_ins.Checked + " " + rad_stud.Checked);
            if (txt_name.Text.Trim().Length == 0 || txt_pass.Text.Trim().Length == 0)
            {
                MessageBox.Show("Please Fill Fields !", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                txt_name.Text.TrimEnd();

                if (rad_ins.Checked)
                {

                    var ins = DB.instructors.FirstOrDefault(i => i.fname == txt_name.Text && i.Password == txt_pass.Text);
                    if (ins != null)
                    {
                        this.Hide();
                        Instructor_HomePage ins_page = new Instructor_HomePage(ins.ins_ID, txt_name.Text);
                        ins_page.ShowDialog();
                        this.Close();
                    }
                    else MessageBox.Show("Wrong Username Or Password !", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (rad_stud.Checked)
                {
                    var stud = DB.students.FirstOrDefault(i => i.fname == txt_name.Text && i.st_ID == int.Parse(txt_pass.Text));
                    if (stud != null)
                    {
                        this.Hide();
                        Student_HomePage st_page = new Student_HomePage(txt_name.Text, int.Parse(txt_pass.Text));


                        st_page.ShowDialog();
                        this.Close();
                    }
                    else MessageBox.Show("Wrong Username Or Password !", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else
                {
                    MessageBox.Show("Please Select Type !", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }

            //this.Hide();
            //Instructor_HomePage ins = new Instructor_HomePage();
            //ins.ShowDialog();
            //this.Close();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
