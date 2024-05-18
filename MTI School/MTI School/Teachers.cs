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
    public partial class Teachers : Form
    {
        SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder
        {
            DataSource = "DESKTOP-O62ILO3",
            InitialCatalog = "mtiSchool",
            IntegratedSecurity = true,
            Encrypt = true,
            TrustServerCertificate = true
        };
        SqlConnection connn;

        SqlDataAdapter adapterr;
        DataTable dtt = new DataTable();
        SqlCommandBuilder cmdd;

        public Teachers()
        {
            InitializeComponent();
            connn = new SqlConnection(builder.ConnectionString);
            adapterr = new SqlDataAdapter("select * from mtiSchool.Teachers", connn);
            adapterr.Fill(dtt);
            dataGridView1.DataSource = dtt;

            // Call the method directly instead of relying on the Load event
            Teachers_Load(this, EventArgs.Empty);
        }




        private void Teachers_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mtiSchoolDataSet.Teachers' table.
            // You can move, or remove it, as needed.
            // this.teachersTableAdapter.Fill(this.mtiSchoolDataSet.Teachers);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cmdd = new SqlCommandBuilder(adapterr);
            adapterr.Update(dtt);
            MessageBox.Show("Passed successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }

}
