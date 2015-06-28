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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.metroGridProfiles = new MetroFramework.Controls.MetroGrid();
            this.ProfilesName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.metroTextBoxNewProfileName = new MetroFramework.Controls.MetroTextBox();
            this.metroButtonAddNewName = new MetroFramework.Controls.MetroButton();
            this.metroButtonDelete = new MetroFramework.Controls.MetroButton();
            this.metroButtonSave = new MetroFramework.Controls.MetroButton();
            this.metroTextBoxGameExePath = new MetroFramework.Controls.MetroTextBox();
            this.metroLabelGameExePath = new MetroFramework.Controls.MetroLabel();
            this.metroTextBoxModDirPath = new MetroFramework.Controls.MetroTextBox();
            this.metroLabelModDirPath = new MetroFramework.Controls.MetroLabel();
            this.metroTextBoxCSGexecutablePath = new MetroFramework.Controls.MetroTextBox();
            this.metroTextBoxBSPexecutablePath = new MetroFramework.Controls.MetroTextBox();
            this.metroLabelCSGexecutablePath = new MetroFramework.Controls.MetroLabel();
            this.metroLabelBSPexecutablePath = new MetroFramework.Controls.MetroLabel();
            this.metroTextBoxVISexecutablePath = new MetroFramework.Controls.MetroTextBox();
            this.metroLabelVISexecutablePath = new MetroFramework.Controls.MetroLabel();
            this.metroTextBoxRADexecutablePath = new MetroFramework.Controls.MetroTextBox();
            this.metroLabelRADexecutablePath = new MetroFramework.Controls.MetroLabel();
            this.metroButtonRADexecutablePath = new MetroFramework.Controls.MetroButton();
            this.metroButtonVISexecutablePath = new MetroFramework.Controls.MetroButton();
            this.metroButtonBSPexecutablePath = new MetroFramework.Controls.MetroButton();
            this.metroButtonCSGexecutablePath = new MetroFramework.Controls.MetroButton();
            this.metroButtonModDirPath = new MetroFramework.Controls.MetroButton();
            this.metroButtonGameExePath = new MetroFramework.Controls.MetroButton();
            this.metroTextBoxCSGexecutableParams = new MetroFramework.Controls.MetroTextBox();
            this.metroTextBoxBSPexecutableParams = new MetroFramework.Controls.MetroTextBox();
            this.metroLabelVISexecutableParams = new MetroFramework.Controls.MetroTextBox();
            this.metroLabelRADexecutableParams = new MetroFramework.Controls.MetroTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.metroGridProfiles)).BeginInit();
            this.SuspendLayout();
            // 
            // metroGridProfiles
            // 
            this.metroGridProfiles.AllowUserToAddRows = false;
            this.metroGridProfiles.AllowUserToDeleteRows = false;
            this.metroGridProfiles.AllowUserToResizeRows = false;
            this.metroGridProfiles.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGridProfiles.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.metroGridProfiles.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.metroGridProfiles.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGridProfiles.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.metroGridProfiles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.metroGridProfiles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProfilesName});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metroGridProfiles.DefaultCellStyle = dataGridViewCellStyle5;
            this.metroGridProfiles.EnableHeadersVisualStyles = false;
            this.metroGridProfiles.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroGridProfiles.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGridProfiles.Location = new System.Drawing.Point(23, 92);
            this.metroGridProfiles.Name = "metroGridProfiles";
            this.metroGridProfiles.ReadOnly = true;
            this.metroGridProfiles.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGridProfiles.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.metroGridProfiles.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.metroGridProfiles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.metroGridProfiles.Size = new System.Drawing.Size(301, 84);
            this.metroGridProfiles.TabIndex = 0;
            // 
            // ProfilesName
            // 
            this.ProfilesName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ProfilesName.HeaderText = "Name";
            this.ProfilesName.Name = "ProfilesName";
            this.ProfilesName.ReadOnly = true;
            this.ProfilesName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // metroTextBoxNewProfileName
            // 
            this.metroTextBoxNewProfileName.Lines = new string[0];
            this.metroTextBoxNewProfileName.Location = new System.Drawing.Point(23, 63);
            this.metroTextBoxNewProfileName.MaxLength = 32767;
            this.metroTextBoxNewProfileName.Name = "metroTextBoxNewProfileName";
            this.metroTextBoxNewProfileName.PasswordChar = '\0';
            this.metroTextBoxNewProfileName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBoxNewProfileName.SelectedText = "";
            this.metroTextBoxNewProfileName.Size = new System.Drawing.Size(301, 23);
            this.metroTextBoxNewProfileName.TabIndex = 1;
            this.metroTextBoxNewProfileName.UseSelectable = true;
            // 
            // metroButtonAddNewName
            // 
            this.metroButtonAddNewName.Location = new System.Drawing.Point(330, 63);
            this.metroButtonAddNewName.Name = "metroButtonAddNewName";
            this.metroButtonAddNewName.Size = new System.Drawing.Size(77, 23);
            this.metroButtonAddNewName.TabIndex = 2;
            this.metroButtonAddNewName.Text = "Add";
            this.metroButtonAddNewName.UseSelectable = true;
            // 
            // metroButtonDelete
            // 
            this.metroButtonDelete.Location = new System.Drawing.Point(330, 92);
            this.metroButtonDelete.Name = "metroButtonDelete";
            this.metroButtonDelete.Size = new System.Drawing.Size(77, 23);
            this.metroButtonDelete.TabIndex = 2;
            this.metroButtonDelete.Text = "Delete";
            this.metroButtonDelete.UseSelectable = true;
            // 
            // metroButtonSave
            // 
            this.metroButtonSave.Location = new System.Drawing.Point(23, 470);
            this.metroButtonSave.Name = "metroButtonSave";
            this.metroButtonSave.Size = new System.Drawing.Size(384, 37);
            this.metroButtonSave.TabIndex = 2;
            this.metroButtonSave.Text = "Save";
            this.metroButtonSave.UseSelectable = true;
            // 
            // metroTextBoxGameExePath
            // 
            this.metroTextBoxGameExePath.Lines = new string[0];
            this.metroTextBoxGameExePath.Location = new System.Drawing.Point(23, 201);
            this.metroTextBoxGameExePath.MaxLength = 32767;
            this.metroTextBoxGameExePath.Name = "metroTextBoxGameExePath";
            this.metroTextBoxGameExePath.PasswordChar = '\0';
            this.metroTextBoxGameExePath.ReadOnly = true;
            this.metroTextBoxGameExePath.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBoxGameExePath.SelectedText = "";
            this.metroTextBoxGameExePath.Size = new System.Drawing.Size(301, 23);
            this.metroTextBoxGameExePath.TabIndex = 1;
            this.metroTextBoxGameExePath.UseSelectable = true;
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
            // metroTextBoxModDirPath
            // 
            this.metroTextBoxModDirPath.Lines = new string[0];
            this.metroTextBoxModDirPath.Location = new System.Drawing.Point(23, 249);
            this.metroTextBoxModDirPath.MaxLength = 32767;
            this.metroTextBoxModDirPath.Name = "metroTextBoxModDirPath";
            this.metroTextBoxModDirPath.PasswordChar = '\0';
            this.metroTextBoxModDirPath.ReadOnly = true;
            this.metroTextBoxModDirPath.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBoxModDirPath.SelectedText = "";
            this.metroTextBoxModDirPath.Size = new System.Drawing.Size(301, 23);
            this.metroTextBoxModDirPath.TabIndex = 1;
            this.metroTextBoxModDirPath.UseSelectable = true;
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
            // metroTextBoxCSGexecutablePath
            // 
            this.metroTextBoxCSGexecutablePath.Lines = new string[0];
            this.metroTextBoxCSGexecutablePath.Location = new System.Drawing.Point(23, 297);
            this.metroTextBoxCSGexecutablePath.MaxLength = 32767;
            this.metroTextBoxCSGexecutablePath.Name = "metroTextBoxCSGexecutablePath";
            this.metroTextBoxCSGexecutablePath.PasswordChar = '\0';
            this.metroTextBoxCSGexecutablePath.ReadOnly = true;
            this.metroTextBoxCSGexecutablePath.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBoxCSGexecutablePath.SelectedText = "";
            this.metroTextBoxCSGexecutablePath.Size = new System.Drawing.Size(208, 23);
            this.metroTextBoxCSGexecutablePath.TabIndex = 1;
            this.metroTextBoxCSGexecutablePath.UseSelectable = true;
            // 
            // metroTextBoxBSPexecutablePath
            // 
            this.metroTextBoxBSPexecutablePath.Lines = new string[0];
            this.metroTextBoxBSPexecutablePath.Location = new System.Drawing.Point(23, 345);
            this.metroTextBoxBSPexecutablePath.MaxLength = 32767;
            this.metroTextBoxBSPexecutablePath.Name = "metroTextBoxBSPexecutablePath";
            this.metroTextBoxBSPexecutablePath.PasswordChar = '\0';
            this.metroTextBoxBSPexecutablePath.ReadOnly = true;
            this.metroTextBoxBSPexecutablePath.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBoxBSPexecutablePath.SelectedText = "";
            this.metroTextBoxBSPexecutablePath.Size = new System.Drawing.Size(208, 23);
            this.metroTextBoxBSPexecutablePath.TabIndex = 1;
            this.metroTextBoxBSPexecutablePath.UseSelectable = true;
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
            // metroLabelBSPexecutablePath
            // 
            this.metroLabelBSPexecutablePath.AutoSize = true;
            this.metroLabelBSPexecutablePath.Location = new System.Drawing.Point(23, 323);
            this.metroLabelBSPexecutablePath.Name = "metroLabelBSPexecutablePath";
            this.metroLabelBSPexecutablePath.Size = new System.Drawing.Size(101, 19);
            this.metroLabelBSPexecutablePath.TabIndex = 3;
            this.metroLabelBSPexecutablePath.Text = "BSP Executable:";
            // 
            // metroTextBoxVISexecutablePath
            // 
            this.metroTextBoxVISexecutablePath.Lines = new string[0];
            this.metroTextBoxVISexecutablePath.Location = new System.Drawing.Point(23, 393);
            this.metroTextBoxVISexecutablePath.MaxLength = 32767;
            this.metroTextBoxVISexecutablePath.Name = "metroTextBoxVISexecutablePath";
            this.metroTextBoxVISexecutablePath.PasswordChar = '\0';
            this.metroTextBoxVISexecutablePath.ReadOnly = true;
            this.metroTextBoxVISexecutablePath.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBoxVISexecutablePath.SelectedText = "";
            this.metroTextBoxVISexecutablePath.Size = new System.Drawing.Size(208, 23);
            this.metroTextBoxVISexecutablePath.TabIndex = 1;
            this.metroTextBoxVISexecutablePath.UseSelectable = true;
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
            // metroTextBoxRADexecutablePath
            // 
            this.metroTextBoxRADexecutablePath.Lines = new string[0];
            this.metroTextBoxRADexecutablePath.Location = new System.Drawing.Point(23, 441);
            this.metroTextBoxRADexecutablePath.MaxLength = 32767;
            this.metroTextBoxRADexecutablePath.Name = "metroTextBoxRADexecutablePath";
            this.metroTextBoxRADexecutablePath.PasswordChar = '\0';
            this.metroTextBoxRADexecutablePath.ReadOnly = true;
            this.metroTextBoxRADexecutablePath.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBoxRADexecutablePath.SelectedText = "";
            this.metroTextBoxRADexecutablePath.Size = new System.Drawing.Size(208, 23);
            this.metroTextBoxRADexecutablePath.TabIndex = 1;
            this.metroTextBoxRADexecutablePath.UseSelectable = true;
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
            // metroTextBoxCSGexecutableParams
            // 
            this.metroTextBoxCSGexecutableParams.Lines = new string[0];
            this.metroTextBoxCSGexecutableParams.Location = new System.Drawing.Point(237, 297);
            this.metroTextBoxCSGexecutableParams.MaxLength = 32767;
            this.metroTextBoxCSGexecutableParams.Name = "metroTextBoxCSGexecutableParams";
            this.metroTextBoxCSGexecutableParams.PasswordChar = '\0';
            this.metroTextBoxCSGexecutableParams.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBoxCSGexecutableParams.SelectedText = "";
            this.metroTextBoxCSGexecutableParams.Size = new System.Drawing.Size(87, 23);
            this.metroTextBoxCSGexecutableParams.TabIndex = 1;
            this.metroTextBoxCSGexecutableParams.UseSelectable = true;
            // 
            // metroTextBoxBSPexecutableParams
            // 
            this.metroTextBoxBSPexecutableParams.Lines = new string[0];
            this.metroTextBoxBSPexecutableParams.Location = new System.Drawing.Point(237, 345);
            this.metroTextBoxBSPexecutableParams.MaxLength = 32767;
            this.metroTextBoxBSPexecutableParams.Name = "metroTextBoxBSPexecutableParams";
            this.metroTextBoxBSPexecutableParams.PasswordChar = '\0';
            this.metroTextBoxBSPexecutableParams.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBoxBSPexecutableParams.SelectedText = "";
            this.metroTextBoxBSPexecutableParams.Size = new System.Drawing.Size(87, 23);
            this.metroTextBoxBSPexecutableParams.TabIndex = 1;
            this.metroTextBoxBSPexecutableParams.UseSelectable = true;
            // 
            // metroLabelVISexecutableParams
            // 
            this.metroLabelVISexecutableParams.Lines = new string[0];
            this.metroLabelVISexecutableParams.Location = new System.Drawing.Point(237, 393);
            this.metroLabelVISexecutableParams.MaxLength = 32767;
            this.metroLabelVISexecutableParams.Name = "metroLabelVISexecutableParams";
            this.metroLabelVISexecutableParams.PasswordChar = '\0';
            this.metroLabelVISexecutableParams.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroLabelVISexecutableParams.SelectedText = "";
            this.metroLabelVISexecutableParams.Size = new System.Drawing.Size(87, 23);
            this.metroLabelVISexecutableParams.TabIndex = 1;
            this.metroLabelVISexecutableParams.UseSelectable = true;
            // 
            // metroLabelRADexecutableParams
            // 
            this.metroLabelRADexecutableParams.Lines = new string[0];
            this.metroLabelRADexecutableParams.Location = new System.Drawing.Point(237, 441);
            this.metroLabelRADexecutableParams.MaxLength = 32767;
            this.metroLabelRADexecutableParams.Name = "metroLabelRADexecutableParams";
            this.metroLabelRADexecutableParams.PasswordChar = '\0';
            this.metroLabelRADexecutableParams.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroLabelRADexecutableParams.SelectedText = "";
            this.metroLabelRADexecutableParams.Size = new System.Drawing.Size(87, 23);
            this.metroLabelRADexecutableParams.TabIndex = 1;
            this.metroLabelRADexecutableParams.UseSelectable = true;
            // 
            // FrmDatCompillerProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 530);
            this.Controls.Add(this.metroLabelRADexecutablePath);
            this.Controls.Add(this.metroLabelVISexecutablePath);
            this.Controls.Add(this.metroLabelBSPexecutablePath);
            this.Controls.Add(this.metroLabelModDirPath);
            this.Controls.Add(this.metroLabelCSGexecutablePath);
            this.Controls.Add(this.metroLabelRADexecutableParams);
            this.Controls.Add(this.metroTextBoxRADexecutablePath);
            this.Controls.Add(this.metroLabelGameExePath);
            this.Controls.Add(this.metroLabelVISexecutableParams);
            this.Controls.Add(this.metroTextBoxVISexecutablePath);
            this.Controls.Add(this.metroButtonGameExePath);
            this.Controls.Add(this.metroButtonModDirPath);
            this.Controls.Add(this.metroButtonCSGexecutablePath);
            this.Controls.Add(this.metroButtonBSPexecutablePath);
            this.Controls.Add(this.metroButtonVISexecutablePath);
            this.Controls.Add(this.metroButtonRADexecutablePath);
            this.Controls.Add(this.metroButtonSave);
            this.Controls.Add(this.metroTextBoxBSPexecutableParams);
            this.Controls.Add(this.metroTextBoxBSPexecutablePath);
            this.Controls.Add(this.metroButtonDelete);
            this.Controls.Add(this.metroTextBoxModDirPath);
            this.Controls.Add(this.metroTextBoxCSGexecutableParams);
            this.Controls.Add(this.metroTextBoxCSGexecutablePath);
            this.Controls.Add(this.metroButtonAddNewName);
            this.Controls.Add(this.metroTextBoxGameExePath);
            this.Controls.Add(this.metroTextBoxNewProfileName);
            this.Controls.Add(this.metroGridProfiles);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmDatCompillerProfile";
            this.Resizable = false;
            this.ShowInTaskbar = false;
            this.Text = "Profiles";
            this.Load += new System.EventHandler(this.FrmDatCompillerProfile_Load);
            ((System.ComponentModel.ISupportInitialize)(this.metroGridProfiles)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroGrid metroGridProfiles;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProfilesName;
        private MetroFramework.Controls.MetroTextBox metroTextBoxNewProfileName;
        private MetroFramework.Controls.MetroButton metroButtonAddNewName;
        private MetroFramework.Controls.MetroButton metroButtonDelete;
        private MetroFramework.Controls.MetroButton metroButtonSave;
        private MetroFramework.Controls.MetroTextBox metroTextBoxGameExePath;
        private MetroFramework.Controls.MetroLabel metroLabelGameExePath;
        private MetroFramework.Controls.MetroTextBox metroTextBoxModDirPath;
        private MetroFramework.Controls.MetroLabel metroLabelModDirPath;
        private MetroFramework.Controls.MetroTextBox metroTextBoxCSGexecutablePath;
        private MetroFramework.Controls.MetroTextBox metroTextBoxBSPexecutablePath;
        private MetroFramework.Controls.MetroLabel metroLabelCSGexecutablePath;
        private MetroFramework.Controls.MetroLabel metroLabelBSPexecutablePath;
        private MetroFramework.Controls.MetroTextBox metroTextBoxVISexecutablePath;
        private MetroFramework.Controls.MetroLabel metroLabelVISexecutablePath;
        private MetroFramework.Controls.MetroTextBox metroTextBoxRADexecutablePath;
        private MetroFramework.Controls.MetroLabel metroLabelRADexecutablePath;
        private MetroFramework.Controls.MetroButton metroButtonRADexecutablePath;
        private MetroFramework.Controls.MetroButton metroButtonVISexecutablePath;
        private MetroFramework.Controls.MetroButton metroButtonBSPexecutablePath;
        private MetroFramework.Controls.MetroButton metroButtonCSGexecutablePath;
        private MetroFramework.Controls.MetroButton metroButtonModDirPath;
        private MetroFramework.Controls.MetroButton metroButtonGameExePath;
        private MetroFramework.Controls.MetroTextBox metroTextBoxCSGexecutableParams;
        private MetroFramework.Controls.MetroTextBox metroTextBoxBSPexecutableParams;
        private MetroFramework.Controls.MetroTextBox metroLabelVISexecutableParams;
        private MetroFramework.Controls.MetroTextBox metroLabelRADexecutableParams;
    }
}