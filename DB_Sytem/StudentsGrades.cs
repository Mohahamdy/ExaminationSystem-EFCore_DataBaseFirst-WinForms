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
    public partial class StudentsGrades : Form
    {
        int ins_id;
        string INS_name;
        public StudentsGrades(int insId, string insName)
        {
            InitializeComponent();
            ins_id=insId;
            INS_name = insName;
        }

        private void lbl_backtohome_Click(object sender, EventArgs e)
        {
            this.Hide();
            Instructor_HomePage home = new Instructor_HomePage(ins_id, INS_name);
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
