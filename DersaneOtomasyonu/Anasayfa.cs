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
    public partial class Anasayfa : Form
    {
        public Anasayfa()
        {
            InitializeComponent();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void FormAcikmi(Form AcilacakForm)
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

                AcilacakForm.Show();
            }
            else
            {
                AcilacakForm.Dispose();
            }
        }

        private void bunifuFlatButton9_Click(object sender, EventArgs e)
        {
            SinifAc donersermaye = new SinifAc();
            FormBilgileriAcikmi(donersermaye);
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
                AcilacakForm.MdiParent = this;
                AcilacakForm.Show();
            }
            else
            {
                AcilacakForm.Dispose();
            }
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            VeliKayitt veli = new VeliKayitt();
            FormBilgileriAcikmi(veli);
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            OgrenciKayit ogrenci = new OgrenciKayit();
            FormBilgileriAcikmi(ogrenci);
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            OgretmenKayitt ogretmen = new OgretmenKayitt();
            FormBilgileriAcikmi(ogretmen);
        }

        private void bunifuFlatButton5_Click(object sender, EventArgs e)
        {
            Tahsilat dekont = new Tahsilat();
            FormBilgileriAcikmi(dekont);
        }

        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {
            OgrenciBilgileri ogrencibilgileri = new OgrenciBilgileri();
            FormBilgileriAcikmi(ogrencibilgileri);
        }

        private void btnOdevler_Click(object sender, EventArgs e)
        {
            Odevler odevler = new Odevler();
            FormBilgileriAcikmi(odevler);
        }

        private void btnVeliBilgileri_Click(object sender, EventArgs e)
        {
            VeliBilgileri velibilgileri = new VeliBilgileri();
            FormBilgileriAcikmi(velibilgileri);
        }

        private void btnOgretmenBilgileri_Click(object sender, EventArgs e)
        {
            OgretmenBilgileri ogretmenbilgileri = new OgretmenBilgileri();
            FormBilgileriAcikmi(ogretmenbilgileri);
        }

  

        private void Deneme_Load(object sender, EventArgs e)
        {
            btnDekont.Enabled = false;
            btnSinifAc.Enabled = false;
            btnOgrenciKayit.Enabled = false;
            btnOgretmenBilgileri.Enabled = false;
            btnOgretmenKayit.Enabled = false;
            btnVeliBilgileri.Enabled = false;
            btnVeliKayit.Enabled = false;
            btnOgrenciBilgileri.Enabled = false;
           
            if (Giris.KullAdi == "bora" && Giris.Sifre == "bora662")
            {
                btnOgrenciKayit.Enabled = true;
                btnOgretmenKayit.Enabled = true;
                btnVeliKayit.Enabled = true;
                btnOgrenciBilgileri.Enabled = true;
                btnOgretmenBilgileri.Enabled = true;
                btnVeliBilgileri.Enabled = true;
                btnSinifAc.Enabled = true;
            }
            else if (Giris.KullAdi == "bora" && Giris.Sifre == "bora1905")
            {
                btnDekont.Enabled = true;
              
            }
            else if (Giris.KullAdi == "bora" && Giris.Sifre == "bora3154")
            {
                btnSinifAc.Enabled = true;
                btnDekont.Enabled = true;
                btnOgrenciKayit.Enabled = true;
                btnOgretmenKayit.Enabled = true;
                btnVeliKayit.Enabled = true;
                btnOgrenciBilgileri.Enabled = true;
                btnOgretmenBilgileri.Enabled = true;
                btnVeliBilgileri.Enabled = true;
              
            }
        }

        private void bunifuImageButton4_Click(object sender, EventArgs e)
        {
            this.Hide();
            MuhasebeGiris mhsb = new MuhasebeGiris();
            FormAcikmi(mhsb);
        }

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            this.Hide();
            İKSifreGiris ik = new İKSifreGiris();
            FormAcikmi(ik);
        }

        private void bunifuImageButton5_Click(object sender, EventArgs e)
        {
            this.Hide();
            TamYetkiliGiris ty = new TamYetkiliGiris();
            FormAcikmi(ty);
        }
    }
}
