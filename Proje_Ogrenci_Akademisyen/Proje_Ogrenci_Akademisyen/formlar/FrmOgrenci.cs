using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Proje_Ogrenci_Akademisyen.Entity;

namespace Proje_Ogrenci_Akademisyen.formlar
{
    public partial class FrmOgrenci : Form
    {
        public FrmOgrenci()
        {
            InitializeComponent();
        }
        OgrenciSinavEntities db = new OgrenciSinavEntities();
        void listele()
        {
            var degerler = from x in db.TblOgrenci
                           select new
                           {
                               x.OgrID,
                               x.OgrAd,
                               x.OgrSoyad,
                               x.OgrNumara,
                               x.OgrSifre,
                               x.OgrMail,
                               x.OgrResim,
                               x.TblBolum.BolumAd
                           };
            dataGridView1.DataSource = degerler.ToList();
        }
        private void FrmOgrenci_Load(object sender, EventArgs e)
        {
            listele();

        }

        private void btnlistele_Click(object sender, EventArgs e)
        {
            listele();
        }
    }
}
