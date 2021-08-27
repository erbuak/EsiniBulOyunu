using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EsiniBulOyunu
{
    public partial class FrmOyunMenu : Form
    {

        FrmOyunAlani frmOyunAlani;
        public FrmOyunMenu()
        {
            InitializeComponent();
        }

        private void FrmOyunMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btn2x2_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmOyunAlani = new FrmOyunAlani(2);
            frmOyunAlani.ShowDialog();
        }

        private void btn4x4_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmOyunAlani = new FrmOyunAlani(4);
            frmOyunAlani.ShowDialog();
        }

        private void btn8x8_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmOyunAlani = new FrmOyunAlani(8);
            frmOyunAlani.ShowDialog();         
        }
    }
}
