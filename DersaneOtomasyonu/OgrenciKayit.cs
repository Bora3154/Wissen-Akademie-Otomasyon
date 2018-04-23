
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

    public partial class OgrenciKayit : Form
    {
        public OgrenciKayit()
        {
            InitializeComponent();
        }
        int odevid;
        int ogrenciid;
        int Sinifid;
        OgrenciKayitRepository OgrKR = new OgrenciKayitRepository();
        DersaneOtomasyonuEntities1 ent = new DersaneOtomasyonuEntities1();
        OdemeVadeleriRepository odmR = new OdemeVadeleriRepository();     
        private void OgrenciKayit_Load(object sender, EventArgs e)
        {
            this.Top = 0;
            this.Left = 0;       
            SiniflariGetir();
            txtOgrenciNumara.Text = Convert.ToString(Kayitİslemleri.OgrenciNumarasi);
            txtVeliNumarasi.Text= Convert.ToString(Kayitİslemleri.VeliNumarasi);
            txtOgrenciAdi.Focus();
        }

        private void SiniflariGetir()
        {
            var Sonuc = from k in ent.Sinif
                        select k.SinifBransi;
            cbsinifi.DataSource = Sonuc.ToList();
        }

        private void grbOgrenciKayit_Enter(object sender, EventArgs e)
        {
            txtOgrenciNumara.Focus();    
        }


        private void btnOgrenciKaydet_Click(object sender, EventArgs e)
        {
            string odev = "";
            odevid = Convert.ToInt32((from k in ent.HaftalikOdevlerr
                                      where k.VerilenKonu == odev
                                      select k.HaftalikOdevID).First());
            string sinif = cbsinifi.SelectedItem.ToString();
            Sinifid = Convert.ToInt32((from k in ent.Sinif
                                       where k.SinifBransi == sinif
                                       select k.SinifID).First());
            if (txtOgrenciAdi.Text.Trim() != "" && txtOgrenciSoyadi.Text.Trim() != "" && txtBolumu.Text.Trim() != "" && txtTaksitTutari.Text.Trim() != "" && txtTcKimlikNo.Text.Trim() != "" && txtSehir.Text.Trim() != "" && txtSemt.Text.Trim() != "" && cbsinifi.Text.Trim() != "" && CbTaksitSayisi.Text.Trim() != "" && CbTaksitSayisi.Text.Trim() != "" && txtTaksitTutari.Text.Trim() != "")
            {
                OgrenciiKayit ogrnc = new OgrenciiKayit();
                ogrnc.VeliID = Convert.ToInt32(txtVeliNumarasi.Text);
                ogrnc.OgrenciNumarasi = Convert.ToInt32(txtOgrenciNumara.Text);
                ogrnc.OgrenciAdi = txtOgrenciAdi.Text;
                ogrnc.HaftalikOdevID = odevid;
                ogrnc.OgrenciSoyadi = txtOgrenciSoyadi.Text;
                ogrnc.OgrenciTcKimlikNo = txtTcKimlikNo.Text;
                ogrnc.SinifID = Sinifid;
                ogrnc.OgrenciOKulBolumu = txtBolumu.Text;
                ogrnc.OgrenciAdresi = txtEvAdresi.Text;
                ogrnc.OgrenciPostaKodu = CbPostakodu.Text;
                ogrnc.OgrenciSemt = txtSemt.Text;
                ogrnc.OgrenciSehir = txtSehir.Text;
                ogrnc.ToplamTaksitSayisi = Convert.ToByte(CbTaksitSayisi.Text);
                ogrnc.OdenecekToplamTutar = Convert.ToDecimal(txtTaksitTutari.Text);            
                OgrKR.Ekle(ogrnc);
                DateTime vade = dtpbaslangic.Value;
                vade = vade.AddMonths(1);
                int Taksitsayisi=Convert.ToInt32(CbTaksitSayisi.Text);
                int taksittutari = Convert.ToInt32(txtTaksitTutari.Text);
                decimal vadeodeme = Convert.ToDecimal(taksittutari / Taksitsayisi);
                byte taksitno = Convert.ToByte("1");
                for (int i = 1; i <= Taksitsayisi; i++)
                {
                    int ogrencino = Convert.ToInt32(txtOgrenciNumara.Text);
                    ogrenciid = (from k in ent.OgrenciiKayit
                                 where k.OgrenciNumarasi == ogrencino
                                 select k.OgrenciID).First();
                    OdemeVadeleri odmvade = new OdemeVadeleri();
                    odmvade.OgrenciID = ogrenciid;
                    odmvade.TaksitTutari =vadeodeme;
                    odmvade.TaksitNo = taksitno;
                    taksitno++;
                    odmvade.VadeTarihi = vade;
                    odmR.Ekle(odmvade);
                    vade = vade.AddMonths(1);
                }
           
                MessageBox.Show("İşleminiz Başarıyla Gerçekleşmiştir !", "# ÖĞRENCİ KAYIT İŞLEMİ GERÇEKLEŞTİ #");
                Clear();
            }

            else
            {
                MessageBox.Show("Öğrenci Bilgilerini eksik girdiniz !", "Bigileri Tam Girdiğinizden Emiz Olunuz!");
            }

        }

        void Clear()
        {
            txtOgrenciAdi.Text= "";
            txtOgrenciSoyadi.Text = "";
            txtBolumu.Text = "";
            txtTaksitTutari.Text = "";
            txtTcKimlikNo.Text= "";
            txtSehir.Text = "";
            txtSemt.Text = "";
            txtEvAdresi.Text = "";
            CbPostakodu.Text = "";
            CbTaksitSayisi.Text = "";
            txtTaksitTutari.Text = "";
            txtOgrenciNumara.Text = "";
            txtVeliNumarasi.Text = "";
        }

        private void cbsinifi_SelectedIndexChanged(object sender, EventArgs e)
        {
            SiniflariGetir();
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
