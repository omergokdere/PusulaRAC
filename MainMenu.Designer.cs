namespace PusulaRAC
{
    partial class MainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.label1 = new System.Windows.Forms.Label();
            this.btnVehOP = new MetroFramework.Controls.MetroButton();
            this.btnTrace = new MetroFramework.Controls.MetroButton();
            this.btnPayments = new MetroFramework.Controls.MetroButton();
            this.btnNotifications = new MetroFramework.Controls.MetroButton();
            this.btnReport = new MetroFramework.Controls.MetroButton();
            this.btnHistory = new MetroFramework.Controls.MetroButton();
            this.btnCliOp = new MetroFramework.Controls.MetroButton();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnRAC = new MetroFramework.Controls.MetroButton();
            this.btnLogout = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(156)))), ((int)(((byte)(42)))));
            this.label1.Location = new System.Drawing.Point(230, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(262, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "RENT A CAR SYSTEM";
            // 
            // btnVehOP
            // 
            this.btnVehOP.AutoSize = true;
            this.btnVehOP.Location = new System.Drawing.Point(97, 163);
            this.btnVehOP.Name = "btnVehOP";
            this.btnVehOP.Size = new System.Drawing.Size(200, 100);
            this.btnVehOP.TabIndex = 5;
            this.btnVehOP.Text = "Car Operations";
            this.btnVehOP.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnVehOP.UseSelectable = true;
            this.btnVehOP.Click += new System.EventHandler(this.btnVehOP_Click);
            // 
            // btnTrace
            // 
            this.btnTrace.AutoSize = true;
            this.btnTrace.Location = new System.Drawing.Point(97, 269);
            this.btnTrace.Name = "btnTrace";
            this.btnTrace.Size = new System.Drawing.Size(200, 100);
            this.btnTrace.TabIndex = 5;
            this.btnTrace.Text = "Trace Cars";
            this.btnTrace.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnTrace.UseSelectable = true;
            this.btnTrace.Click += new System.EventHandler(this.btnVehOP_Click);
            // 
            // btnPayments
            // 
            this.btnPayments.AutoSize = true;
            this.btnPayments.Location = new System.Drawing.Point(333, 269);
            this.btnPayments.Name = "btnPayments";
            this.btnPayments.Size = new System.Drawing.Size(200, 100);
            this.btnPayments.TabIndex = 5;
            this.btnPayments.Text = "Payments";
            this.btnPayments.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnPayments.UseSelectable = true;
            this.btnPayments.Click += new System.EventHandler(this.btnVehOP_Click);
            // 
            // btnNotifications
            // 
            this.btnNotifications.AutoSize = true;
            this.btnNotifications.Location = new System.Drawing.Point(568, 269);
            this.btnNotifications.Name = "btnNotifications";
            this.btnNotifications.Size = new System.Drawing.Size(200, 100);
            this.btnNotifications.TabIndex = 5;
            this.btnNotifications.Text = "Notifications";
            this.btnNotifications.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnNotifications.UseSelectable = true;
            this.btnNotifications.Click += new System.EventHandler(this.btnVehOP_Click);
            // 
            // btnReport
            // 
            this.btnReport.AutoSize = true;
            this.btnReport.Location = new System.Drawing.Point(97, 369);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(200, 100);
            this.btnReport.TabIndex = 5;
            this.btnReport.Text = "Reports";
            this.btnReport.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnReport.UseSelectable = true;
            this.btnReport.Click += new System.EventHandler(this.btnVehOP_Click);
            // 
            // btnHistory
            // 
            this.btnHistory.AutoSize = true;
            this.btnHistory.Location = new System.Drawing.Point(333, 369);
            this.btnHistory.Name = "btnHistory";
            this.btnHistory.Size = new System.Drawing.Size(200, 100);
            this.btnHistory.TabIndex = 5;
            this.btnHistory.Text = "History";
            this.btnHistory.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnHistory.UseSelectable = true;
            this.btnHistory.Click += new System.EventHandler(this.btnVehOP_Click);
            // 
            // btnCliOp
            // 
            this.btnCliOp.Location = new System.Drawing.Point(333, 170);
            this.btnCliOp.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCliOp.Name = "btnCliOp";
            this.btnCliOp.Size = new System.Drawing.Size(200, 93);
            this.btnCliOp.TabIndex = 6;
            this.btnCliOp.Text = "Client Operations";
            this.btnCliOp.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnCliOp.UseSelectable = true;
            this.btnCliOp.Click += new System.EventHandler(this.btnCliOp_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::PusulaRAC.Properties.Resources.pusula2;
            this.pictureBox2.Location = new System.Drawing.Point(1, 19);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(130, 108);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PusulaRAC.Properties.Resources.pusula;
            this.pictureBox1.Location = new System.Drawing.Point(233, 80);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(437, 404);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // btnRAC
            // 
            this.btnRAC.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnRAC.Location = new System.Drawing.Point(568, 170);
            this.btnRAC.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnRAC.Name = "btnRAC";
            this.btnRAC.Size = new System.Drawing.Size(200, 93);
            this.btnRAC.TabIndex = 7;
            this.btnRAC.Text = "Rent A Car";
            this.btnRAC.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnRAC.UseSelectable = true;
            this.btnRAC.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(568, 375);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(200, 94);
            this.btnLogout.TabIndex = 8;
            this.btnLogout.Text = "Logout";
            this.btnLogout.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnLogout.UseSelectable = true;
            this.btnLogout.Click += new System.EventHandler(this.metroButton1_Click_1);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(877, 555);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnRAC);
            this.Controls.Add(this.btnCliOp);
            this.Controls.Add(this.btnHistory);
            this.Controls.Add(this.btnPayments);
            this.Controls.Add(this.btnReport);
            this.Controls.Add(this.btnNotifications);
            this.Controls.Add(this.btnTrace);
            this.Controls.Add(this.btnVehOP);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(100, 50);
            this.MaximizeBox = false;
            this.Name = "MainMenu";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.TransparencyKey = System.Drawing.SystemColors.ButtonFace;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private MetroFramework.Controls.MetroButton btnVehOP;
        private MetroFramework.Controls.MetroButton btnTrace;
        private MetroFramework.Controls.MetroButton btnPayments;
        private MetroFramework.Controls.MetroButton btnNotifications;
        private MetroFramework.Controls.MetroButton btnReport;
        private MetroFramework.Controls.MetroButton btnHistory;
        private MetroFramework.Controls.MetroButton btnCliOp;
        private MetroFramework.Controls.MetroButton btnRAC;
        private MetroFramework.Controls.MetroButton btnLogout;
    }
}