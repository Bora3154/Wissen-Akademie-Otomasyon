
using DersaneOtomasyonu.DAL.DataModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DersaneOtomasyonu.BLL.Repository;

namespace DersaneOtomasyonu
{
    public partial class OgretmenKayitt : Form
    {

        public OgretmenKayitt()
        {
            InitializeComponent();
        }
        int bransid;
        OgretmenKayitRepository OkR = new OgretmenKayitRepository();
        DersaneOtomasyonuEntities1 ent = new DersaneOtomasyonuEntities1();
        private void OgretmenKayit_Load(object sender, EventArgs e)
        {

            rdBay.Checked = true;
            this.Top = 0;
            this.Left = 0;
            BranslarGetir();
            txtOgretmenAdiSoyadi.Focus();
        }

        private void BransGetir()
        {
            string brans = cbBrans.SelectedItem.ToString();
            bransid = Convert.ToInt32((from k in ent.Branslar
                                       where k.Brans == brans
                                       select k.IDBrans).First());
        }
        private void BranslarGetir()
        {
            var Sonuc = from k in ent.Branslar
                        select k.Brans;

            cbBrans.DataSource = Sonuc.ToList();
        }
        void Clear()
        {
            txtOgretmenAdiSoyadi.Text = "";
            txtOgretmenCepTel.Text = "";
            txtOgretmenEvAdresi.Text = "";
            txtOgretmenEvTel.Text = "";
            txtOgretmenMaas.Text = "";
            txtOgretmenMail.Text = "";
            txtOgretmenSehir.Text = "";
            txtOgretmenSemt.Text = "";
            txtOgretmenTcKimlik.Text = "";
            CbPostakodu.Text = "";
            rdBay.Checked = true;
            rdBayan.Checked = false;
        }

        private void btnOgretmenKaydet_Click(object sender, EventArgs e)
        {
            
                if (txtOgretmenTcKimlik.Text.Trim() != "" && txtOgretmenAdiSoyadi.Text.Trim() != "" && txtOgretmenCepTel.Text.Trim() != "" && txtOgretmenEvTel.Text.Trim() != "" && txtOgretmenMaas.Text.Trim() != "" && txtOgretmenMail.Text.Trim() != "" && txtOgretmenSehir.Text.Trim() != "" && txtOgretmenSemt.Text.Trim() != "")
                {
                    OgretmenKayit ogrtmn = new OgretmenKayit();
                    ogrtmn.OgretmenAdi = txtOgretmenAdiSoyadi.Text;
                    ogrtmn.OgretmenTcKimlikNo = txtOgretmenTcKimlik.Text;
                    ogrtmn.OgretmenAdres = txtOgretmenEvAdresi.Text;
                    ogrtmn.OgretmenCepTel = txtOgretmenCepTel.Text;
                    ogrtmn.OgretmenEvTel = txtOgretmenEvTel.Text;
                    ogrtmn.OgretmenMaas = Convert.ToDecimal(txtOgretmenMaas.Text);
                    ogrtmn.OgretmenMailAdresi = txtOgretmenMail.Text;
                    ogrtmn.OgretmenPostaKodu = CbPostakodu.Text;
                    ogrtmn.OgretmenSehir = txtOgretmenSehir.Text;
                    ogrtmn.OgretmenSemt = txtOgretmenSemt.Text;
                    ogrtmn.IDBrans = bransid;
                    if (rdBay.Checked == true)
                    {
                        ogrtmn.OgretmenCinsiyet = rdBay.Text;
                    }
                    else
                    {
                        ogrtmn.OgretmenCinsiyet = rdBayan.Text;
                    }
                    OkR.Ekle(ogrtmn);
                    MessageBox.Show("İşleminiz Başarıyla Gerçekleşmiştir !", "# ÖĞRETMEN KAYIT İŞLEMİ GERÇEKLEŞTİ #");
                    Clear();
                }
            else
            {
                MessageBox.Show("Öğretmen Bilgilerini eksik girdiniz !", "Bigileri Tam Girdiğinizden Emiz Olunuz!");
            }
   
        }
        private void cbBrans_SelectedIndexChanged(object sender, EventArgs e)
        {
            BransGetir();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

    }
}
