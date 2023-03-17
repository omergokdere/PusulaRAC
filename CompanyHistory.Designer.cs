namespace PusulaRAC
{
    partial class CompanyHistory
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
            this.tblVehiclesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.lblModel = new System.Windows.Forms.Label();
            this.lblCBBrand = new System.Windows.Forms.Label();
            this.lblsearchPlate = new System.Windows.Forms.Label();
            this.tbSearchDelName = new MetroFramework.Controls.MetroTextBox();
            this.tblVehiclesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tblVehiclesBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.btnBack = new MetroFramework.Controls.MetroButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tbSearchDelSurname = new MetroFramework.Controls.MetroTextBox();
            this.tblVehiclesTableAdapter3 = new PusulaRAC.PusulaDBDataSet3TableAdapters.tblVehiclesTableAdapter();
            this.pusulaDBDataSet3 = new PusulaRAC.PusulaDBDataSet3();
            this.tblVehiclesBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.tbSearchDelID = new MetroFramework.Controls.MetroTextBox();
            this.gvListV = new MetroFramework.Controls.MetroGrid();
            this.tblVehiclesBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnListV = new MetroFramework.Controls.MetroButton();
            this.plateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brandDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yearDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.tblVehiclesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblVehiclesBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblVehiclesBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pusulaDBDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblVehiclesBindingSource4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvListV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblVehiclesBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // tblVehiclesBindingSource
            // 
            this.tblVehiclesBindingSource.DataMember = "tblVehicles";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(156)))), ((int)(((byte)(42)))));
            this.label1.Location = new System.Drawing.Point(571, 63);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(280, 31);
            this.label1.TabIndex = 49;
            this.label1.Text = "COMPANY HISTORY";
            // 
            // lblModel
            // 
            this.lblModel.AutoSize = true;
            this.lblModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModel.ForeColor = System.Drawing.Color.DarkOrange;
            this.lblModel.Location = new System.Drawing.Point(941, 120);
            this.lblModel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(147, 25);
            this.lblModel.TabIndex = 45;
            this.lblModel.Text = "Company Type";
            // 
            // lblCBBrand
            // 
            this.lblCBBrand.AutoSize = true;
            this.lblCBBrand.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCBBrand.ForeColor = System.Drawing.Color.DarkOrange;
            this.lblCBBrand.Location = new System.Drawing.Point(727, 119);
            this.lblCBBrand.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCBBrand.Name = "lblCBBrand";
            this.lblCBBrand.Size = new System.Drawing.Size(97, 25);
            this.lblCBBrand.TabIndex = 44;
            this.lblCBBrand.Text = "Company";
            // 
            // lblsearchPlate
            // 
            this.lblsearchPlate.AutoSize = true;
            this.lblsearchPlate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsearchPlate.ForeColor = System.Drawing.Color.DarkOrange;
            this.lblsearchPlate.Location = new System.Drawing.Point(494, 120);
            this.lblsearchPlate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblsearchPlate.Name = "lblsearchPlate";
            this.lblsearchPlate.Size = new System.Drawing.Size(64, 25);
            this.lblsearchPlate.TabIndex = 47;
            this.lblsearchPlate.Text = "Name";
            // 
            // tbSearchDelName
            // 
            // 
            // 
            // 
            this.tbSearchDelName.CustomButton.Image = null;
            this.tbSearchDelName.CustomButton.Location = new System.Drawing.Point(142, 1);
            this.tbSearchDelName.CustomButton.Margin = new System.Windows.Forms.Padding(4);
            this.tbSearchDelName.CustomButton.Name = "";
            this.tbSearchDelName.CustomButton.Size = new System.Drawing.Size(41, 41);
            this.tbSearchDelName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbSearchDelName.CustomButton.TabIndex = 1;
            this.tbSearchDelName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbSearchDelName.CustomButton.UseSelectable = true;
            this.tbSearchDelName.CustomButton.Visible = false;
            this.tbSearchDelName.Lines = new string[0];
            this.tbSearchDelName.Location = new System.Drawing.Point(441, 148);
            this.tbSearchDelName.Margin = new System.Windows.Forms.Padding(4);
            this.tbSearchDelName.MaxLength = 32767;
            this.tbSearchDelName.Name = "tbSearchDelName";
            this.tbSearchDelName.PasswordChar = '\0';
            this.tbSearchDelName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbSearchDelName.SelectedText = "";
            this.tbSearchDelName.SelectionLength = 0;
            this.tbSearchDelName.SelectionStart = 0;
            this.tbSearchDelName.ShortcutsEnabled = true;
            this.tbSearchDelName.Size = new System.Drawing.Size(184, 43);
            this.tbSearchDelName.TabIndex = 56;
            this.tbSearchDelName.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.tbSearchDelName.UseSelectable = true;
            this.tbSearchDelName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbSearchDelName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // tblVehiclesBindingSource1
            // 
            this.tblVehiclesBindingSource1.DataMember = "tblVehicles";
            // 
            // tblVehiclesBindingSource3
            // 
            this.tblVehiclesBindingSource3.DataMember = "tblVehicles";
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Red;
            this.btnBack.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(156)))), ((int)(((byte)(42)))));
            this.btnBack.Location = new System.Drawing.Point(59, 186);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(267, 123);
            this.btnBack.TabIndex = 57;
            this.btnBack.Text = "Back";
            this.btnBack.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnBack.UseSelectable = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PusulaRAC.Properties.Resources.pusula2;
            this.pictureBox1.Location = new System.Drawing.Point(59, 37);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(130, 108);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 48;
            this.pictureBox1.TabStop = false;
            // 
            // tbSearchDelSurname
            // 
            // 
            // 
            // 
            this.tbSearchDelSurname.CustomButton.Image = null;
            this.tbSearchDelSurname.CustomButton.Location = new System.Drawing.Point(150, 1);
            this.tbSearchDelSurname.CustomButton.Margin = new System.Windows.Forms.Padding(4);
            this.tbSearchDelSurname.CustomButton.Name = "";
            this.tbSearchDelSurname.CustomButton.Size = new System.Drawing.Size(41, 41);
            this.tbSearchDelSurname.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbSearchDelSurname.CustomButton.TabIndex = 1;
            this.tbSearchDelSurname.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbSearchDelSurname.CustomButton.UseSelectable = true;
            this.tbSearchDelSurname.CustomButton.Visible = false;
            this.tbSearchDelSurname.Lines = new string[0];
            this.tbSearchDelSurname.Location = new System.Drawing.Point(678, 148);
            this.tbSearchDelSurname.Margin = new System.Windows.Forms.Padding(4);
            this.tbSearchDelSurname.MaxLength = 32767;
            this.tbSearchDelSurname.Name = "tbSearchDelSurname";
            this.tbSearchDelSurname.PasswordChar = '\0';
            this.tbSearchDelSurname.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbSearchDelSurname.SelectedText = "";
            this.tbSearchDelSurname.SelectionLength = 0;
            this.tbSearchDelSurname.SelectionStart = 0;
            this.tbSearchDelSurname.ShortcutsEnabled = true;
            this.tbSearchDelSurname.Size = new System.Drawing.Size(192, 43);
            this.tbSearchDelSurname.TabIndex = 53;
            this.tbSearchDelSurname.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.tbSearchDelSurname.UseSelectable = true;
            this.tbSearchDelSurname.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbSearchDelSurname.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
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
            // tbSearchDelID
            // 
            // 
            // 
            // 
            this.tbSearchDelID.CustomButton.Image = null;
            this.tbSearchDelID.CustomButton.Location = new System.Drawing.Point(144, 1);
            this.tbSearchDelID.CustomButton.Margin = new System.Windows.Forms.Padding(4);
            this.tbSearchDelID.CustomButton.Name = "";
            this.tbSearchDelID.CustomButton.Size = new System.Drawing.Size(41, 41);
            this.tbSearchDelID.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbSearchDelID.CustomButton.TabIndex = 1;
            this.tbSearchDelID.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbSearchDelID.CustomButton.UseSelectable = true;
            this.tbSearchDelID.CustomButton.Visible = false;
            this.tbSearchDelID.Lines = new string[0];
            this.tbSearchDelID.Location = new System.Drawing.Point(924, 148);
            this.tbSearchDelID.Margin = new System.Windows.Forms.Padding(4);
            this.tbSearchDelID.MaxLength = 32767;
            this.tbSearchDelID.Name = "tbSearchDelID";
            this.tbSearchDelID.PasswordChar = '\0';
            this.tbSearchDelID.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbSearchDelID.SelectedText = "";
            this.tbSearchDelID.SelectionLength = 0;
            this.tbSearchDelID.SelectionStart = 0;
            this.tbSearchDelID.ShortcutsEnabled = true;
            this.tbSearchDelID.Size = new System.Drawing.Size(186, 43);
            this.tbSearchDelID.TabIndex = 54;
            this.tbSearchDelID.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.tbSearchDelID.UseSelectable = true;
            this.tbSearchDelID.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbSearchDelID.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
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
            this.yearDataGridViewTextBoxColumn});
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
            this.gvListV.Location = new System.Drawing.Point(441, 271);
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
            this.gvListV.TabIndex = 51;
            this.gvListV.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.gvListV.UseStyleColors = true;
            // 
            // tblVehiclesBindingSource2
            // 
            this.tblVehiclesBindingSource2.DataMember = "tblVehicles";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::PusulaRAC.Properties.Resources.pusula;
            this.pictureBox2.Location = new System.Drawing.Point(197, 120);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(825, 526);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 50;
            this.pictureBox2.TabStop = false;
            // 
            // btnListV
            // 
            this.btnListV.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnListV.FontWeight = MetroFramework.MetroButtonWeight.Light;
            this.btnListV.Location = new System.Drawing.Point(441, 200);
            this.btnListV.Margin = new System.Windows.Forms.Padding(4);
            this.btnListV.Name = "btnListV";
            this.btnListV.Size = new System.Drawing.Size(669, 64);
            this.btnListV.TabIndex = 52;
            this.btnListV.Text = "Search";
            this.btnListV.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnListV.UseSelectable = true;
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
            this.brandDataGridViewTextBoxColumn.HeaderText = "Company";
            this.brandDataGridViewTextBoxColumn.Name = "brandDataGridViewTextBoxColumn";
            this.brandDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // modelDataGridViewTextBoxColumn
            // 
            this.modelDataGridViewTextBoxColumn.DataPropertyName = "Model";
            this.modelDataGridViewTextBoxColumn.HeaderText = "Company Type";
            this.modelDataGridViewTextBoxColumn.Name = "modelDataGridViewTextBoxColumn";
            this.modelDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // yearDataGridViewTextBoxColumn
            // 
            this.yearDataGridViewTextBoxColumn.DataPropertyName = "Year";
            this.yearDataGridViewTextBoxColumn.HeaderText = "Active Car Number";
            this.yearDataGridViewTextBoxColumn.Name = "yearDataGridViewTextBoxColumn";
            this.yearDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // CompanyHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1169, 683);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblModel);
            this.Controls.Add(this.lblCBBrand);
            this.Controls.Add(this.lblsearchPlate);
            this.Controls.Add(this.tbSearchDelName);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tbSearchDelSurname);
            this.Controls.Add(this.tbSearchDelID);
            this.Controls.Add(this.gvListV);
            this.Controls.Add(this.btnListV);
            this.Controls.Add(this.pictureBox2);
            this.Name = "CompanyHistory";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            ((System.ComponentModel.ISupportInitialize)(this.tblVehiclesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblVehiclesBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblVehiclesBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pusulaDBDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblVehiclesBindingSource4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvListV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblVehiclesBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource tblVehiclesBindingSource;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblModel;
        private System.Windows.Forms.Label lblCBBrand;
        private System.Windows.Forms.Label lblsearchPlate;
        private MetroFramework.Controls.MetroTextBox tbSearchDelName;
        private System.Windows.Forms.BindingSource tblVehiclesBindingSource1;
        private System.Windows.Forms.BindingSource tblVehiclesBindingSource3;
        private MetroFramework.Controls.MetroButton btnBack;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroTextBox tbSearchDelSurname;
        private PusulaDBDataSet3TableAdapters.tblVehiclesTableAdapter tblVehiclesTableAdapter3;
        private PusulaDBDataSet3 pusulaDBDataSet3;
        private System.Windows.Forms.BindingSource tblVehiclesBindingSource4;
        private MetroFramework.Controls.MetroTextBox tbSearchDelID;
        private MetroFramework.Controls.MetroGrid gvListV;
        private System.Windows.Forms.BindingSource tblVehiclesBindingSource2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private MetroFramework.Controls.MetroButton btnListV;
        private System.Windows.Forms.DataGridViewTextBoxColumn plateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn brandDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yearDataGridViewTextBoxColumn;
    }
}