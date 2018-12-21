namespace OdevTeslim.Formlar
{
    partial class KisiSecForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvKisiler = new System.Windows.Forms.DataGridView();
            this.perIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perIsimDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perSoyisimDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perTelefonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perAdresDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perDepIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passWordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expr1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aktifDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roleNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.depIsimDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblSecilenPersonel = new System.Windows.Forms.Label();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblForKisiSecimiForm = new System.Windows.Forms.Label();
            this.projeDataSeti = new OdevTeslim.Datasets.ProjeDataSeti();
            this.personelView1BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.personelView_1TableAdapter1 = new OdevTeslim.Datasets.ProjeDataSetiTableAdapters.PersonelView_1TableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKisiler)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projeDataSeti)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelView1BindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvKisiler
            // 
            this.dgvKisiler.AllowUserToAddRows = false;
            this.dgvKisiler.AllowUserToDeleteRows = false;
            this.dgvKisiler.AutoGenerateColumns = false;
            this.dgvKisiler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKisiler.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.perIDDataGridViewTextBoxColumn,
            this.perIsimDataGridViewTextBoxColumn,
            this.perSoyisimDataGridViewTextBoxColumn,
            this.perTelefonDataGridViewTextBoxColumn,
            this.perAdresDataGridViewTextBoxColumn,
            this.perDepIDDataGridViewTextBoxColumn,
            this.userIDDataGridViewTextBoxColumn,
            this.userNameDataGridViewTextBoxColumn,
            this.passWordDataGridViewTextBoxColumn,
            this.expr1DataGridViewTextBoxColumn,
            this.aktifDataGridViewTextBoxColumn,
            this.roleNameDataGridViewTextBoxColumn,
            this.depIsimDataGridViewTextBoxColumn});
            this.dgvKisiler.DataSource = this.personelView1BindingSource1;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.DarkRed;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvKisiler.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvKisiler.Location = new System.Drawing.Point(13, 39);
            this.dgvKisiler.Name = "dgvKisiler";
            this.dgvKisiler.ReadOnly = true;
            this.dgvKisiler.RowHeadersVisible = false;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Thistle;
            this.dgvKisiler.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvKisiler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvKisiler.Size = new System.Drawing.Size(522, 348);
            this.dgvKisiler.TabIndex = 0;
            this.dgvKisiler.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // perIDDataGridViewTextBoxColumn
            // 
            this.perIDDataGridViewTextBoxColumn.DataPropertyName = "PerID";
            this.perIDDataGridViewTextBoxColumn.HeaderText = "Per ID";
            this.perIDDataGridViewTextBoxColumn.Name = "perIDDataGridViewTextBoxColumn";
            this.perIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.perIDDataGridViewTextBoxColumn.Width = 50;
            // 
            // perIsimDataGridViewTextBoxColumn
            // 
            this.perIsimDataGridViewTextBoxColumn.DataPropertyName = "PerIsim";
            this.perIsimDataGridViewTextBoxColumn.HeaderText = "PerIsim";
            this.perIsimDataGridViewTextBoxColumn.Name = "perIsimDataGridViewTextBoxColumn";
            this.perIsimDataGridViewTextBoxColumn.ReadOnly = true;
            this.perIsimDataGridViewTextBoxColumn.Width = 150;
            // 
            // perSoyisimDataGridViewTextBoxColumn
            // 
            this.perSoyisimDataGridViewTextBoxColumn.DataPropertyName = "PerSoyisim";
            this.perSoyisimDataGridViewTextBoxColumn.HeaderText = "PerSoyisim";
            this.perSoyisimDataGridViewTextBoxColumn.Name = "perSoyisimDataGridViewTextBoxColumn";
            this.perSoyisimDataGridViewTextBoxColumn.ReadOnly = true;
            this.perSoyisimDataGridViewTextBoxColumn.Width = 150;
            // 
            // perTelefonDataGridViewTextBoxColumn
            // 
            this.perTelefonDataGridViewTextBoxColumn.DataPropertyName = "PerTelefon";
            this.perTelefonDataGridViewTextBoxColumn.HeaderText = "PerTelefon";
            this.perTelefonDataGridViewTextBoxColumn.Name = "perTelefonDataGridViewTextBoxColumn";
            this.perTelefonDataGridViewTextBoxColumn.ReadOnly = true;
            this.perTelefonDataGridViewTextBoxColumn.Visible = false;
            // 
            // perAdresDataGridViewTextBoxColumn
            // 
            this.perAdresDataGridViewTextBoxColumn.DataPropertyName = "PerAdres";
            this.perAdresDataGridViewTextBoxColumn.HeaderText = "PerAdres";
            this.perAdresDataGridViewTextBoxColumn.Name = "perAdresDataGridViewTextBoxColumn";
            this.perAdresDataGridViewTextBoxColumn.ReadOnly = true;
            this.perAdresDataGridViewTextBoxColumn.Visible = false;
            // 
            // perDepIDDataGridViewTextBoxColumn
            // 
            this.perDepIDDataGridViewTextBoxColumn.DataPropertyName = "PerDepID";
            this.perDepIDDataGridViewTextBoxColumn.HeaderText = "PerDepID";
            this.perDepIDDataGridViewTextBoxColumn.Name = "perDepIDDataGridViewTextBoxColumn";
            this.perDepIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.perDepIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // userIDDataGridViewTextBoxColumn
            // 
            this.userIDDataGridViewTextBoxColumn.DataPropertyName = "UserID";
            this.userIDDataGridViewTextBoxColumn.HeaderText = "UserID";
            this.userIDDataGridViewTextBoxColumn.Name = "userIDDataGridViewTextBoxColumn";
            this.userIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.userIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // userNameDataGridViewTextBoxColumn
            // 
            this.userNameDataGridViewTextBoxColumn.DataPropertyName = "UserName";
            this.userNameDataGridViewTextBoxColumn.HeaderText = "UserName";
            this.userNameDataGridViewTextBoxColumn.Name = "userNameDataGridViewTextBoxColumn";
            this.userNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.userNameDataGridViewTextBoxColumn.Visible = false;
            // 
            // passWordDataGridViewTextBoxColumn
            // 
            this.passWordDataGridViewTextBoxColumn.DataPropertyName = "PassWord";
            this.passWordDataGridViewTextBoxColumn.HeaderText = "PassWord";
            this.passWordDataGridViewTextBoxColumn.Name = "passWordDataGridViewTextBoxColumn";
            this.passWordDataGridViewTextBoxColumn.ReadOnly = true;
            this.passWordDataGridViewTextBoxColumn.Visible = false;
            // 
            // expr1DataGridViewTextBoxColumn
            // 
            this.expr1DataGridViewTextBoxColumn.DataPropertyName = "Expr1";
            this.expr1DataGridViewTextBoxColumn.HeaderText = "Expr1";
            this.expr1DataGridViewTextBoxColumn.Name = "expr1DataGridViewTextBoxColumn";
            this.expr1DataGridViewTextBoxColumn.ReadOnly = true;
            this.expr1DataGridViewTextBoxColumn.Visible = false;
            // 
            // aktifDataGridViewTextBoxColumn
            // 
            this.aktifDataGridViewTextBoxColumn.DataPropertyName = "Aktif";
            this.aktifDataGridViewTextBoxColumn.HeaderText = "Aktif";
            this.aktifDataGridViewTextBoxColumn.Name = "aktifDataGridViewTextBoxColumn";
            this.aktifDataGridViewTextBoxColumn.ReadOnly = true;
            this.aktifDataGridViewTextBoxColumn.Visible = false;
            // 
            // roleNameDataGridViewTextBoxColumn
            // 
            this.roleNameDataGridViewTextBoxColumn.DataPropertyName = "RoleName";
            this.roleNameDataGridViewTextBoxColumn.HeaderText = "RoleName";
            this.roleNameDataGridViewTextBoxColumn.Name = "roleNameDataGridViewTextBoxColumn";
            this.roleNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.roleNameDataGridViewTextBoxColumn.Visible = false;
            // 
            // depIsimDataGridViewTextBoxColumn
            // 
            this.depIsimDataGridViewTextBoxColumn.DataPropertyName = "DepIsim";
            this.depIsimDataGridViewTextBoxColumn.HeaderText = "DepIsim";
            this.depIsimDataGridViewTextBoxColumn.Name = "depIsimDataGridViewTextBoxColumn";
            this.depIsimDataGridViewTextBoxColumn.ReadOnly = true;
            this.depIsimDataGridViewTextBoxColumn.Width = 150;
            // 
            // lblSecilenPersonel
            // 
            this.lblSecilenPersonel.AutoSize = true;
            this.lblSecilenPersonel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSecilenPersonel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblSecilenPersonel.Location = new System.Drawing.Point(12, 399);
            this.lblSecilenPersonel.Name = "lblSecilenPersonel";
            this.lblSecilenPersonel.Size = new System.Drawing.Size(163, 18);
            this.lblSecilenPersonel.TabIndex = 1;
            this.lblSecilenPersonel.Text = "Personel seçiniz . . .";
            // 
            // btnOk
            // 
            this.btnOk.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleGreen;
            this.btnOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOk.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOk.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnOk.Location = new System.Drawing.Point(12, 425);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(117, 36);
            this.btnOk.TabIndex = 2;
            this.btnOk.Text = "Tamam";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Salmon;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCancel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCancel.Location = new System.Drawing.Point(424, 425);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(110, 36);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Vazgeç";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblForKisiSecimiForm
            // 
            this.lblForKisiSecimiForm.AutoSize = true;
            this.lblForKisiSecimiForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblForKisiSecimiForm.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblForKisiSecimiForm.Location = new System.Drawing.Point(209, 9);
            this.lblForKisiSecimiForm.Name = "lblForKisiSecimiForm";
            this.lblForKisiSecimiForm.Size = new System.Drawing.Size(131, 18);
            this.lblForKisiSecimiForm.TabIndex = 4;
            this.lblForKisiSecimiForm.Text = "Personel Seçimi";
            // 
            // projeDataSeti
            // 
            this.projeDataSeti.DataSetName = "ProjeDataSeti";
            this.projeDataSeti.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // personelView1BindingSource1
            // 
            this.personelView1BindingSource1.DataMember = "PersonelView_1";
            this.personelView1BindingSource1.DataSource = this.projeDataSeti;
            // 
            // personelView_1TableAdapter1
            // 
            this.personelView_1TableAdapter1.ClearBeforeFill = true;
            // 
            // KisiSecForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(546, 473);
            this.Controls.Add(this.lblForKisiSecimiForm);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.lblSecilenPersonel);
            this.Controls.Add(this.dgvKisiler);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "KisiSecForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KisiSecForm";
            this.Load += new System.EventHandler(this.KisiSecForm_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.KisiSecForm_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKisiler)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projeDataSeti)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelView1BindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvKisiler;
        private System.Windows.Forms.Label lblSecilenPersonel;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.DataGridViewTextBoxColumn perIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn perIsimDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn perSoyisimDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn perTelefonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn perAdresDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn perDepIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passWordDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn expr1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aktifDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roleNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn depIsimDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label lblForKisiSecimiForm;
        private Datasets.ProjeDataSeti projeDataSeti;
        private System.Windows.Forms.BindingSource personelView1BindingSource1;
        private Datasets.ProjeDataSetiTableAdapters.PersonelView_1TableAdapter personelView_1TableAdapter1;
    }
}