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
    public partial class game : Form
    {
        int menang = 0;
        int kalah = 0;
        string pesan = "Selamat Bermain";
        string pesan2 = "Ronde Selanjutnya";

        public game()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            textBox1.Text = pesan;
            textBox2.Text = menang.ToString();
            textBox3.Text = kalah.ToString();
            button1.Visible = false;
            pictureBox4.Visible = false;
            pictureBox5.Visible = false;
            pictureBox6.Visible = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            button1.Visible = true;

            Random acak = new Random();
            int nilai = acak.Next(1, 4);

            if (nilai == 1)
            {
                pictureBox4.Visible = true;
                textBox1.Text = "Anda Seri";
            }
            else if (nilai == 2)
            {
                pictureBox5.Visible = true;
                textBox1.Text = "Anda Kalah";
                kalah += 1;
            }
            else
            {
                pictureBox6.Visible = true;
                textBox1.Text = "Anda Menang";
                menang += 1;
            }
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            pictureBox1.Enabled = false;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            button1.Visible = true;

            Random acak = new Random();
            int nilai = acak.Next(1, 4);

            if (nilai == 1)
            {
                pictureBox4.Visible = true;
                textBox1.Text = "Anda Menang";
                menang += 1;
            }
            else if (nilai == 2)
            {
                pictureBox5.Visible = true;
                textBox1.Text = "Anda Seri";
            }
            else
            {
                pictureBox6.Visible = true;
                textBox1.Text = "Anda Kalah";
                kalah += 1;
            }
            pictureBox1.Visible = false;
            pictureBox3.Visible = false;
            pictureBox2.Enabled = false;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            button1.Visible = true;

            Random acak = new Random();
            int nilai = acak.Next(1, 4);

            if (nilai == 1)
            {
                pictureBox4.Visible = true;
                textBox1.Text = "Anda Kalah";
                kalah += 1;
            }
            else if (nilai == 2)
            {
                pictureBox5.Visible = true;
                textBox1.Text = "Anda Menang";
                menang += 1;
            }
            else
            {
                pictureBox6.Visible = true;
                textBox1.Text = "Anda Seri";
            }
            pictureBox2.Visible = false;
            pictureBox1.Visible = false;
            pictureBox3.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = true;
            pictureBox2.Visible = true;
            pictureBox3.Visible = true;
            pictureBox4.Visible = false;
            pictureBox5.Visible = false;
            pictureBox6.Visible = false;

            pictureBox1.Enabled = true;
            pictureBox2.Enabled = true;
            pictureBox3.Enabled = true;

            button1.Visible = false;
            textBox2.Text = menang.ToString();
            textBox3.Text = kalah.ToString();

            textBox1.Text = pesan2;

            if (menang == 3)
            {
                MessageBox.Show("Anda Adalah Sang Juara");
                menang = 0;
                kalah = 0;
                textBox1.Text = pesan;
                textBox2.Text = menang.ToString();
                textBox3.Text = kalah.ToString();
            }
            else if (kalah == 3)
            {
                MessageBox.Show("Kasian Anda Kalah Terus");
                menang = 0;
                kalah = 0;
                textBox1.Text = pesan;
                textBox2.Text = menang.ToString();
                textBox3.Text = kalah.ToString();

            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void buttonProfile_Click(object sender, EventArgs e)
        {
            profile f2 = new profile();
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
    }
}
