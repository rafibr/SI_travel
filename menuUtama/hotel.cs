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
    public partial class hotel : Form
    {
        public hotel()
        {
            InitializeComponent();
        }

        

        



        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Data sudah benar ?", "Confirmation", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                //code yes goes here

                //resetting input
                namaBox.ResetText();
                telpBox.ResetText();
                emailBox.ResetText();
                tujuan.Text = "-";
                label10.Text = "-";
                tgl.Text = "-";
                total.Text = "-";
                label13.Text = "-";
                dateTimePicker1.ResetText();
                dateTimePicker2.ResetText();
            }
            else if (dialogResult == DialogResult.No)
            {
                //code no goes here
            }
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

        private void buttonReset_Click(object sender, EventArgs e)
        {
            namaBox.ResetText();
            telpBox.ResetText();
            emailBox.ResetText();
            tujuan.Text = "-";
            label10.Text = "-";
            tgl.Text = "-";
            total.Text = "-";
            label13.Text = "-";
            dateTimePicker1.ResetText();
            dateTimePicker2.ResetText();
        }
    }
}
