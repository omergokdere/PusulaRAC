namespace PusulaRAC
{
    partial class ClientOperations
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnListV = new MetroFramework.Controls.MetroButton();
            this.btnAddC = new MetroFramework.Controls.MetroButton();
            this.btnDeletedC = new MetroFramework.Controls.MetroButton();
            this.btnClientHistory = new MetroFramework.Controls.MetroButton();
            this.btnGoBack = new MetroFramework.Controls.MetroButton();
            this.tblVehiclesTableAdapter3 = new PusulaRAC.PusulaDBDataSet3TableAdapters.tblVehiclesTableAdapter();
            this.pusulaDBDataSet3 = new PusulaRAC.PusulaDBDataSet3();
            this.tblVehiclesBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.tbSearchB = new MetroFramework.Controls.MetroTextBox();
            this.tbSearchM = new MetroFramework.Controls.MetroTextBox();
            this.tbSearchY = new MetroFramework.Controls.MetroTextBox();
            this.gvListV = new MetroFramework.Controls.MetroGrid();
            this.plateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brandDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yearDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.classDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblModel = new System.Windows.Forms.Label();
            this.lblCBBrand = new System.Windows.Forms.Label();
            this.lblsearchPlate = new System.Windows.Forms.Label();
            this.tbSearchP = new MetroFramework.Controls.MetroTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.tblVehiclesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblVehiclesBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.tblVehiclesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tblVehiclesBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pusulaDBDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblVehiclesBindingSource4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvListV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblVehiclesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblVehiclesBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblVehiclesBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblVehiclesBindingSource3)).BeginInit();
            this.SuspendLayout();
            // 
            // btnListV
            // 
            this.btnListV.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnListV.FontWeight = MetroFramework.MetroButtonWeight.Light;
            this.btnListV.Location = new System.Drawing.Point(398, 183);
            this.btnListV.Margin = new System.Windows.Forms.Padding(4);
            this.btnListV.Name = "btnListV";
            this.btnListV.Size = new System.Drawing.Size(669, 64);
            this.btnListV.TabIndex = 21;
            this.btnListV.Text = "Search";
            this.btnListV.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnListV.UseSelectable = true;
            // 
            // btnAddC
            // 
            this.btnAddC.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAddC.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnAddC.FontWeight = MetroFramework.MetroButtonWeight.Light;
            this.btnAddC.ForeColor = System.Drawing.Color.Coral;
            this.btnAddC.Location = new System.Drawing.Point(82, 131);
            this.btnAddC.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddC.Name = "btnAddC";
            this.btnAddC.Size = new System.Drawing.Size(267, 123);
            this.btnAddC.TabIndex = 25;
            this.btnAddC.Text = "Add Client";
            this.btnAddC.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnAddC.UseSelectable = true;
            this.btnAddC.Click += new System.EventHandler(this.btnAddC_Click);
            // 
            // btnDeletedC
            // 
            this.btnDeletedC.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnDeletedC.FontWeight = MetroFramework.MetroButtonWeight.Light;
            this.btnDeletedC.ForeColor = System.Drawing.Color.Coral;
            this.btnDeletedC.Location = new System.Drawing.Point(82, 254);
            this.btnDeletedC.Margin = new System.Windows.Forms.Padding(4);
            this.btnDeletedC.Name = "btnDeletedC";
            this.btnDeletedC.Size = new System.Drawing.Size(267, 123);
            this.btnDeletedC.TabIndex = 24;
            this.btnDeletedC.Text = "Deleted Clients";
            this.btnDeletedC.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnDeletedC.UseSelectable = true;
            this.btnDeletedC.Click += new System.EventHandler(this.btnDeletedC_Click);
            // 
            // btnClientHistory
            // 
            this.btnClientHistory.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnClientHistory.FontWeight = MetroFramework.MetroButtonWeight.Light;
            this.btnClientHistory.ForeColor = System.Drawing.Color.Coral;
            this.btnClientHistory.Location = new System.Drawing.Point(82, 378);
            this.btnClientHistory.Margin = new System.Windows.Forms.Padding(4);
            this.btnClientHistory.Name = "btnClientHistory";
            this.btnClientHistory.Size = new System.Drawing.Size(267, 123);
            this.btnClientHistory.TabIndex = 23;
            this.btnClientHistory.Text = "Company History";
            this.btnClientHistory.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnClientHistory.UseSelectable = true;
            this.btnClientHistory.Click += new System.EventHandler(this.btnClientHistory_Click);
            // 
            // btnGoBack
            // 
            this.btnGoBack.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnGoBack.FontWeight = MetroFramework.MetroButtonWeight.Light;
            this.btnGoBack.ForeColor = System.Drawing.Color.Coral;
            this.btnGoBack.Location = new System.Drawing.Point(82, 500);
            this.btnGoBack.Margin = new System.Windows.Forms.Padding(4);
            this.btnGoBack.Name = "btnGoBack";
            this.btnGoBack.Size = new System.Drawing.Size(267, 123);
            this.btnGoBack.TabIndex = 22;
            this.btnGoBack.Text = "Main Menu";
            this.btnGoBack.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnGoBack.UseSelectable = true;
            this.btnGoBack.Click += new System.EventHandler(this.btnGoBack_Click);
            // 
            // tblVehiclesTableAdapter3
            // 
            this.tblVehiclesTableAdapter3.ClearBeforeFill = true;
            // 
            // pusulaDBDataSet3
            // 
            this.pusulaDBDataSet3.DataSetName = "PusulaDBDataSet3";
            this.pusulaDBDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblVehiclesBindingSource4
            // 
            this.tblVehiclesBindingSource4.DataMember = "tblVehicles";
            this.tblVehiclesBindingSource4.DataSource = this.pusulaDBDataSet3;
            // 
            // tbSearchB
            // 
            // 
            // 
            // 
            this.tbSearchB.CustomButton.Image = null;
            this.tbSearchB.CustomButton.Location = new System.Drawing.Point(119, 1);
            this.tbSearchB.CustomButton.Margin = new System.Windows.Forms.Padding(4);
            this.tbSearchB.CustomButton.Name = "";
            this.tbSearchB.CustomButton.Size = new System.Drawing.Size(41, 41);
            this.tbSearchB.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbSearchB.CustomButton.TabIndex = 1;
            this.tbSearchB.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbSearchB.CustomButton.UseSelectable = true;
            this.tbSearchB.CustomButton.Visible = false;
            this.tbSearchB.Lines = new string[0];
            this.tbSearchB.Location = new System.Drawing.Point(567, 131);
            this.tbSearchB.Margin = new System.Windows.Forms.Padding(4);
            this.tbSearchB.MaxLength = 32767;
            this.tbSearchB.Name = "tbSearchB";
            this.tbSearchB.PasswordChar = '\0';
            this.tbSearchB.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbSearchB.SelectedText = "";
            this.tbSearchB.SelectionLength = 0;
            this.tbSearchB.SelectionStart = 0;
            this.tbSearchB.ShortcutsEnabled = true;
            this.tbSearchB.Size = new System.Drawing.Size(161, 43);
            this.tbSearchB.TabIndex = 26;
            this.tbSearchB.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.tbSearchB.UseSelectable = true;
            this.tbSearchB.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbSearchB.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // tbSearchM
            // 
            // 
            // 
            // 
            this.tbSearchM.CustomButton.Image = null;
            this.tbSearchM.CustomButton.Location = new System.Drawing.Point(119, 1);
            this.tbSearchM.CustomButton.Margin = new System.Windows.Forms.Padding(4);
            this.tbSearchM.CustomButton.Name = "";
            this.tbSearchM.CustomButton.Size = new System.Drawing.Size(41, 41);
            this.tbSearchM.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbSearchM.CustomButton.TabIndex = 1;
            this.tbSearchM.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbSearchM.CustomButton.UseSelectable = true;
            this.tbSearchM.CustomButton.Visible = false;
            this.tbSearchM.Lines = new string[0];
            this.tbSearchM.Location = new System.Drawing.Point(736, 131);
            this.tbSearchM.Margin = new System.Windows.Forms.Padding(4);
            this.tbSearchM.MaxLength = 32767;
            this.tbSearchM.Name = "tbSearchM";
            this.tbSearchM.PasswordChar = '\0';
            this.tbSearchM.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbSearchM.SelectedText = "";
            this.tbSearchM.SelectionLength = 0;
            this.tbSearchM.SelectionStart = 0;
            this.tbSearchM.ShortcutsEnabled = true;
            this.tbSearchM.Size = new System.Drawing.Size(161, 43);
            this.tbSearchM.TabIndex = 27;
            this.tbSearchM.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.tbSearchM.UseSelectable = true;
            this.tbSearchM.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbSearchM.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // tbSearchY
            // 
            // 
            // 
            // 
            this.tbSearchY.CustomButton.Image = null;
            this.tbSearchY.CustomButton.Location = new System.Drawing.Point(119, 1);
            this.tbSearchY.CustomButton.Margin = new System.Windows.Forms.Padding(4);
            this.tbSearchY.CustomButton.Name = "";
            this.tbSearchY.CustomButton.Size = new System.Drawing.Size(41, 41);
            this.tbSearchY.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbSearchY.CustomButton.TabIndex = 1;
            this.tbSearchY.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbSearchY.CustomButton.UseSelectable = true;
            this.tbSearchY.CustomButton.Visible = false;
            this.tbSearchY.Lines = new string[0];
            this.tbSearchY.Location = new System.Drawing.Point(906, 131);
            this.tbSearchY.Margin = new System.Windows.Forms.Padding(4);
            this.tbSearchY.MaxLength = 32767;
            this.tbSearchY.Name = "tbSearchY";
            this.tbSearchY.PasswordChar = '\0';
            this.tbSearchY.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbSearchY.SelectedText = "";
            this.tbSearchY.SelectionLength = 0;
            this.tbSearchY.SelectionStart = 0;
            this.tbSearchY.ShortcutsEnabled = true;
            this.tbSearchY.Size = new System.Drawing.Size(161, 43);
            this.tbSearchY.TabIndex = 28;
            this.tbSearchY.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.tbSearchY.UseSelectable = true;
            this.tbSearchY.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbSearchY.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // gvListV
            // 
            this.gvListV.AllowUserToAddRows = false;
            this.gvListV.AllowUserToDeleteRows = false;
            this.gvListV.AllowUserToOrderColumns = true;
            this.gvListV.AllowUserToResizeRows = false;
            this.gvListV.AutoGenerateColumns = false;
            this.gvListV.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.gvListV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gvListV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.gvListV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(119)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(133)))), ((int)(((byte)(72)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gvListV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gvListV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvListV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.plateDataGridViewTextBoxColumn,
            this.brandDataGridViewTextBoxColumn,
            this.modelDataGridViewTextBoxColumn,
            this.yearDataGridViewTextBoxColumn,
            this.classDataGridViewTextBoxColumn});
            this.gvListV.DataSource = this.tblVehiclesBindingSource4;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(133)))), ((int)(((byte)(72)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gvListV.DefaultCellStyle = dataGridViewCellStyle2;
            this.gvListV.EnableHeadersVisualStyles = false;
            this.gvListV.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.gvListV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.gvListV.Location = new System.Drawing.Point(398, 254);
            this.gvListV.Margin = new System.Windows.Forms.Padding(4);
            this.gvListV.Name = "gvListV";
            this.gvListV.ReadOnly = true;
            this.gvListV.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(119)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(133)))), ((int)(((byte)(72)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gvListV.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.gvListV.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gvListV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvListV.Size = new System.Drawing.Size(669, 369);
            this.gvListV.Style = MetroFramework.MetroColorStyle.Orange;
            this.gvListV.TabIndex = 20;
            this.gvListV.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.gvListV.UseStyleColors = true;
            // 
            // plateDataGridViewTextBoxColumn
            // 
            this.plateDataGridViewTextBoxColumn.DataPropertyName = "Plate";
            this.plateDataGridViewTextBoxColumn.HeaderText = "Name";
            this.plateDataGridViewTextBoxColumn.Name = "plateDataGridViewTextBoxColumn";
            this.plateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // brandDataGridViewTextBoxColumn
            // 
            this.brandDataGridViewTextBoxColumn.DataPropertyName = "Brand";
            this.brandDataGridViewTextBoxColumn.HeaderText = "Surname";
            this.brandDataGridViewTextBoxColumn.Name = "brandDataGridViewTextBoxColumn";
            this.brandDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // modelDataGridViewTextBoxColumn
            // 
            this.modelDataGridViewTextBoxColumn.DataPropertyName = "Model";
            this.modelDataGridViewTextBoxColumn.HeaderText = "National ID No";
            this.modelDataGridViewTextBoxColumn.Name = "modelDataGridViewTextBoxColumn";
            this.modelDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // yearDataGridViewTextBoxColumn
            // 
            this.yearDataGridViewTextBoxColumn.DataPropertyName = "Year";
            this.yearDataGridViewTextBoxColumn.HeaderText = "Vehicle Status";
            this.yearDataGridViewTextBoxColumn.Name = "yearDataGridViewTextBoxColumn";
            this.yearDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // classDataGridViewTextBoxColumn
            // 
            this.classDataGridViewTextBoxColumn.DataPropertyName = "Class";
            this.classDataGridViewTextBoxColumn.HeaderText = "Client Type";
            this.classDataGridViewTextBoxColumn.Name = "classDataGridViewTextBoxColumn";
            this.classDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(156)))), ((int)(((byte)(42)))));
            this.label1.Location = new System.Drawing.Point(528, 46);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(298, 31);
            this.label1.TabIndex = 18;
            this.label1.Text = "CLIENT OPERATIONS";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkOrange;
            this.label4.Location = new System.Drawing.Point(933, 103);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 25);
            this.label4.TabIndex = 15;
            this.label4.Text = "Client Type";
            // 
            // lblModel
            // 
            this.lblModel.AutoSize = true;
            this.lblModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModel.ForeColor = System.Drawing.Color.DarkOrange;
            this.lblModel.Location = new System.Drawing.Point(760, 103);
            this.lblModel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(137, 25);
            this.lblModel.TabIndex = 14;
            this.lblModel.Text = "National ID No";
            // 
            // lblCBBrand
            // 
            this.lblCBBrand.AutoSize = true;
            this.lblCBBrand.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCBBrand.ForeColor = System.Drawing.Color.DarkOrange;
            this.lblCBBrand.Location = new System.Drawing.Point(610, 103);
            this.lblCBBrand.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCBBrand.Name = "lblCBBrand";
            this.lblCBBrand.Size = new System.Drawing.Size(92, 25);
            this.lblCBBrand.TabIndex = 13;
            this.lblCBBrand.Text = "Surname";
            // 
            // lblsearchPlate
            // 
            this.lblsearchPlate.AutoSize = true;
            this.lblsearchPlate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsearchPlate.ForeColor = System.Drawing.Color.DarkOrange;
            this.lblsearchPlate.Location = new System.Drawing.Point(451, 103);
            this.lblsearchPlate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblsearchPlate.Name = "lblsearchPlate";
            this.lblsearchPlate.Size = new System.Drawing.Size(64, 25);
            this.lblsearchPlate.TabIndex = 16;
            this.lblsearchPlate.Text = "Name";
            // 
            // tbSearchP
            // 
            // 
            // 
            // 
            this.tbSearchP.CustomButton.Image = null;
            this.tbSearchP.CustomButton.Location = new System.Drawing.Point(119, 1);
            this.tbSearchP.CustomButton.Margin = new System.Windows.Forms.Padding(4);
            this.tbSearchP.CustomButton.Name = "";
            this.tbSearchP.CustomButton.Size = new System.Drawing.Size(41, 41);
            this.tbSearchP.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbSearchP.CustomButton.TabIndex = 1;
            this.tbSearchP.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbSearchP.CustomButton.UseSelectable = true;
            this.tbSearchP.CustomButton.Visible = false;
            this.tbSearchP.Lines = new string[0];
            this.tbSearchP.Location = new System.Drawing.Point(398, 131);
            this.tbSearchP.Margin = new System.Windows.Forms.Padding(4);
            this.tbSearchP.MaxLength = 32767;
            this.tbSearchP.Name = "tbSearchP";
            this.tbSearchP.PasswordChar = '\0';
            this.tbSearchP.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbSearchP.SelectedText = "";
            this.tbSearchP.SelectionLength = 0;
            this.tbSearchP.SelectionStart = 0;
            this.tbSearchP.ShortcutsEnabled = true;
            this.tbSearchP.Size = new System.Drawing.Size(161, 43);
            this.tbSearchP.TabIndex = 29;
            this.tbSearchP.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.tbSearchP.UseSelectable = true;
            this.tbSearchP.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbSearchP.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PusulaRAC.Properties.Resources.pusula2;
            this.pictureBox1.Location = new System.Drawing.Point(16, 20);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(130, 108);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::PusulaRAC.Properties.Resources.pusula;
            this.pictureBox2.Location = new System.Drawing.Point(154, 103);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(825, 526);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 19;
            this.pictureBox2.TabStop = false;
            // 
            // tblVehiclesBindingSource
            // 
            this.tblVehiclesBindingSource.DataMember = "tblVehicles";
            // 
            // tblVehiclesBindingSource2
            // 
            this.tblVehiclesBindingSource2.DataMember = "tblVehicles";
            // 
            // tblVehiclesBindingSource1
            // 
            this.tblVehiclesBindingSource1.DataMember = "tblVehicles";
            // 
            // tblVehiclesBindingSource3
            // 
            this.tblVehiclesBindingSource3.DataMember = "tblVehicles";
            // 
            // ClientOperations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1169, 683);
            this.Controls.Add(this.btnListV);
            this.Controls.Add(this.btnAddC);
            this.Controls.Add(this.btnDeletedC);
            this.Controls.Add(this.btnClientHistory);
            this.Controls.Add(this.btnGoBack);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tbSearchB);
            this.Controls.Add(this.tbSearchM);
            this.Controls.Add(this.tbSearchY);
            this.Controls.Add(this.gvListV);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblModel);
            this.Controls.Add(this.lblCBBrand);
            this.Controls.Add(this.lblsearchPlate);
            this.Controls.Add(this.tbSearchP);
            this.Controls.Add(this.pictureBox2);
            this.MaximizeBox = false;
            this.Name = "ClientOperations";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            ((System.ComponentModel.ISupportInitialize)(this.pusulaDBDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblVehiclesBindingSource4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvListV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblVehiclesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblVehiclesBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblVehiclesBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblVehiclesBindingSource3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource tblVehiclesBindingSource;
        private System.Windows.Forms.BindingSource tblVehiclesBindingSource2;
        private System.Windows.Forms.BindingSource tblVehiclesBindingSource1;
        private MetroFramework.Controls.MetroButton btnListV;
        private MetroFramework.Controls.MetroButton btnAddC;
        private MetroFramework.Controls.MetroButton btnDeletedC;
        private MetroFramework.Controls.MetroButton btnClientHistory;
        private MetroFramework.Controls.MetroButton btnGoBack;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private PusulaDBDataSet3TableAdapters.tblVehiclesTableAdapter tblVehiclesTableAdapter3;
        private PusulaDBDataSet3 pusulaDBDataSet3;
        private System.Windows.Forms.BindingSource tblVehiclesBindingSource4;
        private System.Windows.Forms.BindingSource tblVehiclesBindingSource3;
        private MetroFramework.Controls.MetroTextBox tbSearchB;
        private MetroFramework.Controls.MetroTextBox tbSearchM;
        private MetroFramework.Controls.MetroTextBox tbSearchY;
        private MetroFramework.Controls.MetroGrid gvListV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblModel;
        private System.Windows.Forms.Label lblCBBrand;
        private System.Windows.Forms.Label lblsearchPlate;
        private MetroFramework.Controls.MetroTextBox tbSearchP;
        private System.Windows.Forms.DataGridViewTextBoxColumn plateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn brandDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yearDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn classDataGridViewTextBoxColumn;
    }
}