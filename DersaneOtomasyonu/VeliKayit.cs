using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DersaneOtomasyonu.DAL.DataModel;
using DersaneOtomasyonu.BLL.Repository;

namespace DersaneOtomasyonu
{
    public partial class VeliKayitt : Form
    {
        public VeliKayitt()
        {
            InitializeComponent();
        }
        DersaneOtomasyonuEntities1 ent = new DersaneOtomasyonuEntities1();
        VeliKayitRepository velRep = new VeliKayitRepository();
        int veliId;
        private void VeliKayit_Load(object sender, EventArgs e)
        {
            this.Top = 0;
            this.Left = 0;
            txtVeliAdiSoyadi.Focus();
        }


         private void btnVeliKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtVeliAdiSoyadi.Text.Trim() != "" && txtVeliCepTel.Text.Trim() != "" && CbEgitimDurumu.Text.Trim() != "" && txtGelir.Text.Trim() != "" && txtVelininOgrenNo.Text.Trim() != "" && txtVeliTcKimlik.Text.Trim() != "" && CbYakinlik.Text.Trim() != "")
                {
                    VeliKayit veli = new VeliKayit();
                    veli.VeliAdiSoyadi = txtVeliAdiSoyadi.Text;
                    veli.VeliTcKimlikNo = txtVeliTcKimlik.Text;
                    veli.VeliYakinligi = CbYakinlik.Text;
                    veli.VeliEvAdresi = txtVeliEvAdresi.Text;
                    veli.VeliEgitimDurumu = CbEgitimDurumu.Text;
                    veli.VeliCepTel = txtVeliCepTel.Text;
                    veli.VeliİsAdresi = txtVeliİsAdres.Text;
                    veli.VeliMailAdresi = txtVeliMail.Text;
                    veli.VeliGelirDuzeyi = Convert.ToDecimal(txtGelir.Text);
                    veli.VeliPostaKodu = CbPostakodu.Text;
                    velRep.Ekle(veli);
                    MessageBox.Show("İşleminiz Başarıyla Gerçekleşmiştir !", "# VELİ KAYIT İŞLEMİ GERÇEKLEŞTİ #");
                    VeliGetir();
                    txtVelininOgrenNo.Enabled = false;
                    Kayitİslemleri.OgrenciNumarasi = Convert.ToInt32(txtVelininOgrenNo.Text);
                    Kayitİslemleri.VeliNumarasi = veliId;
                    Clear();
                    OgrenciKayit ogrenci = new OgrenciKayit();
                    FormBilgileriAcikmi(ogrenci);
                }
            }
            catch (Exception ex)
            {
                string hata = ex.Message;
                MessageBox.Show("Veli Bilgilerini eksik girdiniz !", "Bigileri Tam Girdiğinizden Emiz Olunuz!");
            }
           

    
        }
        private void VeliGetir()
        {
            string veliadisoyadi = txtVeliAdiSoyadi.Text;
            veliId = Convert.ToInt32((from k in ent.VeliKayit
                                      where k.VeliAdiSoyadi == veliadisoyadi
                                      select k.VeliID).First());
            lblveliIDver.Text = "Veli Numarası : " + veliId.ToString();
        }
        void Clear()
        {
            txtVeliAdiSoyadi.Text = "";
            txtVeliTcKimlik.Text = "";

            txtVeliCepTel.Text = "";
            txtVeliEvAdresi.Text = "";
            txtGelir.Text = "";
            txtVeliMail.Text = "";
            txtVeliİsAdres.Text = "";
            CbEgitimDurumu.Text = "";
            CbPostakodu.Text = "";
            CbYakinlik.Text = "";
        }
        private void FormBilgileriAcikmi(Form AcilacakForm)
        {
            bool Acikmi = false;
            for (int i = 0; i < this.MdiChildren.Length; i++)
            {
                if (this.MdiChildren[i].Name == AcilacakForm.Name)
                {
                    this.MdiChildren[i].Focus();
                    Acikmi = true;
                }
            }
            if (Acikmi == false)
            {
                AcilacakForm.MdiParent = Anasayfa.ActiveForm;
                AcilacakForm.Show();
            }
            else
            {
                AcilacakForm.Dispose();
            }
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
