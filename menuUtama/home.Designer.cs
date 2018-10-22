namespace menuUtama
{
    partial class home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(home));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panelLeft = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.buttonProfile = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonHotel = new System.Windows.Forms.Button();
            this.buttonAbout = new System.Windows.Forms.Button();
            this.buttonTransaksi = new System.Windows.Forms.Button();
            this.buttonTiket = new System.Windows.Forms.Button();
            this.buttonHome = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonMin = new System.Windows.Forms.Button();
            this.buttonMax = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(263, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(279, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "WELCOME TO OUR APPLICATION";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(396, 490);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(340, 23);
            this.label2.TabIndex = 5;
            this.label2.Text = "LET\'S GO AROUND THE WORLD WITH US";
            // 
            // panelLeft
            // 
            this.panelLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(185)))), ((int)(((byte)(244)))));
            this.panelLeft.Location = new System.Drawing.Point(190, 135);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(10, 74);
            this.panelLeft.TabIndex = 6;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(185)))), ((int)(((byte)(244)))));
            this.panel3.Controls.Add(this.buttonProfile);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 133);
            this.panel3.TabIndex = 5;
            // 
            // buttonProfile
            // 
            this.buttonProfile.BackgroundImage = global::menuUtama.Properties.Resources.download__5_;
            this.buttonProfile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonProfile.Location = new System.Drawing.Point(50, 13);
            this.buttonProfile.Name = "buttonProfile";
            this.buttonProfile.Size = new System.Drawing.Size(99, 86);
            this.buttonProfile.TabIndex = 11;
            this.buttonProfile.UseVisualStyleBackColor = true;
            this.buttonProfile.Click += new System.EventHandler(this.buttonProfile_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Showcard Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(70, 102);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 14);
            this.label9.TabIndex = 10;
            this.label9.Text = "IbnuKun";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(219)))), ((int)(((byte)(220)))));
            this.panel1.Controls.Add(this.buttonHotel);
            this.panel1.Controls.Add(this.panelLeft);
            this.panel1.Controls.Add(this.buttonAbout);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.buttonTransaksi);
            this.panel1.Controls.Add(this.buttonTiket);
            this.panel1.Controls.Add(this.buttonHome);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 600);
            this.panel1.TabIndex = 7;
            // 
            // buttonHotel
            // 
            this.buttonHotel.BackColor = System.Drawing.Color.Transparent;
            this.buttonHotel.FlatAppearance.BorderSize = 0;
            this.buttonHotel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHotel.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonHotel.Image = global::menuUtama.Properties.Resources.hotelicon;
            this.buttonHotel.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonHotel.Location = new System.Drawing.Point(3, 289);
            this.buttonHotel.Name = "buttonHotel";
            this.buttonHotel.Size = new System.Drawing.Size(194, 74);
            this.buttonHotel.TabIndex = 7;
            this.buttonHotel.Text = "Cek Kamar Hotel";
            this.buttonHotel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonHotel.UseVisualStyleBackColor = false;
            this.buttonHotel.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // buttonAbout
            // 
            this.buttonAbout.BackColor = System.Drawing.Color.Transparent;
            this.buttonAbout.FlatAppearance.BorderSize = 0;
            this.buttonAbout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAbout.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAbout.Image = ((System.Drawing.Image)(resources.GetObject("buttonAbout.Image")));
            this.buttonAbout.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonAbout.Location = new System.Drawing.Point(3, 449);
            this.buttonAbout.Name = "buttonAbout";
            this.buttonAbout.Size = new System.Drawing.Size(194, 74);
            this.buttonAbout.TabIndex = 6;
            this.buttonAbout.Text = "About";
            this.buttonAbout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonAbout.UseVisualStyleBackColor = false;
            this.buttonAbout.Click += new System.EventHandler(this.buttonAbout_Click_1);
            // 
            // buttonTransaksi
            // 
            this.buttonTransaksi.BackColor = System.Drawing.Color.Transparent;
            this.buttonTransaksi.FlatAppearance.BorderSize = 0;
            this.buttonTransaksi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTransaksi.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTransaksi.Image = ((System.Drawing.Image)(resources.GetObject("buttonTransaksi.Image")));
            this.buttonTransaksi.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonTransaksi.Location = new System.Drawing.Point(3, 369);
            this.buttonTransaksi.Name = "buttonTransaksi";
            this.buttonTransaksi.Size = new System.Drawing.Size(194, 74);
            this.buttonTransaksi.TabIndex = 3;
            this.buttonTransaksi.Text = "Transaksi";
            this.buttonTransaksi.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonTransaksi.UseVisualStyleBackColor = false;
            this.buttonTransaksi.Click += new System.EventHandler(this.buttonTransaksi_Click_1);
            // 
            // buttonTiket
            // 
            this.buttonTiket.BackColor = System.Drawing.Color.Transparent;
            this.buttonTiket.FlatAppearance.BorderSize = 0;
            this.buttonTiket.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTiket.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTiket.Image = ((System.Drawing.Image)(resources.GetObject("buttonTiket.Image")));
            this.buttonTiket.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonTiket.Location = new System.Drawing.Point(3, 215);
            this.buttonTiket.Name = "buttonTiket";
            this.buttonTiket.Size = new System.Drawing.Size(194, 74);
            this.buttonTiket.TabIndex = 2;
            this.buttonTiket.Text = "Tiket Pesawat";
            this.buttonTiket.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonTiket.UseVisualStyleBackColor = false;
            this.buttonTiket.Click += new System.EventHandler(this.buttonTiket_Click);
            // 
            // buttonHome
            // 
            this.buttonHome.BackColor = System.Drawing.Color.Transparent;
            this.buttonHome.FlatAppearance.BorderSize = 0;
            this.buttonHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHome.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonHome.Image = ((System.Drawing.Image)(resources.GetObject("buttonHome.Image")));
            this.buttonHome.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonHome.Location = new System.Drawing.Point(3, 135);
            this.buttonHome.Name = "buttonHome";
            this.buttonHome.Size = new System.Drawing.Size(194, 74);
            this.buttonHome.TabIndex = 1;
            this.buttonHome.Text = "Home";
            this.buttonHome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonHome.UseVisualStyleBackColor = false;
            this.buttonHome.Click += new System.EventHandler(this.buttonHome_Click_1);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(219)))), ((int)(((byte)(220)))));
            this.panel2.Controls.Add(this.buttonMin);
            this.panel2.Controls.Add(this.buttonMax);
            this.panel2.Controls.Add(this.buttonClose);
            this.panel2.Location = new System.Drawing.Point(199, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(600, 29);
            this.panel2.TabIndex = 23;
            // 
            // buttonMin
            // 
            this.buttonMin.BackgroundImage = global::menuUtama.Properties.Resources.minimize;
            this.buttonMin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonMin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonMin.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(219)))), ((int)(((byte)(220)))));
            this.buttonMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMin.Location = new System.Drawing.Point(498, 2);
            this.buttonMin.Name = "buttonMin";
            this.buttonMin.Size = new System.Drawing.Size(30, 26);
            this.buttonMin.TabIndex = 2;
            this.buttonMin.UseVisualStyleBackColor = true;
            this.buttonMin.Click += new System.EventHandler(this.buttonMin_Click_1);
            // 
            // buttonMax
            // 
            this.buttonMax.BackgroundImage = global::menuUtama.Properties.Resources.maximize;
            this.buttonMax.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonMax.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonMax.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(219)))), ((int)(((byte)(220)))));
            this.buttonMax.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMax.Location = new System.Drawing.Point(534, 2);
            this.buttonMax.Name = "buttonMax";
            this.buttonMax.Size = new System.Drawing.Size(30, 26);
            this.buttonMax.TabIndex = 1;
            this.buttonMax.UseVisualStyleBackColor = true;
            this.buttonMax.Click += new System.EventHandler(this.buttonMax_Click_1);
            // 
            // buttonClose
            // 
            this.buttonClose.BackgroundImage = global::menuUtama.Properties.Resources.cross;
            this.buttonClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonClose.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(219)))), ((int)(((byte)(220)))));
            this.buttonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClose.Location = new System.Drawing.Point(570, 2);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(30, 26);
            this.buttonClose.TabIndex = 0;
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click_1);
            // 
            // home
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(50)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Come On!";
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Button buttonAbout;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button buttonTransaksi;
        private System.Windows.Forms.Button buttonTiket;
        private System.Windows.Forms.Button buttonHome;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button buttonMin;
        private System.Windows.Forms.Button buttonMax;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button buttonProfile;
        private System.Windows.Forms.Button buttonHotel;
    }
}

