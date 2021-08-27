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
    public partial class FrmOyunBitti : Form
    {
        public FrmOyunBitti(int deneme, int sure)
        {
            InitializeComponent();
            lblDeneme.Text = deneme.ToString();
            lblSure.Text = sure.ToString();
        }

        private void btnOyunuKapat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnTekrarOyna_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmOyunMenu frmOyunAlani = new FrmOyunMenu();
            frmOyunAlani.ShowDialog();
        }
    }
}
