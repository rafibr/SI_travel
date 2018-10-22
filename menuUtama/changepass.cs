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
    public partial class changepass : Form
    {
        public changepass()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            home f2 = new home();
            f2.Show();
            this.Hide();
        }
    }
}
