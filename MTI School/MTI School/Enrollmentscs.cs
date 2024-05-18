using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MTI_School
{
    public partial class Enrollmentscs : Form
    {
        SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder
        {
            DataSource = "DESKTOP-O62ILO3",
            InitialCatalog = "mtiSchool",
            IntegratedSecurity = true, // Use integrated security (Windows authentication)
            Encrypt = true,
            TrustServerCertificate = true // Disables certificate validation (use only for development/testing)
        };

        SqlConnection conn;

        SqlDataAdapter adapter;
        DataTable dt = new DataTable();
        SqlCommandBuilder cmd;

        public Enrollmentscs()
        {
            InitializeComponent();
            conn = new SqlConnection(builder.ConnectionString); // Use the connection string from the builder
            adapter = new SqlDataAdapter("select * from mtiSchool.Enrollments", conn);
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
            this.Load += Enrollmentscs_Load;
        }


        private void Enrollmentscs_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mtiSchoolDataSet.Enrollments' table. You can move, or remove it, as needed.
            //this.enrollmentsTableAdapter.Fill(this.mtiSchoolDataSet.Enrollments);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommandBuilder(adapter);
            adapter.Update(dt);
            MessageBox.Show(" passed successfully !", "success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
