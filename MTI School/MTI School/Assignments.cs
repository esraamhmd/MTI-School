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
    public partial class Assignments : Form
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

        public Assignments()
        {
            InitializeComponent();
            conn = new SqlConnection(builder.ConnectionString); // Use the connection string from the builder
            adapter = new SqlDataAdapter("select * from mtiSchool.Assignments", conn);
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
            this.Load += Assignments_Load;
        }

        private void Assignments_Load(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommandBuilder(adapter);
            adapter.Update(dt);
            MessageBox.Show(" passed successfully !", "success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
