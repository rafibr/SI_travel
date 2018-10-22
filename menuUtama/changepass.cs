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
            

            DialogResult dialogResult = MessageBox.Show("Yakin ingin mengubah password ?", "Confirmation", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                //code yes goes here
                this.Close();
            }
            else if (dialogResult == DialogResult.No)
            {
                //code no goes here
            }

        }
    }
}
