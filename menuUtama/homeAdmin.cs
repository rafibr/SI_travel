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
    public partial class homeAdmin : Form
    {
        public homeAdmin()
        {
            InitializeComponent();
        }

        private void buttonHome_Click(object sender, EventArgs e)
        {
            panelLeft.Height = buttonHome.Height;
            panelLeft.Top = buttonHome.Top;
        }

        private void buttonReservasi_Click(object sender, EventArgs e)
        {
            panelLeft.Height = buttonTiket.Height;
            panelLeft.Top = buttonTiket.Top;
        }

        private void buttonTransaksi_Click(object sender, EventArgs e)
        {
            panelLeft.Height = buttonTransaksi.Height;
            panelLeft.Top = buttonTransaksi.Top;
        }

        private void buttonAbout_Click(object sender, EventArgs e)
        {
            panelLeft.Height = buttonAbout.Height;
            panelLeft.Top = buttonAbout.Top;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonHome_Click_1(object sender, EventArgs e)
        {
            panelLeft.Height = buttonHome.Height;
            panelLeft.Top = buttonHome.Top;

            home f2 = new home();
            f2.Show();
            this.Hide();
        }

        private void buttonReservasi_Click_1(object sender, EventArgs e)
        {
            panelLeft.Height = buttonTiket.Height;
            panelLeft.Top = buttonTiket.Top;
            
        }

        private void buttonTransaksi_Click_1(object sender, EventArgs e)
        {
            panelLeft.Height    = buttonTransaksi.Height;
            panelLeft.Top       = buttonTransaksi.Top;

            transaksi f2 = new transaksi();
            f2.Show();
            this.Hide();
        }

        private void buttonAbout_Click_1(object sender, EventArgs e)
        {
            panelLeft.Height = buttonAbout.Height;
            panelLeft.Top = buttonAbout.Top;


        }

        private void panelLeft_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonMax_Click(object sender, EventArgs e)
        {
            
        }

        private void buttonMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void buttonClose_Click_1(object sender, EventArgs e)
        {
            this.Close();
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

        private void button1_Click_1(object sender, EventArgs e)
        {
            panelLeft.Height    = buttonHotel.Height;
            panelLeft.Top       = buttonHotel.Top;

            reservasiHotel f2 = new reservasiHotel();
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

        private void buttonProfile_Click(object sender, EventArgs e)
        {
            pesawat f2 = new pesawat();
            f2.Show();
            this.Hide();
        }
    }
}
