
namespace CV_Project
{
    partial class FormCV
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button btnProfil;
        private System.Windows.Forms.Button btnPendidikan;
        private System.Windows.Forms.Button btnPengalaman;
        private System.Windows.Forms.Button btnKeahlian;
        private System.Windows.Forms.Button btnKontak;
        private System.Windows.Forms.RichTextBox txtOutput;
        private System.Windows.Forms.Button btnSimpan;
        private System.Windows.Forms.Button btnExportPdf;
        private System.Windows.Forms.Button btnClear;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.btnProfil = new System.Windows.Forms.Button();
            this.btnPendidikan = new System.Windows.Forms.Button();
            this.btnPengalaman = new System.Windows.Forms.Button();
            this.btnKeahlian = new System.Windows.Forms.Button();
            this.btnKontak = new System.Windows.Forms.Button();
            this.txtOutput = new System.Windows.Forms.RichTextBox();
            this.btnSimpan = new System.Windows.Forms.Button();
            this.btnExportPdf = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panelCV = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelCV.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnProfil
            // 
            this.btnProfil.Location = new System.Drawing.Point(12, 20);
            this.btnProfil.Name = "btnProfil";
            this.btnProfil.Size = new System.Drawing.Size(108, 50);
            this.btnProfil.TabIndex = 0;
            this.btnProfil.Text = "Profil";
            this.btnProfil.Click += new System.EventHandler(this.btnProfil_Click);
            // 
            // btnPendidikan
            // 
            this.btnPendidikan.Location = new System.Drawing.Point(12, 113);
            this.btnPendidikan.Name = "btnPendidikan";
            this.btnPendidikan.Size = new System.Drawing.Size(108, 49);
            this.btnPendidikan.TabIndex = 1;
            this.btnPendidikan.Text = "Pendidikan";
            this.btnPendidikan.Click += new System.EventHandler(this.btnPendidikan_Click);
            // 
            // btnPengalaman
            // 
            this.btnPengalaman.Location = new System.Drawing.Point(12, 216);
            this.btnPengalaman.Name = "btnPengalaman";
            this.btnPengalaman.Size = new System.Drawing.Size(115, 32);
            this.btnPengalaman.TabIndex = 2;
            this.btnPengalaman.Text = "Pengalaman";
            this.btnPengalaman.Click += new System.EventHandler(this.btnPengalaman_Click);
            // 
            // btnKeahlian
            // 
            this.btnKeahlian.Location = new System.Drawing.Point(20, 289);
            this.btnKeahlian.Name = "btnKeahlian";
            this.btnKeahlian.Size = new System.Drawing.Size(100, 55);
            this.btnKeahlian.TabIndex = 3;
            this.btnKeahlian.Text = "Keahlian";
            this.btnKeahlian.Click += new System.EventHandler(this.btnKeahlian_Click);
            // 
            // btnKontak
            // 
            this.btnKontak.Location = new System.Drawing.Point(20, 384);
            this.btnKontak.Name = "btnKontak";
            this.btnKontak.Size = new System.Drawing.Size(107, 53);
            this.btnKontak.TabIndex = 4;
            this.btnKontak.Text = "Kontak";
            this.btnKontak.Click += new System.EventHandler(this.btnKontak_Click);
            // 
            // txtOutput
            // 
            this.txtOutput.Location = new System.Drawing.Point(0, 3);
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.ReadOnly = true;
            this.txtOutput.Size = new System.Drawing.Size(516, 434);
            this.txtOutput.TabIndex = 5;
            this.txtOutput.Text = "";
            this.txtOutput.TextChanged += new System.EventHandler(this.txtOutput_TextChanged);
            // 
            // btnSimpan
            // 
            this.btnSimpan.Location = new System.Drawing.Point(140, 483);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(120, 41);
            this.btnSimpan.TabIndex = 6;
            this.btnSimpan.Text = "Simpan";
            this.btnSimpan.Click += new System.EventHandler(this.btnSimpan_Click);
            // 
            // btnExportPdf
            // 
            this.btnExportPdf.Location = new System.Drawing.Point(381, 483);
            this.btnExportPdf.Name = "btnExportPdf";
            this.btnExportPdf.Size = new System.Drawing.Size(114, 41);
            this.btnExportPdf.TabIndex = 7;
            this.btnExportPdf.Text = "Export PDF";
            this.btnExportPdf.Click += new System.EventHandler(this.btnExportPdf_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(605, 486);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(115, 41);
            this.btnClear.TabIndex = 8;
            this.btnClear.Text = "Clear";
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(518, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(282, 434);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(837, 486);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 35);
            this.button1.TabIndex = 11;
            this.button1.Text = "Upload Foto";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panelCV
            // 
            this.panelCV.Controls.Add(this.txtOutput);
            this.panelCV.Controls.Add(this.pictureBox1);
            this.panelCV.Location = new System.Drawing.Point(140, 20);
            this.panelCV.Name = "panelCV";
            this.panelCV.Size = new System.Drawing.Size(807, 440);
            this.panelCV.TabIndex = 12;
            // 
            // FormCV
            // 
            this.ClientSize = new System.Drawing.Size(1376, 737);
            this.Controls.Add(this.panelCV);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnProfil);
            this.Controls.Add(this.btnPendidikan);
            this.Controls.Add(this.btnPengalaman);
            this.Controls.Add(this.btnKeahlian);
            this.Controls.Add(this.btnKontak);
            this.Controls.Add(this.btnSimpan);
            this.Controls.Add(this.btnExportPdf);
            this.Controls.Add(this.btnClear);
            this.Name = "FormCV";
            this.Text = "CV Sederhana";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelCV.ResumeLayout(false);
            this.ResumeLayout(false);

        }
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panelCV;
    }
}
