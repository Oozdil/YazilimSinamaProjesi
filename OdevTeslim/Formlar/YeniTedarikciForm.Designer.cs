namespace OdevTeslim.Formlar
{
    partial class YeniTedarikciForm
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
            this.lblForTedarikciEkleFormu = new System.Windows.Forms.Label();
            this.lblAdres = new System.Windows.Forms.Label();
            this.lblTedarikciAdi = new System.Windows.Forms.Label();
            this.txBxTedarikciAdres = new System.Windows.Forms.TextBox();
            this.dgVTedarikciler = new System.Windows.Forms.DataGridView();
            this.tedarikciIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tedarikciIsimDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tedarikciAdresDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.linkLblClose = new System.Windows.Forms.LinkLabel();
            this.btnTedarikciEkle = new System.Windows.Forms.Button();
            this.txBxTedarikci = new System.Windows.Forms.TextBox();
            this.projeDataSeti = new OdevTeslim.Datasets.ProjeDataSeti();
            this.tedarikciTBLBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tedarikciTBLTableAdapter1 = new OdevTeslim.Datasets.ProjeDataSetiTableAdapters.TedarikciTBLTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgVTedarikciler)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projeDataSeti)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tedarikciTBLBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblForTedarikciEkleFormu
            // 
            this.lblForTedarikciEkleFormu.AutoSize = true;
            this.lblForTedarikciEkleFormu.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblForTedarikciEkleFormu.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblForTedarikciEkleFormu.Location = new System.Drawing.Point(179, 140);
            this.lblForTedarikciEkleFormu.Name = "lblForTedarikciEkleFormu";
            this.lblForTedarikciEkleFormu.Size = new System.Drawing.Size(96, 18);
            this.lblForTedarikciEkleFormu.TabIndex = 40;
            this.lblForTedarikciEkleFormu.Text = "Tedarikciler";
            // 
            // lblAdres
            // 
            this.lblAdres.AutoSize = true;
            this.lblAdres.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAdres.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblAdres.Location = new System.Drawing.Point(21, 58);
            this.lblAdres.Name = "lblAdres";
            this.lblAdres.Size = new System.Drawing.Size(65, 18);
            this.lblAdres.TabIndex = 39;
            this.lblAdres.Text = "Adresi :";
            // 
            // lblTedarikciAdi
            // 
            this.lblTedarikciAdi.AutoSize = true;
            this.lblTedarikciAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTedarikciAdi.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTedarikciAdi.Location = new System.Drawing.Point(21, 20);
            this.lblTedarikciAdi.Name = "lblTedarikciAdi";
            this.lblTedarikciAdi.Size = new System.Drawing.Size(89, 18);
            this.lblTedarikciAdi.TabIndex = 38;
            this.lblTedarikciAdi.Text = "Firma Adı :";
            // 
            // txBxTedarikciAdres
            // 
            this.txBxTedarikciAdres.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.txBxTedarikciAdres.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txBxTedarikciAdres.Location = new System.Drawing.Point(136, 54);
            this.txBxTedarikciAdres.Multiline = true;
            this.txBxTedarikciAdres.Name = "txBxTedarikciAdres";
            this.txBxTedarikciAdres.Size = new System.Drawing.Size(242, 67);
            this.txBxTedarikciAdres.TabIndex = 1;
            // 
            // dgVTedarikciler
            // 
            this.dgVTedarikciler.AllowUserToAddRows = false;
            this.dgVTedarikciler.AllowUserToDeleteRows = false;
            this.dgVTedarikciler.AutoGenerateColumns = false;
            this.dgVTedarikciler.BackgroundColor = System.Drawing.Color.LightGoldenrodYellow;
            this.dgVTedarikciler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgVTedarikciler.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tedarikciIDDataGridViewTextBoxColumn,
            this.tedarikciIsimDataGridViewTextBoxColumn,
            this.tedarikciAdresDataGridViewTextBoxColumn});
            this.dgVTedarikciler.DataSource = this.tedarikciTBLBindingSource1;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgVTedarikciler.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgVTedarikciler.Location = new System.Drawing.Point(10, 165);
            this.dgVTedarikciler.Name = "dgVTedarikciler";
            this.dgVTedarikciler.ReadOnly = true;
            this.dgVTedarikciler.RowHeadersVisible = false;
            this.dgVTedarikciler.Size = new System.Drawing.Size(462, 178);
            this.dgVTedarikciler.TabIndex = 36;
            // 
            // tedarikciIDDataGridViewTextBoxColumn
            // 
            this.tedarikciIDDataGridViewTextBoxColumn.DataPropertyName = "TedarikciID";
            this.tedarikciIDDataGridViewTextBoxColumn.HeaderText = "Ted. ID";
            this.tedarikciIDDataGridViewTextBoxColumn.Name = "tedarikciIDDataGridViewTextBoxColumn";
            this.tedarikciIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.tedarikciIDDataGridViewTextBoxColumn.Width = 50;
            // 
            // tedarikciIsimDataGridViewTextBoxColumn
            // 
            this.tedarikciIsimDataGridViewTextBoxColumn.DataPropertyName = "TedarikciIsim";
            this.tedarikciIsimDataGridViewTextBoxColumn.HeaderText = "Isim";
            this.tedarikciIsimDataGridViewTextBoxColumn.Name = "tedarikciIsimDataGridViewTextBoxColumn";
            this.tedarikciIsimDataGridViewTextBoxColumn.ReadOnly = true;
            this.tedarikciIsimDataGridViewTextBoxColumn.Width = 150;
            // 
            // tedarikciAdresDataGridViewTextBoxColumn
            // 
            this.tedarikciAdresDataGridViewTextBoxColumn.DataPropertyName = "TedarikciAdres";
            this.tedarikciAdresDataGridViewTextBoxColumn.HeaderText = "Adres";
            this.tedarikciAdresDataGridViewTextBoxColumn.Name = "tedarikciAdresDataGridViewTextBoxColumn";
            this.tedarikciAdresDataGridViewTextBoxColumn.ReadOnly = true;
            this.tedarikciAdresDataGridViewTextBoxColumn.Width = 250;
            // 
            // linkLblClose
            // 
            this.linkLblClose.AutoSize = true;
            this.linkLblClose.BackColor = System.Drawing.Color.Transparent;
            this.linkLblClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.linkLblClose.LinkColor = System.Drawing.Color.Red;
            this.linkLblClose.Location = new System.Drawing.Point(403, 349);
            this.linkLblClose.Name = "linkLblClose";
            this.linkLblClose.Size = new System.Drawing.Size(69, 20);
            this.linkLblClose.TabIndex = 35;
            this.linkLblClose.TabStop = true;
            this.linkLblClose.Text = "Vazgeç";
            this.linkLblClose.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLblClose_LinkClicked);
            // 
            // btnTedarikciEkle
            // 
            this.btnTedarikciEkle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MidnightBlue;
            this.btnTedarikciEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTedarikciEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTedarikciEkle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnTedarikciEkle.Location = new System.Drawing.Point(384, 16);
            this.btnTedarikciEkle.Name = "btnTedarikciEkle";
            this.btnTedarikciEkle.Size = new System.Drawing.Size(88, 105);
            this.btnTedarikciEkle.TabIndex = 3;
            this.btnTedarikciEkle.Text = "Tedarikçi Ekle";
            this.btnTedarikciEkle.UseVisualStyleBackColor = true;
            this.btnTedarikciEkle.Click += new System.EventHandler(this.btnTedarikciEkle_Click);
            // 
            // txBxTedarikci
            // 
            this.txBxTedarikci.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.txBxTedarikci.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txBxTedarikci.Location = new System.Drawing.Point(136, 16);
            this.txBxTedarikci.Name = "txBxTedarikci";
            this.txBxTedarikci.Size = new System.Drawing.Size(242, 26);
            this.txBxTedarikci.TabIndex = 0;
            // 
            // projeDataSeti
            // 
            this.projeDataSeti.DataSetName = "ProjeDataSeti";
            this.projeDataSeti.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tedarikciTBLBindingSource1
            // 
            this.tedarikciTBLBindingSource1.DataMember = "TedarikciTBL";
            this.tedarikciTBLBindingSource1.DataSource = this.projeDataSeti;
            // 
            // tedarikciTBLTableAdapter1
            // 
            this.tedarikciTBLTableAdapter1.ClearBeforeFill = true;
            // 
            // YeniTedarikciForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(492, 378);
            this.Controls.Add(this.lblForTedarikciEkleFormu);
            this.Controls.Add(this.lblAdres);
            this.Controls.Add(this.lblTedarikciAdi);
            this.Controls.Add(this.txBxTedarikciAdres);
            this.Controls.Add(this.dgVTedarikciler);
            this.Controls.Add(this.linkLblClose);
            this.Controls.Add(this.btnTedarikciEkle);
            this.Controls.Add(this.txBxTedarikci);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "YeniTedarikciForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "YeniTedarikciForm";
            this.Load += new System.EventHandler(this.YeniTedarikciForm_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.YeniTedarikciForm_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.dgVTedarikciler)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projeDataSeti)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tedarikciTBLBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblForTedarikciEkleFormu;
        private System.Windows.Forms.Label lblAdres;
        private System.Windows.Forms.Label lblTedarikciAdi;
        private System.Windows.Forms.TextBox txBxTedarikciAdres;
        private System.Windows.Forms.DataGridView dgVTedarikciler;
        private System.Windows.Forms.LinkLabel linkLblClose;
        private System.Windows.Forms.Button btnTedarikciEkle;
        private System.Windows.Forms.TextBox txBxTedarikci;
        private System.Windows.Forms.DataGridViewTextBoxColumn tedarikciIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tedarikciIsimDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tedarikciAdresDataGridViewTextBoxColumn;
        private Datasets.ProjeDataSeti projeDataSeti;
        private System.Windows.Forms.BindingSource tedarikciTBLBindingSource1;
        private Datasets.ProjeDataSetiTableAdapters.TedarikciTBLTableAdapter tedarikciTBLTableAdapter1;
    }
}