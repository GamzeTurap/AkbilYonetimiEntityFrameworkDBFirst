namespace AkbilYonetimiUI
{
    partial class frmKayitOl
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
            groupBox1 = new GroupBox();
            dtpDogumTarihi = new DateTimePicker();
            btnGiris = new Button();
            txtIsim = new TextBox();
            btnKayitOl = new Button();
            label1 = new Label();
            txtSifre = new TextBox();
            label2 = new Label();
            txtEmail = new TextBox();
            label3 = new Label();
            txtSoyisim = new TextBox();
            label4 = new Label();
            label5 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Transparent;
            groupBox1.Controls.Add(dtpDogumTarihi);
            groupBox1.Controls.Add(btnGiris);
            groupBox1.Controls.Add(txtIsim);
            groupBox1.Controls.Add(btnKayitOl);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtSifre);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtEmail);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtSoyisim);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label5);
            groupBox1.Dock = DockStyle.Right;
            groupBox1.Location = new Point(376, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(332, 370);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // dtpDogumTarihi
            // 
            dtpDogumTarihi.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dtpDogumTarihi.Location = new Point(114, 171);
            dtpDogumTarihi.Name = "dtpDogumTarihi";
            dtpDogumTarihi.Size = new Size(212, 25);
            dtpDogumTarihi.TabIndex = 4;
            // 
            // btnGiris
            // 
            btnGiris.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnGiris.Location = new Point(111, 261);
            btnGiris.Name = "btnGiris";
            btnGiris.Size = new Size(212, 36);
            btnGiris.TabIndex = 6;
            btnGiris.Text = "GİRİŞ YAP";
            btnGiris.UseVisualStyleBackColor = true;
            btnGiris.Click += btnGiris_Click;
            // 
            // txtIsim
            // 
            txtIsim.Location = new Point(114, 28);
            txtIsim.Name = "txtIsim";
            txtIsim.Size = new Size(211, 23);
            txtIsim.TabIndex = 0;
            // 
            // btnKayitOl
            // 
            btnKayitOl.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnKayitOl.Location = new Point(111, 215);
            btnKayitOl.Name = "btnKayitOl";
            btnKayitOl.Size = new Size(211, 40);
            btnKayitOl.TabIndex = 5;
            btnKayitOl.Text = "KAYIT OL";
            btnKayitOl.UseVisualStyleBackColor = true;
            btnKayitOl.Click += btnKayitOl_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Gadugi", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(6, 28);
            label1.Name = "label1";
            label1.Size = new Size(30, 16);
            label1.TabIndex = 44;
            label1.Text = "AD :";
            // 
            // txtSifre
            // 
            txtSifre.Location = new Point(114, 132);
            txtSifre.Name = "txtSifre";
            txtSifre.Size = new Size(211, 23);
            txtSifre.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Font = new Font("Gadugi", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(6, 65);
            label2.Name = "label2";
            label2.Size = new Size(53, 16);
            label2.TabIndex = 43;
            label2.Text = "SOYAD :";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(114, 100);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(211, 23);
            txtEmail.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.Font = new Font("Gadugi", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label3.Location = new Point(6, 102);
            label3.Name = "label3";
            label3.Size = new Size(54, 16);
            label3.TabIndex = 42;
            label3.Text = "e-MAİL :";
            // 
            // txtSoyisim
            // 
            txtSoyisim.Location = new Point(114, 63);
            txtSoyisim.Name = "txtSoyisim";
            txtSoyisim.Size = new Size(211, 23);
            txtSoyisim.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.White;
            label4.Font = new Font("Gadugi", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label4.Location = new Point(6, 176);
            label4.Name = "label4";
            label4.Size = new Size(104, 16);
            label4.TabIndex = 41;
            label4.Text = "DOĞUM TARİHİ :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.White;
            label5.Font = new Font("Gadugi", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label5.Location = new Point(6, 139);
            label5.Name = "label5";
            label5.Size = new Size(46, 16);
            label5.TabIndex = 40;
            label5.Text = "ŞİFRE :";
            // 
            // frmKayitOl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Yellow;
            BackgroundImage = Properties.Resources.c53c9495_833a_e411_a1b0_14feb5cc13c9;
            ClientSize = new Size(708, 370);
            Controls.Add(groupBox1);
            Name = "frmKayitOl";
            Text = "frmKayitOl";
            FormClosed += frmKayitOl_FormClosed;
            Load += frmKayitOl_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private DateTimePicker dtpDogumTarihi;
        private Button btnGiris;
        private TextBox txtIsim;
        private Button btnKayitOl;
        private Label label1;
        private TextBox txtSifre;
        private Label label2;
        private TextBox txtEmail;
        private Label label3;
        private TextBox txtSoyisim;
        private Label label4;
        private Label label5;
    }
}