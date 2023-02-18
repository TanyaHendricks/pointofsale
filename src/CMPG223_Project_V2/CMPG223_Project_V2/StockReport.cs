using Microsoft.Reporting.WinForms;
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
    public partial class StockReport : Form
    {
        public StockReport()
        {
            InitializeComponent();
            // TODO: This line of code loads data into the 'DataSet3.DataTable1' table. You can move, or remove it, as needed.            

            this.DataTable1TableAdapter.Fill(this.DataSet3.DataTable1);
            this.C.RefreshReport();
        
        }

        private void StockReport_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataSet3.DataTable1' table. You can move, or remove it, as needed.
            this.DataTable1TableAdapter.Fill(this.DataSet3.DataTable1);
            this.C.RefreshReport();
      
        }

        private void btnRef_Click(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataSet3.DataTable1' table. You can move, or remove it, as needed.
            this.DataTable1TableAdapter.Fill(this.DataSet3.DataTable1);
            this.C.RefreshReport();
           
        }

        private void btnCls_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
