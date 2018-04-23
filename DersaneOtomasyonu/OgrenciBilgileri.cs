using DersaneOtomasyonu.BLL.Repository;
using DersaneOtomasyonu.DAL.DataModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DersaneOtomasyonu
{
    public partial class OgrenciBilgileri : Form
    {
        public OgrenciBilgileri()
        {
            InitializeComponent();
        }
        OgrenciKayitRepository okr = new OgrenciKayitRepository();

        private void OgrenciBilgileri_Load(object sender, EventArgs e)
        {
            this.Top = 0;
            this.Left = 0;
            Doldur();
            dgvOgrenciDuzenle();
            txtNumaraTarama.Focus();
        }

        private void btn_X_Cikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Alt_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void Doldur()
        {
            var src = okr.Set().Include(x => x.Sinif.OgretmenKayit).ToList();

            dgOgrenciListesi.DataSource = src.Select(x => new
            {
                x.OgrenciNumarasi,
                x.OgrenciAdi,
                x.OgrenciSoyadi,
                x.OgrenciTcKimlikNo,
                x.OgrenciOKulBolumu,
                sınıf = x.Sinif.SinifBransi,
                ogretmen = x.Sinif.OgretmenKayit.OgretmenAdi,
                konu = x.HaftalikOdevlerr.VerilenKonu,
                x.OgrenciAdresi,
                x.OgrenciPostaKodu,
                x.OgrenciSemt,
                x.OgrenciSehir,
                x.OgrenciID,
                x.VeliID,
                x.HaftalikOdevID,
                x.SinifID,
                x.ToplamTaksitSayisi,
                x.OdenecekToplamTutar,
            }).ToList();
        }
        public void dgvOgrenciDuzenle()
        {
            dgOgrenciListesi.Columns[0].Width = 75;
            dgOgrenciListesi.Columns[1].Width = 100;
            dgOgrenciListesi.Columns[2].Width = 100;
            dgOgrenciListesi.Columns[3].Width = 90;
            dgOgrenciListesi.Columns[4].Width = 175;
            dgOgrenciListesi.Columns[5].Width = 65;
            dgOgrenciListesi.Columns[6].Width = 120;
            dgOgrenciListesi.Columns[7].Width = 150;
            dgOgrenciListesi.Columns[8].Width = 250;
            dgOgrenciListesi.Columns[9].Width = 50;
            dgOgrenciListesi.Columns[10].Width = 60;
            dgOgrenciListesi.Columns[11].Width = 60;
            dgOgrenciListesi.Columns[12].Visible = false;
            dgOgrenciListesi.Columns[13].Visible = false;
            dgOgrenciListesi.Columns[14].Visible = false;
            dgOgrenciListesi.Columns[15].Visible = false;
            dgOgrenciListesi.Columns[16].Visible = false;
            dgOgrenciListesi.Columns[17].Visible = false;

        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Güncellemek İstiyormusunuz?", "GÜNCELLENSİN Mİ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int ID = Convert.ToInt32(txtID.Text);
                OgrenciiKayit ogr = okr.Bul(ID);
                ogr.OgrenciAdi = txtOgrenciAdi.Text;
                ogr.OgrenciAdresi = txtEvAdresi.Text;
                ogr.OgrenciNumarasi = Convert.ToInt32(txtOgrenciNumara.Text);
                ogr.OgrenciOKulBolumu = txtBolumu.Text;
                ogr.OgrenciPostaKodu = txtPostakodu.Text;
                ogr.OgrenciSehir = txtSehir.Text;
                ogr.OgrenciSemt = txtSemt.Text;
                ogr.OgrenciSoyadi = txtOgrenciSoyadi.Text;
                ogr.OgrenciTcKimlikNo = txtOgrenciTcKimlikNo.Text;
                MessageBox.Show("Güncelleme Tamamlanmışdır");
                okr.Guncelle(ogr);
                Temizle();
            }
            Doldur();
            dgvOgrenciDuzenle();
        }
        private void Temizle()
        {
            txtOgrenciAdi.Text = "";
            txtEvAdresi.Text = "";
            txtOgrenciNumara.Text = "";
            txtBolumu.Text = "";
            txtPostakodu.Text = "";
            txtSehir.Text = "";
            txtSemt.Text = "";
            txtOgrenciSoyadi.Text = "";
            txtOgrenciTcKimlikNo.Text = "";
            txtOgrencDersKonusu.Text = "";
            txtID.Text = "";
            txtSinifi.Text = "";
        }

        private void btnKayitSil_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Silmek İstiyormusunuz?", "SİLİNSİN Mİ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int ID = Convert.ToInt32(txtID.Text);
                OgrenciiKayit ogr = okr.Bul(ID);
                MessageBox.Show("Silme işlemi Tamamlanmışdır");
                okr.Sil(ogr);
                Temizle();
            }
            Doldur();
            dgvOgrenciDuzenle();
        }

        private void dgOgrenciListesi_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txtOgrenciNumara.Text = Convert.ToString(dgOgrenciListesi.SelectedRows[0].Cells[0].Value);
            txtOgrenciAdi.Text = Convert.ToString(dgOgrenciListesi.SelectedRows[0].Cells[1].Value);
            txtOgrenciSoyadi.Text = Convert.ToString(dgOgrenciListesi.SelectedRows[0].Cells[2].Value);
            txtOgrenciTcKimlikNo.Text = Convert.ToString(dgOgrenciListesi.SelectedRows[0].Cells[3].Value);
            txtSinifi.Text = Convert.ToString(dgOgrenciListesi.SelectedRows[0].Cells[5].Value);
            txtBolumu.Text = Convert.ToString(dgOgrenciListesi.SelectedRows[0].Cells[4].Value);
            txtOgrencDersKonusu.Text = Convert.ToString(dgOgrenciListesi.SelectedRows[0].Cells[7].Value);
            txtEvAdresi.Text = Convert.ToString(dgOgrenciListesi.SelectedRows[0].Cells[8].Value);
            txtPostakodu.Text = Convert.ToString(dgOgrenciListesi.SelectedRows[0].Cells[9].Value);
            txtSemt.Text = Convert.ToString(dgOgrenciListesi.SelectedRows[0].Cells[10].Value);
            txtSehir.Text = Convert.ToString(dgOgrenciListesi.SelectedRows[0].Cells[11].Value);
            txtID.Text = Convert.ToString(dgOgrenciListesi.SelectedRows[0].Cells[12].Value);
        }

        private void txtNumaraTarama_TextChanged(object sender, EventArgs e)
        {
            var src = okr.Set().Include(x => x.Sinif).ToList();

            string OgrenciNumarasi = txtNumaraTarama.Text;
            dgOgrenciListesi.DataSource = src.Where(x => x.OgrenciNumarasi.ToString().Contains(OgrenciNumarasi)).Select(x => new
            {
                x.OgrenciNumarasi,
                x.OgrenciAdi,
                x.OgrenciSoyadi,
                x.OgrenciTcKimlikNo,
                x.OgrenciOKulBolumu,
                sınıf = x.Sinif.SinifBransi,
                ogretmen = x.Sinif.OgretmenKayit.OgretmenAdi,
                konu = x.HaftalikOdevlerr.VerilenKonu,
                x.OgrenciAdresi,
                x.OgrenciPostaKodu,
                x.OgrenciSemt,
                x.OgrenciSehir,
                x.OgrenciID,
                x.VeliID,
                x.HaftalikOdevID,
                x.SinifID,
                x.ToplamTaksitSayisi,
                x.OdenecekToplamTutar,
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