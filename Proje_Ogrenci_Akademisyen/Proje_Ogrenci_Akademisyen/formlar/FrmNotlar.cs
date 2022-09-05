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
    public partial class FrmNotlar : Form
    {
        public FrmNotlar()
        {
            InitializeComponent();
        }
        OgrenciSinavEntities db = new OgrenciSinavEntities();
        

        

        private void FrmNotlar_Load(object sender, EventArgs e)
        {
            comboBox1.DisplayMember = "DersAd";
            comboBox1.ValueMember = "DersID";
            comboBox1.DataSource = db.TblDersler.ToList();
            comboBox2.DisplayMember = "DersAd";
            comboBox2.ValueMember = "DersID";
            comboBox2.DataSource = db.TblDersler.ToList();

        }

        private void btnekle_Click(object sender, EventArgs e)
        {
            TblNotlar t = new TblNotlar();
            t.Vize1 = byte.Parse(txtvize1.Text);
            t.Vize2 = byte.Parse(txtvize2.Text);
            t.Final = byte.Parse(txtfinal.Text);
            t.Quiz1 = byte.Parse(txtquiz1.Text);
            t.Quiz2 = byte.Parse(txtquiz2.Text);
            t.Ders = int.Parse(txtogrenci.Text);
            db.TblNotlar.Add(t);
            MessageBox.Show("Öğrenci not bilgisi için sisteme kaydedildi");


        }

        private void btnhesapla_Click(object sender, EventArgs e)
        {
            byte s1, s2, s3, q1, q2, proje;
            double ortalama;
            s1 = Convert.ToByte(txtvize1.Text);
            s2 = Convert.ToByte(txtvize2.Text);
            s3 = Convert.ToByte(txtfinal.Text);
            q1= Convert.ToByte(txtquiz1.Text);
            q2 = Convert.ToByte(txtquiz2.Text);
            proje = byte.Parse(txtproje.Text);
            ortalama = (s1 + s2 + s3 + q1 + q2 + proje) / 6;
            txtortalama.Text = ortalama.ToString();



        }

        private void btnlistele_Click(object sender, EventArgs e)
        {
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var degerler = from x in db.TblNotlar
                           select new
                           {
                               x.NotID,
                               x.Vize1,
                               x.Ders,
                               x.TblDersler.DersAd
                           };
            dataGridView1.DataSource = degerler.Where(y => y.Ders == 3).ToList();

        }
    }
}
