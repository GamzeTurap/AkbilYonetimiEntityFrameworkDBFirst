
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

namespace AkbilYonetimiUI
{
    public partial class frmKayitOl : Form
    {
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
                foreach (var item in Controls)
                {
                    if (item is TextBox && string.IsNullOrEmpty(((TextBox)item).Text))
                    {
                        MessageBox.Show("Zorunlu alanları doldurunuz!");
                        return;
                    }
                }
            }
            catch (Exception ex)
            {
                //ex log.txt'ye yazılacak (loglama)
                MessageBox.Show("Beklenmedik bir hata oluştu. Lütfen tekrar deneyiniz.");
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
    }
}
