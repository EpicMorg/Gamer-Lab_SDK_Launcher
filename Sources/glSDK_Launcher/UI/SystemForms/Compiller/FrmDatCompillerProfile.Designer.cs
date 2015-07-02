using glSDK.Pocos;

namespace glSDK.UI.SystemForms.Compiller
{
    partial class FrmDatCompillerProfile
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.metroLabelRADexecutablePath = new MetroFramework.Controls.MetroLabel();
            this.metroLabelVISexecutablePath = new MetroFramework.Controls.MetroLabel();
            this.metroLabelBSPexecutablePath = new MetroFramework.Controls.MetroLabel();
            this.metroLabelModDirPath = new MetroFramework.Controls.MetroLabel();
            this.metroLabelCSGexecutablePath = new MetroFramework.Controls.MetroLabel();
            this.txtRadArgs = new MetroFramework.Controls.MetroTextBox();
            this.txtRadPath = new MetroFramework.Controls.MetroTextBox();
            this.metroLabelGameExePath = new MetroFramework.Controls.MetroLabel();
            this.txtVisArgs = new MetroFramework.Controls.MetroTextBox();
            this.txtVisPath = new MetroFramework.Controls.MetroTextBox();
            this.metroButtonGameExePath = new MetroFramework.Controls.MetroButton();
            this.metroButtonModDirPath = new MetroFramework.Controls.MetroButton();
            this.metroButtonCSGexecutablePath = new MetroFramework.Controls.MetroButton();
            this.metroButtonBSPexecutablePath = new MetroFramework.Controls.MetroButton();
            this.metroButtonVISexecutablePath = new MetroFramework.Controls.MetroButton();
            this.metroButtonRADexecutablePath = new MetroFramework.Controls.MetroButton();
            this.metroButtonSave = new MetroFramework.Controls.MetroButton();
            this.txtBspArgs = new MetroFramework.Controls.MetroTextBox();
            this.txtBspPath = new MetroFramework.Controls.MetroTextBox();
            this.metroButtonDelete = new MetroFramework.Controls.MetroButton();
            this.txtMod = new MetroFramework.Controls.MetroTextBox();
            this.txtCsgArgs = new MetroFramework.Controls.MetroTextBox();
            this.txtCsgPath = new MetroFramework.Controls.MetroTextBox();
            this.metroButtonAddNewName = new MetroFramework.Controls.MetroButton();
            this.txtGameExe = new MetroFramework.Controls.MetroTextBox();
            this.txtName = new MetroFramework.Controls.MetroTextBox();
            this.dgvProfiles = new MetroFramework.Controls.MetroGrid();
            this.ProfilesName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtGameArgs = new MetroFramework.Controls.MetroTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProfiles)).BeginInit();
            this.SuspendLayout();
            // 
            // metroLabelRADexecutablePath
            // 
            this.metroLabelRADexecutablePath.AutoSize = true;
            this.metroLabelRADexecutablePath.Location = new System.Drawing.Point(23, 419);
            this.metroLabelRADexecutablePath.Name = "metroLabelRADexecutablePath";
            this.metroLabelRADexecutablePath.Size = new System.Drawing.Size(104, 19);
            this.metroLabelRADexecutablePath.TabIndex = 3;
            this.metroLabelRADexecutablePath.Text = "RAD Executable:";
            // 
            // metroLabelVISexecutablePath
            // 
            this.metroLabelVISexecutablePath.AutoSize = true;
            this.metroLabelVISexecutablePath.Location = new System.Drawing.Point(23, 371);
            this.metroLabelVISexecutablePath.Name = "metroLabelVISexecutablePath";
            this.metroLabelVISexecutablePath.Size = new System.Drawing.Size(96, 19);
            this.metroLabelVISexecutablePath.TabIndex = 3;
            this.metroLabelVISexecutablePath.Text = "VIS Executable:";
            // 
            // metroLabelBSPexecutablePath
            // 
            this.metroLabelBSPexecutablePath.AutoSize = true;
            this.metroLabelBSPexecutablePath.Location = new System.Drawing.Point(23, 323);
            this.metroLabelBSPexecutablePath.Name = "metroLabelBSPexecutablePath";
            this.metroLabelBSPexecutablePath.Size = new System.Drawing.Size(101, 19);
            this.metroLabelBSPexecutablePath.TabIndex = 3;
            this.metroLabelBSPexecutablePath.Text = "BSP Executable:";
            // 
            // metroLabelModDirPath
            // 
            this.metroLabelModDirPath.AutoSize = true;
            this.metroLabelModDirPath.Location = new System.Drawing.Point(23, 227);
            this.metroLabelModDirPath.Name = "metroLabelModDirPath";
            this.metroLabelModDirPath.Size = new System.Drawing.Size(208, 19);
            this.metroLabelModDirPath.TabIndex = 3;
            this.metroLabelModDirPath.Text = "Mod directory (C:\\Half-Life\\valve):";
            // 
            // metroLabelCSGexecutablePath
            // 
            this.metroLabelCSGexecutablePath.AutoSize = true;
            this.metroLabelCSGexecutablePath.Location = new System.Drawing.Point(23, 275);
            this.metroLabelCSGexecutablePath.Name = "metroLabelCSGexecutablePath";
            this.metroLabelCSGexecutablePath.Size = new System.Drawing.Size(103, 19);
            this.metroLabelCSGexecutablePath.TabIndex = 3;
            this.metroLabelCSGexecutablePath.Text = "CSG Executable:";
            // 
            // txtRadArgs
            // 
            this.txtRadArgs.Lines = new string[0];
            this.txtRadArgs.Location = new System.Drawing.Point(237, 441);
            this.txtRadArgs.MaxLength = 32767;
            this.txtRadArgs.Name = "txtRadArgs";
            this.txtRadArgs.PasswordChar = '\0';
            this.txtRadArgs.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtRadArgs.SelectedText = "";
            this.txtRadArgs.Size = new System.Drawing.Size(87, 23);
            this.txtRadArgs.TabIndex = 1;
            this.txtRadArgs.UseSelectable = true;
            // 
            // txtRadPath
            // 
            this.txtRadPath.Lines = new string[0];
            this.txtRadPath.Location = new System.Drawing.Point(23, 441);
            this.txtRadPath.MaxLength = 32767;
            this.txtRadPath.Name = "txtRadPath";
            this.txtRadPath.PasswordChar = '\0';
            this.txtRadPath.ReadOnly = true;
            this.txtRadPath.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtRadPath.SelectedText = "";
            this.txtRadPath.Size = new System.Drawing.Size(208, 23);
            this.txtRadPath.TabIndex = 1;
            this.txtRadPath.UseSelectable = true;
            // 
            // metroLabelGameExePath
            // 
            this.metroLabelGameExePath.AutoSize = true;
            this.metroLabelGameExePath.Location = new System.Drawing.Point(23, 179);
            this.metroLabelGameExePath.Name = "metroLabelGameExePath";
            this.metroLabelGameExePath.Size = new System.Drawing.Size(216, 19);
            this.metroLabelGameExePath.TabIndex = 3;
            this.metroLabelGameExePath.Text = "Game exe path (C:\\Half-Life\\hl.exe):";
            // 
            // txtVisArgs
            // 
            this.txtVisArgs.Lines = new string[0];
            this.txtVisArgs.Location = new System.Drawing.Point(237, 393);
            this.txtVisArgs.MaxLength = 32767;
            this.txtVisArgs.Name = "txtVisArgs";
            this.txtVisArgs.PasswordChar = '\0';
            this.txtVisArgs.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtVisArgs.SelectedText = "";
            this.txtVisArgs.Size = new System.Drawing.Size(87, 23);
            this.txtVisArgs.TabIndex = 1;
            this.txtVisArgs.UseSelectable = true;
            // 
            // txtVisPath
            // 
            this.txtVisPath.Lines = new string[0];
            this.txtVisPath.Location = new System.Drawing.Point(23, 393);
            this.txtVisPath.MaxLength = 32767;
            this.txtVisPath.Name = "txtVisPath";
            this.txtVisPath.PasswordChar = '\0';
            this.txtVisPath.ReadOnly = true;
            this.txtVisPath.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtVisPath.SelectedText = "";
            this.txtVisPath.Size = new System.Drawing.Size(208, 23);
            this.txtVisPath.TabIndex = 1;
            this.txtVisPath.UseSelectable = true;
            // 
            // metroButtonGameExePath
            // 
            this.metroButtonGameExePath.Location = new System.Drawing.Point(330, 201);
            this.metroButtonGameExePath.Name = "metroButtonGameExePath";
            this.metroButtonGameExePath.Size = new System.Drawing.Size(77, 23);
            this.metroButtonGameExePath.TabIndex = 2;
            this.metroButtonGameExePath.Text = "Browse";
            this.metroButtonGameExePath.UseSelectable = true;
            this.metroButtonGameExePath.Click += new System.EventHandler(this.metroButtonGameExePath_Click);
            // 
            // metroButtonModDirPath
            // 
            this.metroButtonModDirPath.Location = new System.Drawing.Point(330, 249);
            this.metroButtonModDirPath.Name = "metroButtonModDirPath";
            this.metroButtonModDirPath.Size = new System.Drawing.Size(77, 23);
            this.metroButtonModDirPath.TabIndex = 2;
            this.metroButtonModDirPath.Text = "Browse";
            this.metroButtonModDirPath.UseSelectable = true;
            this.metroButtonModDirPath.Click += new System.EventHandler(this.metroButtonModDirPath_Click);
            // 
            // metroButtonCSGexecutablePath
            // 
            this.metroButtonCSGexecutablePath.Location = new System.Drawing.Point(330, 297);
            this.metroButtonCSGexecutablePath.Name = "metroButtonCSGexecutablePath";
            this.metroButtonCSGexecutablePath.Size = new System.Drawing.Size(77, 23);
            this.metroButtonCSGexecutablePath.TabIndex = 2;
            this.metroButtonCSGexecutablePath.Text = "Browse";
            this.metroButtonCSGexecutablePath.UseSelectable = true;
            this.metroButtonCSGexecutablePath.Click += new System.EventHandler(this.metroButtonCSGexecutablePath_Click);
            // 
            // metroButtonBSPexecutablePath
            // 
            this.metroButtonBSPexecutablePath.Location = new System.Drawing.Point(330, 345);
            this.metroButtonBSPexecutablePath.Name = "metroButtonBSPexecutablePath";
            this.metroButtonBSPexecutablePath.Size = new System.Drawing.Size(77, 23);
            this.metroButtonBSPexecutablePath.TabIndex = 2;
            this.metroButtonBSPexecutablePath.Text = "Browse";
            this.metroButtonBSPexecutablePath.UseSelectable = true;
            this.metroButtonBSPexecutablePath.Click += new System.EventHandler(this.metroButtonBSPexecutablePath_Click);
            // 
            // metroButtonVISexecutablePath
            // 
            this.metroButtonVISexecutablePath.Location = new System.Drawing.Point(330, 393);
            this.metroButtonVISexecutablePath.Name = "metroButtonVISexecutablePath";
            this.metroButtonVISexecutablePath.Size = new System.Drawing.Size(77, 23);
            this.metroButtonVISexecutablePath.TabIndex = 2;
            this.metroButtonVISexecutablePath.Text = "Browse";
            this.metroButtonVISexecutablePath.UseSelectable = true;
            this.metroButtonVISexecutablePath.Click += new System.EventHandler(this.metroButtonVISexecutablePath_Click);
            // 
            // metroButtonRADexecutablePath
            // 
            this.metroButtonRADexecutablePath.Location = new System.Drawing.Point(330, 441);
            this.metroButtonRADexecutablePath.Name = "metroButtonRADexecutablePath";
            this.metroButtonRADexecutablePath.Size = new System.Drawing.Size(77, 23);
            this.metroButtonRADexecutablePath.TabIndex = 2;
            this.metroButtonRADexecutablePath.Text = "Browse";
            this.metroButtonRADexecutablePath.UseSelectable = true;
            this.metroButtonRADexecutablePath.Click += new System.EventHandler(this.metroButtonRADexecutablePath_Click);
            // 
            // metroButtonSave
            // 
            this.metroButtonSave.Location = new System.Drawing.Point(23, 470);
            this.metroButtonSave.Name = "metroButtonSave";
            this.metroButtonSave.Size = new System.Drawing.Size(384, 37);
            this.metroButtonSave.TabIndex = 2;
            this.metroButtonSave.Text = "Save";
            this.metroButtonSave.UseSelectable = true;
            this.metroButtonSave.Click += new System.EventHandler(this.metroButtonSave_Click);
            // 
            // txtBspArgs
            // 
            this.txtBspArgs.Lines = new string[0];
            this.txtBspArgs.Location = new System.Drawing.Point(237, 345);
            this.txtBspArgs.MaxLength = 32767;
            this.txtBspArgs.Name = "txtBspArgs";
            this.txtBspArgs.PasswordChar = '\0';
            this.txtBspArgs.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtBspArgs.SelectedText = "";
            this.txtBspArgs.Size = new System.Drawing.Size(87, 23);
            this.txtBspArgs.TabIndex = 1;
            this.txtBspArgs.UseSelectable = true;
            // 
            // txtBspPath
            // 
            this.txtBspPath.Lines = new string[0];
            this.txtBspPath.Location = new System.Drawing.Point(23, 345);
            this.txtBspPath.MaxLength = 32767;
            this.txtBspPath.Name = "txtBspPath";
            this.txtBspPath.PasswordChar = '\0';
            this.txtBspPath.ReadOnly = true;
            this.txtBspPath.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtBspPath.SelectedText = "";
            this.txtBspPath.Size = new System.Drawing.Size(208, 23);
            this.txtBspPath.TabIndex = 1;
            this.txtBspPath.UseSelectable = true;
            // 
            // metroButtonDelete
            // 
            this.metroButtonDelete.Location = new System.Drawing.Point(330, 92);
            this.metroButtonDelete.Name = "metroButtonDelete";
            this.metroButtonDelete.Size = new System.Drawing.Size(77, 23);
            this.metroButtonDelete.TabIndex = 2;
            this.metroButtonDelete.Text = "Delete";
            this.metroButtonDelete.UseSelectable = true;
            this.metroButtonDelete.Click += new System.EventHandler(this.metroButtonDelete_Click);
            // 
            // txtMod
            // 
            this.txtMod.Lines = new string[0];
            this.txtMod.Location = new System.Drawing.Point(23, 249);
            this.txtMod.MaxLength = 32767;
            this.txtMod.Name = "txtMod";
            this.txtMod.PasswordChar = '\0';
            this.txtMod.ReadOnly = true;
            this.txtMod.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtMod.SelectedText = "";
            this.txtMod.Size = new System.Drawing.Size(301, 23);
            this.txtMod.TabIndex = 1;
            this.txtMod.UseSelectable = true;
            // 
            // txtCsgArgs
            // 
            this.txtCsgArgs.Lines = new string[0];
            this.txtCsgArgs.Location = new System.Drawing.Point(237, 297);
            this.txtCsgArgs.MaxLength = 32767;
            this.txtCsgArgs.Name = "txtCsgArgs";
            this.txtCsgArgs.PasswordChar = '\0';
            this.txtCsgArgs.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCsgArgs.SelectedText = "";
            this.txtCsgArgs.Size = new System.Drawing.Size(87, 23);
            this.txtCsgArgs.TabIndex = 1;
            this.txtCsgArgs.UseSelectable = true;
            // 
            // txtCsgPath
            // 
            this.txtCsgPath.Lines = new string[0];
            this.txtCsgPath.Location = new System.Drawing.Point(23, 297);
            this.txtCsgPath.MaxLength = 32767;
            this.txtCsgPath.Name = "txtCsgPath";
            this.txtCsgPath.PasswordChar = '\0';
            this.txtCsgPath.ReadOnly = true;
            this.txtCsgPath.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCsgPath.SelectedText = "";
            this.txtCsgPath.Size = new System.Drawing.Size(208, 23);
            this.txtCsgPath.TabIndex = 1;
            this.txtCsgPath.UseSelectable = true;
            // 
            // metroButtonAddNewName
            // 
            this.metroButtonAddNewName.Location = new System.Drawing.Point(330, 63);
            this.metroButtonAddNewName.Name = "metroButtonAddNewName";
            this.metroButtonAddNewName.Size = new System.Drawing.Size(77, 23);
            this.metroButtonAddNewName.TabIndex = 2;
            this.metroButtonAddNewName.Text = "Add";
            this.metroButtonAddNewName.UseSelectable = true;
            this.metroButtonAddNewName.Click += new System.EventHandler(this.metroButtonAddNewName_Click);
            // 
            // txtGameExe
            // 
            this.txtGameExe.Lines = new string[0];
            this.txtGameExe.Location = new System.Drawing.Point(23, 201);
            this.txtGameExe.MaxLength = 32767;
            this.txtGameExe.Name = "txtGameExe";
            this.txtGameExe.PasswordChar = '\0';
            this.txtGameExe.ReadOnly = true;
            this.txtGameExe.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtGameExe.SelectedText = "";
            this.txtGameExe.Size = new System.Drawing.Size(208, 23);
            this.txtGameExe.TabIndex = 1;
            this.txtGameExe.UseSelectable = true;
            // 
            // txtName
            // 
            this.txtName.Lines = new string[0];
            this.txtName.Location = new System.Drawing.Point(23, 63);
            this.txtName.MaxLength = 32767;
            this.txtName.Name = "txtName";
            this.txtName.PasswordChar = '\0';
            this.txtName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtName.SelectedText = "";
            this.txtName.Size = new System.Drawing.Size(301, 23);
            this.txtName.TabIndex = 1;
            this.txtName.UseSelectable = true;
            // 
            // dgvProfiles
            // 
            this.dgvProfiles.AllowUserToAddRows = false;
            this.dgvProfiles.AllowUserToDeleteRows = false;
            this.dgvProfiles.AllowUserToResizeRows = false;
            this.dgvProfiles.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvProfiles.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvProfiles.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvProfiles.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProfiles.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvProfiles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProfiles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProfilesName});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvProfiles.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvProfiles.EnableHeadersVisualStyles = false;
            this.dgvProfiles.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvProfiles.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvProfiles.Location = new System.Drawing.Point(23, 92);
            this.dgvProfiles.Name = "dgvProfiles";
            this.dgvProfiles.ReadOnly = true;
            this.dgvProfiles.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProfiles.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvProfiles.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvProfiles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProfiles.Size = new System.Drawing.Size(301, 84);
            this.dgvProfiles.TabIndex = 0;
            this.dgvProfiles.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProfiles_CellContentClick);
            // 
            // ProfilesName
            // 
            this.ProfilesName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ProfilesName.DataPropertyName = "Name";
            this.ProfilesName.HeaderText = "Name";
            this.ProfilesName.Name = "ProfilesName";
            this.ProfilesName.ReadOnly = true;
            this.ProfilesName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // txtGameArgs
            // 
            this.txtGameArgs.Lines = new string[0];
            this.txtGameArgs.Location = new System.Drawing.Point(237, 201);
            this.txtGameArgs.MaxLength = 32767;
            this.txtGameArgs.Name = "txtGameArgs";
            this.txtGameArgs.PasswordChar = '\0';
            this.txtGameArgs.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtGameArgs.SelectedText = "";
            this.txtGameArgs.Size = new System.Drawing.Size(87, 23);
            this.txtGameArgs.TabIndex = 4;
            this.txtGameArgs.UseSelectable = true;
            // 
            // FrmDatCompillerProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 530);
            this.Controls.Add(this.txtGameArgs);
            this.Controls.Add(this.metroLabelRADexecutablePath);
            this.Controls.Add(this.metroLabelVISexecutablePath);
            this.Controls.Add(this.metroLabelBSPexecutablePath);
            this.Controls.Add(this.metroLabelModDirPath);
            this.Controls.Add(this.metroLabelCSGexecutablePath);
            this.Controls.Add(this.txtRadArgs);
            this.Controls.Add(this.txtRadPath);
            this.Controls.Add(this.metroLabelGameExePath);
            this.Controls.Add(this.txtVisArgs);
            this.Controls.Add(this.txtVisPath);
            this.Controls.Add(this.metroButtonGameExePath);
            this.Controls.Add(this.metroButtonModDirPath);
            this.Controls.Add(this.metroButtonCSGexecutablePath);
            this.Controls.Add(this.metroButtonBSPexecutablePath);
            this.Controls.Add(this.metroButtonVISexecutablePath);
            this.Controls.Add(this.metroButtonRADexecutablePath);
            this.Controls.Add(this.metroButtonSave);
            this.Controls.Add(this.txtBspArgs);
            this.Controls.Add(this.txtBspPath);
            this.Controls.Add(this.metroButtonDelete);
            this.Controls.Add(this.txtMod);
            this.Controls.Add(this.txtCsgArgs);
            this.Controls.Add(this.txtCsgPath);
            this.Controls.Add(this.metroButtonAddNewName);
            this.Controls.Add(this.txtGameExe);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.dgvProfiles);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmDatCompillerProfile";
            this.Resizable = false;
            this.ShowInTaskbar = false;
            this.Text = "Profiles";
            this.Load += new System.EventHandler(this.FrmDatCompillerProfile_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProfiles)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroGrid dgvProfiles;
        private MetroFramework.Controls.MetroTextBox txtName;
        private MetroFramework.Controls.MetroButton metroButtonAddNewName;
        private MetroFramework.Controls.MetroButton metroButtonDelete;
        private MetroFramework.Controls.MetroButton metroButtonSave;
        private MetroFramework.Controls.MetroTextBox txtGameExe;
        private MetroFramework.Controls.MetroLabel metroLabelGameExePath;
        private MetroFramework.Controls.MetroTextBox txtMod;
        private MetroFramework.Controls.MetroLabel metroLabelModDirPath;
        private MetroFramework.Controls.MetroTextBox txtCsgPath;
        private MetroFramework.Controls.MetroTextBox txtBspPath;
        private MetroFramework.Controls.MetroLabel metroLabelCSGexecutablePath;
        private MetroFramework.Controls.MetroLabel metroLabelBSPexecutablePath;
        private MetroFramework.Controls.MetroTextBox txtVisPath;
        private MetroFramework.Controls.MetroLabel metroLabelVISexecutablePath;
        private MetroFramework.Controls.MetroTextBox txtRadPath;
        private MetroFramework.Controls.MetroLabel metroLabelRADexecutablePath;
        private MetroFramework.Controls.MetroButton metroButtonRADexecutablePath;
        private MetroFramework.Controls.MetroButton metroButtonVISexecutablePath;
        private MetroFramework.Controls.MetroButton metroButtonBSPexecutablePath;
        private MetroFramework.Controls.MetroButton metroButtonCSGexecutablePath;
        private MetroFramework.Controls.MetroButton metroButtonModDirPath;
        private MetroFramework.Controls.MetroButton metroButtonGameExePath;
        private MetroFramework.Controls.MetroTextBox txtCsgArgs;
        private MetroFramework.Controls.MetroTextBox txtBspArgs;
        private MetroFramework.Controls.MetroTextBox txtVisArgs;
        private MetroFramework.Controls.MetroTextBox txtRadArgs;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProfilesName;
        private MetroFramework.Controls.MetroTextBox txtGameArgs;
    }
}