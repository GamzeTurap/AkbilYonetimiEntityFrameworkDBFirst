namespace AkbilYonetimiUI
{
    partial class FrmAkbiller
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
            menuStrip1 = new MenuStrip();
            aNASAYFAToolStripMenuItem = new ToolStripMenuItem();
            cikisYAPToolStripMenuItem = new ToolStripMenuItem();
            groupBox1 = new GroupBox();
            cmbBoxAkbilTipleri = new ComboBox();
            btnKaydet = new Button();
            maskedTextBoxAkbilNo = new MaskedTextBox();
            label2 = new Label();
            label1 = new Label();
            dataGridViewAkbiller = new DataGridView();
            menuStrip1.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAkbiller).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { aNASAYFAToolStripMenuItem, cikisYAPToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(375, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // aNASAYFAToolStripMenuItem
            // 
            aNASAYFAToolStripMenuItem.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            aNASAYFAToolStripMenuItem.Name = "aNASAYFAToolStripMenuItem";
            aNASAYFAToolStripMenuItem.Size = new Size(86, 20);
            aNASAYFAToolStripMenuItem.Text = "ANASAYFA";
            aNASAYFAToolStripMenuItem.Click += aNASAYFAToolStripMenuItem_Click;
            // 
            // cikisYAPToolStripMenuItem
            // 
            cikisYAPToolStripMenuItem.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            cikisYAPToolStripMenuItem.Name = "cikisYAPToolStripMenuItem";
            cikisYAPToolStripMenuItem.Size = new Size(78, 20);
            cikisYAPToolStripMenuItem.Text = "CIKIS YAP";
            cikisYAPToolStripMenuItem.Click += cikisYAPToolStripMenuItem_Click;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Transparent;
            groupBox1.Controls.Add(cmbBoxAkbilTipleri);
            groupBox1.Controls.Add(btnKaydet);
            groupBox1.Controls.Add(maskedTextBoxAkbilNo);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Dock = DockStyle.Top;
            groupBox1.Location = new Point(0, 24);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(375, 111);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            // 
            // cmbBoxAkbilTipleri
            // 
            cmbBoxAkbilTipleri.FormattingEnabled = true;
            cmbBoxAkbilTipleri.Items.AddRange(new object[] { "Öğrenci", "Tam ", "Anne ", "65+", "Öğretmen", "Polis", "Asker", "Engelli", "Sağlık Çalışanı" });
            cmbBoxAkbilTipleri.Location = new Point(82, 53);
            cmbBoxAkbilTipleri.Name = "cmbBoxAkbilTipleri";
            cmbBoxAkbilTipleri.Size = new Size(149, 23);
            cmbBoxAkbilTipleri.TabIndex = 3;
            // 
            // btnKaydet
            // 
            btnKaydet.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnKaydet.Location = new Point(242, 21);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(97, 55);
            btnKaydet.TabIndex = 2;
            btnKaydet.Text = "YENİ AKBİL KAYDET";
            btnKaydet.UseVisualStyleBackColor = true;
            btnKaydet.Click += btnKaydet_Click;
            // 
            // maskedTextBoxAkbilNo
            // 
            maskedTextBoxAkbilNo.Location = new Point(82, 21);
            maskedTextBoxAkbilNo.Mask = "0000000000000000";
            maskedTextBoxAkbilNo.Name = "maskedTextBoxAkbilNo";
            maskedTextBoxAkbilNo.Size = new Size(149, 23);
            maskedTextBoxAkbilNo.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(9, 54);
            label2.Name = "label2";
            label2.Size = new Size(76, 17);
            label2.TabIndex = 1;
            label2.Text = "Akbil Tipi :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(15, 27);
            label1.Name = "label1";
            label1.Size = new Size(70, 17);
            label1.TabIndex = 0;
            label1.Text = "Akbil No :";
            // 
            // dataGridViewAkbiller
            // 
            dataGridViewAkbiller.AllowUserToAddRows = false;
            dataGridViewAkbiller.AllowUserToDeleteRows = false;
            dataGridViewAkbiller.AllowUserToOrderColumns = true;
            dataGridViewAkbiller.BackgroundColor = SystemColors.ActiveBorder;
            dataGridViewAkbiller.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewAkbiller.Dock = DockStyle.Bottom;
            dataGridViewAkbiller.GridColor = Color.DarkOliveGreen;
            dataGridViewAkbiller.Location = new Point(0, 141);
            dataGridViewAkbiller.Name = "dataGridViewAkbiller";
            dataGridViewAkbiller.ReadOnly = true;
            dataGridViewAkbiller.RowTemplate.Height = 25;
            dataGridViewAkbiller.Size = new Size(375, 167);
            dataGridViewAkbiller.TabIndex = 3;
            // 
            // FrmAkbiller
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(375, 308);
            Controls.Add(dataGridViewAkbiller);
            Controls.Add(groupBox1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "FrmAkbiller";
            Text = "FrmAkbiller";
            Load += FrmAkbiller_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAkbiller).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem aNASAYFAToolStripMenuItem;
        private ToolStripMenuItem cikisYAPToolStripMenuItem;
        private GroupBox groupBox1;
        private ComboBox cmbBoxAkbilTipleri;
        private Button btnKaydet;
        private MaskedTextBox maskedTextBoxAkbilNo;
        private Label label2;
        private Label label1;
        private DataGridView dataGridViewAkbiller;
    }
}