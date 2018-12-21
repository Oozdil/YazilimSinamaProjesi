using OdevTeslim.Datasets;

namespace OdevTeslim.Formlar
{
    partial class MarkaEkleForm
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
            this.txBxMarka = new System.Windows.Forms.TextBox();
            this.btnMarkaEkle = new System.Windows.Forms.Button();
            this.linkLblClose = new System.Windows.Forms.LinkLabel();
            this.dgVMarkalar = new System.Windows.Forms.DataGridView();
            this.markaIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.markaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.projeDataSeti = new OdevTeslim.Datasets.ProjeDataSeti();
            this.markaTBLBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.markaTBLTableAdapter1 = new OdevTeslim.Datasets.ProjeDataSetiTableAdapters.MarkaTBLTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgVMarkalar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projeDataSeti)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.markaTBLBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // txBxMarka
            // 
            this.txBxMarka.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.txBxMarka.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txBxMarka.Location = new System.Drawing.Point(12, 12);
            this.txBxMarka.Name = "txBxMarka";
            this.txBxMarka.Size = new System.Drawing.Size(193, 26);
            this.txBxMarka.TabIndex = 1;
            // 
            // btnMarkaEkle
            // 
            this.btnMarkaEkle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MidnightBlue;
            this.btnMarkaEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMarkaEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMarkaEkle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMarkaEkle.Location = new System.Drawing.Point(220, 11);
            this.btnMarkaEkle.Name = "btnMarkaEkle";
            this.btnMarkaEkle.Size = new System.Drawing.Size(128, 30);
            this.btnMarkaEkle.TabIndex = 2;
            this.btnMarkaEkle.Text = "Marka Ekle";
            this.btnMarkaEkle.UseVisualStyleBackColor = true;
            this.btnMarkaEkle.Click += new System.EventHandler(this.btnMarkaEkle_Click);
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
            this.linkLblClose.TabIndex = 6;
            this.linkLblClose.TabStop = true;
            this.linkLblClose.Text = "Vazgeç";
            this.linkLblClose.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLblClose_LinkClicked);
            // 
            // dgVMarkalar
            // 
            this.dgVMarkalar.AllowUserToAddRows = false;
            this.dgVMarkalar.AllowUserToDeleteRows = false;
            this.dgVMarkalar.AutoGenerateColumns = false;
            this.dgVMarkalar.BackgroundColor = System.Drawing.Color.LightGoldenrodYellow;
            this.dgVMarkalar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgVMarkalar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.markaIDDataGridViewTextBoxColumn,
            this.markaDataGridViewTextBoxColumn});
            this.dgVMarkalar.DataSource = this.markaTBLBindingSource1;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgVMarkalar.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgVMarkalar.Location = new System.Drawing.Point(12, 66);
            this.dgVMarkalar.Name = "dgVMarkalar";
            this.dgVMarkalar.ReadOnly = true;
            this.dgVMarkalar.RowHeadersVisible = false;
            this.dgVMarkalar.Size = new System.Drawing.Size(336, 178);
            this.dgVMarkalar.TabIndex = 7;
            // 
            // markaIDDataGridViewTextBoxColumn
            // 
            this.markaIDDataGridViewTextBoxColumn.DataPropertyName = "MarkaID";
            this.markaIDDataGridViewTextBoxColumn.HeaderText = "Marka ID";
            this.markaIDDataGridViewTextBoxColumn.Name = "markaIDDataGridViewTextBoxColumn";
            this.markaIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.markaIDDataGridViewTextBoxColumn.Width = 75;
            // 
            // markaDataGridViewTextBoxColumn
            // 
            this.markaDataGridViewTextBoxColumn.DataPropertyName = "Marka";
            this.markaDataGridViewTextBoxColumn.HeaderText = "Marka";
            this.markaDataGridViewTextBoxColumn.Name = "markaDataGridViewTextBoxColumn";
            this.markaDataGridViewTextBoxColumn.ReadOnly = true;
            this.markaDataGridViewTextBoxColumn.Width = 250;
            // 
            // projeDataSeti
            // 
            this.projeDataSeti.DataSetName = "ProjeDataSeti";
            this.projeDataSeti.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // markaTBLBindingSource1
            // 
            this.markaTBLBindingSource1.DataMember = "MarkaTBL";
            this.markaTBLBindingSource1.DataSource = this.projeDataSeti;
            // 
            // markaTBLTableAdapter1
            // 
            this.markaTBLTableAdapter1.ClearBeforeFill = true;
            // 
            // MarkaEkleForm
            // 
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(361, 283);
            this.Controls.Add(this.dgVMarkalar);
            this.Controls.Add(this.linkLblClose);
            this.Controls.Add(this.btnMarkaEkle);
            this.Controls.Add(this.txBxMarka);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MarkaEkleForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.MarkaEkleForm_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.MarkaEkleForm_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.dgVMarkalar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projeDataSeti)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.markaTBLBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion
        private System.Windows.Forms.TextBox txBxMarka;
        private System.Windows.Forms.Button btnMarkaEkle;
        private System.Windows.Forms.LinkLabel linkLblClose;
        private System.Windows.Forms.DataGridView dgVMarkalar;
        private System.Windows.Forms.DataGridViewTextBoxColumn markaIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn markaDataGridViewTextBoxColumn;
        private ProjeDataSeti projeDataSeti;
        private System.Windows.Forms.BindingSource markaTBLBindingSource1;
        private Datasets.ProjeDataSetiTableAdapters.MarkaTBLTableAdapter markaTBLTableAdapter1;
    }
}