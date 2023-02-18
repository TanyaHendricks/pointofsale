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
    public partial class Sales : Form
    {
        private Menu FrmPnt = new Menu();
        private SqlConnection conn;
        private TextBox[] txts = new TextBox[5];
        private DataTable dTbl = new DataTable();
        private SqlParameter[] iParams = new SqlParameter[6];

        private int saleId;

        private string sql;
        
        private int idSelctd1;
        private int idSelctd2;
        private int idSelctd3;
        private int idSelctd4;

        private string head1 = "IsService T/F";
        private string head2 = "Description";
        private string head3 = "Quantity";
        private string head6 = "UOM";
        private string head4 = "Unit Sell Price";        

        private string par1 = "@SALE_NO";
        private string par2 = "@SERV_NO";
        private string par3 = "@STCK_NO";
        private string par4= "@IS_SERV";
        private string par5 = "@QTY";
        private string par6 = "@SP";

        private string par1H = "@DATE";
                

        //CONSTRUCT
        public Sales()
        {
            InitializeComponent();

            //PROPERTIES FOR DATAGRID
            dGV1.DataSource = null;
            dGV1.ColumnCount = 8;
            dGV1.Columns[0].Width = 60;
            dGV1.Columns[0].Name = head1;
            dGV1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dGV1.Columns[1].Name = head2;
            dGV1.Columns[2].Width = 50;
            dGV1.Columns[2].Name = head3;
            dGV1.Columns[3].Width = 50;
            dGV1.Columns[3].Name = head6;
            dGV1.Columns[4].Width = 80;
            dGV1.Columns[4].Name = head4;
            dGV1.Columns[5].Visible = false;
            dGV1.Columns[6].Visible = false;
            dGV1.Columns[7].Visible = false;

            FrmPnt.DefineDGVProps(dGV1);

            cBox2_1.Visible = false;
            tBox2_2.Visible = false;
            tBoxItmId.Visible = false;
            tBox2_7.Visible = false;
            tBox2_3.Visible = false;
            tBox2_4.Visible = false;     

        }    

        //LOAD
        private void Sales_Load(object sender, EventArgs e)
        {
            Refrsh();
        }

        //TO MAKE SQL STATEMENT FOR SALE LINES
        public string MakeSqlForSalesLines(int saleId) {

            string sql1;
      
            sql1 = @"SELECT Sale_Detail.Sale_Detail_isService, Stock.Stock_Description, Sale_Detail.Sale_Detail_Quantity, Unit_Of_Measure.Unit_Of_Measure_Description, Sale_Detail.Sale_Detail_Unit_Price, 
		                    Sale_Header.Sale_Id, SUM(Sale_Detail.Sale_Detail_Quantity * Sale_Detail.Sale_Detail_Unit_Price) AS Sale_Detail_Total, Sale_Detail.Sale_Detail_Stock_No
                        FROM Unit_Of_Measure RIGHT OUTER JOIN
                            Stock ON Unit_Of_Measure.Unit_Of_Measure_Id = Stock.Stock_Unit_Of_Measure_Id RIGHT OUTER JOIN
                            Sale_Detail ON Stock.Stock_No = Sale_Detail.Sale_Detail_Stock_No LEFT OUTER JOIN
                            Sale_Header ON Sale_Detail.Sale_Detail_Sale_Id = Sale_Header.Sale_Id
                        WHERE(Sale_Header.Sale_Id = " + saleId + ") AND (Sale_Detail.Sale_Detail_isService = 0) " +
                       "GROUP BY Sale_Detail.Sale_Detail_isService, Stock.Stock_Description, Sale_Detail.Sale_Detail_Quantity, Unit_Of_Measure.Unit_Of_Measure_Description, Sale_Header.Sale_Id, " +
                           "Sale_Detail.Sale_Detail_Stock_No, Sale_Detail.Sale_Detail_Unit_Price UNION " +
                       "SELECT Sale_Detail.Sale_Detail_isService, Services.Service_Description, Sale_Detail.Sale_Detail_Quantity, Unit_Of_Measure.Unit_Of_Measure_Description, Sale_Detail.Sale_Detail_Unit_Price, " +
                           "Sale_Header.Sale_Id, SUM(Sale_Detail.Sale_Detail_Quantity * Sale_Detail.Sale_Detail_Unit_Price) AS Sale_Detail_Total, Sale_Detail.Sale_Detail_Service_No " +
                       "FROM Unit_Of_Measure RIGHT OUTER JOIN " +
                           "Services ON Unit_Of_Measure.Unit_Of_Measure_Id = Services.Service_Unit_Of_Measure_Id RIGHT OUTER JOIN " +
                           "Sale_Detail ON Services.Service_No = Sale_Detail.Sale_Detail_Service_No LEFT OUTER JOIN " +
                           "Sale_Header ON Sale_Detail.Sale_Detail_Sale_Id = Sale_Header.Sale_Id " +
                       "WHERE(Sale_Header.Sale_Id = "+ saleId + ") AND (Sale_Detail.Sale_Detail_isService = 1) " +
                       "GROUP BY Sale_Detail.Sale_Detail_isService, Services.Service_Description, Sale_Detail.Sale_Detail_Quantity, Unit_Of_Measure.Unit_Of_Measure_Description, Sale_Header.Sale_Id, " +
                           "Sale_Detail.Sale_Detail_Service_No, Sale_Detail.Sale_Detail_Unit_Price";
            return sql1;
        }

        //TO RERESH LINES
        public void Refrsh()
        {
            //int saleId = 0;

            txts[0] = tBox2_1;
            txts[1] = tBox2_2;
            txts[2] = tBox2_3;
            txts[3] = tBox2_7;
            txts[4] = tBox2_4;
                  

            tBoxItmId.Text = "";
            cBox2_1.Text = tBox2_1.Text;
            tBox2_5.Text = "";
       


            FrmPnt.ClearContrls(txts, dGV1);

            if (tBoxSrch.Text != "")
            {
                saleId = Convert.ToInt32(tBoxSrch.Text);

                sql = MakeSqlForSalesLines(saleId);

                conn = FrmPnt.MakeConnection();

                FrmPnt.Selct(sql, conn, dGV1);

            }
            else {

                saleId = 0;

                sql = MakeSqlForSalesLines(saleId);

                conn = FrmPnt.MakeConnection();

                FrmPnt.Selct(sql, conn, dGV1);
            }

            dGV1.ClearSelection();
        }

        //TO REFRESH HEAD
        public void RefrshHead() {

            tBoxSrch.Text = "";
            tBox1_3.Text = "";
            dTP1_2.Value = DateTime.Today;

            if (tBoxSrch.Text != "")
            {
                tBox1_3.Text = GetTransactionTtl(tBoxSrch.Text);
            }
        }

        //TO GET ID
        public int GetTblCompoundId(DataGridView dGV, int ColNo) {
            int id = 0;            

            try
            {
                String selcted = dGV.SelectedRows[0].Cells[ColNo].Value.ToString();
                if (selcted == "True")
                {
                    id = 1;
                }
                else if (selcted == "False")
                {
                    id = 0;
                }
                else 
                {
                    id = Convert.ToInt32(selcted);
                }                
            }
            catch
            {
                               
                MessageBox.Show("Item Id not found. Select and existing item", "Id Status", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
                      
            return id;
        }                 

        //EVENT: BUTTON: INSERT LINE
        private void btnIns2_Click(object sender, EventArgs e)
        {
            string sql;                     

            try
            {
                iParams[0] = new SqlParameter();
                iParams[0].ParameterName = par1;
                iParams[0].Value = Convert.ToInt32(tBoxSrch.Text);
                iParams[0].SqlDbType = SqlDbType.Int;

                iParams[1] = new SqlParameter();
                iParams[1].ParameterName = par2;
                iParams[1].SqlDbType = SqlDbType.Int;

                iParams[2] = new SqlParameter();
                iParams[2].ParameterName = par3;
                iParams[2].SqlDbType = SqlDbType.Int;

                iParams[3] = new SqlParameter();
                iParams[3].ParameterName = par4;
                iParams[3].SqlDbType = SqlDbType.Bit;

                if (cBox2_1.Text == "Service")
                {
                    iParams[1].Value = Convert.ToInt32(tBoxItmId.Text);
                    iParams[2].Value = DBNull.Value;
                    iParams[3].Value = true;
                }
                else if (cBox2_1.Text == "Stock")
                {
                    iParams[1].Value = DBNull.Value;
                    iParams[2].Value = tBoxItmId.Text;
                    iParams[3].Value = false;
                }
            
                iParams[4] = new SqlParameter();
                iParams[4].ParameterName = par5;
                iParams[4].SqlDbType = SqlDbType.Float;
                iParams[4].Value = Convert.ToDecimal(tBox2_3.Text);

                iParams[5] = new SqlParameter();
                iParams[5].ParameterName = par6;
                iParams[5].SqlDbType = SqlDbType.Money;
                iParams[5].Value = Convert.ToDecimal(tBox2_4.Text);

                sql = @"INSERT INTO [dbo].[Sale_Detail] ([Sale_Detail_Sale_Id], [Sale_Detail_Service_No], [Sale_Detail_Stock_No], [Sale_Detail_isService], [Sale_Detail_Quantity], [Sale_Detail_Unit_Price]) VALUES (" + par1 + ", " + par2 + ", " + par3 + ", " + par4 + ", " + par5 + ", " + par6 + ")";

                conn = FrmPnt.MakeConnection();

                if (FrmPnt.Insrt(conn, sql, iParams) == 1)
                {
                    Refrsh();
                }
            }
            catch 
            {
                MessageBox.Show("Check input values", "Insert Status", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
            
        }

        //EVENT: BUTTON: UPDATE LINE
        private void btnUp2_Click(object sender, EventArgs e)
        {
            string sql;                     

            try
            {
                decimal par5;
                decimal par6;

                par5 = Convert.ToDecimal(tBox2_3.Text);
                par6 = Convert.ToDecimal(tBox2_4.Text);

                conn = FrmPnt.MakeConnection();

                sql = @"UPDATE [dbo].[Sale_Detail] SET [Sale_Detail_Quantity] = " + par5 + ", [Sale_Detail_Unit_Price] = " + par6 + " WHERE [Sale_Detail_Sale_Id] = " + idSelctd1 + " AND [Sale_Detail_Item_No] = " + idSelctd2 + " AND [Sale_Detail_isService] = " + idSelctd3;

                if (FrmPnt.Updte(conn, sql, tBox2_2.Text) == 1)
                {
                    Refrsh();
                }
            }
            catch
            {
                MessageBox.Show("Check input values", "Update Status", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }


        }

        //EVENT: BUTTON: DELETE LINE
        private void btnDel2_Click(object sender, EventArgs e)
        {
            string sql;

            conn = FrmPnt.MakeConnection();

            sql = @"DELETE FROM [dbo].[Sale_Detail] WHERE [Sale_Detail_Sale_Id] = " + idSelctd1 + " AND [Sale_Detail_Item_No] = " + idSelctd2 + " AND [Sale_Detail_isService] = " + idSelctd3;

            if (FrmPnt.Delte(conn, sql, tBox2_2.Text) == 1)
            {
                Refrsh();
            }
        }

        //EVENT: BUTTON: REFRESH LINE
        private void btnRef2_Click(object sender, EventArgs e)
        {
            
            Refrsh();

        }

        //EVENT: BUTTON: CLOSE
        private void btnCls_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //EVENT: TBOX_ITEM_DES: FIND ITEM_ID
        private void tBox2_2_TextChanged(object sender, EventArgs e)
        {
            string sql;

            //UPDATE ITEM_ID
            if (cBox2_1.Text == "Service" && tBox2_2.Text != "") {
                sql = @"SELECT [Service_No] FROM [dbo].[Services] WHERE [Service_Description] = '" + tBox2_2.Text+ "'";
                dTbl = FrmPnt.MakeDataTble(sql, conn);
                tBoxItmId.Text = dTbl.Rows[0][0].ToString();
            }
            else if(cBox2_1.Text == "Stock" && tBox2_2.Text != "") {
                sql = @"SELECT [Stock_No] FROM [dbo].[Stock] WHERE [Stock_Description] = '" + tBox2_2.Text+"'";
                dTbl = FrmPnt.MakeDataTble(sql, conn);
                tBoxItmId.Text = dTbl.Rows[0][0].ToString();
                
            }

            if (tBoxSrch.Text != "")
            {
                tBox1_3.Text = GetTransactionTtl(tBoxSrch.Text);
            }

        }

        //EVENT: TEXTBOX: ITEMS: LOOKUP SERVICE/STOCK_FORM
        private void tBox2_2_DoubleClick(object sender, EventArgs e)
        {
            if (cBox2_1.Text == "Service")
            {
                Service srvce = new Service();
                srvce.ShowDialog();

                try
                {
                    if (srvce.dGV1.SelectedRows[0].Index != -1)
                    {
                        tBoxItmId.Text = srvce.dGV1.SelectedRows[0].Cells[0].Value.ToString();
                        tBox2_2.Text = srvce.dGV1.SelectedRows[0].Cells[1].Value.ToString();
                        tBox2_7.Text = srvce.dGV1.SelectedRows[0].Cells[2].Value.ToString();
                        tBox2_4.Text = srvce.dGV1.SelectedRows[0].Cells[3].Value.ToString();
                    }

                }
                catch
                {
                    //MessageBox.Show("No selection was made", "Allocation Status", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
                }
            }
            else if (cBox2_1.Text == "Stock")
            {
                Stock stck = new Stock();
                stck.ShowDialog();

                try
                {
                    if (stck.dGV1.SelectedRows[0].Index != -1)
                    {
                        tBoxItmId.Text = stck.dGV1.SelectedRows[0].Cells[0].Value.ToString();
                        tBox2_2.Text = stck.dGV1.SelectedRows[0].Cells[1].Value.ToString();
                        tBox2_7.Text = stck.dGV1.SelectedRows[0].Cells[2].Value.ToString();
                        tBox2_4.Text = stck.dGV1.SelectedRows[0].Cells[4].Value.ToString();
                    }
                }
                catch
                {
                    //MessageBox.Show("No selection was made", "Allocation Status", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
                }
            }

            if (tBoxSrch.Text != "")
            {
                tBox1_3.Text = GetTransactionTtl(tBoxSrch.Text);
            }

        }
        
        //EVENT: TEXTBOX: TRANSACTION: LOOKUP SALELOOKUP_FORM
        private void tBoxSrch_DoubleClick(object sender, EventArgs e)
        {
            Sale_LookUp saleLkUp = new Sale_LookUp();
            saleLkUp.ShowDialog();

            try
            {
                if (saleLkUp.dGV1.SelectedRows[0].Index != -1)
                {
                    tBoxSrch.Text = saleLkUp.dGV1.SelectedRows[0].Cells[0].Value.ToString();
                    dTP1_2.Value = DateTime.Parse(saleLkUp.dGV1.SelectedRows[0].Cells[1].Value.ToString());
                    tBox1_3.Text = saleLkUp.dGV1.SelectedRows[0].Cells[2].Value.ToString();
                }
            }
            catch
            {
                //MessageBox.Show("No selection was made", "Allocation Status", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            if (tBoxSrch.Text != "") 
            {
                tBox1_3.Text = GetTransactionTtl(tBoxSrch.Text);
            }           

        }

        //EVENT: BUTTON: INSERT HEAD
        private void btnIns1_Click(object sender, EventArgs e)
        {
            string sql;

            DateTime dTime = dTP1_2.Value;

            tBox1_2.Text = dTime.ToString();           

            SqlParameter[] iHParams;
            iHParams = new SqlParameter[1];
            iHParams[0] = new SqlParameter();
            iHParams[0].ParameterName = par1H;
            iHParams[0].Value = tBox1_2.Text;
            iHParams[0].SqlDbType = SqlDbType.DateTime;

            sql = @"INSERT INTO [dbo].[Sale_Header] ([Sale_Date]) VALUES (" + par1H+ ")";

            conn = FrmPnt.MakeConnection();

            if (FrmPnt.Insrt(conn, sql, iHParams) == 1)
            {
                Refrsh();
                try
                {
                    string sql1;
                    
                    sql1 = @"SELECT Sale_Header.[Sale_Id] FROM Sale_Header WHERE [Sale_Id] = (SELECT MAX([Sale_Id]) FROM [dbo].[Sale_Header])";

                    conn = FrmPnt.MakeConnection();

                    dTbl = FrmPnt.MakeDataTble(sql1, conn);

                    tBoxSrch.Text = dTbl.Rows[0][0].ToString();
                }
                catch 
                {
                
                }
            
            }

            //GET INSERTED ID            
     
          

        }

        //EVENT: BUTTON: UPDATE HEAD
        private void btnUp1_Click(object sender, EventArgs e)
        {
            string sql;
           
            conn = FrmPnt.MakeConnection();
          
            idSelctd4 = Convert.ToInt32(tBoxSrch.Text);

            sql = @"UPDATE [dbo].[Sale_Header] SET [Sale_Date] = '"+ dTP1_2.Value.ToString()+"' WHERE [Sale_Id]="+idSelctd4;

            if (FrmPnt.Updte(conn, sql, tBoxSrch.Text) == 1)
            {
                RefrshHead();
            }
        }

        //EVENT: BUTTON: DELETE HEAD
        private void btnDel1_Click(object sender, EventArgs e)
        {
            string sql;

            conn = FrmPnt.MakeConnection();           

            idSelctd4 = Convert.ToInt32(tBoxSrch.Text);            

            sql = @"DELETE FROM [dbo].[Sale_Header] WHERE [Sale_Id] = " + idSelctd4;

            if (FrmPnt.Delte(conn, sql, tBoxSrch.Text) == 1)
            {
                RefrshHead();
            }
        }

        //EVENT: BUTTON: REFRESH HEAD
        private void btnRef1_Click(object sender, EventArgs e)
        {
            RefrshHead();

            FrmPnt.ClearContrls(txts, dGV1);
                                   
        }

        //EVENT: TEXTBOX: TRANSACTION: LOAD GRIDVIEW
        private void tBoxSrch_TextChanged(object sender, EventArgs e)
        {
            int saleId = 0;

            if (tBoxSrch.Text != "") {
            
                saleId = Convert.ToInt32(tBoxSrch.Text);                
                
                sql = MakeSqlForSalesLines(saleId);

                conn = FrmPnt.MakeConnection();

                FrmPnt.Selct(sql, conn, dGV1);

                cBox2_1.Visible = true;
                tBox2_2.Visible = true;
                tBoxItmId.Visible = true;
                tBox2_7.Visible = true;
                tBox2_3.Visible = true;
                tBox2_4.Visible = true;

            }
            else{                              

                Refrsh();

                cBox2_1.Visible = false;
                tBox2_2.Visible = false;
                tBoxItmId.Visible = false;
                tBox2_7.Visible = false;
                tBox2_3.Visible = false;
                tBox2_4.Visible = false;
            }         
        }

        //TO SELECT ROW CLICK
        public void RowSelcted(DataGridView dGV, TextBox[] txts)
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
                        for (int i = 0; i < dGV1.ColumnCount; i++)
                        {
                            string temp = dGV1.SelectedRows[0].Cells[i].Value.ToString();

                            if (i == 0)
                            {
                                if (temp == "True")
                                {
                                    cBox2_1.Text = "Service";
                                    idSelctd3 = 1;
                                }
                                else if (temp == "False")
                                {
                                    cBox2_1.Text = "Stock";
                                    idSelctd3 = 0;
                                }
                            }
                            else if (i == 1)
                            {
                                tBox2_2.Text = temp;
                            }
                            else if (i == 2)
                            {
                                tBox2_3.Text = temp;
                            }
                            else if (i == 3)
                            {
                                tBox2_7.Text = temp;
                            }
                            else if (i == 4)
                            {
                                tBox2_4.Text = temp;
                            }
                            else if (i == 5)
                            {
                                idSelctd1 = Convert.ToInt32(temp);
                            }
                            else if (i == 6)
                            {
                                tBox2_5.Text = temp;
                            }
                            else if (i == 7)
                            {
                                idSelctd2 = Convert.ToInt32(temp);
                            }
                        }
                    }
                }
            }
            catch 
            {
                //MessageBox.Show("No selection was made", "Allocation Status", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
            }

            idSelctd1 = GetTblCompoundId(dGV1, 5);
            idSelctd2 = GetTblCompoundId(dGV1, 7);
            idSelctd3 = GetTblCompoundId(dGV1, 0);

            tBox1_3.Text = GetTransactionTtl(tBoxSrch.Text);


        }

        //EVENT: DATAGRIDVIEW: CLICK
        private void dGV1_Click_1(object sender, EventArgs e)
        {        
            RowSelcted(dGV1, txts);
        }
             
        //EVENT: SERVICE/STOCK CHECKBOX: TEXTCHANGED
        private void cBox2_1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Refrsh();
        }

        //TO GET TRANSACTION TOTAL
        public string GetTransactionTtl(string saleId) 
        {
            string sql;
            string ttl;

            sql = @"SELECT SUM(Sale_Detail_Quantity*Sale_Detail_Unit_Price) AS Sale_Total FROM Sale_Header FULL OUTER JOIN Sale_Detail ON Sale_Header.Sale_Id = Sale_Detail.Sale_Detail_Sale_Id WHERE Sale_Header.Sale_Id = "+saleId+" GROUP BY Sale_Header.Sale_Id, Sale_Header.Sale_Date";

            conn = FrmPnt.MakeConnection();
                               
            dTbl = FrmPnt.MakeDataTble(sql, conn);

            ttl = dTbl.Rows[0][0].ToString();

            return ttl;        
        }                    
    }    
}
