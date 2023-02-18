using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CMPG223_Project_V2
{
    public partial class GPS : Form
    {
        public GPS()
        {
            InitializeComponent();
        }

        private void btnUOM_Click(object sender, EventArgs e)
        {
            UOM frm = new UOM();
            frm.Show();
            this.Close();
        }

        private void btnSvcs_Click(object sender, EventArgs e)
        {
            Service frm = new Service();
            frm.Show();
            this.Close();
        }

        private void btnStck_Click(object sender, EventArgs e)
        {
            Stock frm = new Stock();
            frm.Show();
            this.Close();
        }

        private void btnSales_Click(object sender, EventArgs e)
        {
            Sales frm = new Sales();
            frm.Show();
            this.Close();
        }

        private void btnMthSale_Click(object sender, EventArgs e)
        {
            SalsReport frm = new SalsReport();        
            frm.Show();
            this.Close();
        }

        private void btnStkMrk_Click(object sender, EventArgs e)
        {
            StockReport frm = new StockReport();
            frm.Show();
            this.Close();
        }

        private void GPS_DoubleClick(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
