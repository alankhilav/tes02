using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coba
{
    public partial class Form1 : Form
    {
        Data data = new Data();

        public Form1()
        {
            InitializeComponent();
            
        }

        private void btnKirim_Click(object sender, EventArgs e)
        {
            if (tbPesan.Text != "")
            {
                rtbPesan.Text += "Anda\t: " + tbPesan.Text + "\nBot\t: " + data.proses(tbPesan.Text) + "\n";
                tbPesan.Text = "";
                tbPesan.Focus();
            }
            
        }

        private void tbPesan_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnKirim_Click(this, new EventArgs());
            }
        }
    }
}
