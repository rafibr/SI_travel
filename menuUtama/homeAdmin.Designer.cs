namespace menuUtama
{
    partial class homeAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(homeAdmin));
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "0001",
            "Banjarmasin",
            "Surabaya",
            "2",
            "2",
            "Rp. 2000000"}, -1);
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("0002");
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem("0003");
            System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem("0004");
            this.panelLeft = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.buttonProfile = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonHotel = new System.Windows.Forms.Button();
            this.buttonTiket = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonMin = new System.Windows.Forms.Button();
            this.buttonMax = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.kd_transaksi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Asal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Tujuan = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Jlh_dewasa = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.jlh_anak = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Total = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelLeft
            // 
            this.panelLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(185)))), ((int)(((byte)(244)))));
            this.panelLeft.Location = new System.Drawing.Point(190, 135);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(10, 74);
            this.panelLeft.TabIndex = 6;
            this.panelLeft.Paint += new System.Windows.Forms.PaintEventHandler(this.panelLeft_Paint);
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
            this.label9.Location = new System.Drawing.Point(78, 102);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 14);
            this.label9.TabIndex = 10;
            this.label9.Text = "Admin";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(219)))), ((int)(((byte)(220)))));
            this.panel1.Controls.Add(this.panelLeft);
            this.panel1.Controls.Add(this.buttonHotel);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.buttonTiket);
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
            this.buttonHotel.Location = new System.Drawing.Point(0, 206);
            this.buttonHotel.Name = "buttonHotel";
            this.buttonHotel.Size = new System.Drawing.Size(194, 74);
            this.buttonHotel.TabIndex = 7;
            this.buttonHotel.Text = "Transaksi Hotel";
            this.buttonHotel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonHotel.UseVisualStyleBackColor = false;
            this.buttonHotel.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // buttonTiket
            // 
            this.buttonTiket.BackColor = System.Drawing.Color.Transparent;
            this.buttonTiket.FlatAppearance.BorderSize = 0;
            this.buttonTiket.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTiket.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTiket.Image = ((System.Drawing.Image)(resources.GetObject("buttonTiket.Image")));
            this.buttonTiket.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonTiket.Location = new System.Drawing.Point(0, 132);
            this.buttonTiket.Name = "buttonTiket";
            this.buttonTiket.Size = new System.Drawing.Size(194, 74);
            this.buttonTiket.TabIndex = 2;
            this.buttonTiket.Text = "Transaksi Pesawat";
            this.buttonTiket.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonTiket.UseVisualStyleBackColor = false;
            this.buttonTiket.Click += new System.EventHandler(this.buttonTiket_Click);
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
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.kd_transaksi,
            this.Asal,
            this.Tujuan,
            this.Jlh_dewasa,
            this.jlh_anak,
            this.Total});
            this.listView1.GridLines = true;
            this.listView1.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3,
            listViewItem4});
            this.listView1.Location = new System.Drawing.Point(222, 34);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(552, 454);
            this.listView1.TabIndex = 24;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // kd_transaksi
            // 
            this.kd_transaksi.Text = "Kode Transaksi";
            this.kd_transaksi.Width = 89;
            // 
            // Asal
            // 
            this.Asal.Text = "Asal";
            this.Asal.Width = 71;
            // 
            // Tujuan
            // 
            this.Tujuan.Text = "Tujuan";
            // 
            // Jlh_dewasa
            // 
            this.Jlh_dewasa.Text = "Jumlah Dewasa";
            this.Jlh_dewasa.Width = 102;
            // 
            // jlh_anak
            // 
            this.jlh_anak.Text = "Jumlah Anak";
            this.jlh_anak.Width = 116;
            // 
            // Total
            // 
            this.Total.Text = "Total";
            this.Total.Width = 91;
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Location = new System.Drawing.Point(352, 520);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 25;
            this.button1.Text = "Edit";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Location = new System.Drawing.Point(586, 520);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 26;
            this.button2.Text = "Delete";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // homeAdmin
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(50)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "homeAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Come On!";
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button buttonTiket;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button buttonMin;
        private System.Windows.Forms.Button buttonMax;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button buttonProfile;
        private System.Windows.Forms.Button buttonHotel;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader kd_transaksi;
        private System.Windows.Forms.ColumnHeader Asal;
        private System.Windows.Forms.ColumnHeader Tujuan;
        private System.Windows.Forms.ColumnHeader Jlh_dewasa;
        private System.Windows.Forms.ColumnHeader jlh_anak;
        private System.Windows.Forms.ColumnHeader Total;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

