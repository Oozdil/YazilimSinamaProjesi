namespace OdevTeslim.Raporlamalar
{
    partial class RaporForm
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
            this.repVwKisiZimmet = new Microsoft.Reporting.WinForms.ReportViewer();
            this.repVwDepartmanZimmet = new Microsoft.Reporting.WinForms.ReportViewer();
            this.repVwZimmetTutanagi = new Microsoft.Reporting.WinForms.ReportViewer();
            this.repVwStokRaporu = new Microsoft.Reporting.WinForms.ReportViewer();
            this.repVwStokHareket = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dgVUser = new System.Windows.Forms.DataGridView();
            this.perIsimDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perSoyisimDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roleNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.depIsimDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.projeDataSeti = new OdevTeslim.Datasets.ProjeDataSeti();
            this.userViewTableAdapter = new OdevTeslim.Datasets.ProjeDataSetiTableAdapters.UserViewTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgVUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userViewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projeDataSeti)).BeginInit();
            this.SuspendLayout();
            // 
            // repVwKisiZimmet
            // 
            this.repVwKisiZimmet.DocumentMapWidth = 65;
            this.repVwKisiZimmet.Location = new System.Drawing.Point(20, 60);
            this.repVwKisiZimmet.Name = "repVwKisiZimmet";
            this.repVwKisiZimmet.ServerReport.BearerToken = null;
            this.repVwKisiZimmet.Size = new System.Drawing.Size(67, 459);
            this.repVwKisiZimmet.TabIndex = 0;
            this.repVwKisiZimmet.Load += new System.EventHandler(this.repVwKisiZimmet_Load);
            // 
            // repVwDepartmanZimmet
            // 
            this.repVwDepartmanZimmet.DocumentMapWidth = 64;
            this.repVwDepartmanZimmet.Location = new System.Drawing.Point(111, 60);
            this.repVwDepartmanZimmet.Name = "repVwDepartmanZimmet";
            this.repVwDepartmanZimmet.ServerReport.BearerToken = null;
            this.repVwDepartmanZimmet.Size = new System.Drawing.Size(66, 459);
            this.repVwDepartmanZimmet.TabIndex = 1;
            // 
            // repVwZimmetTutanagi
            // 
            this.repVwZimmetTutanagi.DocumentMapWidth = 77;
            this.repVwZimmetTutanagi.Location = new System.Drawing.Point(204, 60);
            this.repVwZimmetTutanagi.Name = "repVwZimmetTutanagi";
            this.repVwZimmetTutanagi.ServerReport.BearerToken = null;
            this.repVwZimmetTutanagi.Size = new System.Drawing.Size(79, 459);
            this.repVwZimmetTutanagi.TabIndex = 2;
            // 
            // repVwStokRaporu
            // 
            this.repVwStokRaporu.DocumentMapWidth = 77;
            this.repVwStokRaporu.Location = new System.Drawing.Point(302, 60);
            this.repVwStokRaporu.Name = "repVwStokRaporu";
            this.repVwStokRaporu.ServerReport.BearerToken = null;
            this.repVwStokRaporu.Size = new System.Drawing.Size(79, 456);
            this.repVwStokRaporu.TabIndex = 3;
            // 
            // repVwStokHareket
            // 
            this.repVwStokHareket.DocumentMapWidth = 80;
            this.repVwStokHareket.Location = new System.Drawing.Point(397, 60);
            this.repVwStokHareket.Name = "repVwStokHareket";
            this.repVwStokHareket.ServerReport.BearerToken = null;
            this.repVwStokHareket.Size = new System.Drawing.Size(82, 456);
            this.repVwStokHareket.TabIndex = 4;
            // 
            // dgVUser
            // 
            this.dgVUser.AllowUserToAddRows = false;
            this.dgVUser.AllowUserToDeleteRows = false;
            this.dgVUser.AutoGenerateColumns = false;
            this.dgVUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgVUser.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.perIsimDataGridViewTextBoxColumn,
            this.perSoyisimDataGridViewTextBoxColumn,
            this.roleNameDataGridViewTextBoxColumn,
            this.depIsimDataGridViewTextBoxColumn});
            this.dgVUser.DataSource = this.userViewBindingSource;
            this.dgVUser.Location = new System.Drawing.Point(515, 60);
            this.dgVUser.Name = "dgVUser";
            this.dgVUser.ReadOnly = true;
            this.dgVUser.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgVUser.Size = new System.Drawing.Size(303, 97);
            this.dgVUser.TabIndex = 5;
            // 
            // perIsimDataGridViewTextBoxColumn
            // 
            this.perIsimDataGridViewTextBoxColumn.DataPropertyName = "PerIsim";
            this.perIsimDataGridViewTextBoxColumn.HeaderText = "PerIsim";
            this.perIsimDataGridViewTextBoxColumn.Name = "perIsimDataGridViewTextBoxColumn";
            // 
            // perSoyisimDataGridViewTextBoxColumn
            // 
            this.perSoyisimDataGridViewTextBoxColumn.DataPropertyName = "PerSoyisim";
            this.perSoyisimDataGridViewTextBoxColumn.HeaderText = "PerSoyisim";
            this.perSoyisimDataGridViewTextBoxColumn.Name = "perSoyisimDataGridViewTextBoxColumn";
            // 
            // roleNameDataGridViewTextBoxColumn
            // 
            this.roleNameDataGridViewTextBoxColumn.DataPropertyName = "RoleName";
            this.roleNameDataGridViewTextBoxColumn.HeaderText = "RoleName";
            this.roleNameDataGridViewTextBoxColumn.Name = "roleNameDataGridViewTextBoxColumn";
            this.roleNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // depIsimDataGridViewTextBoxColumn
            // 
            this.depIsimDataGridViewTextBoxColumn.DataPropertyName = "DepIsim";
            this.depIsimDataGridViewTextBoxColumn.HeaderText = "DepIsim";
            this.depIsimDataGridViewTextBoxColumn.Name = "depIsimDataGridViewTextBoxColumn";
            // 
            // userViewBindingSource
            // 
            this.userViewBindingSource.DataMember = "UserView";
            this.userViewBindingSource.DataSource = this.projeDataSeti;
            // 
            // projeDataSeti
            // 
            this.projeDataSeti.DataSetName = "ProjeDataSeti";
            this.projeDataSeti.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // userViewTableAdapter
            // 
            this.userViewTableAdapter.ClearBeforeFill = true;
            // 
            // RaporForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 539);
            this.Controls.Add(this.dgVUser);
            this.Controls.Add(this.repVwStokHareket);
            this.Controls.Add(this.repVwStokRaporu);
            this.Controls.Add(this.repVwZimmetTutanagi);
            this.Controls.Add(this.repVwDepartmanZimmet);
            this.Controls.Add(this.repVwKisiZimmet);
            this.Name = "RaporForm";
            this.Text = "RaporForm";
            this.Load += new System.EventHandler(this.RaporForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgVUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userViewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projeDataSeti)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public Microsoft.Reporting.WinForms.ReportViewer repVwKisiZimmet;
        public Microsoft.Reporting.WinForms.ReportViewer repVwDepartmanZimmet;
        public Microsoft.Reporting.WinForms.ReportViewer repVwZimmetTutanagi;
        public Microsoft.Reporting.WinForms.ReportViewer repVwStokRaporu;
        public Microsoft.Reporting.WinForms.ReportViewer repVwStokHareket;
        private System.Windows.Forms.DataGridView dgVUser;
        private Datasets.ProjeDataSeti projeDataSeti;
        private System.Windows.Forms.BindingSource userViewBindingSource;
        private Datasets.ProjeDataSetiTableAdapters.UserViewTableAdapter userViewTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn perIsimDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn perSoyisimDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roleNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn depIsimDataGridViewTextBoxColumn;
    }
}