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
    public partial class SalsReport : Form
    {
        private int mth, yr;

        public SalsReport()
        {
            InitializeComponent();
        }

        private void SalsReport_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataSet2.DataTable1' table. You can move, or remove it, as needed.
            this.DataTable1TableAdapter.Fill(this.DataSet2.DataTable1, this.mth, this.yr);

            this.rPV1.RefreshReport();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           

            if (tBoxMth.Text == "")
            {
                mth = 0;
            }
            else 
            {
                mth = Convert.ToInt32(tBoxMth.Text.ToString());
            }

            if (tBoxYr.Text == "")
            {
                yr = 0;
            }
            else
            {
                yr = Convert.ToInt32(tBoxYr.Text.ToString());
            }

            this.DataTable1TableAdapter.Fill(this.DataSet2.DataTable1, this.mth, this.yr);

            this.rPV1.RefreshReport();
        }
    }
}
