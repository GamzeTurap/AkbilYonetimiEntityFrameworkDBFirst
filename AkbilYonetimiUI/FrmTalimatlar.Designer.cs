namespace AkbilYonetimiUI
{
    partial class FrmTalimatlar
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTalimatlar));
            menuStrip1 = new MenuStrip();
            anaMenuToolStripMenuItem = new ToolStripMenuItem();
            cıkısYapToolStripMenuItem = new ToolStripMenuItem();
            checkBoxTumunuGoster = new CheckBox();
            label1 = new Label();
            lbl = new Label();
            dataGridViewTalimatlar = new DataGridView();
            timerBekleyenTalimat = new System.Windows.Forms.Timer(components);
            contextMenuStrip1 = new ContextMenuStrip(components);
            talimatiYukleToolStripMenuItem = new ToolStripMenuItem();
            talimatiIptalEtToolStripMenuItem = new ToolStripMenuItem();
            txtYuklenecekTutar = new TextBox();
            btnTalimatKaydet = new Button();
            cmbBoxAkbiller = new ComboBox();
            lblBekleyenTalimat = new Label();
            groupBoxYukleme = new GroupBox();
            label3 = new Label();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTalimatlar).BeginInit();
            contextMenuStrip1.SuspendLayout();
            groupBoxYukleme.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.White;
            menuStrip1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            menuStrip1.Items.AddRange(new ToolStripItem[] { anaMenuToolStripMenuItem, cıkısYapToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(702, 25);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // anaMenuToolStripMenuItem
            // 
            anaMenuToolStripMenuItem.Name = "anaMenuToolStripMenuItem";
            anaMenuToolStripMenuItem.Size = new Size(83, 21);
            anaMenuToolStripMenuItem.Text = "Ana Menü";
            anaMenuToolStripMenuItem.Click += anaMenuToolStripMenuItem_Click;
            // 
            // cıkısYapToolStripMenuItem
            // 
            cıkısYapToolStripMenuItem.Name = "cıkısYapToolStripMenuItem";
            cıkısYapToolStripMenuItem.Size = new Size(75, 21);
            cıkısYapToolStripMenuItem.Text = "Çıkış Yap";
            // 
            // checkBoxTumunuGoster
            // 
            checkBoxTumunuGoster.AutoSize = true;
            checkBoxTumunuGoster.BackColor = SystemColors.ControlLightLight;
            checkBoxTumunuGoster.Location = new Point(0, 233);
            checkBoxTumunuGoster.Name = "checkBoxTumunuGoster";
            checkBoxTumunuGoster.Size = new Size(108, 19);
            checkBoxTumunuGoster.TabIndex = 1;
            checkBoxTumunuGoster.Text = "Tümünü Göster";
            checkBoxTumunuGoster.UseVisualStyleBackColor = false;
            checkBoxTumunuGoster.CheckedChanged += checkBoxTumunuGoster_CheckedChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(6, 19);
            label1.Name = "label1";
            label1.Size = new Size(139, 20);
            label1.TabIndex = 2;
            label1.Text = "Yüklenecek Tutar  :";
            // 
            // lbl
            // 
            lbl.AutoSize = true;
            lbl.BackColor = Color.Transparent;
            lbl.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lbl.ForeColor = Color.White;
            lbl.Location = new Point(480, 39);
            lbl.Name = "lbl";
            lbl.Size = new Size(128, 20);
            lbl.TabIndex = 3;
            lbl.Text = "Bekleyen Talimat";
            // 
            // dataGridViewTalimatlar
            // 
            dataGridViewTalimatlar.AllowUserToAddRows = false;
            dataGridViewTalimatlar.AllowUserToDeleteRows = false;
            dataGridViewTalimatlar.AllowUserToOrderColumns = true;
            dataGridViewTalimatlar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewTalimatlar.Dock = DockStyle.Bottom;
            dataGridViewTalimatlar.Location = new Point(0, 258);
            dataGridViewTalimatlar.Name = "dataGridViewTalimatlar";
            dataGridViewTalimatlar.RowTemplate.Height = 25;
            dataGridViewTalimatlar.Size = new Size(702, 145);
            dataGridViewTalimatlar.TabIndex = 4;
            // 
            // timerBekleyenTalimat
            // 
            timerBekleyenTalimat.Tick += timerBekleyenTalimat_Tick;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { talimatiYukleToolStripMenuItem, talimatiIptalEtToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(174, 48);
            // 
            // talimatiYukleToolStripMenuItem
            // 
            talimatiYukleToolStripMenuItem.BackgroundImageLayout = ImageLayout.Stretch;
            talimatiYukleToolStripMenuItem.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            talimatiYukleToolStripMenuItem.Image = (Image)resources.GetObject("talimatiYukleToolStripMenuItem.Image");
            talimatiYukleToolStripMenuItem.Name = "talimatiYukleToolStripMenuItem";
            talimatiYukleToolStripMenuItem.Size = new Size(173, 22);
            talimatiYukleToolStripMenuItem.Text = "Talimatı Yükle";
            talimatiYukleToolStripMenuItem.Click += talimatiYukleToolStripMenuItem_Click;
            // 
            // talimatiIptalEtToolStripMenuItem
            // 
            talimatiIptalEtToolStripMenuItem.BackgroundImageLayout = ImageLayout.Stretch;
            talimatiIptalEtToolStripMenuItem.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            talimatiIptalEtToolStripMenuItem.Image = Properties.Resources.Adsız1;
            talimatiIptalEtToolStripMenuItem.Name = "talimatiIptalEtToolStripMenuItem";
            talimatiIptalEtToolStripMenuItem.Size = new Size(173, 22);
            talimatiIptalEtToolStripMenuItem.Text = "Talimatı İptal Et";
            talimatiIptalEtToolStripMenuItem.Click += talimatiIptalEtToolStripMenuItem_Click;
            // 
            // txtYuklenecekTutar
            // 
            txtYuklenecekTutar.Location = new Point(151, 16);
            txtYuklenecekTutar.Name = "txtYuklenecekTutar";
            txtYuklenecekTutar.Size = new Size(110, 23);
            txtYuklenecekTutar.TabIndex = 6;
            // 
            // btnTalimatKaydet
            // 
            btnTalimatKaydet.Location = new Point(151, 45);
            btnTalimatKaydet.Name = "btnTalimatKaydet";
            btnTalimatKaydet.Size = new Size(110, 28);
            btnTalimatKaydet.TabIndex = 7;
            btnTalimatKaydet.Text = "TALİMATI KAYDET";
            btnTalimatKaydet.UseVisualStyleBackColor = true;
            btnTalimatKaydet.Click += btnTalimatKaydet_Click;
            // 
            // cmbBoxAkbiller
            // 
            cmbBoxAkbiller.FormattingEnabled = true;
            cmbBoxAkbiller.Location = new Point(117, 40);
            cmbBoxAkbiller.Name = "cmbBoxAkbiller";
            cmbBoxAkbiller.Size = new Size(316, 23);
            cmbBoxAkbiller.TabIndex = 9;
            cmbBoxAkbiller.SelectedIndexChanged += cmbBoxAkbiller_SelectedIndexChanged;
            // 
            // lblBekleyenTalimat
            // 
            lblBekleyenTalimat.AutoSize = true;
            lblBekleyenTalimat.BackColor = Color.Transparent;
            lblBekleyenTalimat.Font = new Font("Segoe UI Emoji", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblBekleyenTalimat.ForeColor = Color.MistyRose;
            lblBekleyenTalimat.Location = new Point(530, 73);
            lblBekleyenTalimat.Name = "lblBekleyenTalimat";
            lblBekleyenTalimat.Size = new Size(18, 20);
            lblBekleyenTalimat.TabIndex = 10;
            lblBekleyenTalimat.Text = "0";
            // 
            // groupBoxYukleme
            // 
            groupBoxYukleme.BackColor = Color.Transparent;
            groupBoxYukleme.Controls.Add(label1);
            groupBoxYukleme.Controls.Add(txtYuklenecekTutar);
            groupBoxYukleme.Controls.Add(btnTalimatKaydet);
            groupBoxYukleme.Location = new Point(117, 73);
            groupBoxYukleme.Name = "groupBoxYukleme";
            groupBoxYukleme.Size = new Size(316, 79);
            groupBoxYukleme.TabIndex = 11;
            groupBoxYukleme.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(0, 40);
            label3.Name = "label3";
            label3.Size = new Size(100, 20);
            label3.TabIndex = 12;
            label3.Text = "Akbil Seçiniz:";
            // 
            // FrmTalimatlar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            BackgroundImage = Properties.Resources.istanbul_fotograflari_hd_indir_cekergezer_hakan_aydin_fotograflari_istanbul_turkiye_25_baslik;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(702, 403);
            Controls.Add(label3);
            Controls.Add(groupBoxYukleme);
            Controls.Add(lblBekleyenTalimat);
            Controls.Add(cmbBoxAkbiller);
            Controls.Add(dataGridViewTalimatlar);
            Controls.Add(lbl);
            Controls.Add(checkBoxTumunuGoster);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "FrmTalimatlar";
            Text = "FrmTalimatlar";
            Load += FrmTalimatlar_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTalimatlar).EndInit();
            contextMenuStrip1.ResumeLayout(false);
            groupBoxYukleme.ResumeLayout(false);
            groupBoxYukleme.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem anaMenuToolStripMenuItem;
        private ToolStripMenuItem cıkısYapToolStripMenuItem;
        private CheckBox checkBoxTumunuGoster;
        private Label label1;
        private Label lblBekleyenTalimat;
        private DataGridView dataGridViewTalimatlar;
        private System.Windows.Forms.Timer timerBekleyenTalimat;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem talimatiYukleToolStripMenuItem;
        private TextBox txtYuklenecekTutar;
        private Button btnTalimatKaydet;
        private ComboBox cmbBoxAkbiller;
        private Label label2;
        private GroupBox groupBoxYukleme;
        private ToolStripMenuItem talimatiIptalEtToolStripMenuItem;
        private Label lbl;
        private Label label3;
    }
}