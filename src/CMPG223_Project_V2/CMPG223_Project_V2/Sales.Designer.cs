namespace CMPG223_Project_V2
{
    partial class Sales
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sales));
            this.dGV1 = new System.Windows.Forms.DataGridView();
            this.gBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tBoxSrch = new System.Windows.Forms.TextBox();
            this.gBox2 = new System.Windows.Forms.GroupBox();
            this.tBox1_2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tBox1_3 = new System.Windows.Forms.TextBox();
            this.btnDel1 = new System.Windows.Forms.Button();
            this.btnRef1 = new System.Windows.Forms.Button();
            this.dTP1_2 = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.btnIns1 = new System.Windows.Forms.Button();
            this.btnUp1 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCls = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tBox2_5 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tBox2_7 = new System.Windows.Forms.TextBox();
            this.tBox2_6 = new System.Windows.Forms.Label();
            this.tBox2_1 = new System.Windows.Forms.TextBox();
            this.tBoxItmId = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tBox2_4 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cBox2_1 = new System.Windows.Forms.ComboBox();
            this.tBox2_2 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tBox2_3 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnIns2 = new System.Windows.Forms.Button();
            this.btnUp2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.gBox3 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnDel2 = new System.Windows.Forms.Button();
            this.btnRef2 = new System.Windows.Forms.Button();
            this.tTip_1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dGV1)).BeginInit();
            this.gBox1.SuspendLayout();
            this.gBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dGV1
            // 
            this.dGV1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGV1.Location = new System.Drawing.Point(371, 73);
            this.dGV1.Name = "dGV1";
            this.dGV1.ReadOnly = true;
            this.dGV1.RowHeadersWidth = 51;
            this.dGV1.RowTemplate.Height = 24;
            this.dGV1.Size = new System.Drawing.Size(625, 349);
            this.dGV1.TabIndex = 3;
            this.tTip_1.SetToolTip(this.dGV1, "Select the row by clicking in the first column of\r\nthe datagridview before updati" +
        "ng or deleting existing\r\nitems.\r\nOnce a selection is made the relevant fields sh" +
        "ould \r\npopulate ");
            this.dGV1.Click += new System.EventHandler(this.dGV1_Click_1);
            // 
            // gBox1
            // 
            this.gBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.gBox1.Controls.Add(this.label1);
            this.gBox1.Controls.Add(this.tBoxSrch);
            this.gBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gBox1.Location = new System.Drawing.Point(28, 73);
            this.gBox1.Name = "gBox1";
            this.gBox1.Size = new System.Drawing.Size(297, 96);
            this.gBox1.TabIndex = 1;
            this.gBox1.TabStop = false;
            this.gBox1.Text = "Search Transactions";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lookup Sales Transaction";
            // 
            // tBoxSrch
            // 
            this.tBoxSrch.BackColor = System.Drawing.Color.Maroon;
            this.tBoxSrch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tBoxSrch.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBoxSrch.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.tBoxSrch.Location = new System.Drawing.Point(25, 55);
            this.tBoxSrch.Name = "tBoxSrch";
            this.tBoxSrch.ReadOnly = true;
            this.tBoxSrch.Size = new System.Drawing.Size(251, 22);
            this.tBoxSrch.TabIndex = 1;
            this.tTip_1.SetToolTip(this.tBoxSrch, "Double-click this textbox to lookup existing sale transactions\r\nNB: A selection m" +
        "ust appear in this field for the line detail\r\n      section to be activated");
            this.tBoxSrch.TextChanged += new System.EventHandler(this.tBoxSrch_TextChanged);
            this.tBoxSrch.DoubleClick += new System.EventHandler(this.tBoxSrch_DoubleClick);
            // 
            // gBox2
            // 
            this.gBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.gBox2.Controls.Add(this.tBox1_2);
            this.gBox2.Controls.Add(this.label2);
            this.gBox2.Controls.Add(this.tBox1_3);
            this.gBox2.Controls.Add(this.btnDel1);
            this.gBox2.Controls.Add(this.btnRef1);
            this.gBox2.Controls.Add(this.dTP1_2);
            this.gBox2.Controls.Add(this.label6);
            this.gBox2.Controls.Add(this.btnIns1);
            this.gBox2.Controls.Add(this.btnUp1);
            this.gBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gBox2.Location = new System.Drawing.Point(28, 234);
            this.gBox2.Name = "gBox2";
            this.gBox2.Size = new System.Drawing.Size(297, 260);
            this.gBox2.TabIndex = 2;
            this.gBox2.TabStop = false;
            this.gBox2.Text = "Maintain Transaction";
            // 
            // tBox1_2
            // 
            this.tBox1_2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.tBox1_2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tBox1_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBox1_2.Location = new System.Drawing.Point(25, 18);
            this.tBox1_2.Name = "tBox1_2";
            this.tBox1_2.ReadOnly = true;
            this.tBox1_2.Size = new System.Drawing.Size(115, 15);
            this.tBox1_2.TabIndex = 0;
            this.tBox1_2.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Total";
            // 
            // tBox1_3
            // 
            this.tBox1_3.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.tBox1_3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tBox1_3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBox1_3.Location = new System.Drawing.Point(25, 112);
            this.tBox1_3.Name = "tBox1_3";
            this.tBox1_3.ReadOnly = true;
            this.tBox1_3.Size = new System.Drawing.Size(251, 22);
            this.tBox1_3.TabIndex = 0;
            this.tBox1_3.TabStop = false;
            this.tTip_1.SetToolTip(this.tBox1_3, "Displays the sum of the totals of all the lines for\r\n the transaction number disp" +
        "layed in the search section ");
            // 
            // btnDel1
            // 
            this.btnDel1.BackColor = System.Drawing.Color.Navy;
            this.btnDel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDel1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDel1.Location = new System.Drawing.Point(28, 207);
            this.btnDel1.Name = "btnDel1";
            this.btnDel1.Size = new System.Drawing.Size(112, 30);
            this.btnDel1.TabIndex = 4;
            this.btnDel1.Text = "Delete";
            this.tTip_1.SetToolTip(this.btnDel1, "To delete an existing transaction header:\r\n - Make a selection via transaction lo" +
        "okup \r\n - Press update button\r\n");
            this.btnDel1.UseVisualStyleBackColor = false;
            this.btnDel1.Click += new System.EventHandler(this.btnDel1_Click);
            // 
            // btnRef1
            // 
            this.btnRef1.BackColor = System.Drawing.Color.Navy;
            this.btnRef1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRef1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnRef1.Location = new System.Drawing.Point(164, 207);
            this.btnRef1.Name = "btnRef1";
            this.btnRef1.Size = new System.Drawing.Size(112, 30);
            this.btnRef1.TabIndex = 5;
            this.btnRef1.Text = "Refresh";
            this.tTip_1.SetToolTip(this.btnRef1, "To refresh/clear the form from the transaction header selected \r\nand the line det" +
        "ails displayed:\r\n - Press refresh button\r\n");
            this.btnRef1.UseVisualStyleBackColor = false;
            this.btnRef1.Click += new System.EventHandler(this.btnRef1_Click);
            // 
            // dTP1_2
            // 
            this.dTP1_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dTP1_2.Location = new System.Drawing.Point(28, 55);
            this.dTP1_2.Name = "dTP1_2";
            this.dTP1_2.Size = new System.Drawing.Size(248, 22);
            this.dTP1_2.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(25, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "Date";
            // 
            // btnIns1
            // 
            this.btnIns1.BackColor = System.Drawing.Color.Navy;
            this.btnIns1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIns1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnIns1.Location = new System.Drawing.Point(28, 162);
            this.btnIns1.Name = "btnIns1";
            this.btnIns1.Size = new System.Drawing.Size(112, 30);
            this.btnIns1.TabIndex = 2;
            this.btnIns1.Text = "Insert";
            this.tTip_1.SetToolTip(this.btnIns1, "To insert a new transaction header:\r\n - Select a date from the datepicker\r\n - Pre" +
        "ss insert button");
            this.btnIns1.UseVisualStyleBackColor = false;
            this.btnIns1.Click += new System.EventHandler(this.btnIns1_Click);
            // 
            // btnUp1
            // 
            this.btnUp1.BackColor = System.Drawing.Color.Navy;
            this.btnUp1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUp1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnUp1.Location = new System.Drawing.Point(164, 162);
            this.btnUp1.Name = "btnUp1";
            this.btnUp1.Size = new System.Drawing.Size(112, 30);
            this.btnUp1.TabIndex = 3;
            this.btnUp1.Text = "Update";
            this.tTip_1.SetToolTip(this.btnUp1, "To update an existing transaction header:\r\n - Make a selection via transaction lo" +
        "okup \r\n - Amend the date with the date picker\r\n - Press update button");
            this.btnUp1.UseVisualStyleBackColor = false;
            this.btnUp1.Click += new System.EventHandler(this.btnUp1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(84, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(186, 29);
            this.label7.TabIndex = 0;
            this.label7.Text = "TRANSACTION";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(328, 18);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(171, 29);
            this.label8.TabIndex = 0;
            this.label8.Text = "LINE DETAILS";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.gBox1);
            this.panel1.Controls.Add(this.gBox2);
            this.panel1.Location = new System.Drawing.Point(12, 58);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(368, 559);
            this.panel1.TabIndex = 0;
            // 
            // btnCls
            // 
            this.btnCls.BackColor = System.Drawing.Color.Navy;
            this.btnCls.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCls.Location = new System.Drawing.Point(1300, 641);
            this.btnCls.Name = "btnCls";
            this.btnCls.Size = new System.Drawing.Size(112, 30);
            this.btnCls.TabIndex = 2;
            this.btnCls.Text = "Close";
            this.btnCls.UseVisualStyleBackColor = false;
            this.btnCls.Click += new System.EventHandler(this.btnCls_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.tBox2_5);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Controls.Add(this.gBox3);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.dGV1);
            this.panel2.Location = new System.Drawing.Point(414, 58);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1040, 559);
            this.panel2.TabIndex = 1;
            // 
            // tBox2_5
            // 
            this.tBox2_5.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.tBox2_5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tBox2_5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBox2_5.ForeColor = System.Drawing.SystemColors.WindowText;
            this.tBox2_5.Location = new System.Drawing.Point(676, 454);
            this.tBox2_5.Margin = new System.Windows.Forms.Padding(10);
            this.tBox2_5.Name = "tBox2_5";
            this.tBox2_5.ReadOnly = true;
            this.tBox2_5.Size = new System.Drawing.Size(202, 26);
            this.tBox2_5.TabIndex = 0;
            this.tBox2_5.TabStop = false;
            this.tTip_1.SetToolTip(this.tBox2_5, "Displays line total of the line selected on the datagridview");
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(484, 458);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(152, 18);
            this.label12.TabIndex = 0;
            this.label12.Text = "Selected Line Total";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.groupBox1.Controls.Add(this.tBox2_7);
            this.groupBox1.Controls.Add(this.tBox2_6);
            this.groupBox1.Controls.Add(this.tBox2_1);
            this.groupBox1.Controls.Add(this.tBoxItmId);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.tBox2_4);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.cBox2_1);
            this.groupBox1.Controls.Add(this.tBox2_2);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.tBox2_3);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.btnIns2);
            this.groupBox1.Controls.Add(this.btnUp2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(37, 73);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(297, 312);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Insert / Update Transaction Lines";
            // 
            // tBox2_7
            // 
            this.tBox2_7.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.tBox2_7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tBox2_7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBox2_7.Location = new System.Drawing.Point(162, 159);
            this.tBox2_7.Name = "tBox2_7";
            this.tBox2_7.ReadOnly = true;
            this.tBox2_7.Size = new System.Drawing.Size(108, 22);
            this.tBox2_7.TabIndex = 0;
            this.tBox2_7.TabStop = false;
            this.tTip_1.SetToolTip(this.tBox2_7, "Item_Id is automatically populated from the\r\n\"LookUp Item Description\" selection\r" +
        "\n");
            // 
            // tBox2_6
            // 
            this.tBox2_6.AutoSize = true;
            this.tBox2_6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBox2_6.Location = new System.Drawing.Point(159, 139);
            this.tBox2_6.Name = "tBox2_6";
            this.tBox2_6.Size = new System.Drawing.Size(40, 17);
            this.tBox2_6.TabIndex = 0;
            this.tBox2_6.Text = "UOM";
            // 
            // tBox2_1
            // 
            this.tBox2_1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.tBox2_1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tBox2_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBox2_1.Location = new System.Drawing.Point(32, 76);
            this.tBox2_1.Name = "tBox2_1";
            this.tBox2_1.ReadOnly = true;
            this.tBox2_1.Size = new System.Drawing.Size(115, 15);
            this.tBox2_1.TabIndex = 0;
            this.tBox2_1.Visible = false;
            // 
            // tBoxItmId
            // 
            this.tBoxItmId.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.tBoxItmId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tBoxItmId.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBoxItmId.Location = new System.Drawing.Point(29, 159);
            this.tBoxItmId.Name = "tBoxItmId";
            this.tBoxItmId.ReadOnly = true;
            this.tBoxItmId.Size = new System.Drawing.Size(108, 22);
            this.tBoxItmId.TabIndex = 0;
            this.tBoxItmId.TabStop = false;
            this.tTip_1.SetToolTip(this.tBoxItmId, "Item_Id is automatically populated from the\r\n\"LookUp Item Description\" selection");
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(26, 139);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 17);
            this.label11.TabIndex = 0;
            this.label11.Text = "Item_Id";
            // 
            // tBox2_4
            // 
            this.tBox2_4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBox2_4.Location = new System.Drawing.Point(162, 218);
            this.tBox2_4.Name = "tBox2_4";
            this.tBox2_4.Size = new System.Drawing.Size(112, 22);
            this.tBox2_4.TabIndex = 4;
            this.tTip_1.SetToolTip(this.tBox2_4, "Unit SP is automatically populated from the\r\n\"LookUp Item Description\" selection " +
        "but can be changed\r\nto other values.\r\n\r\n");
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(159, 198);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(101, 17);
            this.label9.TabIndex = 0;
            this.label9.Text = "Unit Sale Price";
            // 
            // cBox2_1
            // 
            this.cBox2_1.FormattingEnabled = true;
            this.cBox2_1.Items.AddRange(new object[] {
            "Stock",
            "Service"});
            this.cBox2_1.Location = new System.Drawing.Point(29, 50);
            this.cBox2_1.Name = "cBox2_1";
            this.cBox2_1.Size = new System.Drawing.Size(247, 24);
            this.cBox2_1.TabIndex = 1;
            this.tTip_1.SetToolTip(this.cBox2_1, "Select stock or service item\r\nNB: This field controls the item lookup box option\r" +
        "\n       that will appear below in the \"LookUp Item Description\"");
            this.cBox2_1.SelectionChangeCommitted += new System.EventHandler(this.cBox2_1_SelectionChangeCommitted);
            // 
            // tBox2_2
            // 
            this.tBox2_2.BackColor = System.Drawing.Color.Maroon;
            this.tBox2_2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tBox2_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBox2_2.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.tBox2_2.Location = new System.Drawing.Point(29, 114);
            this.tBox2_2.Name = "tBox2_2";
            this.tBox2_2.ReadOnly = true;
            this.tBox2_2.Size = new System.Drawing.Size(247, 22);
            this.tBox2_2.TabIndex = 2;
            this.tTip_1.SetToolTip(this.tBox2_2, "Double-click to access either stock- or service maintenance forms");
            this.tBox2_2.TextChanged += new System.EventHandler(this.tBox2_2_TextChanged);
            this.tBox2_2.DoubleClick += new System.EventHandler(this.tBox2_2_DoubleClick);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(28, 94);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(162, 17);
            this.label10.TabIndex = 0;
            this.label10.Text = "LookUp Item Description";
            // 
            // tBox2_3
            // 
            this.tBox2_3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBox2_3.Location = new System.Drawing.Point(29, 218);
            this.tBox2_3.Name = "tBox2_3";
            this.tBox2_3.Size = new System.Drawing.Size(108, 22);
            this.tBox2_3.TabIndex = 3;
            this.tTip_1.SetToolTip(this.tBox2_3, "Enter only positive values for the quantity field");
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(26, 198);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Quantity";
            // 
            // btnIns2
            // 
            this.btnIns2.BackColor = System.Drawing.Color.Navy;
            this.btnIns2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIns2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnIns2.Location = new System.Drawing.Point(29, 261);
            this.btnIns2.Name = "btnIns2";
            this.btnIns2.Size = new System.Drawing.Size(112, 30);
            this.btnIns2.TabIndex = 5;
            this.btnIns2.Text = "Insert";
            this.tTip_1.SetToolTip(this.btnIns2, resources.GetString("btnIns2.ToolTip"));
            this.btnIns2.UseVisualStyleBackColor = false;
            this.btnIns2.Click += new System.EventHandler(this.btnIns2_Click);
            // 
            // btnUp2
            // 
            this.btnUp2.BackColor = System.Drawing.Color.Navy;
            this.btnUp2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUp2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnUp2.Location = new System.Drawing.Point(162, 261);
            this.btnUp2.Name = "btnUp2";
            this.btnUp2.Size = new System.Drawing.Size(112, 30);
            this.btnUp2.TabIndex = 6;
            this.btnUp2.Text = "Update";
            this.tTip_1.SetToolTip(this.btnUp2, resources.GetString("btnUp2.ToolTip"));
            this.btnUp2.UseVisualStyleBackColor = false;
            this.btnUp2.Click += new System.EventHandler(this.btnUp2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(26, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Select Item Type";
            // 
            // gBox3
            // 
            this.gBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.gBox3.Controls.Add(this.label4);
            this.gBox3.Controls.Add(this.btnDel2);
            this.gBox3.Controls.Add(this.btnRef2);
            this.gBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gBox3.Location = new System.Drawing.Point(37, 405);
            this.gBox3.Name = "gBox3";
            this.gBox3.Size = new System.Drawing.Size(297, 106);
            this.gBox3.TabIndex = 2;
            this.gBox3.TabStop = false;
            this.gBox3.Text = "Delete / Refresh Transaction Lines";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(31, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Select row to";
            // 
            // btnDel2
            // 
            this.btnDel2.BackColor = System.Drawing.Color.Navy;
            this.btnDel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDel2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDel2.Location = new System.Drawing.Point(31, 59);
            this.btnDel2.Name = "btnDel2";
            this.btnDel2.Size = new System.Drawing.Size(112, 30);
            this.btnDel2.TabIndex = 1;
            this.btnDel2.Text = "Delete";
            this.tTip_1.SetToolTip(this.btnDel2, "To update existing line detail:\r\n - Select item from the datagridview on the righ" +
        "t\r\n - Press delete button\r\n - Press refresh button to repopulate the datagridvie" +
        "w with one less record\r\n");
            this.btnDel2.UseVisualStyleBackColor = false;
            this.btnDel2.Click += new System.EventHandler(this.btnDel2_Click);
            // 
            // btnRef2
            // 
            this.btnRef2.BackColor = System.Drawing.Color.Navy;
            this.btnRef2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRef2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnRef2.Location = new System.Drawing.Point(164, 59);
            this.btnRef2.Name = "btnRef2";
            this.btnRef2.Size = new System.Drawing.Size(112, 30);
            this.btnRef2.TabIndex = 2;
            this.btnRef2.Text = "Refresh";
            this.tTip_1.SetToolTip(this.btnRef2, "To refresh the line details:\r\n - Press refresh button\r\n");
            this.btnRef2.UseVisualStyleBackColor = false;
            this.btnRef2.Click += new System.EventHandler(this.btnRef2_Click);
            // 
            // tTip_1
            // 
            this.tTip_1.IsBalloon = true;
            this.tTip_1.ShowAlways = true;
            this.tTip_1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // Sales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1463, 727);
            this.ControlBox = false;
            this.Controls.Add(this.btnCls);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Sales";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sales";
            this.Load += new System.EventHandler(this.Sales_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGV1)).EndInit();
            this.gBox1.ResumeLayout(false);
            this.gBox1.PerformLayout();
            this.gBox2.ResumeLayout(false);
            this.gBox2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gBox3.ResumeLayout(false);
            this.gBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dGV1;
        private System.Windows.Forms.GroupBox gBox1;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox tBoxSrch;
        private System.Windows.Forms.GroupBox gBox2;
        private System.Windows.Forms.Button btnIns1;
        private System.Windows.Forms.Button btnUp1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnDel1;
        private System.Windows.Forms.Button btnRef1;
        private System.Windows.Forms.DateTimePicker dTP1_2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox tBox1_3;
        private System.Windows.Forms.Button btnCls;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.TextBox tBox2_2;
        private System.Windows.Forms.Label label10;
        public System.Windows.Forms.TextBox tBox2_3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnIns2;
        private System.Windows.Forms.Button btnUp2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox gBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnDel2;
        private System.Windows.Forms.Button btnRef2;
        private System.Windows.Forms.ComboBox cBox2_1;
        private System.Windows.Forms.Label label12;
        public System.Windows.Forms.TextBox tBoxItmId;
        private System.Windows.Forms.Label label11;
        public System.Windows.Forms.TextBox tBox2_4;
        private System.Windows.Forms.Label label9;
        public System.Windows.Forms.TextBox tBox1_2;
        public System.Windows.Forms.TextBox tBox2_5;
        public System.Windows.Forms.TextBox tBox2_1;
        public System.Windows.Forms.TextBox tBox2_7;
        private System.Windows.Forms.Label tBox2_6;
        private System.Windows.Forms.ToolTip tTip_1;
    }
}