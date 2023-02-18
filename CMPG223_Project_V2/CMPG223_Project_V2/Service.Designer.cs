namespace CMPG223_Project_V2
{
    partial class Service
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
            this.dGV1 = new System.Windows.Forms.DataGridView();
            this.gBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tBoxSrch = new System.Windows.Forms.TextBox();
            this.gBox2 = new System.Windows.Forms.GroupBox();
            this.tBoxUOM_Id = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnUp = new System.Windows.Forms.Button();
            this.btnIns = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.tBoxCol4 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tBoxCol3 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tBoxCol2 = new System.Windows.Forms.TextBox();
            this.gBox3 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnDel = new System.Windows.Forms.Button();
            this.butRef = new System.Windows.Forms.Button();
            this.btnCls = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dGV1)).BeginInit();
            this.gBox1.SuspendLayout();
            this.gBox2.SuspendLayout();
            this.gBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dGV1
            // 
            this.dGV1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGV1.Location = new System.Drawing.Point(36, 41);
            this.dGV1.Name = "dGV1";
            this.dGV1.RowHeadersWidth = 51;
            this.dGV1.RowTemplate.Height = 24;
            this.dGV1.Size = new System.Drawing.Size(680, 450);
            this.dGV1.TabIndex = 0;
            this.dGV1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGV1_CellDoubleClick);
            this.dGV1.Click += new System.EventHandler(this.dGV1_Click);
            // 
            // gBox1
            // 
            this.gBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.gBox1.Controls.Add(this.label1);
            this.gBox1.Controls.Add(this.tBoxSrch);
            this.gBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gBox1.Location = new System.Drawing.Point(750, 21);
            this.gBox1.Name = "gBox1";
            this.gBox1.Size = new System.Drawing.Size(302, 89);
            this.gBox1.TabIndex = 1;
            this.gBox1.TabStop = false;
            this.gBox1.Text = "Search";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Service Description";
            // 
            // tBoxSrch
            // 
            this.tBoxSrch.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBoxSrch.Location = new System.Drawing.Point(22, 50);
            this.tBoxSrch.Name = "tBoxSrch";
            this.tBoxSrch.Size = new System.Drawing.Size(255, 22);
            this.tBoxSrch.TabIndex = 0;
            this.tBoxSrch.TextChanged += new System.EventHandler(this.tBoxSrch_TextChanged);
            // 
            // gBox2
            // 
            this.gBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.gBox2.Controls.Add(this.tBoxUOM_Id);
            this.gBox2.Controls.Add(this.label6);
            this.gBox2.Controls.Add(this.btnUp);
            this.gBox2.Controls.Add(this.btnIns);
            this.gBox2.Controls.Add(this.label4);
            this.gBox2.Controls.Add(this.tBoxCol4);
            this.gBox2.Controls.Add(this.label3);
            this.gBox2.Controls.Add(this.tBoxCol3);
            this.gBox2.Controls.Add(this.label2);
            this.gBox2.Controls.Add(this.tBoxCol2);
            this.gBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gBox2.Location = new System.Drawing.Point(750, 123);
            this.gBox2.Name = "gBox2";
            this.gBox2.Size = new System.Drawing.Size(302, 238);
            this.gBox2.TabIndex = 2;
            this.gBox2.TabStop = false;
            this.gBox2.Text = "Insert / Update";
            // 
            // tBoxUOM_Id
            // 
            this.tBoxUOM_Id.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.tBoxUOM_Id.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBoxUOM_Id.Location = new System.Drawing.Point(221, 99);
            this.tBoxUOM_Id.Name = "tBoxUOM_Id";
            this.tBoxUOM_Id.ReadOnly = true;
            this.tBoxUOM_Id.Size = new System.Drawing.Size(56, 22);
            this.tBoxUOM_Id.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(218, 81);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "UOM Id";
            // 
            // btnUp
            // 
            this.btnUp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUp.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnUp.Location = new System.Drawing.Point(165, 191);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(112, 30);
            this.btnUp.TabIndex = 6;
            this.btnUp.Text = "Update";
            this.btnUp.UseVisualStyleBackColor = false;
            this.btnUp.Click += new System.EventHandler(this.btnUp_Click);
            // 
            // btnIns
            // 
            this.btnIns.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnIns.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIns.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnIns.Location = new System.Drawing.Point(21, 191);
            this.btnIns.Name = "btnIns";
            this.btnIns.Size = new System.Drawing.Size(112, 30);
            this.btnIns.TabIndex = 5;
            this.btnIns.Text = "Insert";
            this.btnIns.UseVisualStyleBackColor = false;
            this.btnIns.Click += new System.EventHandler(this.btnIns_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(20, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Sell Price";
            // 
            // tBoxCol4
            // 
            this.tBoxCol4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBoxCol4.Location = new System.Drawing.Point(22, 146);
            this.tBoxCol4.Name = "tBoxCol4";
            this.tBoxCol4.Size = new System.Drawing.Size(111, 22);
            this.tBoxCol4.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(166, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Lookup UOM Description";
            // 
            // tBoxCol3
            // 
            this.tBoxCol3.BackColor = System.Drawing.Color.Maroon;
            this.tBoxCol3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBoxCol3.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.tBoxCol3.Location = new System.Drawing.Point(22, 99);
            this.tBoxCol3.Name = "tBoxCol3";
            this.tBoxCol3.ReadOnly = true;
            this.tBoxCol3.Size = new System.Drawing.Size(180, 22);
            this.tBoxCol3.TabIndex = 2;
            this.tBoxCol3.DoubleClick += new System.EventHandler(this.tBoxCol3_DoubleClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Service Description";
            // 
            // tBoxCol2
            // 
            this.tBoxCol2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBoxCol2.Location = new System.Drawing.Point(22, 50);
            this.tBoxCol2.Name = "tBoxCol2";
            this.tBoxCol2.Size = new System.Drawing.Size(255, 22);
            this.tBoxCol2.TabIndex = 1;
            // 
            // gBox3
            // 
            this.gBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.gBox3.Controls.Add(this.label5);
            this.gBox3.Controls.Add(this.btnDel);
            this.gBox3.Controls.Add(this.butRef);
            this.gBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gBox3.Location = new System.Drawing.Point(750, 375);
            this.gBox3.Name = "gBox3";
            this.gBox3.Size = new System.Drawing.Size(302, 97);
            this.gBox3.TabIndex = 3;
            this.gBox3.TabStop = false;
            this.gBox3.Text = "Delete / Refresh";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(32, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Select row to";
            // 
            // btnDel
            // 
            this.btnDel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnDel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDel.Location = new System.Drawing.Point(25, 50);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(112, 30);
            this.btnDel.TabIndex = 1;
            this.btnDel.Text = "Delete";
            this.btnDel.UseVisualStyleBackColor = false;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // butRef
            // 
            this.butRef.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.butRef.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butRef.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.butRef.Location = new System.Drawing.Point(169, 50);
            this.butRef.Name = "butRef";
            this.butRef.Size = new System.Drawing.Size(112, 30);
            this.butRef.TabIndex = 2;
            this.butRef.Text = "Refresh";
            this.butRef.UseVisualStyleBackColor = false;
            this.butRef.Click += new System.EventHandler(this.butRef_Click);
            // 
            // btnCls
            // 
            this.btnCls.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnCls.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCls.Location = new System.Drawing.Point(940, 485);
            this.btnCls.Name = "btnCls";
            this.btnCls.Size = new System.Drawing.Size(112, 30);
            this.btnCls.TabIndex = 4;
            this.btnCls.Text = "Close";
            this.btnCls.UseVisualStyleBackColor = false;
            this.btnCls.Click += new System.EventHandler(this.btnCls_Click);
            // 
            // Service
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1086, 529);
            this.ControlBox = false;
            this.Controls.Add(this.btnCls);
            this.Controls.Add(this.gBox3);
            this.Controls.Add(this.gBox2);
            this.Controls.Add(this.gBox1);
            this.Controls.Add(this.dGV1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Service";
            this.Text = "Service";
            this.Load += new System.EventHandler(this.Service_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGV1)).EndInit();
            this.gBox1.ResumeLayout(false);
            this.gBox1.PerformLayout();
            this.gBox2.ResumeLayout(false);
            this.gBox2.PerformLayout();
            this.gBox3.ResumeLayout(false);
            this.gBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox gBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tBoxSrch;
        private System.Windows.Forms.GroupBox gBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tBoxCol4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tBoxCol3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tBoxCol2;
        private System.Windows.Forms.Button btnIns;
        private System.Windows.Forms.Button btnUp;
        private System.Windows.Forms.GroupBox gBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button butRef;
        private System.Windows.Forms.Button btnCls;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tBoxUOM_Id;
        public System.Windows.Forms.DataGridView dGV1;
    }
}