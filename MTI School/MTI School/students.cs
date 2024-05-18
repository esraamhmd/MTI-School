using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace MTI_School
{
    public partial class students : Form
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

        public students()
        {
            InitializeComponent();
            conn = new SqlConnection(builder.ConnectionString); // Use the connection string from the builder
            adapter = new SqlDataAdapter("select * from mtiSchool.Students", conn);
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
            this.Load += students_Load;
        }

        private void students_Load(object sender, EventArgs e)
        {
            // You can remove the auto-generated code below if not needed
            // this.studentsTableAdapter.Fill(this.mtiSchoolDataSet.Students);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommandBuilder(adapter);
            adapter.Update(dt);
            MessageBox.Show(" passed successfully !" ,"success",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
    }
}
