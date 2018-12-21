using OdevTeslim.Datasets;

namespace OdevTeslim.Formlar
{
    partial class KategoriEkleForm
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
            this.dgVKategoriler = new System.Windows.Forms.DataGridView();
            this.kategoriIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kategoriDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.linkLblClose = new System.Windows.Forms.LinkLabel();
            this.btnKategoriEkle = new System.Windows.Forms.Button();
            this.txBxKategori = new System.Windows.Forms.TextBox();
            this.projeDataSeti = new OdevTeslim.Datasets.ProjeDataSeti();
            this.kategoriTBLBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.kategoriTBLTableAdapter1 = new OdevTeslim.Datasets.ProjeDataSetiTableAdapters.KategoriTBLTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgVKategoriler)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projeDataSeti)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kategoriTBLBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgVKategoriler
            // 
            this.dgVKategoriler.AllowUserToAddRows = false;
            this.dgVKategoriler.AllowUserToDeleteRows = false;
            this.dgVKategoriler.AutoGenerateColumns = false;
            this.dgVKategoriler.BackgroundColor = System.Drawing.Color.LightGoldenrodYellow;
            this.dgVKategoriler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgVKategoriler.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.kategoriIDDataGridViewTextBoxColumn,
            this.kategoriDataGridViewTextBoxColumn});
            this.dgVKategoriler.DataSource = this.kategoriTBLBindingSource1;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgVKategoriler.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgVKategoriler.Location = new System.Drawing.Point(12, 66);
            this.dgVKategoriler.Name = "dgVKategoriler";
            this.dgVKategoriler.ReadOnly = true;
            this.dgVKategoriler.RowHeadersVisible = false;
            this.dgVKategoriler.Size = new System.Drawing.Size(336, 178);
            this.dgVKategoriler.TabIndex = 11;
            // 
            // kategoriIDDataGridViewTextBoxColumn
            // 
            this.kategoriIDDataGridViewTextBoxColumn.DataPropertyName = "KategoriID";
            this.kategoriIDDataGridViewTextBoxColumn.HeaderText = "KategoriID";
            this.kategoriIDDataGridViewTextBoxColumn.Name = "kategoriIDDataGridViewTextBoxColumn";
            this.kategoriIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.kategoriIDDataGridViewTextBoxColumn.Width = 75;
            // 
            // kategoriDataGridViewTextBoxColumn
            // 
            this.kategoriDataGridViewTextBoxColumn.DataPropertyName = "Kategori";
            this.kategoriDataGridViewTextBoxColumn.HeaderText = "Kategori";
            this.kategoriDataGridViewTextBoxColumn.Name = "kategoriDataGridViewTextBoxColumn";
            this.kategoriDataGridViewTextBoxColumn.ReadOnly = true;
            this.kategoriDataGridViewTextBoxColumn.Width = 250;
            // 
            // linkLblClose
            // 
            this.linkLblClose.AutoSize = true;
            this.linkLblClose.BackColor = System.Drawing.Color.Transparent;
            this.linkLblClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.linkLblClose.LinkColor = System.Drawing.Color.Red;
            this.linkLblClose.Location = new System.Drawing.Point(279, 250);
            this.linkLblClose.Name = "linkLblClose";
            this.linkLblClose.Size = new System.Drawing.Size(69, 20);
            this.linkLblClose.TabIndex = 10;
            this.linkLblClose.TabStop = true;
            this.linkLblClose.Text = "Vazgeç";
            this.linkLblClose.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLblClose_LinkClicked);
            // 
            // btnKategoriEkle
            // 
            this.btnKategoriEkle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MidnightBlue;
            this.btnKategoriEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKategoriEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKategoriEkle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnKategoriEkle.Location = new System.Drawing.Point(220, 11);
            this.btnKategoriEkle.Name = "btnKategoriEkle";
            this.btnKategoriEkle.Size = new System.Drawing.Size(128, 30);
            this.btnKategoriEkle.TabIndex = 9;
            this.btnKategoriEkle.Text = "Kategori  Ekle";
            this.btnKategoriEkle.UseVisualStyleBackColor = true;
            this.btnKategoriEkle.Click += new System.EventHandler(this.btnKategoriEkle_Click);
            // 
            // txBxKategori
            // 
            this.txBxKategori.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.txBxKategori.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txBxKategori.Location = new System.Drawing.Point(12, 12);
            this.txBxKategori.Name = "txBxKategori";
            this.txBxKategori.Size = new System.Drawing.Size(193, 26);
            this.txBxKategori.TabIndex = 8;
            // 
            // projeDataSeti
            // 
            this.projeDataSeti.DataSetName = "ProjeDataSeti";
            this.projeDataSeti.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kategoriTBLBindingSource1
            // 
            this.kategoriTBLBindingSource1.DataMember = "KategoriTBL";
            this.kategoriTBLBindingSource1.DataSource = this.projeDataSeti;
            // 
            // kategoriTBLTableAdapter1
            // 
            this.kategoriTBLTableAdapter1.ClearBeforeFill = true;
            // 
            // KategoriEkleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(361, 282);
            this.Controls.Add(this.dgVKategoriler);
            this.Controls.Add(this.linkLblClose);
            this.Controls.Add(this.btnKategoriEkle);
            this.Controls.Add(this.txBxKategori);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "KategoriEkleForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KategoriEkleForm";
            this.Load += new System.EventHandler(this.KategoriEkleForm_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.KategoriEkleForm_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.dgVKategoriler)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projeDataSeti)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kategoriTBLBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgVKategoriler;
        private System.Windows.Forms.LinkLabel linkLblClose;
        private System.Windows.Forms.Button btnKategoriEkle;
        private System.Windows.Forms.TextBox txBxKategori;
        private System.Windows.Forms.DataGridViewTextBoxColumn kategoriIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kategoriDataGridViewTextBoxColumn;
        private ProjeDataSeti projeDataSeti;
        private System.Windows.Forms.BindingSource kategoriTBLBindingSource1;
        private Datasets.ProjeDataSetiTableAdapters.KategoriTBLTableAdapter kategoriTBLTableAdapter1;
    }
}