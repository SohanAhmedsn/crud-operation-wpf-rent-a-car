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

namespace RentACar.Reports
{
    public partial class FirstForm : Form
    {
        public FirstForm()
        {
            InitializeComponent();
        }

        private void FirstForm_Load(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(ConnectionHelper.ConnectionString))
            {
                using (SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Customers", con))
                {
                    DataSet ds = new DataSet();
                    da.Fill(ds, "Customers");
                    FirstRepo rpt1 = new FirstRepo();
                    rpt1.SetDataSource(ds);
                    this.crystalReportViewer1.ReportSource= rpt1;
                    this.crystalReportViewer1.Refresh();
                    

                }
            }
        }
    }
}
