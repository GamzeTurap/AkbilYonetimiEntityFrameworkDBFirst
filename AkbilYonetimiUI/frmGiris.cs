using Microsoft.VisualBasic;
using System.Data.SqlClient;
using System.Collections;
using System.Text;
using AkbilYonetimiIsKatmani;
using AkbilYonetimiVeriKatmani;
using AkbilYonetimiVeriKatmani.Models;

namespace AkbilYonetimiUI
{
    public partial class frmGiris : Form
    {
        public string Email { get; set; }//kay�tol fromunda kay�t olan kullan�c�n�n emaili buraya gelsin

        AkbildbContext context = new AkbildbContext();

        public frmGiris()
        {
            InitializeComponent();
        }
        private void frmGiris_Load(object sender, EventArgs e)
        {
            if (Email != null)
            {
                txtEmail.Text = Email;
            }


            txtEmail.TabIndex = 1;
            txtSifre.TabIndex = 2;
            checkBoxHatirla.TabIndex = 3;
            btnGirisYap.TabIndex = 4;
            btnKayitOl.TabIndex = 5;

            //Beni hat�rlay� Properties.Setting ile yapana kadar buras� b�yle, kolayl�k sa�las�n diye.
            txtEmail.Text = "gamzeturap@gmail.com";
            txtSifre.Text = "1234";

        }

        private void btnKayitOl_Click(object sender, EventArgs e)
        {
            //bu formu gizleyece�iz
            //kay�t ol formu a�aca��z
            this.Hide();
            frmKayitOl frm = new frmKayitOl();
            frm.Show();
        }


        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            GirisYap();
        }

        private void GirisYap()
        {
            try
            {
                //1) Email ve �ifre textboxlar� dolu mu?
                if (string.IsNullOrEmpty(txtEmail.Text) || string.IsNullOrEmpty(txtSifre.Text))
                {
                    MessageBox.Show("bilgileri eksiksiz giriniz", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }

                //2) Girdi�i email ve �ifre veritaban�nda mevcut mu?
                //select*from kullan�c�lar where email='' and sifre=''
                var kullanici = context.Kullanicilars.FirstOrDefault(x => x.Email == txtEmail.Text && x.Parola == GenelIslemler.MD5Encryption(txtSifre.Text));
                if (kullanici==null)
                {
                    MessageBox.Show("Email ya da �ifrenizi yanl�� girdiniz!");
                    return;
                }
                else
                {
                    MessageBox.Show($"Ho� Geldiniz.. {kullanici.Ad}{kullanici.Soyad}");
                    GenelIslemler.GirisYapanKullaniciEmail = kullanici.Email;
                    GenelIslemler.GirisYapanKullaniciAdSoyad = $"{kullanici.Ad}{kullanici.Soyad}";
                    GenelIslemler.GirisYapanKullaniciID = kullanici.Id;

                    // beni hat�rlay� setting ile yazal�m
                    // temizlik
                    txtEmail.Clear(); txtSifre.Clear();
                    FrmAnasayfa frmAnasayfa = new FrmAnasayfa();
                    this.Hide();
                    frmAnasayfa.Show();
                }



            }
            catch (Exception hata)
            {
                //dipnot excepti�nlar asla kullan�c�ya g�sterilmez
                //exceptionlar loglan�r. biz �u an ��renme/geli�tirme a�ams�nda oldu�umuz i�in yazd�k.
                MessageBox.Show("beklenmedik bir sorun olu�tu!" + hata.Message);

            }
        }

        private void checkBoxHatirla_CheckedChanged(object sender, EventArgs e)
        {

            BeniHatirlaAyarla();
        }

        private void BeniHatirlaAyarla()
        {
            if (checkBoxHatirla.Checked)
            {
                Properties.Settings1.Default.BeniHatirla = true;
            }
            else
            {
                Properties.Settings1.Default.BeniHatirla = false;
            }
        }
        private void txtSifre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter)) // bas�lan tu� enter ise giri� yapacak.
            {
                GirisYap();

            }
        }
    }
}
