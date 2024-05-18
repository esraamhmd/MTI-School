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
    public partial class Exams : Form
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

        public Exams()
        {
            InitializeComponent();
            conn = new SqlConnection(builder.ConnectionString); // Use the connection string from the builder
            adapter = new SqlDataAdapter("select * from mtiSchool.Exams", conn);
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
            this.Load += Exams_Load;
        }

        private void Exams_Load(object sender, EventArgs e)
        {
            // You can remove the auto-generated code below if not needed
            // this.studentsTableAdapter.Fill(this.mtiSchoolDataSet.Students);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommandBuilder(adapter);
            adapter.Update(dt);
            MessageBox.Show(" passed successfully !", "success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
