namespace AkbilYonetimiUI
{
    partial class FrmAyarlar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            btnGuncelle = new Button();
            label4 = new Label();
            label5 = new Label();
            txtEmail = new TextBox();
            txtIsim = new TextBox();
            txtSoyisim = new TextBox();
            dtpDogumTarihi = new DateTimePicker();
            txtSifre = new TextBox();
            groupBox1 = new GroupBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 10.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Honeydew;
            label1.Location = new Point(6, 19);
            label1.Name = "label1";
            label1.Size = new Size(60, 19);
            label1.TabIndex = 0;
            label1.Text = "E-mail :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Black", 10.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Honeydew;
            label2.Location = new Point(6, 50);
            label2.Name = "label2";
            label2.Size = new Size(46, 19);
            label2.TabIndex = 1;
            label2.Text = "İsim :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Black", 10.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Honeydew;
            label3.Location = new Point(6, 81);
            label3.Name = "label3";
            label3.Size = new Size(70, 19);
            label3.TabIndex = 2;
            label3.Text = "Soyisim :";
            // 
            // btnGuncelle
            // 
            btnGuncelle.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnGuncelle.Location = new Point(55, 209);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(184, 32);
            btnGuncelle.TabIndex = 5;
            btnGuncelle.Text = "BİLGİLERİ GÜNCELLE";
            btnGuncelle.UseVisualStyleBackColor = true;
            btnGuncelle.Click += btnGuncelle_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Black", 10.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.Honeydew;
            label4.Location = new Point(6, 112);
            label4.Name = "label4";
            label4.Size = new Size(112, 19);
            label4.TabIndex = 2;
            label4.Text = "Doğum Tarihi :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Black", 10.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.Honeydew;
            label5.Location = new Point(6, 143);
            label5.Name = "label5";
            label5.Size = new Size(83, 19);
            label5.TabIndex = 2;
            label5.Text = "Yeni Şifre :";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(128, 15);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(163, 23);
            txtEmail.TabIndex = 6;
            // 
            // txtIsim
            // 
            txtIsim.Location = new Point(128, 46);
            txtIsim.Name = "txtIsim";
            txtIsim.Size = new Size(163, 23);
            txtIsim.TabIndex = 6;
            // 
            // txtSoyisim
            // 
            txtSoyisim.Location = new Point(128, 81);
            txtSoyisim.Name = "txtSoyisim";
            txtSoyisim.Size = new Size(163, 23);
            txtSoyisim.TabIndex = 6;
            // 
            // dtpDogumTarihi
            // 
            dtpDogumTarihi.Location = new Point(128, 112);
            dtpDogumTarihi.Name = "dtpDogumTarihi";
            dtpDogumTarihi.Size = new Size(163, 23);
            dtpDogumTarihi.TabIndex = 7;
            // 
            // txtSifre
            // 
            txtSifre.Location = new Point(128, 143);
            txtSifre.Name = "txtSifre";
            txtSifre.Size = new Size(163, 23);
            txtSifre.TabIndex = 6;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Transparent;
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(btnGuncelle);
            groupBox1.Controls.Add(txtSifre);
            groupBox1.Controls.Add(dtpDogumTarihi);
            groupBox1.Controls.Add(txtEmail);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtSoyisim);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtIsim);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label5);
            groupBox1.Location = new Point(12, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(334, 276);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            // 
            // FrmAyarlar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.CadetBlue;
            BackgroundImage = Properties.Resources.Ekran_görüntüsü_2023_03_24_111659;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(608, 378);
            Controls.Add(groupBox1);
            DoubleBuffered = true;
            ForeColor = Color.MediumBlue;
            Name = "FrmAyarlar";
            Text = "FrmAyarlar";
            Load += FrmAyarlar_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnGuncelle;
        private Label label4;
        private Label label5;
        private TextBox txtEmail;
        private TextBox txtIsim;
        private TextBox txtSoyisim;
        private DateTimePicker dtpDogumTarihi;
        private TextBox txtSifre;
        private GroupBox groupBox1;
    }
}