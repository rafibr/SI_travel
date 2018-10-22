using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace menuUtama
{
    public partial class transaksi : Form
    {
        public transaksi()
        {
            InitializeComponent();
            oldColor = buttonHotel.BackColor;
        }

        Color oldColor;
        Color newColor = Color.FromArgb(0, Color.MediumAquamarine);  // your pick, including Black



        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void buttonReservasi_Click(object sender, EventArgs e)
        {
            panelLeft.Height = buttonTiket.Height;
            panelLeft.Top = buttonTiket.Top;

            reservasiPesawat f2 = new reservasiPesawat();
            f2.Show();
            this.Hide();

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonHome_Click(object sender, EventArgs e)
        {
            panelLeft.Height = buttonHome.Height;
            panelLeft.Top = buttonHome.Top;

            home f2 = new home();
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

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void buttonMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void roundButton2_MouseEnter(object sender, EventArgs e)
        {
            
        }

        private void roundButton1_MouseHover(object sender, EventArgs e)
        {
            roundButton1.BackColor = Color.GhostWhite;
        }

        private void roundButton2_MouseHover(object sender, EventArgs e)
        {
            roundButton2.BackColor = Color.GhostWhite;
        }

        private void roundButton1_MouseLeave(object sender, EventArgs e)
        {
            var cc2 = System.Drawing.ColorTranslator.FromHtml("#007EA7");
            roundButton1.BackColor = cc2;
        }

        private void roundButton2_MouseLeave(object sender, EventArgs e)
        {
            var cc2 = System.Drawing.ColorTranslator.FromHtml("#007EA7");
            roundButton2.BackColor = cc2;
        }

        private void buttonProfile_Click(object sender, EventArgs e)
        {
            profile f2 = new profile();
            f2.Show();
            this.Hide();
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            panelLeft.Height = buttonHotel.Height;
            panelLeft.Top = buttonHotel.Top;

            reservasiHotel f2 = new reservasiHotel();
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

        private void roundButton1_Click(object sender, EventArgs e)
        {
            pesawat f2 = new pesawat();
            f2.Show();
            this.Hide();
        }

        private void roundButton2_Click(object sender, EventArgs e)
        {
            hotel f2 = new hotel();
            f2.Show();
            this.Hide();
        }
    }
}
