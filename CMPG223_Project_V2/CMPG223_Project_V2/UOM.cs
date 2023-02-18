using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data.SqlTypes;

namespace CMPG223_Project_V2
{
    public partial class UOM : Form
    {
        private Menu FrmPnt = new Menu();
        private SqlConnection conn;
        private TextBox[] txts = new TextBox[1];   
        private int idSelctd;
        private string tbl1 = "Unit_Of_Measure";
        private string head1 = "Id";
        private string col1 = "Unit_Of_Measure_Id";
        private string head2 = "UOM Decription";
        private string par2 = "@UOM_DESC";
        private string col2 = "Unit_Of_Measure_Description";

        //CONSTRUCT
        public UOM()
        {
            InitializeComponent();

            //PROPERTIES FOR DATAGRID
            dGV1.DataSource = null;
            dGV1.ColumnCount = 2;
            dGV1.Columns[0].Width = 50;
            dGV1.Columns[0].Name = head1;
            dGV1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dGV1.Columns[1].Name = head2;            

            FrmPnt.DefineDGVProps(dGV1);
        }

        //LOAD
        private void UOM_Load(object sender, EventArgs e)
        {
            Refrsh();   
        }

        //TO RERESH
        public void Refrsh()
        {
            string sql;

            txts[0] = tBoxCol2;
            tBoxSrch.Text = "";

            FrmPnt.ClearContrls(txts, dGV1);

            sql = @"SELECT * FROM " + tbl1;
            conn = FrmPnt.MakeConnection();
            FrmPnt.Selct(sql, conn, dGV1);

            FrmPnt.ClearContrls(txts, dGV1);
        }

        //EVENT: BUTTON: INSERT
        private void btnIns_Click(object sender, EventArgs e)
        {
            string sql;
            SqlParameter[] iParams;

            iParams = new SqlParameter[1];

            iParams[0] = new SqlParameter();
            iParams[0].ParameterName = par2;
            iParams[0].Value = tBoxCol2.Text;
            iParams[0].SqlDbType = SqlDbType.VarChar;

            sql = @"INSERT INTO " + tbl1 + "(" + col2 + ") VALUES (" + par2 + ")";

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

            sql = @"UPDATE[dbo]." +tbl1+ " SET " +col2+ " = '" +tBoxCol2.Text+ "' WHERE " +col1+ " = " + idSelctd;

            if (FrmPnt.Updte(conn, sql, tBoxCol2.Text) == 1) { 
                Refrsh();
            }            
        }

        //EVENT: BUTTON: DELETE
        private void btnDel_Click(object sender, EventArgs e)
        {
            string sql;

            conn = FrmPnt.MakeConnection();

            idSelctd = FrmPnt.GetTblId(dGV1);

            sql = @"DELETE FROM [dbo]." +tbl1+ " WHERE " +col1+ " = " + idSelctd;
      
            if (FrmPnt.Delte(conn, sql, tBoxCol2.Text) == 1) {                
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

            sql = @"SELECT * FROM " + tbl1 + " WHERE " + col2 + " LIKE '%" +tBoxSrch.Text+ "%'";

            conn = FrmPnt.MakeConnection();

            FrmPnt.Selct(sql, conn, dGV1);        
        }

        //EVENT: DATAGRIDVIEW: CLICK
        private void dGV1_Click(object sender, EventArgs e)
        {
            FrmPnt.RowSelcted(dGV1, txts);
        }

        //EVENT: DATAGRIDVIEW: ROW_DOUBLE_CLICK
        private void dGV1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.Close();
        }
    }
}
