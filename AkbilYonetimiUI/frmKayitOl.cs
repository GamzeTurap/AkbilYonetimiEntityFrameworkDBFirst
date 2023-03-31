
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AkbilYonetimiIsKatmani;
using AkbilYonetimiVeriKatmani.Models;

namespace AkbilYonetimiUI
{
    public partial class frmKayitOl : Form
    {
        AkbildbContext context = new AkbildbContext();
        public frmKayitOl()
        {
            InitializeComponent();
        }

        private void frmKayitOl_Load(object sender, EventArgs e)
        {
            txtSifre.PasswordChar = '*';
            dtpDogumTarihi.MaxDate = new DateTime(2016, 1, 1);
            dtpDogumTarihi.Value = new DateTime(2016, 1, 1);
            dtpDogumTarihi.Format = DateTimePickerFormat.Short;
        }

        private void btnKayitOl_Click(object sender, EventArgs e)
        {
            try
            {
                btnKayitOl.Enabled = false;
                btnGirisYap.Enabled = false;

                foreach (var item in Controls)
                {
                    if (item is TextBox && string.IsNullOrEmpty(((TextBox)item).Text))
                    {
                        MessageBox.Show("zorunlu alanları doldurunuz");
                        btnKayitOl.Enabled = true;
                        btnGirisYap.Enabled = true;
                        return;
                    }

                }//foreach bitti
                //bu emailden sistemde var mı?
                if (context.Kullanicilars.FirstOrDefault(x => x.Email == txtEmail.Text.Trim()) != null)
                {
                    MessageBox.Show("bu emaille sistemde kayıt mevcuttur!");
                    btnKayitOl.Enabled = true;
                    btnGirisYap.Enabled = true;
                    return;
                }

                Kullanicilar yeniKullanici = new Kullanicilar()
                {
                    EklenmeTarihi = DateTime.Now,
                    Ad = txtIsim.Text.Trim(),
                    Soyad = txtSoyisim.Text.Trim(),
                    DogumTarihi = dtpDogumTarihi.Value,
                    Email = txtEmail.Text.Trim(),
                    Parola = GenelIslemler.MD5Encryption(txtSifre.Text.Trim())
                };
                context.Kullanicilars.Add(yeniKullanici);
                if (context.SaveChanges() > 0)
                {
                    MessageBox.Show("Kullanıcı Eklendi!");
                    //temizlik
                    foreach (var item in Controls)
                    {
                        if (item is TextBox)
                        {
                            ((TextBox)item).Clear();

                        }
                        if (item is DateTimePicker)
                        {
                            ((DateTimePicker)item).Value = ((DateTimePicker)item).MaxDate;

                        }//forech bitt
                    }

                    var cevap = MessageBox.Show("Giriş sayfasına gitmet ister misiniz?", "SORU", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if ((int)cevap == 6)    //(cevap==DialogResult.Yes)
                    {
                        frmGiris frmg = new frmGiris();
                        frmg.Email = txtEmail.Text.Trim();
                        this.Hide();
                        frmg.Show();
                    }

                }
                else
                {
                    MessageBox.Show("Kullanici Ekleme Başarısız Oldu!");
                }

                btnKayitOl.Enabled = true;
                btnGirisYap.Enabled = true;
            }
            catch (Exception ex)
            {
                //ex log.txt'ye yazılacak (loglama)
                MessageBox.Show("Beklenmedik bir hata oluştu. Lütfen tekrar deneyiniz.");
                btnKayitOl.Enabled = true;
                btnGirisYap.Enabled = true;
            }
        }

        private void GirisFormunaGit()
        {
            frmGiris frmG = new frmGiris();
            frmG.Email = txtEmail.Text.Trim();
            this.Hide();
            frmG.Show();
        }

        private void frmKayitOl_FormClosed(object sender, FormClosedEventArgs e)
        {
            GirisFormunaGit();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            GirisFormunaGit();
        }

        private void cIKISYAPToolStripMenuItem_Click(object sender, EventArgs e)
        {

            MessageBox.Show("Güle Güle Çıkış Yapıldı");
            GenelIslemler.GirisYapanKullaniciAdSoyad = string.Empty;
            GenelIslemler.GirisYapanKullaniciID = 0;

            frmGiris giris = new frmGiris();
            foreach (Form item in Application.OpenForms)
            {
                if (item.Name != "frmGiris")
                {
                    item.Hide();
                }
            }
            giris.Show();
        }

        private void aNASAYFAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAnasayfa frma = new FrmAnasayfa();
            this.Hide();
            frma.Show();
        }
    }
}
