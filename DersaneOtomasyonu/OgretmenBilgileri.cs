
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
    public partial class OgretmenBilgileri : Form
    {
        public OgretmenBilgileri()
        {
            InitializeComponent();
        }
        OgretmenKayitRepository okr = new OgretmenKayitRepository();
        DersaneOtomasyonuEntities1 ent = new DersaneOtomasyonuEntities1();
        private void OgretmenBilgileri_Load(object sender, EventArgs e)
        {
            Doldur();
            dgvOgretmenDuzenle();
            this.Top = 0;
            this.Left = 0;
            txtNumaraTarama.Focus();

        }
        private void Doldur()
        {
            var src = okr.Set().Include(x => x.Sinif).ToList();

            dgvogretmenbilgleri.DataSource = src.Select(x => new
            {
                x.OgretmenID,
                Sınıflar = string.Join(", ", x.Sinif.Select(o => o.SinifBransi)),
                x.Branslar.Brans,
                x.OgretmenAdi,
                x.OgretmenTcKimlikNo,
                x.OgretmenCinsiyet,
                x.OgretmenCepTel,
                x.OgretmenEvTel,
                x.OgretmenMailAdresi,
                x.OgretmenMaas,
                x.OgretmenAdres,
                x.OgretmenSemt,
                x.OgretmenSehir,
                x.OgretmenPostaKodu,
            }).ToList();
        }
        public void dgvOgretmenDuzenle()
        {
            dgvogretmenbilgleri.Columns[0].Width = 35;
            dgvogretmenbilgleri.Columns[1].Width = 85;
            dgvogretmenbilgleri.Columns[2].Width = 160;
            dgvogretmenbilgleri.Columns[3].Width = 120;
            dgvogretmenbilgleri.Columns[4].Width = 100;
            dgvogretmenbilgleri.Columns[5].Visible = false;
            dgvogretmenbilgleri.Columns[6].Width = 100;
            dgvogretmenbilgleri.Columns[7].Width = 100;
            dgvogretmenbilgleri.Columns[8].Width = 200;
            dgvogretmenbilgleri.Columns[9].Width = 90;
            dgvogretmenbilgleri.Columns[10].Width = 250;
            dgvogretmenbilgleri.Columns[11].Width = 100;
            dgvogretmenbilgleri.Columns[12].Width = 75;
            dgvogretmenbilgleri.Columns[13].Width = 65;
        }
        private void btnGncl_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Güncellemek İstiyormusunuz?", "GÜNCELLENSİN Mİ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int Id = Convert.ToInt32(txtOgretmenId.Text);
                OgretmenKayit ogretmen = okr.Bul(Id);
                ogretmen.Branslar.Brans = txtBrans.Text;
                ogretmen.OgretmenAdi = txtogrtmenAdSoyad.Text;
                ogretmen.OgretmenTcKimlikNo = txtogrtmenTcKimlikNo.Text;
                ogretmen.OgretmenCepTel = txtogrtmenCepTel.Text;
                ogretmen.OgretmenEvTel = txtogrtmenEvTel.Text;
                ogretmen.OgretmenMailAdresi = txtogrtmenMail.Text;
                ogretmen.OgretmenMaas = Convert.ToDecimal(txtogrtmenMaas.Text);
                ogretmen.OgretmenAdres = txtogrtmenEvAdres.Text;
                ogretmen.OgretmenSemt = txtogrtmenSemt.Text;
                ogretmen.OgretmenSehir = txtogrtmenSehir.Text;
                ogretmen.OgretmenPostaKodu = txtpostakodu.Text;
                MessageBox.Show("Güncellenme Tamamlanmışdır");
                okr.Guncelle(ogretmen);
                Temizle();
            }
            Doldur();
            dgvOgretmenDuzenle();
        }
        private void Temizle()
        {
            txtBrans.Text = "";
            txtogrtmenAdSoyad.Text = "";
            txtogrtmenTcKimlikNo.Text = "";
            txtogrtmenCepTel.Text = "";
            txtogrtmenEvTel.Text = "";
            txtogrtmenMail.Text = "";
            txtogrtmenMaas.Text = "";
            txtogrtmenEvAdres.Text = "";
            txtogrtmenSemt.Text = "";
            txtogrtmenSehir.Text = "";
            txtpostakodu.Text = "";
            txtOgretmenId.Text = "";

        }
        private void dgvogretmenbilgleri_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txtBrans.Text = Convert.ToString(dgvogretmenbilgleri.SelectedRows[0].Cells[2].Value);
            txtogrtmenAdSoyad.Text = Convert.ToString(dgvogretmenbilgleri.SelectedRows[0].Cells[3].Value);
            txtogrtmenTcKimlikNo.Text = Convert.ToString(dgvogretmenbilgleri.SelectedRows[0].Cells[4].Value);
            txtogrtmenCepTel.Text = Convert.ToString(dgvogretmenbilgleri.SelectedRows[0].Cells[6].Value);
            txtogrtmenEvTel.Text = Convert.ToString(dgvogretmenbilgleri.SelectedRows[0].Cells[7].Value);
            txtogrtmenMail.Text = Convert.ToString(dgvogretmenbilgleri.SelectedRows[0].Cells[8].Value);
            txtogrtmenMaas.Text = Convert.ToString(dgvogretmenbilgleri.SelectedRows[0].Cells[9].Value);
            txtogrtmenEvAdres.Text = Convert.ToString(dgvogretmenbilgleri.SelectedRows[0].Cells[10].Value);
            txtogrtmenSemt.Text = Convert.ToString(dgvogretmenbilgleri.SelectedRows[0].Cells[11].Value);
            txtogrtmenSehir.Text = Convert.ToString(dgvogretmenbilgleri.SelectedRows[0].Cells[12].Value);
            txtpostakodu.Text = Convert.ToString(dgvogretmenbilgleri.SelectedRows[0].Cells[13].Value);
            txtOgretmenId.Text = Convert.ToString(dgvogretmenbilgleri.SelectedRows[0].Cells[0].Value);
        }
        private void TcKimligeOgretmenDuzenle()
        {
            dgvogretmenbilgleri.Columns[0].Width = 35;
            dgvogretmenbilgleri.Columns[1].Width = 75;
            dgvogretmenbilgleri.Columns[2].Width = 160;
            dgvogretmenbilgleri.Columns[3].Width = 120;
            dgvogretmenbilgleri.Columns[4].Width = 130;
            dgvogretmenbilgleri.Columns[5].Visible = false;
            dgvogretmenbilgleri.Columns[6].Width = 100;
            dgvogretmenbilgleri.Columns[7].Width = 100;
            dgvogretmenbilgleri.Columns[8].Width = 200;
            dgvogretmenbilgleri.Columns[9].Width = 90;
            dgvogretmenbilgleri.Columns[10].Width = 250;
            dgvogretmenbilgleri.Columns[11].Width = 100;
            dgvogretmenbilgleri.Columns[12].Width = 75;
            dgvogretmenbilgleri.Columns[13].Width = 120;
        }
        private void txtNumaraTarama_TextChanged(object sender, EventArgs e)
        {
            var src = okr.Set().Include(x => x.Sinif).ToList();

            string TcKimlikTara = txtNumaraTarama.Text;
            dgvogretmenbilgleri.DataSource = src.Where(x => x.OgretmenTcKimlikNo.Contains(TcKimlikTara)).Select(x => new
            {
                x.OgretmenID,
                Sınıflar = string.Join(", ", x.Sinif.Select(o => o.SinifBransi)),
                x.Branslar.Brans,
                x.OgretmenAdi,
                x.OgretmenTcKimlikNo,
                x.OgretmenCinsiyet,
                x.OgretmenCepTel,
                x.OgretmenEvTel,
                x.OgretmenMailAdresi,
                x.OgretmenMaas,
                x.OgretmenAdres,
                x.OgretmenSemt,
                x.OgretmenSehir,
                x.OgretmenPostaKodu,
            }).ToList();
        }

        private void btnKayitSil_Click(object sender, EventArgs e)
        {
            if (Convert.ToString(dgvogretmenbilgleri.SelectedRows[0].Cells[1].Value)=="")
            {
                try
                {
                    if (MessageBox.Show("Silmek İstiyormusunuz?", "SİLİNSİN Mİ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        int Id = Convert.ToInt32(txtOgretmenId.Text);
                        OgretmenKayit ogretmen = okr.Bul(Id);
                        MessageBox.Show("Silme İşlemi Tamamlanmışdı");
                        okr.Sil(ogretmen);
                        Temizle();
                    }
                    Doldur();
                    dgvOgretmenDuzenle();
                }
                catch (Exception ex)
                {
                    string hata = ex.Message;
                }
            }

            else
            {
                MessageBox.Show("Öğretmen en az bir sınıfta eğitim vermeye devam etmekdedi !", "İŞLEMİNİZ GEREKLEŞTİRİLEMEDİ !");
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
