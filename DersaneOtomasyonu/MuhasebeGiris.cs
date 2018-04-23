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
    public partial class MuhasebeGiris : Form
    {
        public MuhasebeGiris()
        {
            InitializeComponent();
        }

        private void MuhasebeGiris_Load(object sender, EventArgs e)
        {
            this.Top = 250;
            this.Left = 450;
            txtKullanıcıAdi.Focus();
        }
        private void Temiz()
        {
            txtKullanıcıAdi.Text = "";
            txtSifre.Text = "";
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            if (txtKullanıcıAdi.Text.ToLower() == "bora" && txtSifre.Text.ToLower() == "bora1905")
            {
                Giris.KullAdi = txtKullanıcıAdi.Text.ToLower();
                Giris.Sifre = txtSifre.Text.ToLower();
                Anasayfa ana = new Anasayfa();
                FormAcikmi(ana);
                txtKullanıcıAdi.Text = "";
                txtSifre.Text = "";
                this.Close();
                Temiz();
            }
            else
            {
                MessageBox.Show("Kullanıcı Adı veya Şifrenizi yanlış girdiniz !", "Yanlış Şifre");
                Temiz();
            }
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

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
            Anasayfa ana = new Anasayfa();
            FormAcikmi(ana);
        }
    }
}
