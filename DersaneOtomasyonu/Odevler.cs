using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using DersaneOtomasyonu.DAL.DataModel;
using DersaneOtomasyonu.BLL.Repository;

namespace DersaneOtomasyonu
{

    public partial class Odevler : Form
    {

        DersaneOtomasyonuEntities1 ent = new DersaneOtomasyonuEntities1();
        public Odevler()
        {
            InitializeComponent();

        }
        OgrenciKayitRepository okr = new OgrenciKayitRepository();
        OdevRepository odR = new OdevRepository();
        private void Odevler_Load(object sender, EventArgs e)
        {
            this.Top = 0;
            this.Left = 0;
            Doldur();
            dgvOgrenciDuzenle();
            SinifGetir();
            DersGetir();
            CbOgrenciDersKonusu.Focus();

        }
        private void Doldur()
        {
            var src = okr.Set().Include(x => x.Sinif.OgretmenKayit).ToList();

            dgOgrenciListesi.DataSource = src.Select(x => new
            {
                x.OgrenciNumarasi,
                x.OgrenciAdi,
                x.OgrenciSoyadi,
                x.Sinif.OgretmenKayit.Branslar.Brans,
                sınıf = x.Sinif.SinifBransi,
                konu = x.HaftalikOdevlerr.VerilenKonu,
                x.VeliKayit.VeliMailAdresi,
                x.HaftalikOdevlerr.VerilisTarihi,
                x.HaftalikOdevlerr.TeslimTarihi,
                x.HaftalikOdevlerr.VerilenNot,
                x.OgrenciID,
                x.HaftalikOdevID
            }).ToList();
        }
        private void Dolduryenile()
        {
            OgrenciKayitRepository okr1 = new OgrenciKayitRepository();
            var src = okr1.Set().Include(x => x.Sinif.OgretmenKayit).ToList();

            dgOgrenciListesi.DataSource = src.Select(x => new
            {
                x.OgrenciNumarasi,
                x.OgrenciAdi,
                x.OgrenciSoyadi,
                x.Sinif.OgretmenKayit.Branslar.Brans,
                sınıf = x.Sinif.SinifBransi,
                konu = x.HaftalikOdevlerr.VerilenKonu,
                x.VeliKayit.VeliMailAdresi,
                x.HaftalikOdevlerr.VerilisTarihi,
                x.HaftalikOdevlerr.TeslimTarihi,
                x.HaftalikOdevlerr.VerilenNot,
                x.OgrenciID,
                x.HaftalikOdevID
            }).ToList();
        }
        public void dgvOgrenciDuzenle()
        {
            dgOgrenciListesi.Columns[0].Width = 75;
            dgOgrenciListesi.Columns[1].Width = 90;
            dgOgrenciListesi.Columns[2].Width = 80;
            dgOgrenciListesi.Columns[3].Width = 165;
            dgOgrenciListesi.Columns[4].Width = 75;
            dgOgrenciListesi.Columns[5].Width = 150;
            dgOgrenciListesi.Columns[6].Width = 175;
            dgOgrenciListesi.Columns[7].Width = 100;
            dgOgrenciListesi.Columns[8].Width = 100;
            dgOgrenciListesi.Columns[9].Width = 50;
            dgOgrenciListesi.Columns[10].Visible = false;
            dgOgrenciListesi.Columns[11].Visible = false;

        }

        private void SinifGetir()
        {
            var Sonuc = from k in ent.Sinif
                        select k.SinifBransi;
            cbOgrenciSinif.DataSource = Sonuc.ToList();
        }
        private void DersGetir()
        {
            var Sonuc = from k in ent.Branslar
                        select k.Brans;
            CbOgrenciDers.DataSource = Sonuc.ToList();
        }


        private void dgOgrenciListesi_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txtOgrenciAdiSoyadi.Text = Convert.ToString(dgOgrenciListesi.SelectedRows[0].Cells[1].Value + " " + dgOgrenciListesi.SelectedRows[0].Cells[2].Value);
            txtOgrenciNumara.Text = Convert.ToString(dgOgrenciListesi.SelectedRows[0].Cells[0].Value);
            cbOgrenciSinif.Text = Convert.ToString(dgOgrenciListesi.SelectedRows[0].Cells[4].Value);
            CbOgrenciDers.Text = Convert.ToString(dgOgrenciListesi.SelectedRows[0].Cells[3].Value);
            CbOgrenciDersKonusu.Text = Convert.ToString(dgOgrenciListesi.SelectedRows[0].Cells[5].Value);
            txtVeliMail.Text = Convert.ToString(dgOgrenciListesi.SelectedRows[0].Cells[6].Value);
            dtVerilisTarihi.Text = Convert.ToString(dgOgrenciListesi.SelectedRows[0].Cells[7].Value);
            dtpTeslimTarihi.Text = Convert.ToString(dgOgrenciListesi.SelectedRows[0].Cells[8].Value);
            txtVerilenNot.Text = Convert.ToString(dgOgrenciListesi.SelectedRows[0].Cells[9].Value);
            txtID.Text = Convert.ToString(dgOgrenciListesi.SelectedRows[0].Cells[11].Value);
        }

        private void txtOgrenciNumarasi_TextChanged(object sender, EventArgs e)
        {
            var src = okr.Set().Include(x => x.Sinif).ToList();

            string OgrenciNumarasi = txtOgrenciNumarasi.Text;
            dgOgrenciListesi.DataSource = src.Where(x => x.OgrenciNumarasi.ToString().Contains(OgrenciNumarasi)).Select(x => new
            {
                x.OgrenciNumarasi,
                x.OgrenciAdi,
                x.OgrenciSoyadi,
                x.Sinif.OgretmenKayit.Branslar.Brans,
                sınıf = x.Sinif.SinifBransi,
                konu = x.HaftalikOdevlerr.VerilenKonu,
                x.VeliKayit.VeliMailAdresi,
                x.HaftalikOdevlerr.VerilisTarihi,
                x.HaftalikOdevlerr.TeslimTarihi,
                x.HaftalikOdevlerr.VerilenNot,
                x.OgrenciID,
                x.HaftalikOdevID
            }).ToList();
        }

        private void btnOdevGuncelle_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Güncellemek İstiyormusunuz?", "GÜNCELLENSİN Mİ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int ID = Convert.ToInt32(txtID.Text);
                HaftalikOdevlerr odev = odR.Bul(ID);
                odev.VerilenKonu = CbOgrenciDersKonusu.Text;
                odev.TeslimTarihi = dtpTeslimTarihi.Value;
                odev.VerilisTarihi = dtpTeslimTarihi.Value;
                odev.VerilenNot = Convert.ToByte(txtVerilenNot.Text);
                MessageBox.Show("Güncelleme İşlemi Tamamlandı");
                odR.Guncelle(odev);
                MailMessage mesaj = new MailMessage();
                SmtpClient islemci = new SmtpClient();

                islemci.Credentials = new System.Net.NetworkCredential("Final.Dershanesi@hotmail.com", "Final123456789");
                islemci.Port = 587;
                islemci.Host = "smtp.live.com";
                islemci.EnableSsl = true;
                mesaj.To.Add(txtVeliMail.Text);
                mesaj.From = new MailAddress("Final.Dershanesi@hotmail.com");
                mesaj.Subject = "WİSSEN AKADEMİE ÖĞRENCİ ÖDEV BİLDİRİMİ!";
                mesaj.Body = ("Velisi bulunduğunuz.... " + txtOgrenciAdiSoyadi.Text + " isimli " + txtOgrenciNumara.Text + " numaralı örencimize " + CbOgrenciDers.Text + " Dersi " + CbOgrenciDersKonusu.Text + " Proje Ödevi olarak hocalarımız tarafından ödev tanımlanmıştır." + " Ödev Veriliş Tarihi:" + dtVerilisTarihi.Value + " Ödev Teslim Tarihi : " + dtpTeslimTarihi.Value + " VELİMİZİN BİLGİSİNE !");
                islemci.Send(mesaj);
                temizle();
                Dolduryenile();
                dgvOgrenciDuzenle();
            }

        }

        private void temizle()
        {
            txtID.Text = "";
            txtOgrenciAdiSoyadi.Text = "";
            txtOgrenciNumara.Text = "";
            txtOgrenciNumarasi.Text = "";
            txtVeliMail.Text = "";
            txtVerilenNot.Text = "";

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


