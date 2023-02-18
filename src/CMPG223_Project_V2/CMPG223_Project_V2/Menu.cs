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
using Microsoft.Win32;
using System.Globalization;
using System.Linq.Expressions;
using Microsoft.SqlServer;


namespace CMPG223_Project_V2
{
    public partial class Menu : Form
    {
        private SqlCommand cmnd;
        private SqlDataAdapter adpt = new SqlDataAdapter();
        private DataTable dTbl;

        //CONSTRUCT
        public Menu()
        {
            InitializeComponent();
        }

        //TO MAKE A SQLCONNECTION
        public SqlConnection MakeConnection()
        {
            string constr = @"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=C:\USERS\BOB4R\DESKTOP\ZOOM\CMPG223_DBV2.MDF;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            SqlConnection conn = new SqlConnection(constr);
            return conn;
        }

        //TO DEFINE STANDARD PROPERTIES FOR DATAGRIDVIEW
        public void DefineDGVProps(DataGridView dGV1) 
        {
            dGV1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dGV1.MultiSelect = false;
            dGV1.ReadOnly = true;
        }

        //TO POPULATE DATAGRIDVIEW
        public void Populate(DataGridView dGV, String[] pparams) 
        {
            dGV.Rows.Add(pparams);
        }

        //TO CLEAR CONTROL
        public void ClearContrls(TextBox[] txts, DataGridView dGV) {

            dGV.ClearSelection();

            for (int i = 0; i < txts.Length; i++) {
                txts[i].Text = "";
            }        
        }

        //TO SELECT ROW CLICK
        public void RowSelcted(DataGridView dGV, TextBox[] txts) {
            int selctedInd;
            string[] tboxValues = new string[txts.Length];               

            try 
            {
                selctedInd = dGV.SelectedRows[0].Index;
                if (selctedInd !=-1) {
                    if (dGV.SelectedRows[0].Cells[0].Value != null) 
                    {
                        for (int i = 1; i < dGV.ColumnCount;  i++) 
                        {
                            string temp = dGV.SelectedRows[0].Cells[i].Value.ToString();
                            txts[i - 1].Text = temp;
                        }                  
                    }
                }                 
            }
            catch 
            {
                MessageBox.Show("No selection was made", "Allocation Status", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
            }
        }

        //TO GET TABLE ID
        public int GetTblId(DataGridView dGV) 
        {
            int id = 0;

            try 
            {
                String selcted = dGV.SelectedRows[0].Cells[0].Value.ToString();
                id = Convert.ToInt32(selcted);           
            }
            catch
            {
                MessageBox.Show("Item Id not found. Select and exiting item", "Insert/Delete Status", MessageBoxButtons.OK, MessageBoxIcon.Error);               
            }

            return id;
        }

        //TO INSERT 
        public int Insrt(SqlConnection conn, string sql, SqlParameter[] iparams) 
        {
            int j = 0;

            int parLen = iparams.Length;
            String[] iparamsStr = new string[iparams.Length];

            cmnd = new SqlCommand(sql, conn);

            for (int i = 0; i < parLen; i++) 
            {
                cmnd.Parameters.AddWithValue(iparams[i].ParameterName, iparams[i].Value);
            }
            try 
            {             
                for (int i = 0; i < parLen; i++)
                iparamsStr[i] = (iparams[i].Value).ToString();
                
                conn.Open();
                               
                if (cmnd.ExecuteNonQuery() > 0)
                {
                   j = 1;
                   MessageBox.Show("Successfully Inserted: " + String.Join(", ", iparamsStr), "Insert Status", MessageBoxButtons.OK, MessageBoxIcon.Information);                                                       
                }              
            }
            catch
            {
                adpt.Dispose();
                cmnd.Dispose();
                conn.Close();

                MessageBox.Show("Check input for negative quantities or prices, duplicate records, empty strings and sell price <= cost price", "Insert Status", MessageBoxButtons.OK, MessageBoxIcon.Error);         
            }

            adpt.Dispose();
            cmnd.Dispose();
            conn.Close();
            return j;
        }

        //TO SELECT
        public void Selct(string sql, SqlConnection conn, DataGridView dGV) {
            int dTi;

            cmnd = new SqlCommand(sql, conn);
            dTbl = new DataTable();

            dGV.Rows.Clear();

            try {
                conn.Open();

                adpt = new SqlDataAdapter(cmnd);
                adpt.Fill(dTbl);

                dTi = dTbl.Columns.Count;

                foreach (DataRow row in dTbl.Rows) 
                {
                    String[] dRow = new string[dTi];

                    for (int i = 0; i < dTi; i++) 
                    {
                        dRow[i] = row[i].ToString();
                    }

                    Populate(dGV, dRow);

                }

                cmnd.Dispose();
                conn.Close();

                dTbl.Rows.Clear();
            }               
            catch (Exception ex) 
            {

                cmnd.Dispose();
                conn.Close();
                MessageBox.Show(ex.Message, "Select Command Status", MessageBoxButtons.OK, MessageBoxIcon.Error);                              

            }
        }

        //TO MAKE A DATATABLE
        public DataTable MakeDataTble(string sql, SqlConnection conn)
        {          
            cmnd = new SqlCommand(sql, conn);
            dTbl = new DataTable();

            try
            {
                conn.Open();

                adpt = new SqlDataAdapter(cmnd);
                adpt.Fill(dTbl);

                cmnd.Dispose();
                conn.Close();

                //dTbl.Rows.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Select Command Status", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return dTbl;
        }

        //TO UPDATE
        public int Updte(SqlConnection conn, string sql, string search) {

            int i=0;

            cmnd = new SqlCommand(sql, conn);

            try 
            {
                conn.Open();

                adpt.UpdateCommand = new SqlCommand(sql, conn);

                if (adpt.UpdateCommand.ExecuteNonQuery() > 0) 
                {
                    MessageBox.Show("Update: " +search, "Update Status", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    i = 1;
                }

                adpt.Dispose();
                cmnd.Dispose();
                conn.Close();
            }
            catch 
            {
                MessageBox.Show("Check input for negative quantities or prices, duplicate records, empty strings and sell price <= cost price", "Update Status", MessageBoxButtons.OK, MessageBoxIcon.Error);
                adpt.Dispose();
                cmnd.Dispose();
                conn.Close();
            }

            return i;
        }

        //TO DELETE
        public int Delte(SqlConnection conn, string sql, string search) 
        {
            int i = 0;
            cmnd = new SqlCommand(sql, conn);

            try
            {
                conn.Open();

                adpt.DeleteCommand = new SqlCommand(sql, conn);

                if (MessageBox.Show("Confirm Deletion of: " +search, "Delete Check", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    if (adpt.DeleteCommand.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("Deleted: " +search, "Delete Status", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        i = 1;
                    }
                }
                else 
                {
                    MessageBox.Show("Please Refresh", "Delete Status",MessageBoxButtons.OK, MessageBoxIcon.Information) ;
                }                               

            cmnd.Dispose();
            conn.Close();                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Deleted Status", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmnd.Dispose();
                conn.Close();
            }

            return i;
        }

        //TO MAKE AND OPEN CHILD FORM
        public void ShowChildForm(string eXistForm)
        {

            Form formInst = Activator.CreateInstance(Type.GetType("CMPG223_Project_V2." + eXistForm)) as Form;

            formInst.MdiParent = this;
            formInst.Show();
        }

        //SALES FORM: SALES FORM LOOKUP
        private void salesLookUpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowChildForm("Sale_LookUp");
        }

        //MENUSTRIP: EXIT
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //MENUSTRIP: UOM FORM
        private void unitOfMeasureToolStripMenuItem_Click(object sender, EventArgs e)
        {            
            ShowChildForm("UOM");
        }

        //MENUSTRIP: SERVICES FORM
        private void servicesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowChildForm("Service");
        }

        //MENUSTRIP: STOCK FORM
        private void stockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowChildForm("Stock");
        }

        //MENUSTRIP: SALES FORM
        private void salesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowChildForm("Sales");
        }

        //MENUSTRIP: GPS
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            ShowChildForm("GPS");
        }

        //MENUSTRIP: SALES REPORT
        private void salesReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SalsReport frm = new SalsReport();
            frm.Show();
        }

        //MENUSTRIP: STOCK REPORT
        private void stockReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StockReport rprt = new StockReport();
            rprt.Show();
        }
    }    

}


