namespace AkbilYonetimiUI
{
    partial class frmGiris
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            grpBoxGiris = new GroupBox();
            btnKayitOl = new Button();
            btnGirisYap = new Button();
            checkBoxHatirla = new CheckBox();
            txtSifre = new TextBox();
            txtEmail = new TextBox();
            label2 = new Label();
            label1 = new Label();
            grpBoxGiris.SuspendLayout();
            SuspendLayout();
            // 
            // grpBoxGiris
            // 
            grpBoxGiris.BackColor = Color.Transparent;
            grpBoxGiris.Controls.Add(btnKayitOl);
            grpBoxGiris.Controls.Add(btnGirisYap);
            grpBoxGiris.Controls.Add(checkBoxHatirla);
            grpBoxGiris.Controls.Add(txtSifre);
            grpBoxGiris.Controls.Add(txtEmail);
            grpBoxGiris.Controls.Add(label2);
            grpBoxGiris.Controls.Add(label1);
            grpBoxGiris.Location = new Point(243, 22);
            grpBoxGiris.Name = "grpBoxGiris";
            grpBoxGiris.Size = new Size(285, 204);
            grpBoxGiris.TabIndex = 0;
            grpBoxGiris.TabStop = false;
            // 
            // btnKayitOl
            // 
            btnKayitOl.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnKayitOl.Location = new Point(176, 122);
            btnKayitOl.Name = "btnKayitOl";
            btnKayitOl.Size = new Size(92, 31);
            btnKayitOl.TabIndex = 5;
            btnKayitOl.Text = "KAYIT OL";
            btnKayitOl.UseVisualStyleBackColor = true;
            btnKayitOl.Click += btnKayitOl_Click;
            // 
            // btnGirisYap
            // 
            btnGirisYap.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnGirisYap.Location = new Point(85, 122);
            btnGirisYap.Name = "btnGirisYap";
            btnGirisYap.Size = new Size(85, 31);
            btnGirisYap.TabIndex = 4;
            btnGirisYap.Text = "GİRİS YAP";
            btnGirisYap.UseVisualStyleBackColor = true;
            btnGirisYap.Click += btnGirisYap_Click;
            // 
            // checkBoxHatirla
            // 
            checkBoxHatirla.AutoSize = true;
            checkBoxHatirla.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            checkBoxHatirla.Location = new Point(73, 95);
            checkBoxHatirla.Name = "checkBoxHatirla";
            checkBoxHatirla.Size = new Size(107, 21);
            checkBoxHatirla.TabIndex = 3;
            checkBoxHatirla.Text = "Beni Hatırla!";
            checkBoxHatirla.UseVisualStyleBackColor = true;
            // 
            // txtSifre
            // 
            txtSifre.Location = new Point(73, 56);
            txtSifre.Name = "txtSifre";
            txtSifre.Size = new Size(195, 23);
            txtSifre.TabIndex = 2;
            txtSifre.KeyPress += txtSifre_KeyPress;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(73, 25);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(195, 23);
            txtEmail.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(23, 56);
            label2.Name = "label2";
            label2.Size = new Size(44, 17);
            label2.TabIndex = 0;
            label2.Text = "Sifre :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(11, 26);
            label1.Name = "label1";
            label1.Size = new Size(56, 17);
            label1.TabIndex = 0;
            label1.Text = "E-mail :";
            // 
            // frmGiris
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.istockphoto_1283504873_612x612;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(594, 370);
            Controls.Add(grpBoxGiris);
            DoubleBuffered = true;
            ForeColor = Color.DarkBlue;
            Name = "frmGiris";
            Text = "HOŞ GELDİNİZ...";
            Load += frmGiris_Load;
            grpBoxGiris.ResumeLayout(false);
            grpBoxGiris.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpBoxGiris;
        private Button btnKayitOl;
        private Button btnGirisYap;
        private CheckBox checkBoxHatirla;
        private TextBox txtSifre;
        private TextBox txtEmail;
        private Label label2;
        private Label label1;
    }
}