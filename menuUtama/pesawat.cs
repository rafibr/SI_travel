﻿using System;
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
    public partial class pesawat : Form
    {
        public pesawat()
        {
            InitializeComponent();
        }

        

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
            panelLeft.Height = buttonReservasi.Height;
            panelLeft.Top = buttonReservasi.Top;
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonHome_Click(object sender, EventArgs e)
        {
            home f2 = new home();
            f2.Show();
            this.Close();
        }

        private void buttonTransaksi_Click(object sender, EventArgs e)
        {
            panelLeft.Height = buttonReservasi.Height;
            panelLeft.Top = buttonReservasi.Top;

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
    }
}
