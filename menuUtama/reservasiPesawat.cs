using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace menuUtama
{
    public partial class reservasiPesawat : Form
    {
        public reservasiPesawat()
        {
            InitializeComponent();
        }

        

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBoxAll(object sender, EventArgs e)
        {
          


        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            panel2.Height = vScrollBar1.Value;
                panel3.Height = vScrollBar1.Value;
            panel4.Height = vScrollBar1.Value;
            panel5.Height = vScrollBar1.Value;
            panel6.Height = vScrollBar1.Value;
            panel7.Height = vScrollBar1.Value;
        }

        private void buttonHome_Click(object sender, EventArgs e)
        {
            panelLeft.Height = buttonHome.Height;
            panelLeft.Top = buttonHome.Top;

            home f2 = new home();
            f2.Show();
            this.Hide();
        }

        private void buttonTiket_Click(object sender, EventArgs e)
        {
            panelLeft.Height = buttonTiket.Height;
            panelLeft.Top = buttonTiket.Top;

            reservasiPesawat f2 = new reservasiPesawat();
            f2.Show();
            this.Hide();
        }

        private void buttonTransaksi_Click(object sender, EventArgs e)
        {
            panelLeft.Height = buttonTransaksi.Height;
            panelLeft.Top = buttonTransaksi.Top;

            transaksi f2 = new transaksi();
            f2.Show();
            this.Hide();
        }

        private void buttonMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void buttonMax_Click(object sender, EventArgs e)
        {
            if (WindowState.ToString() == "Normal")
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonTiket_Click_1(object sender, EventArgs e)
        {
            panelLeft.Height = buttonTiket.Height;
            panelLeft.Top = buttonTiket.Top;

            reservasiPesawat f2 = new reservasiPesawat();
            f2.Show();
            this.Hide();
        }

        private void buttonHotel_Click(object sender, EventArgs e)
        {
            panelLeft.Height = buttonHotel.Height;
            panelLeft.Top = buttonHotel.Top;

            reservasiHotel f2 = new reservasiHotel();
            f2.Show();
            this.Hide();
        }

        private void buttonProfile_Click(object sender, EventArgs e)
        {
            profile f2 = new profile();
            f2.Show();
            this.Hide();
        }

        private void buttonHome_Click_1(object sender, EventArgs e)
        {
            panelLeft.Height = buttonHome.Height;
            panelLeft.Top = buttonHome.Top;

            home f2 = new home();
            f2.Show();
            this.Hide();
        }

        private void buttonTransaksi_Click_1(object sender, EventArgs e)
        {
            panelLeft.Height = buttonTransaksi.Height;
            panelLeft.Top = buttonTransaksi.Top;

            transaksi f2 = new transaksi();
            f2.Show();
            this.Hide();
        }

        private void buttonAbout_Click(object sender, EventArgs e)
        {
            panelLeft.Height = buttonAbout.Height;
            panelLeft.Top = buttonAbout.Top;

            about f2 = new about();
            f2.Show();
            this.Hide();
        }

        private void buttonMin_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void buttonMax_Click_1(object sender, EventArgs e)
        {
            if (WindowState.ToString() == "Normal")
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void buttonClose_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panelLeft.Height = buttonTransaksi.Height;
            panelLeft.Top = buttonTransaksi.Top;

            transaksi f2 = new transaksi();
            f2.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panelLeft.Height = buttonTransaksi.Height;
            panelLeft.Top = buttonTransaksi.Top;

            transaksi f2 = new transaksi();
            f2.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panelLeft.Height = buttonTransaksi.Height;
            panelLeft.Top = buttonTransaksi.Top;

            transaksi f2 = new transaksi();
            f2.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            panelLeft.Height = buttonTransaksi.Height;
            panelLeft.Top = buttonTransaksi.Top;

            transaksi f2 = new transaksi();
            f2.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            panelLeft.Height = buttonTransaksi.Height;
            panelLeft.Top = buttonTransaksi.Top;

            transaksi f2 = new transaksi();
            f2.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            panelLeft.Height = buttonTransaksi.Height;
            panelLeft.Top = buttonTransaksi.Top;

            transaksi f2 = new transaksi();
            f2.Show();
            this.Hide();
        }
    }
}
