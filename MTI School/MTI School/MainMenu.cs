using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MTI_School
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void studentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            students studentform = new students();
            studentform.Show();
            //this.Close();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {

        }

        private void teachersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Teachers tech = new Teachers();
           tech.Show();

        }

        private void coursesToolStripMenuItem_Click(object sender, EventArgs e)
        {
        Courses cour = new Courses();
            cour.Show();

        }

        private void enrollmentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Enrollmentscs eee = new  Enrollmentscs();
            eee.Show();

        }

        private void assigmentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Assignments ass = new Assignments();
            ass.Show();

        }

        private void exaToolStripMenuItem_Click(object sender, EventArgs e)
        {
           Exams xxx = new Exams();
           xxx.Show();
        }

        private void attendanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Attendance aaa = new Attendance();
            aaa.Show();
        }

        private void paymentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Paymentscs vvv= new Paymentscs();
            vvv.Show();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            RbStudNames dd=new RbStudNames();
            dd.Show();
        }
    }
}
