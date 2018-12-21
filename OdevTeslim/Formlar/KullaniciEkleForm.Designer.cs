using OdevTeslim.Datasets;

namespace OdevTeslim.Formlar
{
    partial class KullaniciEkleForm
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
            this.lblForKullaniciEkleForm = new System.Windows.Forms.Label();
            this.dgVPersonel = new System.Windows.Forms.DataGridView();
            this.perIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perIsimDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perSoyisimDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passWordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aktifDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roleNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.depIsimDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userViewBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.projeDataSeti = new OdevTeslim.Datasets.ProjeDataSeti();
            this.lblForSeciliPersonelInfo = new System.Windows.Forms.Label();
            this.lblForSeciliPersonel = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.lblPass = new System.Windows.Forms.Label();
            this.lblPassRepeat = new System.Windows.Forms.Label();
            this.btnPersonelEkle = new System.Windows.Forms.Button();
            this.txBxPass = new System.Windows.Forms.TextBox();
            this.txBxPassRepeat = new System.Windows.Forms.TextBox();
            this.txBxUserName = new System.Windows.Forms.TextBox();
            this.chBxAktif = new System.Windows.Forms.CheckBox();
            this.lblRol = new System.Windows.Forms.Label();
            this.comBxRole = new System.Windows.Forms.ComboBox();
            this.roleTBLBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.lblRole = new System.Windows.Forms.Label();
            this.roleTBLTableAdapter1 = new OdevTeslim.Datasets.ProjeDataSetiTableAdapters.RoleTBLTableAdapter();
            this.userViewTableAdapter1 = new OdevTeslim.Datasets.ProjeDataSetiTableAdapters.UserViewTableAdapter();
            this.tabControlUsers = new System.Windows.Forms.TabControl();
            this.tabPageUserIslemleri = new System.Windows.Forms.TabPage();
            this.tabPageIslemHareketleri = new System.Windows.Forms.TabPage();
            this.dgVUSerHareketleri = new System.Windows.Forms.DataGridView();
            this.perIsimDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perSoyisimDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tarihDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ıslemLogDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userHareketleriViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.userHareketleriDataSet = new OdevTeslim.Datasets.UserHareketleriDataSet();
            this.userHareketleriViewTableAdapter = new OdevTeslim.Datasets.UserHareketleriDataSetTableAdapters.UserHareketleriViewTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgVPersonel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userViewBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projeDataSeti)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roleTBLBindingSource1)).BeginInit();
            this.tabControlUsers.SuspendLayout();
            this.tabPageUserIslemleri.SuspendLayout();
            this.tabPageIslemHareketleri.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgVUSerHareketleri)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userHareketleriViewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userHareketleriDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // lblForKullaniciEkleForm
            // 
            this.lblForKullaniciEkleForm.AutoSize = true;
            this.lblForKullaniciEkleForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblForKullaniciEkleForm.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblForKullaniciEkleForm.Location = new System.Drawing.Point(25, 25);
            this.lblForKullaniciEkleForm.Name = "lblForKullaniciEkleForm";
            this.lblForKullaniciEkleForm.Size = new System.Drawing.Size(275, 20);
            this.lblForKullaniciEkleForm.TabIndex = 0;
            this.lblForKullaniciEkleForm.Text = "Kullanıcı Ekleme veya Düzenleme";
            // 
            // dgVPersonel
            // 
            this.dgVPersonel.AllowUserToAddRows = false;
            this.dgVPersonel.AllowUserToDeleteRows = false;
            this.dgVPersonel.AutoGenerateColumns = false;
            this.dgVPersonel.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgVPersonel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgVPersonel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgVPersonel.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.perIDDataGridViewTextBoxColumn,
            this.userIDDataGridViewTextBoxColumn,
            this.perIsimDataGridViewTextBoxColumn,
            this.perSoyisimDataGridViewTextBoxColumn,
            this.userNameDataGridViewTextBoxColumn,
            this.passWordDataGridViewTextBoxColumn,
            this.aktifDataGridViewTextBoxColumn,
            this.roleNameDataGridViewTextBoxColumn,
            this.depIsimDataGridViewTextBoxColumn});
            this.dgVPersonel.DataSource = this.userViewBindingSource1;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.DarkRed;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgVPersonel.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgVPersonel.Location = new System.Drawing.Point(25, 75);
            this.dgVPersonel.MultiSelect = false;
            this.dgVPersonel.Name = "dgVPersonel";
            this.dgVPersonel.ReadOnly = true;
            this.dgVPersonel.RowHeadersVisible = false;
            this.dgVPersonel.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgVPersonel.Size = new System.Drawing.Size(656, 369);
            this.dgVPersonel.TabIndex = 100;
            this.dgVPersonel.SelectionChanged += new System.EventHandler(this.dgVPersonel_SelectionChanged);
            // 
            // perIDDataGridViewTextBoxColumn
            // 
            this.perIDDataGridViewTextBoxColumn.DataPropertyName = "PerID";
            this.perIDDataGridViewTextBoxColumn.HeaderText = "Per ID";
            this.perIDDataGridViewTextBoxColumn.Name = "perIDDataGridViewTextBoxColumn";
            this.perIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.perIDDataGridViewTextBoxColumn.Width = 50;
            // 
            // userIDDataGridViewTextBoxColumn
            // 
            this.userIDDataGridViewTextBoxColumn.DataPropertyName = "UserID";
            this.userIDDataGridViewTextBoxColumn.HeaderText = "User ID";
            this.userIDDataGridViewTextBoxColumn.Name = "userIDDataGridViewTextBoxColumn";
            this.userIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.userIDDataGridViewTextBoxColumn.Width = 40;
            // 
            // perIsimDataGridViewTextBoxColumn
            // 
            this.perIsimDataGridViewTextBoxColumn.DataPropertyName = "PerIsim";
            this.perIsimDataGridViewTextBoxColumn.HeaderText = "Isim";
            this.perIsimDataGridViewTextBoxColumn.Name = "perIsimDataGridViewTextBoxColumn";
            this.perIsimDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // perSoyisimDataGridViewTextBoxColumn
            // 
            this.perSoyisimDataGridViewTextBoxColumn.DataPropertyName = "PerSoyisim";
            this.perSoyisimDataGridViewTextBoxColumn.HeaderText = "Soyisim";
            this.perSoyisimDataGridViewTextBoxColumn.Name = "perSoyisimDataGridViewTextBoxColumn";
            this.perSoyisimDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // userNameDataGridViewTextBoxColumn
            // 
            this.userNameDataGridViewTextBoxColumn.DataPropertyName = "UserName";
            this.userNameDataGridViewTextBoxColumn.HeaderText = "User Name";
            this.userNameDataGridViewTextBoxColumn.Name = "userNameDataGridViewTextBoxColumn";
            this.userNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.userNameDataGridViewTextBoxColumn.Width = 75;
            // 
            // passWordDataGridViewTextBoxColumn
            // 
            this.passWordDataGridViewTextBoxColumn.DataPropertyName = "PassWord";
            this.passWordDataGridViewTextBoxColumn.HeaderText = "Pass Word";
            this.passWordDataGridViewTextBoxColumn.Name = "passWordDataGridViewTextBoxColumn";
            this.passWordDataGridViewTextBoxColumn.ReadOnly = true;
            this.passWordDataGridViewTextBoxColumn.Width = 75;
            // 
            // aktifDataGridViewTextBoxColumn
            // 
            this.aktifDataGridViewTextBoxColumn.DataPropertyName = "Aktif";
            this.aktifDataGridViewTextBoxColumn.HeaderText = "Aktif";
            this.aktifDataGridViewTextBoxColumn.Name = "aktifDataGridViewTextBoxColumn";
            this.aktifDataGridViewTextBoxColumn.ReadOnly = true;
            this.aktifDataGridViewTextBoxColumn.Width = 40;
            // 
            // roleNameDataGridViewTextBoxColumn
            // 
            this.roleNameDataGridViewTextBoxColumn.DataPropertyName = "RoleName";
            this.roleNameDataGridViewTextBoxColumn.HeaderText = "Rolü";
            this.roleNameDataGridViewTextBoxColumn.Name = "roleNameDataGridViewTextBoxColumn";
            this.roleNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.roleNameDataGridViewTextBoxColumn.Width = 70;
            // 
            // depIsimDataGridViewTextBoxColumn
            // 
            this.depIsimDataGridViewTextBoxColumn.DataPropertyName = "DepIsim";
            this.depIsimDataGridViewTextBoxColumn.HeaderText = "Departman";
            this.depIsimDataGridViewTextBoxColumn.Name = "depIsimDataGridViewTextBoxColumn";
            this.depIsimDataGridViewTextBoxColumn.ReadOnly = true;
            this.depIsimDataGridViewTextBoxColumn.Width = 75;
            // 
            // userViewBindingSource1
            // 
            this.userViewBindingSource1.DataMember = "UserView";
            this.userViewBindingSource1.DataSource = this.projeDataSeti;
            // 
            // projeDataSeti
            // 
            this.projeDataSeti.DataSetName = "ProjeDataSeti";
            this.projeDataSeti.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lblForSeciliPersonelInfo
            // 
            this.lblForSeciliPersonelInfo.AutoSize = true;
            this.lblForSeciliPersonelInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblForSeciliPersonelInfo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblForSeciliPersonelInfo.Location = new System.Drawing.Point(663, 9);
            this.lblForSeciliPersonelInfo.Name = "lblForSeciliPersonelInfo";
            this.lblForSeciliPersonelInfo.Size = new System.Drawing.Size(121, 18);
            this.lblForSeciliPersonelInfo.TabIndex = 2;
            this.lblForSeciliPersonelInfo.Text = "Seçili Personel";
            // 
            // lblForSeciliPersonel
            // 
            this.lblForSeciliPersonel.AutoSize = true;
            this.lblForSeciliPersonel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblForSeciliPersonel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblForSeciliPersonel.Location = new System.Drawing.Point(13, 12);
            this.lblForSeciliPersonel.Name = "lblForSeciliPersonel";
            this.lblForSeciliPersonel.Size = new System.Drawing.Size(81, 17);
            this.lblForSeciliPersonel.TabIndex = 3;
            this.lblForSeciliPersonel.Text = "Yeni Kayıt";
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUserName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblUserName.Location = new System.Drawing.Point(13, 79);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(108, 18);
            this.lblUserName.TabIndex = 4;
            this.lblUserName.Text = "Kullanıcı adı :";
            // 
            // lblPass
            // 
            this.lblPass.AutoSize = true;
            this.lblPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPass.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblPass.Location = new System.Drawing.Point(13, 127);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(53, 18);
            this.lblPass.TabIndex = 5;
            this.lblPass.Text = "Şifre :";
            // 
            // lblPassRepeat
            // 
            this.lblPassRepeat.AutoSize = true;
            this.lblPassRepeat.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPassRepeat.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblPassRepeat.Location = new System.Drawing.Point(13, 181);
            this.lblPassRepeat.Name = "lblPassRepeat";
            this.lblPassRepeat.Size = new System.Drawing.Size(107, 18);
            this.lblPassRepeat.TabIndex = 6;
            this.lblPassRepeat.Text = "Şifre Tekrar :";
            // 
            // btnPersonelEkle
            // 
            this.btnPersonelEkle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MidnightBlue;
            this.btnPersonelEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPersonelEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnPersonelEkle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPersonelEkle.Location = new System.Drawing.Point(16, 326);
            this.btnPersonelEkle.Name = "btnPersonelEkle";
            this.btnPersonelEkle.Size = new System.Drawing.Size(244, 39);
            this.btnPersonelEkle.TabIndex = 5;
            this.btnPersonelEkle.Text = "KULLANICI EKLE - KAYDET";
            this.btnPersonelEkle.UseVisualStyleBackColor = true;
            this.btnPersonelEkle.Click += new System.EventHandler(this.btnPersonelEkle_Click);
            // 
            // txBxPass
            // 
            this.txBxPass.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.txBxPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txBxPass.Location = new System.Drawing.Point(13, 150);
            this.txBxPass.Name = "txBxPass";
            this.txBxPass.Size = new System.Drawing.Size(244, 24);
            this.txBxPass.TabIndex = 1;
            // 
            // txBxPassRepeat
            // 
            this.txBxPassRepeat.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.txBxPassRepeat.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txBxPassRepeat.Location = new System.Drawing.Point(13, 205);
            this.txBxPassRepeat.Name = "txBxPassRepeat";
            this.txBxPassRepeat.Size = new System.Drawing.Size(244, 24);
            this.txBxPassRepeat.TabIndex = 2;
            // 
            // txBxUserName
            // 
            this.txBxUserName.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.txBxUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txBxUserName.Location = new System.Drawing.Point(13, 100);
            this.txBxUserName.Name = "txBxUserName";
            this.txBxUserName.Size = new System.Drawing.Size(244, 24);
            this.txBxUserName.TabIndex = 0;
            // 
            // chBxAktif
            // 
            this.chBxAktif.AutoSize = true;
            this.chBxAktif.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.chBxAktif.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.chBxAktif.Location = new System.Drawing.Point(13, 297);
            this.chBxAktif.Name = "chBxAktif";
            this.chBxAktif.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chBxAktif.Size = new System.Drawing.Size(70, 22);
            this.chBxAktif.TabIndex = 4;
            this.chBxAktif.Text = ": Aktif";
            this.chBxAktif.UseVisualStyleBackColor = true;
            // 
            // lblRol
            // 
            this.lblRol.AutoSize = true;
            this.lblRol.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblRol.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblRol.Location = new System.Drawing.Point(14, 237);
            this.lblRol.Name = "lblRol";
            this.lblRol.Size = new System.Drawing.Size(53, 18);
            this.lblRol.TabIndex = 13;
            this.lblRol.Text = "Rolü :";
            // 
            // comBxRole
            // 
            this.comBxRole.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.comBxRole.DataSource = this.roleTBLBindingSource1;
            this.comBxRole.DisplayMember = "RoleName";
            this.comBxRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comBxRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comBxRole.FormattingEnabled = true;
            this.comBxRole.Location = new System.Drawing.Point(13, 262);
            this.comBxRole.Name = "comBxRole";
            this.comBxRole.Size = new System.Drawing.Size(244, 26);
            this.comBxRole.TabIndex = 3;
            this.comBxRole.ValueMember = "RoleID";
            this.comBxRole.Visible = false;
            // 
            // roleTBLBindingSource1
            // 
            this.roleTBLBindingSource1.DataMember = "RoleTBL";
            this.roleTBLBindingSource1.DataSource = this.projeDataSeti;
            // 
            // lblRole
            // 
            this.lblRole.AutoSize = true;
            this.lblRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblRole.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblRole.Location = new System.Drawing.Point(13, 42);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(81, 17);
            this.lblRole.TabIndex = 15;
            this.lblRole.Text = "Yeni Kayıt";
            // 
            // roleTBLTableAdapter1
            // 
            this.roleTBLTableAdapter1.ClearBeforeFill = true;
            // 
            // userViewTableAdapter1
            // 
            this.userViewTableAdapter1.ClearBeforeFill = true;
            // 
            // tabControlUsers
            // 
            this.tabControlUsers.Controls.Add(this.tabPageUserIslemleri);
            this.tabControlUsers.Controls.Add(this.tabPageIslemHareketleri);
            this.tabControlUsers.Location = new System.Drawing.Point(687, 47);
            this.tabControlUsers.Name = "tabControlUsers";
            this.tabControlUsers.SelectedIndex = 0;
            this.tabControlUsers.Size = new System.Drawing.Size(286, 397);
            this.tabControlUsers.TabIndex = 101;
            // 
            // tabPageUserIslemleri
            // 
            this.tabPageUserIslemleri.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tabPageUserIslemleri.Controls.Add(this.lblForSeciliPersonel);
            this.tabPageUserIslemleri.Controls.Add(this.lblRole);
            this.tabPageUserIslemleri.Controls.Add(this.lblUserName);
            this.tabPageUserIslemleri.Controls.Add(this.comBxRole);
            this.tabPageUserIslemleri.Controls.Add(this.lblPass);
            this.tabPageUserIslemleri.Controls.Add(this.lblRol);
            this.tabPageUserIslemleri.Controls.Add(this.lblPassRepeat);
            this.tabPageUserIslemleri.Controls.Add(this.chBxAktif);
            this.tabPageUserIslemleri.Controls.Add(this.btnPersonelEkle);
            this.tabPageUserIslemleri.Controls.Add(this.txBxUserName);
            this.tabPageUserIslemleri.Controls.Add(this.txBxPass);
            this.tabPageUserIslemleri.Controls.Add(this.txBxPassRepeat);
            this.tabPageUserIslemleri.Location = new System.Drawing.Point(4, 22);
            this.tabPageUserIslemleri.Name = "tabPageUserIslemleri";
            this.tabPageUserIslemleri.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageUserIslemleri.Size = new System.Drawing.Size(278, 371);
            this.tabPageUserIslemleri.TabIndex = 0;
            this.tabPageUserIslemleri.Text = "Kullanıcı İşlemleri";
            // 
            // tabPageIslemHareketleri
            // 
            this.tabPageIslemHareketleri.Controls.Add(this.dgVUSerHareketleri);
            this.tabPageIslemHareketleri.Location = new System.Drawing.Point(4, 22);
            this.tabPageIslemHareketleri.Name = "tabPageIslemHareketleri";
            this.tabPageIslemHareketleri.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageIslemHareketleri.Size = new System.Drawing.Size(278, 371);
            this.tabPageIslemHareketleri.TabIndex = 1;
            this.tabPageIslemHareketleri.Text = "Hareket Detayları";
            this.tabPageIslemHareketleri.UseVisualStyleBackColor = true;
            // 
            // dgVUSerHareketleri
            // 
            this.dgVUSerHareketleri.AllowUserToAddRows = false;
            this.dgVUSerHareketleri.AllowUserToDeleteRows = false;
            this.dgVUSerHareketleri.AutoGenerateColumns = false;
            this.dgVUSerHareketleri.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgVUSerHareketleri.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.perIsimDataGridViewTextBoxColumn1,
            this.perSoyisimDataGridViewTextBoxColumn1,
            this.tarihDataGridViewTextBoxColumn,
            this.ıslemLogDataGridViewTextBoxColumn});
            this.dgVUSerHareketleri.DataSource = this.userHareketleriViewBindingSource;
            this.dgVUSerHareketleri.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgVUSerHareketleri.Location = new System.Drawing.Point(3, 3);
            this.dgVUSerHareketleri.Name = "dgVUSerHareketleri";
            this.dgVUSerHareketleri.ReadOnly = true;
            this.dgVUSerHareketleri.RowHeadersVisible = false;
            this.dgVUSerHareketleri.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgVUSerHareketleri.Size = new System.Drawing.Size(272, 365);
            this.dgVUSerHareketleri.TabIndex = 0;
            // 
            // perIsimDataGridViewTextBoxColumn1
            // 
            this.perIsimDataGridViewTextBoxColumn1.DataPropertyName = "PerIsim";
            this.perIsimDataGridViewTextBoxColumn1.HeaderText = "Isim";
            this.perIsimDataGridViewTextBoxColumn1.Name = "perIsimDataGridViewTextBoxColumn1";
            this.perIsimDataGridViewTextBoxColumn1.ReadOnly = true;
            this.perIsimDataGridViewTextBoxColumn1.Width = 75;
            // 
            // perSoyisimDataGridViewTextBoxColumn1
            // 
            this.perSoyisimDataGridViewTextBoxColumn1.DataPropertyName = "PerSoyisim";
            this.perSoyisimDataGridViewTextBoxColumn1.HeaderText = "Soyisim";
            this.perSoyisimDataGridViewTextBoxColumn1.Name = "perSoyisimDataGridViewTextBoxColumn1";
            this.perSoyisimDataGridViewTextBoxColumn1.ReadOnly = true;
            this.perSoyisimDataGridViewTextBoxColumn1.Width = 75;
            // 
            // tarihDataGridViewTextBoxColumn
            // 
            this.tarihDataGridViewTextBoxColumn.DataPropertyName = "Tarih";
            this.tarihDataGridViewTextBoxColumn.HeaderText = "Tarih";
            this.tarihDataGridViewTextBoxColumn.Name = "tarihDataGridViewTextBoxColumn";
            this.tarihDataGridViewTextBoxColumn.ReadOnly = true;
            this.tarihDataGridViewTextBoxColumn.Width = 50;
            // 
            // ıslemLogDataGridViewTextBoxColumn
            // 
            this.ıslemLogDataGridViewTextBoxColumn.DataPropertyName = "IslemLog";
            this.ıslemLogDataGridViewTextBoxColumn.HeaderText = "Islem";
            this.ıslemLogDataGridViewTextBoxColumn.Name = "ıslemLogDataGridViewTextBoxColumn";
            this.ıslemLogDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // userHareketleriViewBindingSource
            // 
            this.userHareketleriViewBindingSource.DataMember = "UserHareketleriView";
            this.userHareketleriViewBindingSource.DataSource = this.userHareketleriDataSet;
            // 
            // userHareketleriDataSet
            // 
            this.userHareketleriDataSet.DataSetName = "UserHareketleriDataSet";
            this.userHareketleriDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // userHareketleriViewTableAdapter
            // 
            this.userHareketleriViewTableAdapter.ClearBeforeFill = true;
            // 
            // KullaniciEkleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(993, 472);
            this.Controls.Add(this.tabControlUsers);
            this.Controls.Add(this.lblForSeciliPersonelInfo);
            this.Controls.Add(this.dgVPersonel);
            this.Controls.Add(this.lblForKullaniciEkleForm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "KullaniciEkleForm";
            this.Text = "KullaniciEkleForm";
            this.Load += new System.EventHandler(this.KullaniciEkleForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgVPersonel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userViewBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projeDataSeti)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roleTBLBindingSource1)).EndInit();
            this.tabControlUsers.ResumeLayout(false);
            this.tabPageUserIslemleri.ResumeLayout(false);
            this.tabPageUserIslemleri.PerformLayout();
            this.tabPageIslemHareketleri.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgVUSerHareketleri)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userHareketleriViewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userHareketleriDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblForKullaniciEkleForm;
        private System.Windows.Forms.DataGridView dgVPersonel;
        private System.Windows.Forms.Label lblForSeciliPersonelInfo;
        private System.Windows.Forms.Label lblForSeciliPersonel;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.Label lblPassRepeat;
        private System.Windows.Forms.Button btnPersonelEkle;
        private System.Windows.Forms.TextBox txBxPass;
        private System.Windows.Forms.TextBox txBxPassRepeat;
        private System.Windows.Forms.TextBox txBxUserName;
        private System.Windows.Forms.CheckBox chBxAktif;
        private System.Windows.Forms.Label lblRol;
        private System.Windows.Forms.ComboBox comBxRole;
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.DataGridViewTextBoxColumn perIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn perIsimDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn perSoyisimDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passWordDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aktifDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roleNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn depIsimDataGridViewTextBoxColumn;
        private ProjeDataSeti projeDataSeti;
        private System.Windows.Forms.BindingSource roleTBLBindingSource1;
        private Datasets.ProjeDataSetiTableAdapters.RoleTBLTableAdapter roleTBLTableAdapter1;
        private System.Windows.Forms.BindingSource userViewBindingSource1;
        private Datasets.ProjeDataSetiTableAdapters.UserViewTableAdapter userViewTableAdapter1;
        private System.Windows.Forms.TabControl tabControlUsers;
        private System.Windows.Forms.TabPage tabPageUserIslemleri;
        private System.Windows.Forms.TabPage tabPageIslemHareketleri;
        private System.Windows.Forms.DataGridView dgVUSerHareketleri;
        private UserHareketleriDataSet userHareketleriDataSet;
        private System.Windows.Forms.BindingSource userHareketleriViewBindingSource;
        private Datasets.UserHareketleriDataSetTableAdapters.UserHareketleriViewTableAdapter userHareketleriViewTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn perIsimDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn perSoyisimDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn tarihDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ıslemLogDataGridViewTextBoxColumn;
    }
}