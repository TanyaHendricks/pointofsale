namespace CMPG223_Project_V2
{
    partial class UOM
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dGV1 = new System.Windows.Forms.DataGridView();
            this.btnUp = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnCls = new System.Windows.Forms.Button();
            this.tBoxCol2 = new System.Windows.Forms.TextBox();
            this.btnIns = new System.Windows.Forms.Button();
            this.butRef = new System.Windows.Forms.Button();
            this.tBoxSrch = new System.Windows.Forms.TextBox();
            this.gBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gBox3 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.gBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dGV1)).BeginInit();
            this.gBox1.SuspendLayout();
            this.gBox3.SuspendLayout();
            this.gBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dGV1
            // 
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dGV1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dGV1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dGV1.DefaultCellStyle = dataGridViewCellStyle8;
            this.dGV1.Location = new System.Drawing.Point(43, 38);
            this.dGV1.Name = "dGV1";
            this.dGV1.RowHeadersWidth = 51;
            this.dGV1.RowTemplate.Height = 24;
            this.dGV1.Size = new System.Drawing.Size(519, 430);
            this.dGV1.TabIndex = 0;
            this.dGV1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGV1_CellDoubleClick);
            this.dGV1.Click += new System.EventHandler(this.dGV1_Click);
            // 
            // btnUp
            // 
            this.btnUp.BackColor = System.Drawing.Color.Olive;
            this.btnUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUp.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnUp.Location = new System.Drawing.Point(164, 106);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(112, 30);
            this.btnUp.TabIndex = 3;
            this.btnUp.Text = "Update";
            this.btnUp.UseVisualStyleBackColor = false;
            this.btnUp.Click += new System.EventHandler(this.btnUp_Click);
            // 
            // btnDel
            // 
            this.btnDel.BackColor = System.Drawing.Color.Olive;
            this.btnDel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDel.Location = new System.Drawing.Point(31, 59);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(112, 30);
            this.btnDel.TabIndex = 1;
            this.btnDel.Text = "Delete";
            this.btnDel.UseVisualStyleBackColor = false;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnCls
            // 
            this.btnCls.BackColor = System.Drawing.Color.Olive;
            this.btnCls.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCls.Location = new System.Drawing.Point(783, 438);
            this.btnCls.Name = "btnCls";
            this.btnCls.Size = new System.Drawing.Size(112, 30);
            this.btnCls.TabIndex = 4;
            this.btnCls.Text = "Close";
            this.btnCls.UseVisualStyleBackColor = false;
            this.btnCls.Click += new System.EventHandler(this.btnCls_Click);
            // 
            // tBoxCol2
            // 
            this.tBoxCol2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBoxCol2.Location = new System.Drawing.Point(31, 59);
            this.tBoxCol2.Name = "tBoxCol2";
            this.tBoxCol2.Size = new System.Drawing.Size(242, 22);
            this.tBoxCol2.TabIndex = 1;
            // 
            // btnIns
            // 
            this.btnIns.BackColor = System.Drawing.Color.Olive;
            this.btnIns.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIns.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnIns.Location = new System.Drawing.Point(31, 106);
            this.btnIns.Name = "btnIns";
            this.btnIns.Size = new System.Drawing.Size(112, 30);
            this.btnIns.TabIndex = 2;
            this.btnIns.Text = "Insert";
            this.btnIns.UseVisualStyleBackColor = false;
            this.btnIns.Click += new System.EventHandler(this.btnIns_Click);
            // 
            // butRef
            // 
            this.butRef.BackColor = System.Drawing.Color.Olive;
            this.butRef.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butRef.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.butRef.Location = new System.Drawing.Point(164, 59);
            this.butRef.Name = "butRef";
            this.butRef.Size = new System.Drawing.Size(112, 30);
            this.butRef.TabIndex = 2;
            this.butRef.Text = "Refresh";
            this.butRef.UseVisualStyleBackColor = false;
            this.butRef.Click += new System.EventHandler(this.butRef_Click);
            // 
            // tBoxSrch
            // 
            this.tBoxSrch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tBoxSrch.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBoxSrch.Location = new System.Drawing.Point(28, 55);
            this.tBoxSrch.Name = "tBoxSrch";
            this.tBoxSrch.Size = new System.Drawing.Size(242, 22);
            this.tBoxSrch.TabIndex = 1;
            this.tBoxSrch.TextChanged += new System.EventHandler(this.tBoxSrch_TextChanged);
            // 
            // gBox1
            // 
            this.gBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.gBox1.Controls.Add(this.label1);
            this.gBox1.Controls.Add(this.tBoxSrch);
            this.gBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gBox1.Location = new System.Drawing.Point(598, 34);
            this.gBox1.Name = "gBox1";
            this.gBox1.Size = new System.Drawing.Size(297, 96);
            this.gBox1.TabIndex = 1;
            this.gBox1.TabStop = false;
            this.gBox1.Text = "Search";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "UOM Description";
            // 
            // gBox3
            // 
            this.gBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.gBox3.Controls.Add(this.label3);
            this.gBox3.Controls.Add(this.btnDel);
            this.gBox3.Controls.Add(this.butRef);
            this.gBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gBox3.Location = new System.Drawing.Point(598, 311);
            this.gBox3.Name = "gBox3";
            this.gBox3.Size = new System.Drawing.Size(297, 106);
            this.gBox3.TabIndex = 3;
            this.gBox3.TabStop = false;
            this.gBox3.Text = "Delete / Refresh";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(31, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Select row to";
            // 
            // gBox2
            // 
            this.gBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.gBox2.Controls.Add(this.btnIns);
            this.gBox2.Controls.Add(this.btnUp);
            this.gBox2.Controls.Add(this.tBoxCol2);
            this.gBox2.Controls.Add(this.label2);
            this.gBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gBox2.Location = new System.Drawing.Point(598, 142);
            this.gBox2.Name = "gBox2";
            this.gBox2.Size = new System.Drawing.Size(297, 155);
            this.gBox2.TabIndex = 2;
            this.gBox2.TabStop = false;
            this.gBox2.Text = "Insert / Update";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "UOM Description";
            // 
            // UOM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(926, 507);
            this.ControlBox = false;
            this.Controls.Add(this.gBox2);
            this.Controls.Add(this.gBox3);
            this.Controls.Add(this.gBox1);
            this.Controls.Add(this.btnCls);
            this.Controls.Add(this.dGV1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UOM";
            this.Text = "Unit Of Measure";
            this.Load += new System.EventHandler(this.UOM_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGV1)).EndInit();
            this.gBox1.ResumeLayout(false);
            this.gBox1.PerformLayout();
            this.gBox3.ResumeLayout(false);
            this.gBox3.PerformLayout();
            this.gBox2.ResumeLayout(false);
            this.gBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnUp;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnCls;
        private System.Windows.Forms.Button btnIns;
        private System.Windows.Forms.Button butRef;
        public System.Windows.Forms.TextBox tBoxCol2;
        public System.Windows.Forms.TextBox tBoxSrch;
        private System.Windows.Forms.GroupBox gBox1;
        private System.Windows.Forms.GroupBox gBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox gBox2;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.DataGridView dGV1;
    }
}