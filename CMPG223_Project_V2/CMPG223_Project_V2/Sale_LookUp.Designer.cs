namespace CMPG223_Project_V2
{
    partial class Sale_LookUp
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
            this.dTP1 = new System.Windows.Forms.DateTimePicker();
            this.dGV1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.butRef = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tBoxSale_Id = new System.Windows.Forms.TextBox();
            this.btnCls = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dGV1)).BeginInit();
            this.SuspendLayout();
            // 
            // dTP1
            // 
            this.dTP1.Location = new System.Drawing.Point(32, 46);
            this.dTP1.Name = "dTP1";
            this.dTP1.Size = new System.Drawing.Size(402, 22);
            this.dTP1.TabIndex = 1;
            this.dTP1.ValueChanged += new System.EventHandler(this.dTP1_ValueChanged);
            // 
            // dGV1
            // 
            this.dGV1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGV1.Location = new System.Drawing.Point(32, 88);
            this.dGV1.Name = "dGV1";
            this.dGV1.ReadOnly = true;
            this.dGV1.RowHeadersWidth = 51;
            this.dGV1.RowTemplate.Height = 24;
            this.dGV1.Size = new System.Drawing.Size(402, 296);
            this.dGV1.TabIndex = 3;
            this.dGV1.Click += new System.EventHandler(this.dGV1_Click);
            this.dGV1.DoubleClick += new System.EventHandler(this.dGV1_DoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Date Search";
            // 
            // butRef
            // 
            this.butRef.BackColor = System.Drawing.Color.Navy;
            this.butRef.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butRef.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.butRef.Location = new System.Drawing.Point(189, 413);
            this.butRef.Name = "butRef";
            this.butRef.Size = new System.Drawing.Size(112, 30);
            this.butRef.TabIndex = 5;
            this.butRef.Text = "Refresh";
            this.butRef.UseVisualStyleBackColor = false;
            this.butRef.Click += new System.EventHandler(this.butRef_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 400);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Selected No";
            // 
            // tBoxSale_Id
            // 
            this.tBoxSale_Id.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.tBoxSale_Id.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tBoxSale_Id.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBoxSale_Id.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.tBoxSale_Id.Location = new System.Drawing.Point(32, 418);
            this.tBoxSale_Id.Name = "tBoxSale_Id";
            this.tBoxSale_Id.Size = new System.Drawing.Size(134, 22);
            this.tBoxSale_Id.TabIndex = 4;
            this.tBoxSale_Id.TabStop = false;
            // 
            // btnCls
            // 
            this.btnCls.BackColor = System.Drawing.Color.Navy;
            this.btnCls.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCls.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCls.Location = new System.Drawing.Point(322, 413);
            this.btnCls.Name = "btnCls";
            this.btnCls.Size = new System.Drawing.Size(112, 30);
            this.btnCls.TabIndex = 6;
            this.btnCls.Text = "Close";
            this.btnCls.UseVisualStyleBackColor = false;
            this.btnCls.Click += new System.EventHandler(this.btnCls_Click);
            // 
            // Sale_LookUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(479, 468);
            this.Controls.Add(this.btnCls);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tBoxSale_Id);
            this.Controls.Add(this.butRef);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dGV1);
            this.Controls.Add(this.dTP1);
            this.Name = "Sale_LookUp";
            this.Text = "Sale_LookUp";
            this.Load += new System.EventHandler(this.Sale_LookUp_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGV1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker dTP1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button butRef;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tBoxSale_Id;
        private System.Windows.Forms.Button btnCls;
        public System.Windows.Forms.DataGridView dGV1;
    }
}