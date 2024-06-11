namespace GP_AniTag
{
    partial class TumSahip
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TumSahip));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.sahipidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sahipadiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sahiptelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sahipmailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sahiplerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.anidataDataSet = new GP_AniTag.anidataDataSet();
            this.sahiplerTableAdapter = new GP_AniTag.anidataDataSetTableAdapters.SahiplerTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sahiplerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.anidataDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sahipidDataGridViewTextBoxColumn,
            this.sahipadiDataGridViewTextBoxColumn,
            this.sahiptelDataGridViewTextBoxColumn,
            this.sahipmailDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.sahiplerBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 21);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(458, 288);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // sahipidDataGridViewTextBoxColumn
            // 
            this.sahipidDataGridViewTextBoxColumn.DataPropertyName = "sahip_id";
            this.sahipidDataGridViewTextBoxColumn.HeaderText = "sahip_id";
            this.sahipidDataGridViewTextBoxColumn.Name = "sahipidDataGridViewTextBoxColumn";
            // 
            // sahipadiDataGridViewTextBoxColumn
            // 
            this.sahipadiDataGridViewTextBoxColumn.DataPropertyName = "sahip_adi";
            this.sahipadiDataGridViewTextBoxColumn.HeaderText = "sahip_adi";
            this.sahipadiDataGridViewTextBoxColumn.Name = "sahipadiDataGridViewTextBoxColumn";
            // 
            // sahiptelDataGridViewTextBoxColumn
            // 
            this.sahiptelDataGridViewTextBoxColumn.DataPropertyName = "sahip_tel";
            this.sahiptelDataGridViewTextBoxColumn.HeaderText = "sahip_tel";
            this.sahiptelDataGridViewTextBoxColumn.Name = "sahiptelDataGridViewTextBoxColumn";
            // 
            // sahipmailDataGridViewTextBoxColumn
            // 
            this.sahipmailDataGridViewTextBoxColumn.DataPropertyName = "sahip_mail";
            this.sahipmailDataGridViewTextBoxColumn.HeaderText = "sahip_mail";
            this.sahipmailDataGridViewTextBoxColumn.Name = "sahipmailDataGridViewTextBoxColumn";
            // 
            // sahiplerBindingSource
            // 
            this.sahiplerBindingSource.DataMember = "Sahipler";
            this.sahiplerBindingSource.DataSource = this.anidataDataSet;
            // 
            // anidataDataSet
            // 
            this.anidataDataSet.DataSetName = "anidataDataSet";
            this.anidataDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sahiplerTableAdapter
            // 
            this.sahiplerTableAdapter.ClearBeforeFill = true;
            // 
            // TumSahip
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TumSahip";
            this.Text = "TumSahip";
            this.Load += new System.EventHandler(this.TumSahip_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sahiplerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.anidataDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private anidataDataSet anidataDataSet;
        private System.Windows.Forms.BindingSource sahiplerBindingSource;
        private anidataDataSetTableAdapters.SahiplerTableAdapter sahiplerTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn sahipidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sahipadiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sahiptelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sahipmailDataGridViewTextBoxColumn;
    }
}