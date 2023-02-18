using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.SqlTypes;


namespace CMPG223_Project_V2
{
    public partial class Sale_LookUp : Form
    {
        private Menu FrmPnt = new Menu();
        private SqlConnection conn;
        private TextBox[] txts = new TextBox[1];
        private DataTable dTbl = new DataTable();
        private string tbl1 = "Sale_Header";
        private string head1_1 = "Sales No";
        private string col1_1 = "Sale_Id";
        private string head1_2 = "Date";
        private string col1_2 = "Sale_Date";
        private string head1_3 = "Total";  
        private string col1_3 = "Sale_Total";
        private string tbl2 = "Sale_Detail";    
        private string col0_1 = "Sale_Detail_Sale_Id"; 
        private string col0_2 = "Sale_Detail_Quantity";
        private string col0_3 = "Sale_Detail_Unit_Price";       

        //CONSTRUCT
        public Sale_LookUp()
        {
            InitializeComponent();        

            //PROPERTIES FOR DATAGRID
            dGV1.DataSource = null;
            dGV1.ColumnCount = 3;
            dGV1.Columns[0].Width = 40;
            dGV1.Columns[0].Name = head1_1;            
            dGV1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dGV1.Columns[1].Name = head1_2;
            dGV1.Columns[2].Width = 70;
            dGV1.Columns[2].Name = head1_3;

            FrmPnt.DefineDGVProps(dGV1);
        }

        //LOAD
        private void Sale_LookUp_Load(object sender, EventArgs e)
        {
            Refrsh();
        }

        //TO RERESH
        public void Refrsh()
        {
            string sql;

            txts[0] = tBoxSale_Id;
            
            FrmPnt.ClearContrls(txts, dGV1);

            sql = @"SELECT "+tbl1+"."+col1_1+", FORMAT("+tbl1+"."+col1_2+", 'yyyy/MM/dd'), FORMAT(SUM("+col0_2+"*"+col0_3+"),'N2') AS "+col1_3+" FROM "+tbl1+" FULL OUTER JOIN "+tbl2+" ON "+tbl1+"."+col1_1+" = "+tbl2+"."+col0_1+" GROUP BY " + tbl1 + "." + col1_1 + ", " + tbl1 + "." + col1_2;
            
            conn = FrmPnt.MakeConnection();

            FrmPnt.Selct(sql, conn, dGV1);

            FrmPnt.ClearContrls(txts, dGV1);
            
        }

        //TO MAKE DATATABLE
        public void MakeDataTble() {

            string sql;

            sql = @"SELECT " + tbl1 + "." + col1_1 + ", FORMAT(" + tbl1 + "." + col1_2 + ", 'yyyy/MM/dd'), FORMAT(SUM(" + col0_2 + "*" + col0_3 + "),'N2') AS " + col1_3 + " FROM " + tbl1 + " FULL OUTER JOIN " + tbl2 + " ON " + tbl1 + "." + col1_1 + " = " + tbl2 + "." + col0_1 + " GROUP BY " + tbl1 + "." + col1_1 + ", " + tbl1 + "." + col1_2;

            conn = FrmPnt.MakeConnection();

            dTbl = FrmPnt.MakeDataTble(sql, conn);
        
        }

        //EVENT: BUTTON: REFRESH
        private void butRef_Click(object sender, EventArgs e)
        {
            Refrsh();
        }

        //EVENT: BUTTON: CLOSE
        private void btnCls_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //EVENT: DATEPICKER: SEARCH
        private void dTP1_ValueChanged(object sender, EventArgs e)
        {
            string sql;

            sql = @"SELECT " + tbl1 + "." + col1_1 + ", FORMAT(" + tbl1 + "." + col1_2 + ", 'yyyy/MM/dd'), FORMAT(SUM(" + col0_2 + "*" + col0_3 + "),'N2') AS " + col1_3 + " FROM " + tbl1 + " FULL OUTER JOIN " + tbl2 + " ON " + tbl1 + "." + col1_1 + " = " + tbl2 + "." + col0_1 + " WHERE " + tbl1 + "." + col1_2 + " = '" + dTP1.Value.ToString() + "' GROUP BY " + tbl1 + "." + col1_1 + ", " + tbl1 + "." + col1_2;

            conn = FrmPnt.MakeConnection();

            FrmPnt.Selct(sql, conn, dGV1);
         
        }

        //EVENT: DATAGRIDVIEW: CLICK
        private void dGV1_Click(object sender, EventArgs e)
        {
            int selctedInd;
            string[] tboxValues = new string[txts.Length];

            try
            {
                selctedInd = dGV1.SelectedRows[0].Index;
                if (selctedInd != -1)
                {
                    if (dGV1.SelectedRows[0].Cells[0].Value != null)
                    {
                        for (int i = 1; i < txts.Length + 1; i++)
                        {
                            string temp = dGV1.SelectedRows[0].Cells[i - 1].Value.ToString();
                            txts[i - 1].Text = temp;
                        }
                    }
                }
            }
            catch 
            {

            }
        }

        //EVENT: DATAGRIDVIEW: ROW_DOUBLE_CLICK
        private void dGV1_DoubleClick(object sender, EventArgs e)
        {
            this.Close();
        }

    }    
}
