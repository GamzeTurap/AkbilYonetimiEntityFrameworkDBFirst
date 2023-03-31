namespace AkbilYonetimiUI
{
    partial class FrmAnasayfa
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
            btnAkbil = new Button();
            btnTalimat = new Button();
            btnAyarlar = new Button();
            SuspendLayout();
            // 
            // btnAkbil
            // 
            btnAkbil.BackColor = Color.Gray;
            btnAkbil.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnAkbil.ForeColor = Color.Ivory;
            btnAkbil.Location = new Point(353, 12);
            btnAkbil.Name = "btnAkbil";
            btnAkbil.Size = new Size(201, 48);
            btnAkbil.TabIndex = 0;
            btnAkbil.Text = "AKBİL İŞLEMLERİ";
            btnAkbil.UseVisualStyleBackColor = false;
            btnAkbil.Click += btnAkbil_Click;
            // 
            // btnTalimat
            // 
            btnTalimat.BackColor = Color.Gray;
            btnTalimat.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnTalimat.ForeColor = Color.Ivory;
            btnTalimat.Location = new Point(353, 66);
            btnTalimat.Name = "btnTalimat";
            btnTalimat.Size = new Size(201, 42);
            btnTalimat.TabIndex = 0;
            btnTalimat.Text = "TALİMATLAR";
            btnTalimat.UseVisualStyleBackColor = false;
            btnTalimat.Click += btnTalimat_Click;
            // 
            // btnAyarlar
            // 
            btnAyarlar.BackColor = Color.Gray;
            btnAyarlar.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnAyarlar.ForeColor = Color.Ivory;
            btnAyarlar.Location = new Point(353, 114);
            btnAyarlar.Name = "btnAyarlar";
            btnAyarlar.Size = new Size(201, 42);
            btnAyarlar.TabIndex = 0;
            btnAyarlar.Text = "AYARLAR";
            btnAyarlar.UseVisualStyleBackColor = false;
            btnAyarlar.Click += btnAyarlar_Click;
            // 
            // FrmAnasayfa
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            BackgroundImage = Properties.Resources._1656413801326;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(566, 349);
            Controls.Add(btnAyarlar);
            Controls.Add(btnTalimat);
            Controls.Add(btnAkbil);
            ForeColor = Color.DarkGray;
            Name = "FrmAnasayfa";
            Text = "FrmAnasayfa";
            FormClosed += FrmAnasayfa_FormClosed;
            ResumeLayout(false);
        }

        #endregion

        private Button btnAkbil;
        private Button btnTalimat;
        private Button btnAyarlar;
    }
}