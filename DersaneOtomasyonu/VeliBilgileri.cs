using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DersaneOtomasyonu.BLL.Repository;
using DersaneOtomasyonu.DAL.DataModel;
namespace DersaneOtomasyonu
{
    public partial class VeliBilgileri : Form
    {
        public VeliBilgileri()
        {
            InitializeComponent();
        }
        VeliKayitRepository velR = new VeliKayitRepository();
        VeliKayitt vel = new VeliKayitt();

        DersaneOtomasyonuEntities1 ent = new DersaneOtomasyonuEntities1();
        private void VeliBilgileri_Load(object sender, EventArgs e)
        {           
            this.Top = 0;
            this.Left = 0;
            Doldur();
            dgvVeliDuzenle();
            txtNumaraTarama.Focus();
        }
        public void dgvVeliDuzenle()
        {
            dgVeliListele.Columns[0].Width = 35;
            dgVeliListele.Columns[1].Width = 120;
            dgVeliListele.Columns[2].Width = 100;
            dgVeliListele.Columns[3].Width = 100;
            dgVeliListele.Columns[4].Width = 75;
            dgVeliListele.Columns[5].Width = 100;
            dgVeliListele.Columns[6].Width = 150;
            dgVeliListele.Columns[7].Width = 75;
            dgVeliListele.Columns[8].Width = 100;
            dgVeliListele.Columns[9].Width = 200;
            dgVeliListele.Columns[10].Width = 200;
            dgVeliListele.Columns[11].Width = 75;
        }

        private void dgVeliListele_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txtID.Text = Convert.ToString(dgVeliListele.SelectedRows[0].Cells[0].Value);
            txtVeliAdiSoyadi.Text = Convert.ToString(dgVeliListele.SelectedRows[0].Cells[1].Value);
            txtVeliTcKimlik.Text = Convert.ToString(dgVeliListele.SelectedRows[0].Cells[2].Value);
            txtVelininOgrenNo.Text = Convert.ToString(dgVeliListele.SelectedRows[0].Cells[3].Value);
            txtVeliYakinligi.Text = Convert.ToString(dgVeliListele.SelectedRows[0].Cells[4].Value);
            txtVeliCepTel.Text = Convert.ToString(dgVeliListele.SelectedRows[0].Cells[5].Value);
            txtVeliMail.Text = Convert.ToString(dgVeliListele.SelectedRows[0].Cells[6].Value);
            txtVeliEgitimDurumu.Text = Convert.ToString(dgVeliListele.SelectedRows[0].Cells[7].Value);
            txtVeliGelir.Text = Convert.ToString(dgVeliListele.SelectedRows[0].Cells[8].Value);
            txtVeliEvAdresi.Text = Convert.ToString(dgVeliListele.SelectedRows[0].Cells[9].Value);
            txtVeliİsAdres.Text = Convert.ToString(dgVeliListele.SelectedRows[0].Cells[10].Value);
            txtPostaKodu.Text = Convert.ToString(dgVeliListele.SelectedRows[0].Cells[11].Value);
        }
        private void Doldur()
        {
            var src = velR.Set().Include(x => x.OgrenciiKayit).ToList();

            dgVeliListele.DataSource = src.Select(x => new
            {
                x.VeliID,
                x.VeliAdiSoyadi,
                x.VeliTcKimlikNo,
                OgrenciNo = string.Join(", ", x.OgrenciiKayit.Select(o => o.OgrenciNumarasi)),
                x.VeliYakinligi,
                x.VeliCepTel,
                x.VeliMailAdresi,
                x.VeliEgitimDurumu,
                x.VeliGelirDuzeyi,
                x.VeliEvAdresi,
                x.VeliİsAdresi,
                x.VeliPostaKodu
            }).ToList();
        }
        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Güncellemek İstiyormusunuz?", "GÜNCELLENSİN Mİ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int ID = Convert.ToInt32(txtID.Text);
                VeliKayit veli = velR.Bul(ID);
                veli.VeliAdiSoyadi = txtVeliAdiSoyadi.Text;
                veli.VeliTcKimlikNo = txtVeliTcKimlik.Text;
                veli.VeliYakinligi = txtVeliYakinligi.Text;
                veli.VeliEvAdresi = txtVeliEvAdresi.Text;
                veli.VeliEgitimDurumu = txtVeliEgitimDurumu.Text;
                veli.VeliCepTel = txtVeliCepTel.Text;
                veli.VeliİsAdresi = txtVeliİsAdres.Text;
                veli.VeliMailAdresi = txtVeliMail.Text;
                veli.VeliGelirDuzeyi = Convert.ToDecimal(txtVeliGelir.Text);
                veli.VeliPostaKodu = txtPostaKodu.Text;
                MessageBox.Show("Güncelleme Tamamlanmışdır");
                velR.Guncelle(veli);
                Temizle();
            }
            Doldur();
            dgvVeliDuzenle();
        }


        private void Temizle()
        {
            txtNumaraTarama.Text = "";
            txtPostaKodu.Text = "";
            txtVeliAdiSoyadi.Text = "";
            txtVeliCepTel.Text = "";
            txtVeliEgitimDurumu.Text = "";
            txtVeliEvAdresi.Text = "";
            txtVeliGelir.Text = "";
            txtVeliMail.Text = "";
            txtVelininOgrenNo.Text = "";
            txtVeliTcKimlik.Text = "";
            txtVeliYakinligi.Text = "";
            txtVeliİsAdres.Text = "";
        }

        private void btnKayitSil_Click(object sender, EventArgs e)
        {
            if (txtVelininOgrenNo.Text.Trim() == "")
            {
                if (MessageBox.Show("Silmek İstiyormusunuz?", "Silinsin mi?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int ID = Convert.ToInt32(txtID.Text);
                    VeliKayit veli = velR.Bul(ID);
                    velR.Sil(veli);
                    Temizle();
                }
                Doldur();
                dgvVeliDuzenle();
            }
            else
            {
                MessageBox.Show("Veli' ye ait Öğrenci Kayıtlıdır.", "Silme İşlemini Gerçekleştiremezsiniz !");
            }
        }

        private void txtNumaraTarama_TextChanged(object sender, EventArgs e)
        {
            var src = velR.Set().Include(x => x.OgrenciiKayit).ToList();
            string TcKimlikTara = txtNumaraTarama.Text;
            dgVeliListele.DataSource = src.Where(x => x.VeliTcKimlikNo.Contains(TcKimlikTara)).Select(x => new
            {
                x.VeliID,
                x.VeliAdiSoyadi,
                x.VeliTcKimlikNo,
                OgrenciNo = string.Join(", ", x.OgrenciiKayit.Select(o => o.OgrenciNumarasi)),
                x.VeliYakinligi,
                x.VeliCepTel,
                x.VeliMailAdresi,
                x.VeliEgitimDurumu,
                x.VeliGelirDuzeyi,
                x.VeliEvAdresi,
                x.VeliİsAdresi,
                x.VeliPostaKodu
            }).ToList();
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
