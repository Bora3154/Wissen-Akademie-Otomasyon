using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DersaneOtomasyonu.DAL.DataModel;
using DersaneOtomasyonu.BLL.Repository;
using System.Reflection;
using System.Data;
using DevExpress.XtraReports.UI;
using System.Net.Mail;

namespace DersaneOtomasyonu
{
    public partial class Tahsilat : Form
    {
        public Tahsilat()
        {
            InitializeComponent();
        }
        OdemeVadeleriRepository ogrR = new OdemeVadeleriRepository();
        OdemeTahsil ot = new OdemeTahsil();
        private void Doldur()
        {
            OdemeVadeleriRepository ogrR1 = new OdemeVadeleriRepository();
            var src = ogrR1.Set().Include(x => x.OgrenciiKayit).ToList();

            dgvTahsilat.DataSource = src.Select(x => new
            {
                x.OdemeBilgileriID,
                x.OgrenciiKayit.VeliKayit.VeliAdiSoyadi,
                x.OgrenciiKayit.VeliKayit.VeliTcKimlikNo,
                x.OgrenciiKayit.OgrenciNumarasi,
                x.VadeTarihi,
                x.TaksitNo,
                x.TaksitTutari,
                x.Odedimi,
                x.OgrenciiKayit.VeliKayit.VeliMailAdresi
            }).ToList();
        }
        public void dgvVeliDuzenle()
        {
            dgvTahsilat.Columns[0].Width = 35;
            dgvTahsilat.Columns[1].Width = 130;
            dgvTahsilat.Columns[2].Width = 100;
            dgvTahsilat.Columns[3].Width = 75;
            dgvTahsilat.Columns[4].Width = 120;
            dgvTahsilat.Columns[5].Width = 65;
            dgvTahsilat.Columns[6].Width = 75;
            dgvTahsilat.Columns[7].Width = 75;
            dgvTahsilat.Columns[8].Width = 150;

        }
        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

    


        private void dgvTahsilat_DoubleClick(object sender, EventArgs e)
        {
            txtID.Text = Convert.ToString(dgvTahsilat.SelectedRows[0].Cells[0].Value);
            txtAdiSoyadi.Text = Convert.ToString(dgvTahsilat.SelectedRows[0].Cells[1].Value);
            txtTCKimlikNo.Text = Convert.ToString(dgvTahsilat.SelectedRows[0].Cells[2].Value);
            txtOgrenciNumarasi.Text = Convert.ToString(dgvTahsilat.SelectedRows[0].Cells[3].Value);
            txtVadeTarihi.Text = Convert.ToString(dgvTahsilat.SelectedRows[0].Cells[4].Value);
            txtTaksitNo.Text = Convert.ToString(dgvTahsilat.SelectedRows[0].Cells[5].Value);
            txtTaksitTutari.Text = Convert.ToString(dgvTahsilat.SelectedRows[0].Cells[6].Value);
            txtOdeme.Text = Convert.ToString(dgvTahsilat.SelectedRows[0].Cells[7].Value);
            txtVeliMailAdresi.Text = Convert.ToString(dgvTahsilat.SelectedRows[0].Cells[8].Value);
            dgvVeliDuzenle();
        }
        public DataTable LINQToDataTable<T>(IEnumerable<T> Lnqlst)
        {
            DataTable dt = new DataTable();


            PropertyInfo[] columns = null;

            if (Lnqlst == null) return dt;

            foreach (T Record in Lnqlst)
            {

                if (columns == null)
                {
                    columns = ((Type)Record.GetType()).GetProperties();
                    foreach (PropertyInfo GetProperty in columns)
                    {
                        Type colType = GetProperty.PropertyType;

                        if ((colType.IsGenericType) && (colType.GetGenericTypeDefinition()
                        == typeof(Nullable<>)))
                        {
                            colType = colType.GetGenericArguments()[0];
                        }

                        dt.Columns.Add(new DataColumn(GetProperty.Name, colType));
                    }
                }

                DataRow dr = dt.NewRow();

                foreach (PropertyInfo pinfo in columns)
                {
                    dr[pinfo.Name] = pinfo.GetValue(Record, null) == null ? DBNull.Value : pinfo.GetValue
                    (Record, null);
                }

                dt.Rows.Add(dr);
            }
            return dt;
        }
        private void brnOdemeİslemi_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Dekont İşlemine Geçilsinmi?", "DEKONT ÇIKTISI?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int Id = Convert.ToInt32(txtID.Text);
                    OdemeVadeleri odeme = ogrR.Bul(Id);
                    odeme.TaksitNo = Convert.ToByte(txtTaksitNo.Text);
                    odeme.TaksitTutari = Convert.ToDecimal(txtTaksitTutari.Text);
                    odeme.Odedimi = Convert.ToBoolean(txtOdeme.Text);
                    odeme.VadeTarihi = txtVadeTarihi.Value;
                    MessageBox.Show("Ödeme İşlemi Tamamlanmışdır.");
                    ogrR.Guncelle(odeme);
                    var srg = ot.Odemeler_View.Where(s => s.OdemeBilgileriID == Id && s.VeliAdiSoyadi==txtAdiSoyadi.Text&&s.TaksitNo==Convert.ToByte(txtTaksitNo.Text));
                    DataSet Ds = new DataSet();
                    Ds.Tables.Add(LINQToDataTable(srg));
                    Faturalar ft = new Faturalar();
                    ft.DataSource = Ds;
                    ft.ShowPreview();
                    MailMessage mesaj = new MailMessage();
                    SmtpClient islemci = new SmtpClient();

                    islemci.Credentials = new System.Net.NetworkCredential("Final.Dershanesi@hotmail.com", "Final123456789");
                    islemci.Port = 587;
                    islemci.Host = "smtp.live.com";
                    islemci.EnableSsl = true;
                    mesaj.To.Add(txtVeliMailAdresi.Text);
                    mesaj.From = new MailAddress("Final.Dershanesi@hotmail.com");
                    mesaj.Subject = "WİSSEN AKADEMİE TAKSİT ÖDEME BİLDİRİMİ!";
                    mesaj.Body = ("Sayın; " + txtAdiSoyadi.Text +" öğrenciniz "+txtOgrenciNumarasi.Text+" numaralı örencimize ait " + txtVadeTarihi.Text + " vade tarihine ait "+txtTaksitNo.Text + ". aya dair taksitinize ait " + txtTaksitTutari.Text + " TL Taksit Ücreti Tahsil Edlmiştir. VELİMİZİN BİLGİSİNE!" );
                    islemci.Send(mesaj);
                }
                Doldur();
                dgvVeliDuzenle();
                Temizle();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veli Mail Adresi Yanlış !", "Mail Olarak Gönderilemedi !");
                string hata = ex.Message;
                
            }

        }
        private void Temizle()
        {
            txtOgrencino.Text = txtVadeTarihi.Text = txtTCKimlikNo.Text = txtTaksitTutari.Text = txtTaksitNo.Text = txtOgrenciNumarasi.Text = txtOdeme.Text = txtID.Text = txtAdiSoyadi.Text =txtVeliMailAdresi.Text= "";
        }

        private void Tahsilat_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'odemeTahsil.Odemeler_View' table. You can move, or remove it, as needed.
            this.odemeler_ViewTableAdapter.Fill(this.odemeTahsil.Odemeler_View);
            this.Top = 0;
            this.Left = 0;
            Doldur();
            dgvVeliDuzenle();
            txtOdeme.Focus();
        }

        private void txtOgrencino_TextChanged(object sender, EventArgs e)
        {
            var src = ogrR.Set().Include(x => x.OgrenciiKayit).ToList();
            string ogrencino = txtOgrencino.Text;
            dgvTahsilat.DataSource = src.Where(x => x.OgrenciiKayit.OgrenciNumarasi.ToString().Contains(ogrencino.ToLower())).Select(x => new
            {
                x.OdemeBilgileriID,
                x.OgrenciiKayit.VeliKayit.VeliAdiSoyadi,
                x.OgrenciiKayit.VeliKayit.VeliTcKimlikNo,
                x.OgrenciiKayit.OgrenciNumarasi,
                x.VadeTarihi,
                x.TaksitNo,
                x.TaksitTutari,
                x.Odedimi,
                x.OgrenciiKayit.VeliKayit.VeliMailAdresi
            }).ToList();
            dgvVeliDuzenle(); ;
        }
    }
}
