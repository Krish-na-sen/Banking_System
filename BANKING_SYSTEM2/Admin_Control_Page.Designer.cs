namespace BANKING_SYSTEM2
{
    partial class Admin_Control_Page
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
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.sB_BANKDataSet = new BANKING_SYSTEM2.SB_BANKDataSet();
            this.cUSTOMERREGISTRATION1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cUSTOMER_REGISTRATION1TableAdapter = new BANKING_SYSTEM2.SB_BANKDataSetTableAdapters.CUSTOMER_REGISTRATION1TableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sB_BANKDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cUSTOMERREGISTRATION1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkViolet;
            this.label1.Location = new System.Drawing.Point(292, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "ADMIN CONTROL ";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.LightSalmon;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 145);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(705, 260);
            this.dataGridView1.TabIndex = 1;
            // 
            // sB_BANKDataSet
            // 
            this.sB_BANKDataSet.DataSetName = "SB_BANKDataSet";
            this.sB_BANKDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cUSTOMERREGISTRATION1BindingSource
            // 
            this.cUSTOMERREGISTRATION1BindingSource.DataMember = "CUSTOMER_REGISTRATION1";
            this.cUSTOMERREGISTRATION1BindingSource.DataSource = this.sB_BANKDataSet;
            // 
            // cUSTOMER_REGISTRATION1TableAdapter
            // 
            this.cUSTOMER_REGISTRATION1TableAdapter.ClearBeforeFill = true;
            // 
            // Admin_Control_Page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 452);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Name = "Admin_Control_Page";
            this.Text = "Admin_Control_Page";
            this.Load += new System.EventHandler(this.Admin_Control_Page_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sB_BANKDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cUSTOMERREGISTRATION1BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private SB_BANKDataSet sB_BANKDataSet;
        private System.Windows.Forms.BindingSource cUSTOMERREGISTRATION1BindingSource;
        private SB_BANKDataSetTableAdapters.CUSTOMER_REGISTRATION1TableAdapter cUSTOMER_REGISTRATION1TableAdapter;
    }
}