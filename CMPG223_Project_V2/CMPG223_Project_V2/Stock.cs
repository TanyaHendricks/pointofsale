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
    public partial class Stock : Form
    {
        private Menu FrmPnt = new Menu();
        private SqlConnection conn;
        private TextBox[] txts = new TextBox[5];
        private DataTable dTbl = new DataTable();
        private int idSelctd;
        private string tbl1 = "Stock";
        private string head1 = "No";
        private string col1_1 = "Stock_No";
        private string head2 = "Stock Description";
        private string par2 = "@STOCK_DESC";
        private string col1_2 = "Stock_Description";
        private string head3 = "UOM Decription";
        private string par3 = "@UOM_ID";
        private string col1_3 = "Stock_Unit_Of_Measure_Id";
        private string head4 = "Unit Cost Price";
        private string par4 = "@UNIT_COST_PRICE";
        private string col1_4 = "Stock_Unit_Cost_Price";
        private string head5 = "Unit Sell Price";
        private string par5 = "@UNIT_SELL_PRICE";
        private string col1_5 = "Stock_Unit_Sell_Price";
        private string tbl2 = "Unit_Of_Measure";
        private string col2_1 = "Unit_Of_Measure_Id";
        private string col2_2 = "Unit_Of_Measure_Description";

        //CONSTRUCT
        public Stock()
        {
            InitializeComponent();

            //PROPERTIES FOR DATAGRID
            dGV1.DataSource = null;
            dGV1.ColumnCount = 5;
            dGV1.Columns[0].Width = 50;
            dGV1.Columns[0].Name = head1;
            dGV1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dGV1.Columns[1].Name = head2;
            dGV1.Columns[2].Width = 80;
            dGV1.Columns[2].Name = head3;
            dGV1.Columns[3].Width = 80;
            dGV1.Columns[3].Name = head4;
            dGV1.Columns[4].Width = 80;
            dGV1.Columns[4].Name = head5;

            FrmPnt.DefineDGVProps(dGV1);
        }

        //LOAD
        private void Stock_Load(object sender, EventArgs e)
        {
            Refrsh();
        }

        //TO RERESH
        public void Refrsh()
        {
            string sql;

            txts[0] = tBoxCol2;
            txts[1] = tBoxCol3;
            txts[2] = tBoxCol4;
            txts[3] = tBoxCol5;
            txts[4] = tBoxUOM_Id;

            tBoxSrch.Text = "";

            FrmPnt.ClearContrls(txts, dGV1);

            sql = @"SELECT " + tbl1 + "." + col1_1 + ", " + tbl1 + "." + col1_2 + ", " + tbl2 + "." + col2_2 + ", " + tbl1 + "." + col1_4 + ", " + tbl1 + "." + col1_5 + " FROM " + tbl2 + " RIGHT OUTER JOIN " + tbl1 + " ON " + tbl2 + "." + col2_1 + " = " + tbl1 + "." + col1_3;
            conn = FrmPnt.MakeConnection();
            FrmPnt.Selct(sql, conn, dGV1);

            FrmPnt.ClearContrls(txts, dGV1);
        }

        //EVENT: BUTTON: INSERT
        private void btnIns_Click(object sender, EventArgs e)
        {
            string sql;
            SqlParameter[] iParams;

            iParams = new SqlParameter[4];

            iParams[0] = new SqlParameter();
            iParams[0].ParameterName = par2;
            iParams[0].Value = tBoxCol2.Text;
            iParams[0].SqlDbType = SqlDbType.VarChar;
            iParams[1] = new SqlParameter();
            iParams[1].ParameterName = par3;
            iParams[1].Value = tBoxUOM_Id.Text;
            iParams[1].SqlDbType = SqlDbType.Int;
            iParams[2] = new SqlParameter();
            iParams[2].ParameterName = par4;
            iParams[2].Value = tBoxCol4.Text;
            iParams[2].SqlDbType = SqlDbType.Money;
            iParams[3] = new SqlParameter();
            iParams[3].ParameterName = par5;
            iParams[3].Value = tBoxCol5.Text;
            iParams[3].SqlDbType = SqlDbType.Money;

            sql = @"INSERT INTO " + tbl1 + "(" + col1_2 + ", " + col1_3 + ", " + col1_4 + ", " + col1_5 + ") VALUES (" + par2 + ", " + par3 + ", " + par4 + ", " + par5 + ")";


            conn = FrmPnt.MakeConnection();

            if (FrmPnt.Insrt(conn, sql, iParams) == 1)
            {
                Refrsh();
            }
        }

        //EVENT: BUTTON: UPDATE
        private void btnUp_Click(object sender, EventArgs e)
        {
            string sql;

            conn = FrmPnt.MakeConnection();

            idSelctd = FrmPnt.GetTblId(dGV1);

            sql = @"UPDATE [dbo]." + tbl1 + " SET " + col1_2 + " = '" + tBoxCol2.Text + "', " + col1_3 + " = " + tBoxUOM_Id.Text + ", " + col1_4 + " = " + tBoxCol4.Text + ", " + col1_5 + " = " + tBoxCol5.Text + " WHERE " + col1_1 + " = " + idSelctd;

            if (FrmPnt.Updte(conn, sql, tBoxCol2.Text) == 1)
            {
                Refrsh();
            }
        }

        //EVENT: BUTTON: DELETE
        private void btnDel_Click(object sender, EventArgs e)
        {
            string sql;

            conn = FrmPnt.MakeConnection();

            idSelctd = FrmPnt.GetTblId(dGV1);

            sql = @"DELETE FROM [dbo]." + tbl1 + " WHERE " + col1_1 + " = " + idSelctd;

            if (FrmPnt.Delte(conn, sql, tBoxCol2.Text) == 1)
            {
                Refrsh();
            }
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

        //EVENT: TEXTBOX: SEARCH
        private void tBoxSrch_TextChanged(object sender, EventArgs e)
        {
            string sql;


            sql = @"SELECT " + tbl1 + "." + col1_1 + ", " + tbl1 + "." + col1_2 + ", " + tbl2 + "." + col2_2 + ", " + tbl1 + "." + col1_4 + ", " + tbl1 + "." + col1_5 + " FROM " + tbl2 + " RIGHT OUTER JOIN " + tbl1 + " ON " + tbl2 + "." + col2_1 + " = " + tbl1 + "." + col1_3 + " WHERE " + tbl1 + "." + col1_2 + " LIKE '%" + tBoxSrch.Text + "%'";

            conn = FrmPnt.MakeConnection();

            FrmPnt.Selct(sql, conn, dGV1);
        }

        //EVENT: DATAGRIDVIEW: CLICK
        private void dGV1_Click(object sender, EventArgs e)
        {
            FrmPnt.RowSelcted(dGV1, txts);
        }

        //EVENT: TBOX_UOM_DES: FIND UOM_ID
        private void tBoxCol3_TextChanged(object sender, EventArgs e)
        {
            string sql;

            //UPDATE UOM_ID
            sql = @"SELECT " + col2_1 + " FROM " + tbl2 + " WHERE " + col2_2 + " LIKE '%" + tBoxCol3.Text + "%'";

            dTbl = FrmPnt.MakeDataTble(sql, conn);

            tBoxUOM_Id.Text = dTbl.Rows[0][0].ToString();
        }

        //EVENT: TBOX_UOM_DES: LOOKUP UOM_FORM
        private void tBoxCol3_DoubleClick(object sender, EventArgs e)
        {
            UOM units = new UOM();
            units.ShowDialog();

            try
            {
                if (units.dGV1.SelectedRows[0].Index != -1)
                {
                    tBoxCol3.Text = units.dGV1.SelectedRows[0].Cells[1].Value.ToString();
                }
            }
            catch
            {
                MessageBox.Show("No selection was made", "Allocation Status", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    
        //EVENT: DATAGRIDVIEW: ROW_DOUBLE_CLICK
        private void dGV1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.Close();
        }
    }
}
