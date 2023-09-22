using RentACar.Customers;
using RentACar.Orders;
using RentACar.Reports;
using RentACar.Vehicles;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentACar
{
    public partial class MainFormContainer : Form
    {
        public MainFormContainer()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void viewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new VehiclesView { MdiParent = this }.Show();
;
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new VehicleAdd { MdiParent = this}.Show();
        }

        private void editDeleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new VehicleEditDelete { MdiParent = this }.Show();
        }

        private void viewToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            new CustomersView { MdiParent = this }.Show();
        }

        private void addToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            new CustomerAdd { MdiParent = this }.Show();
        }

        private void editDeleteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            new CustomerEditAndDelete { MdiParent = this }.Show();
        }

        private void orderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new OrderView { MdiParent = this }.Show();
        }

        private void MainFormContainer_Load(object sender, EventArgs e)
        {

        }

        private void simpleReportsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FirstForm { MdiParent = this }.Show();
        }
    }
}
