using System;
using System.Windows.Forms;

namespace MTI_School
{
    public partial class RbStudNames : Form
    {
      // private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private mtiSchoolDataSet mtiSchoolDataSet; // Assuming MTISchoolDataSet is your dataset class
        private StudNameRTableAdapter studNameRTableAdapter;

        public RbStudNames()
        {
            this.Load += new System.EventHandler(this.RbStudNames_Load);
            InitializeComponent();

            // Create and configure the ReportViewer control
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.Controls.Add(reportViewer1);
            reportViewer1.Dock = DockStyle.Fill;

            mtiSchoolDataSet = new mtiSchoolDataSet();
            studNameRTableAdapter = new StudNameRTableAdapter();
        }

        private void RbStudNames_Load(object sender, EventArgs e)
        {
            this.reportViewer1.RefreshReport();
            // Perform any additional initialization if needed
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {
            this.reportViewer1.RefreshReport();
            // You can handle report viewer load event if needed
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Call the Fill method of the StudNameRTableAdapter with parameters
           this. studNameRTableAdapter.Fill(mtiSchoolDataSet.StudNameR, textBox1.Text);

            // Refresh the report viewer to reflect the changes
            this.reportViewer1.RefreshReport();
        }
    }
}
