
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
    public partial class SinifAc : Form
    {
        public SinifAc()
        {
            InitializeComponent();
        }
        DersaneOtomasyonuEntities1 ent = new DersaneOtomasyonuEntities1();
        OgretmenKayitRepository ogr = new OgretmenKayitRepository();
        SinifRepository snfR = new SinifRepository();
        BranslarRepository brR = new BranslarRepository();
        int sinid, ogretmenid, bransid;


        public void dgvSiniflariDuzenle()
        {
            dgvsinif.Columns[0].Width = 175;
            dgvsinif.Columns[1].Width = 200;
            dgvsinif.Columns[2].Width = 150;
            dgvsinif.Columns[3].Width = 150;
            dgvsinif.Columns[5].Visible = false;


        }
        private void SinifIDGetir()
        {
            string sinif = cbsinifi.SelectedItem.ToString();
            sinid = Convert.ToInt32((from k in ent.Sinif
                                     where k.SinifBransi == sinif
                                     select k.SinifID).First());
        }
        private void SinifIdgetir()
        {
            string sinif = txtYeniSinifAdi.Text.ToString();
            sinid = Convert.ToInt32((from k in ent.Sinif
                                     where k.SinifBransi == sinif
                                     select k.SinifID).First());
        }
        private void SiniflariGetir()
        {
            var Sonuc = from k in ent.Sinif
                        select k.SinifBransi;
            cbsinifi.DataSource = Sonuc.ToList();
        }

        private void ogrenciGetir()
        {
            var Sonuc = from k in ent.OgrenciiKayit
                        select k.OgrenciAdi;
            txtOgrenciSayisi.Text = Sonuc.Count().ToString();
        }

        private void cbsinifi_SelectedIndexChanged(object sender, EventArgs e)
        {
            SinifIDGetir();
            SinifGetirByOgrenci(sinid);
            try
            {
                if (Convert.ToString(dgvsinif.SelectedRows[0].Cells[2].Value).Trim() != "" && Convert.ToString(dgvsinif.SelectedRows[0].Cells[3].Value).Trim() != "" && Convert.ToString(dgvsinif.SelectedRows[0].Cells[0].Value).Trim() != "" && Convert.ToString(dgvsinif.SelectedRows[0].Cells[4].Value).Trim() != "" && Convert.ToString(dgvsinif.SelectedRows[0].Cells[5].Value).Trim() != "")
                {
                    txtBaslangic.Text = Convert.ToString(dgvsinif.SelectedRows[0].Cells[2].Value);
                    dtpbitis.Text = Convert.ToString(dgvsinif.SelectedRows[0].Cells[3].Value);
                    CbOgretmenBrans.Text = Convert.ToString(dgvsinif.SelectedRows[0].Cells[0].Value);
                    txtYeniSinifAdi.Text = Convert.ToString(dgvsinif.SelectedRows[0].Cells[4].Value);
                    txtOgrenciSayisi.Text = Convert.ToString(dgvsinif.SelectedRows[0].Cells[5].Value);
                }
            }
            catch (Exception ex)
            {
                string hata = ex.Message;
            }

        }
        private void OgrenciGetirBySinif(int sinid)
        {
            var ID = from x in ent.OgrenciiKayit
                     where x.OgrenciID == sinid
                     select new { };

        }

        private void SinifGetirByOgrenci(int ogrID)
        {
            var ID = from x in ent.Sinif
                     where x.SinifID == ogrID
                     select new { x.OgretmenKayit.Branslar.Brans, x.OgretmenKayit.OgretmenAdi, x.DerslerinBaslangici, x.DerslerinBitisi, x.SinifBransi, x.OgrenciiKayit.Count };
            dgvsinif.DataSource = ID.ToList();
            dgvSiniflariDuzenle();

        }
        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Güncellemek İstiyormusunuz?", "GÜNCELLENSİN Mİ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                OgretmenIdGetir();
                SinifIDGetir();
                Sinif sinif = snfR.Bul(sinid);
                sinif.SinifBransi = txtYeniSinifAdi.Text;
                sinif.OgretmenID = ogretmenid;
                sinif.DerslerinBaslangici = txtBaslangic.Value;
                sinif.DerslerinBitisi = dtpbitis.Value;
                MessageBox.Show("Güncellenme Tamamlanmışdır");
                snfR.Guncelle(sinif);
                Temizle();
            }
            SiniflariGetir();
            ogrenciGetir();
            OgrenciGetirBySinif(sinid);
            OgretmenleriGetir();
            BransGetir();
            dgvSiniflariDuzenle();
        }
        private void Temizle()
        {
            dtpbitis.Text = "";
            txtBaslangic.Text = "";
            txtYeniSinifAdi.Text = "";
            txtOgrenciSayisi.Text = "";
        }
        private void dgvsinif_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txtBaslangic.Text = Convert.ToString(dgvsinif.SelectedRows[0].Cells[2].Value);
            dtpbitis.Text = Convert.ToString(dgvsinif.SelectedRows[0].Cells[3].Value);
            CbOgretmenBrans.Text = Convert.ToString(dgvsinif.SelectedRows[0].Cells[0].Value);
            txtYeniSinifAdi.Text = Convert.ToString(dgvsinif.SelectedRows[0].Cells[4].Value);
            cbOgretmenAdi.Text = Convert.ToString(dgvsinif.SelectedRows[0].Cells[1].Value);
            cbsinifi.Text = Convert.ToString(dgvsinif.SelectedRows[0].Cells[4].Value);
            txtOgrenciSayisi.Text = Convert.ToString(dgvsinif.SelectedRows[0].Cells[5].Value);
        }

        private void cbOgretmenAdi_SelectedIndexChanged(object sender, EventArgs e)
        {
            OgretmenIdGetir();
            OgretmenGetirBySinif(ogretmenid);
            try
            {
                if (Convert.ToString(dgvsinif.SelectedRows[0].Cells[2].Value).Trim() != "" && Convert.ToString(dgvsinif.SelectedRows[0].Cells[3].Value).Trim() != "" && Convert.ToString(dgvsinif.SelectedRows[0].Cells[0].Value).Trim() != "" && Convert.ToString(dgvsinif.SelectedRows[0].Cells[4].Value).Trim() != "" && Convert.ToString(dgvsinif.SelectedRows[0].Cells[5].Value).Trim() != "")
                {
                    txtBaslangic.Value = Convert.ToDateTime(dgvsinif.SelectedRows[0].Cells[2].Value);
                    dtpbitis.Value = Convert.ToDateTime(dgvsinif.SelectedRows[0].Cells[3].Value);
                    CbOgretmenBrans.Text = Convert.ToString(dgvsinif.SelectedRows[0].Cells[0].Value);
                    txtYeniSinifAdi.Text = Convert.ToString(dgvsinif.SelectedRows[0].Cells[4].Value);
                    txtOgrenciSayisi.Text = Convert.ToString(dgvsinif.SelectedRows[0].Cells[5].Value);
                    CbOgretmenBrans.Text = Convert.ToString(dgvsinif.SelectedRows[0].Cells[0].Value);

                }
            }
            catch (Exception ex)
            {
                string hata = ex.Message;
            }
        }
        private void OgretmenIdGetir()
        {
            string ogretmen = cbOgretmenAdi.SelectedItem.ToString();

            ogretmenid = (from k in ent.OgretmenKayit
                          where k.OgretmenAdi == ogretmen
                          select k.OgretmenID).First();
        }
        private void OgretmenleriGetir()
        {
            var Sonuc = from k in ent.OgretmenKayit
                        select k.OgretmenAdi;
            cbOgretmenAdi.DataSource = Sonuc.ToList();
        }
        private void BransGetir()
        {
            var Sonuc = from k in ent.Branslar
                        select k.Brans;
            CbOgretmenBrans.DataSource = Sonuc.ToList();
        }

        private void CbOgretmenBrans_SelectedIndexChanged(object sender, EventArgs e)
        {
            string OgretmenBrans = CbOgretmenBrans.SelectedItem.ToString();

            bransid = (from k in ent.Branslar
                       where k.Brans == OgretmenBrans
                       select k.IDBrans).First();
            BransGetirByOgretmen(bransid);
            dgvSiniflariDuzenle();
        }

        private void SinifAc_Load(object sender, EventArgs e)
        {
            SiniflariGetir();
            ogrenciGetir();
            OgrenciGetirBySinif(sinid);
            OgretmenleriGetir();
            BransGetir();
            this.Top = 0;
            this.Left = 0;
            txtYeniSinifAdi.Focus();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                SinifIdgetir();
                int ID = sinid;
                Sinif snf = snfR.Bul(ID);
                if (snf != null)
                {
                    MessageBox.Show("Aynı Sınıf önceden girilmiş.", "Dikkat Sistemde Kayıtlı!");
                }                    
            }
            catch (Exception ex)
            {
                if (MessageBox.Show("Öğretim Görevlisini Bu Sınıfa Atamak İstiyor musunuz?", "KAYDEDİLSİN Mİ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    OgretmenIdGetir();
                    Sinif sinif = new Sinif();
                    sinif.SinifBransi = txtYeniSinifAdi.Text;
                    sinif.OgretmenID = ogretmenid;
                    sinif.DerslerinBaslangici = txtBaslangic.Value;
                    sinif.DerslerinBitisi = dtpbitis.Value;
                    MessageBox.Show("Atama İşlemi Tamamlanmışdır");
                    snfR.Ekle(sinif);
                    Temizle();
                }
                SiniflariGetir();
                ogrenciGetir();
                OgrenciGetirBySinif(sinid);
                OgretmenleriGetir();
                BransGetir();
                dgvSiniflariDuzenle();
                string hata = ex.Message;
            }     
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Silmek İstiyormusunuz?", "SİLİNSİN Mİ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                SinifIDGetir();
                int ID = sinid;
                Sinif snf = snfR.Bul(ID);
                MessageBox.Show("Silme işlemi Tamamlanmışdır");
                snfR.Sil(snf);
                Temizle();
            }
            SiniflariGetir();
            ogrenciGetir();
            OgrenciGetirBySinif(sinid);
            OgretmenleriGetir();
            BransGetir();
            dgvSiniflariDuzenle();
        }

        private void BransGetirByOgretmen(int Bransid)
        {
            var branslar = from x in ent.Sinif
                           where x.OgretmenKayit.Branslar.IDBrans == Bransid
                           select new { x.OgretmenKayit.Branslar.Brans, x.OgretmenKayit.OgretmenAdi, x.DerslerinBaslangici, x.DerslerinBitisi, x.SinifBransi, x.OgrenciiKayit.Count };
            dgvsinif.DataSource = branslar.ToList();

        }
        private void OgretmenGetirBySinif(int Ogretmenid)
        {
            var ogretmen = from x in ent.Sinif
                           where x.OgretmenID == Ogretmenid
                           select new { x.OgretmenKayit.Branslar.Brans, x.OgretmenKayit.OgretmenAdi, x.DerslerinBaslangici, x.DerslerinBitisi, x.SinifBransi, x.OgrenciiKayit.Count };
            dgvsinif.DataSource = ogretmen.ToList();
            dgvSiniflariDuzenle();
        }
    }
}
