using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proje_Ogrenci_Akademisyen.formlar
{
    public partial class FrmGiris : Form
    {
        public FrmGiris()
        {
            InitializeComponent();
        }

        private void maskedTextBox2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

    

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if(txtnumara.Text== "00000" && txtsifre.Text=="000")
            {
                FrmHarita frm = new FrmHarita();
                frm.Hide();
                this.Hide();

            }
        }

        private void txtsifre_TextChanged(object sender, EventArgs e)
        {
            if(txtsifre.Text=="000" && txtnumara.Text=="00000")
            {
                FrmHarita frm = new FrmHarita();
                frm.Hide();
                this.Hide();

            }
        }
    }
}
