using OdevTeslim.Datasets;

namespace OdevTeslim.Formlar
{
    partial class UrunStokHareketForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnEkle = new System.Windows.Forms.Button();
            this.dgVHareketler = new System.Windows.Forms.DataGridView();
            this.tarihDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fsoyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stokHareketTipDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tsoyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stokIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stokHareketIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perIsimDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perSoyisimDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stokHareketViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stokHareketleriDataSet = new OdevTeslim.Datasets.StokHareketleriDataSet();
            this.lblForStokFormu = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.stokHareketViewTableAdapter = new OdevTeslim.Datasets.StokHareketleriDataSetTableAdapters.StokHareketViewTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgVHareketler)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stokHareketViewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stokHareketleriDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEkle
            // 
            this.btnEkle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MidnightBlue;
            this.btnEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEkle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEkle.Location = new System.Drawing.Point(727, 58);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(86, 137);
            this.btnEkle.TabIndex = 23;
            this.btnEkle.Text = "Rapor Al";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // dgVHareketler
            // 
            this.dgVHareketler.AllowUserToAddRows = false;
            this.dgVHareketler.AllowUserToDeleteRows = false;
            this.dgVHareketler.AutoGenerateColumns = false;
            this.dgVHareketler.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgVHareketler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgVHareketler.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tarihDataGridViewTextBoxColumn,
            this.fadDataGridViewTextBoxColumn,
            this.fsoyadDataGridViewTextBoxColumn,
            this.stokHareketTipDataGridViewTextBoxColumn,
            this.tadDataGridViewTextBoxColumn,
            this.tsoyadDataGridViewTextBoxColumn,
            this.stokIDDataGridViewTextBoxColumn,
            this.stokHareketIDDataGridViewTextBoxColumn,
            this.perIDDataGridViewTextBoxColumn,
            this.perIsimDataGridViewTextBoxColumn,
            this.perSoyisimDataGridViewTextBoxColumn});
            this.dgVHareketler.DataSource = this.stokHareketViewBindingSource;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgVHareketler.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgVHareketler.Location = new System.Drawing.Point(12, 58);
            this.dgVHareketler.MultiSelect = false;
            this.dgVHareketler.Name = "dgVHareketler";
            this.dgVHareketler.ReadOnly = true;
            this.dgVHareketler.RowHeadersVisible = false;
            this.dgVHareketler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgVHareketler.Size = new System.Drawing.Size(696, 369);
            this.dgVHareketler.TabIndex = 21;
            // 
            // tarihDataGridViewTextBoxColumn
            // 
            this.tarihDataGridViewTextBoxColumn.DataPropertyName = "Tarih";
            this.tarihDataGridViewTextBoxColumn.HeaderText = "Tarih";
            this.tarihDataGridViewTextBoxColumn.Name = "tarihDataGridViewTextBoxColumn";
            this.tarihDataGridViewTextBoxColumn.ReadOnly = true;
            this.tarihDataGridViewTextBoxColumn.Width = 75;
            // 
            // fadDataGridViewTextBoxColumn
            // 
            this.fadDataGridViewTextBoxColumn.DataPropertyName = "Fad";
            this.fadDataGridViewTextBoxColumn.HeaderText = "Kimden";
            this.fadDataGridViewTextBoxColumn.Name = "fadDataGridViewTextBoxColumn";
            this.fadDataGridViewTextBoxColumn.ReadOnly = true;
            this.fadDataGridViewTextBoxColumn.Width = 75;
            // 
            // fsoyadDataGridViewTextBoxColumn
            // 
            this.fsoyadDataGridViewTextBoxColumn.DataPropertyName = "Fsoyad";
            this.fsoyadDataGridViewTextBoxColumn.HeaderText = "";
            this.fsoyadDataGridViewTextBoxColumn.Name = "fsoyadDataGridViewTextBoxColumn";
            this.fsoyadDataGridViewTextBoxColumn.ReadOnly = true;
            this.fsoyadDataGridViewTextBoxColumn.Width = 75;
            // 
            // stokHareketTipDataGridViewTextBoxColumn
            // 
            this.stokHareketTipDataGridViewTextBoxColumn.DataPropertyName = "StokHareketTip";
            this.stokHareketTipDataGridViewTextBoxColumn.HeaderText = "StokHareketTip";
            this.stokHareketTipDataGridViewTextBoxColumn.Name = "stokHareketTipDataGridViewTextBoxColumn";
            this.stokHareketTipDataGridViewTextBoxColumn.ReadOnly = true;
            this.stokHareketTipDataGridViewTextBoxColumn.Width = 150;
            // 
            // tadDataGridViewTextBoxColumn
            // 
            this.tadDataGridViewTextBoxColumn.DataPropertyName = "Tad";
            this.tadDataGridViewTextBoxColumn.HeaderText = "Kime";
            this.tadDataGridViewTextBoxColumn.Name = "tadDataGridViewTextBoxColumn";
            this.tadDataGridViewTextBoxColumn.ReadOnly = true;
            this.tadDataGridViewTextBoxColumn.Width = 75;
            // 
            // tsoyadDataGridViewTextBoxColumn
            // 
            this.tsoyadDataGridViewTextBoxColumn.DataPropertyName = "Tsoyad";
            this.tsoyadDataGridViewTextBoxColumn.HeaderText = "";
            this.tsoyadDataGridViewTextBoxColumn.Name = "tsoyadDataGridViewTextBoxColumn";
            this.tsoyadDataGridViewTextBoxColumn.ReadOnly = true;
            this.tsoyadDataGridViewTextBoxColumn.Width = 75;
            // 
            // stokIDDataGridViewTextBoxColumn
            // 
            this.stokIDDataGridViewTextBoxColumn.DataPropertyName = "StokID";
            this.stokIDDataGridViewTextBoxColumn.HeaderText = "StokID";
            this.stokIDDataGridViewTextBoxColumn.Name = "stokIDDataGridViewTextBoxColumn";
            this.stokIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.stokIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // stokHareketIDDataGridViewTextBoxColumn
            // 
            this.stokHareketIDDataGridViewTextBoxColumn.DataPropertyName = "StokHareketID";
            this.stokHareketIDDataGridViewTextBoxColumn.HeaderText = "StokHareketID";
            this.stokHareketIDDataGridViewTextBoxColumn.Name = "stokHareketIDDataGridViewTextBoxColumn";
            this.stokHareketIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.stokHareketIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // perIDDataGridViewTextBoxColumn
            // 
            this.perIDDataGridViewTextBoxColumn.DataPropertyName = "PerID";
            this.perIDDataGridViewTextBoxColumn.HeaderText = "PerID";
            this.perIDDataGridViewTextBoxColumn.Name = "perIDDataGridViewTextBoxColumn";
            this.perIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.perIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // perIsimDataGridViewTextBoxColumn
            // 
            this.perIsimDataGridViewTextBoxColumn.DataPropertyName = "PerIsim";
            this.perIsimDataGridViewTextBoxColumn.HeaderText = "İşlemi Yapan";
            this.perIsimDataGridViewTextBoxColumn.Name = "perIsimDataGridViewTextBoxColumn";
            this.perIsimDataGridViewTextBoxColumn.ReadOnly = true;
            this.perIsimDataGridViewTextBoxColumn.Width = 75;
            // 
            // perSoyisimDataGridViewTextBoxColumn
            // 
            this.perSoyisimDataGridViewTextBoxColumn.DataPropertyName = "PerSoyisim";
            this.perSoyisimDataGridViewTextBoxColumn.HeaderText = "";
            this.perSoyisimDataGridViewTextBoxColumn.Name = "perSoyisimDataGridViewTextBoxColumn";
            this.perSoyisimDataGridViewTextBoxColumn.ReadOnly = true;
            this.perSoyisimDataGridViewTextBoxColumn.Width = 75;
            // 
            // stokHareketViewBindingSource
            // 
            this.stokHareketViewBindingSource.DataMember = "StokHareketView";
            this.stokHareketViewBindingSource.DataSource = this.stokHareketleriDataSet;
            // 
            // stokHareketleriDataSet
            // 
            this.stokHareketleriDataSet.DataSetName = "StokHareketleriDataSet";
            this.stokHareketleriDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lblForStokFormu
            // 
            this.lblForStokFormu.AutoSize = true;
            this.lblForStokFormu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblForStokFormu.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblForStokFormu.Location = new System.Drawing.Point(12, 25);
            this.lblForStokFormu.Name = "lblForStokFormu";
            this.lblForStokFormu.Size = new System.Drawing.Size(101, 17);
            this.lblForStokFormu.TabIndex = 20;
            this.lblForStokFormu.Text = "Stok Durumu";
            // 
            // btnClose
            // 
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MidnightBlue;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnClose.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnClose.Location = new System.Drawing.Point(727, 393);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(86, 34);
            this.btnClose.TabIndex = 24;
            this.btnClose.Text = "Kapat";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // stokHareketViewTableAdapter
            // 
            this.stokHareketViewTableAdapter.ClearBeforeFill = true;
            // 
            // UrunStokHareketForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(834, 452);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.dgVHareketler);
            this.Controls.Add(this.lblForStokFormu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UrunStokHareketForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UrunStokHareketForm";
            this.Load += new System.EventHandler(this.UrunStokHareketForm_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.UrunStokHareketForm_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.dgVHareketler)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stokHareketViewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stokHareketleriDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.DataGridView dgVHareketler;
        private System.Windows.Forms.Label lblForStokFormu;
        private System.Windows.Forms.Button btnClose;
        private StokHareketleriDataSet stokHareketleriDataSet;
        private System.Windows.Forms.BindingSource stokHareketViewBindingSource;
        private Datasets.StokHareketleriDataSetTableAdapters.StokHareketViewTableAdapter stokHareketViewTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn tarihDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fsoyadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stokHareketTipDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tsoyadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stokIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stokHareketIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn perIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn perIsimDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn perSoyisimDataGridViewTextBoxColumn;
    }
}